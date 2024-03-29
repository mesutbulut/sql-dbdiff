using System.Data.SqlClient;
using DBDiff.Schema.Events;
using DBDiff.Schema.SQLServer.Generates.Generates.Util;
using DBDiff.Schema.SQLServer.Generates.Model;
using DBDiff.Schema.SQLServer.Generates.Generates.SQLCommands;

namespace DBDiff.Schema.SQLServer.Generates.Generates
{
    public class GenerateStoreProcedures
    {
        private static int NameIndex = -1;
        private static int object_idIndex = -1;
        private static int ownerIndex = -1;
        private static int typeIndex = -1;

        private Generate root;

        public GenerateStoreProcedures(Generate root)
        {
            this.root = root;
        }

        private static void InitIndex(SqlDataReader reader)
        {
            if (NameIndex == -1)
            {
                object_idIndex = reader.GetOrdinal("object_id");
                NameIndex = reader.GetOrdinal("Name");
                ownerIndex = reader.GetOrdinal("owner");
                typeIndex = reader.GetOrdinal("type");
            }
        }

        //private static string GetSQLParameters()
        //{
        //    string sql = "";
        //    sql += "select AP.is_output, AP.scale, AP.precision, '[' + SCHEMA_NAME(O.schema_id) + '].['+  O.name + ']' AS ObjectName, AP.name, TT.name AS TypeName, AP.max_length from sys.all_parameters AP ";
        //    sql += "INNER JOIN sys.types TT ON TT.user_type_id = AP.user_type_id ";
        //    sql += "INNER JOIN sys.objects O ON O.object_id = AP.object_id ";
        //    sql += "WHERE type = 'PC' ORDER BY O.object_id, AP.parameter_id ";
        //    return sql;
        //}

        //private static string GetSQL()
        //{
        //    string sql = "";
        //    sql += "select ISNULL(CONVERT(varchar,AM.execute_as_principal_id),'CALLER') as ExecuteAs, P.type, AF.name AS assembly_name, AM.assembly_class, AM.assembly_id, AM.assembly_method, P.object_id, S.name as owner, P.name as name from sys.procedures P ";
        //    sql += "INNER JOIN sys.schemas S ON S.schema_id = P.schema_id ";
        //    sql += "LEFT JOIN sys.assembly_modules AM ON AM.object_id = P.object_id ";
        //    sql += "LEFT JOIN sys.assemblies AF ON AF.assembly_id = AM.assembly_id";
        //    return sql;
        //}

        private static void FillParameters(Database database, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(StoreProcedureSQLCommand.GetParameters(database.Info.Version), conn))
                {
                    conn.Open();
                    command.CommandTimeout = 0;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Parameter param = new Parameter();
                            param.Name = reader["Name"].ToString();
                            param.Type = reader["TypeName"].ToString();
                            param.Size = (short)reader["max_length"];
                            param.Scale = (byte)reader["scale"];
                            param.Precision = (byte)reader["precision"];
                            param.Output = (bool)reader["is_output"];
                            if (param.Type.Equals("nchar") || param.Type.Equals("nvarchar"))
                            {
                                if (param.Size != -1)
                                    param.Size = param.Size / 2;
                            }
                            database.CLRProcedures[reader["ObjectName"].ToString()].Parameters.Add(param);
                        }
                    }
                }
            }
        }

        public void Fill(Database database, string connectionString)
        {
            if ((database.Options.Ignore.FilterStoreProcedure) || (database.Options.Ignore.FilterCLRStoreProcedure))
            {
                root.RaiseOnReading(new ProgressEventArgs("Reading Store Procedures...", Constants.READING_PROCEDURES));
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(StoreProcedureSQLCommand.Get(database.Info.Version), conn))
                    {
                        conn.Open();
                        command.CommandTimeout = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InitIndex(reader);
                                if ((reader[typeIndex].ToString().Trim().Equals("P")) && (database.Options.Ignore.FilterStoreProcedure))
                                {
                                    StoreProcedure item = new StoreProcedure(database);
                                    item.Id = (int)reader[object_idIndex];
                                    item.Name = (string)reader[NameIndex];
                                    item.Owner = (string)reader[ownerIndex];
                                    database.Procedures.Add(item);                                    
                                }
                                if ((reader[typeIndex].ToString().Trim().Equals("PC")) && (database.Options.Ignore.FilterCLRStoreProcedure))
                                {
                                    CLRStoreProcedure item = new CLRStoreProcedure(database);
                                    item.Id = (int)reader[object_idIndex];
                                    item.Name = reader[NameIndex].ToString();
                                    item.Owner = reader[ownerIndex].ToString();
                                    item.IsAssembly = true;
                                    item.AssemblyId = (int)reader["assembly_id"];
                                    item.AssemblyName = reader["assembly_name"].ToString();
                                    item.AssemblyClass = reader["assembly_class"].ToString();
                                    item.AssemblyExecuteAs = reader["ExecuteAs"].ToString();
                                    item.AssemblyMethod = reader["assembly_method"].ToString();
                                    database.CLRProcedures.Add(item);
                                }                                
                            }
                        }
                    }                    
                }
                if (database.CLRProcedures.Count > 0)
                    FillParameters(database, connectionString);
            }
        }
    }
}
