using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBDiff.Schema.SQLServer.Generates.Options;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;

namespace DBDiff.Settings
{
    public class Project
    {
        #region SQL Statements
        private static string ProjectUpdateSql = @"UPDATE Project SET Name = @Name, ConnectionStringSource = @ConnectionStringSource, ConnectionStringDestination = @ConnectionStringDestination, Type = @Type WHERE ProjectId = @ProjectId";
        #endregion

        public enum ProjectType : short
        {
            SQLServer = 1
        }

        private static string connectionString = string.Format("Data Source={0}\\Database.sdf", Path.GetDirectoryName(Assembly.GetCallingAssembly().Location));

        public int Id { get; set; }
        public string ConnectionStringSource { get; set; }
        public string ConnectionStringDestination { get; set; }
        public SqlOption Options { get; set; }
        public ProjectType Type { get; set; }
        public string Name { get; set; }

        #region Private Static Methods
        /// <summary>
        /// Add a Project to the list in the databse
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static int Add(Project item)
        {
            int maxId = 0;
            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                using (SqlCeTransaction transaction = connection.BeginTransaction())
                {
                    using (SqlCeCommand command = new SqlCeCommand("INSERT INTO Project (Name, ConnectionStringSource, ConnectionStringDestination, Options, Type, Internal) VALUES ('" + item.Name.Replace("'", "''") + "','" + item.ConnectionStringSource + "','" + item.ConnectionStringDestination + "','" + item.Options + "'," + ((int)item.Type).ToString() + ",0)", connection, transaction))
                    {
                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT MAX(ProjectId) AS NewId FROM Project WHERE Internal = 0";
                    
                        using (SqlCeDataReader reader = command.ExecuteReader())
                            if (reader.Read())
                                maxId = int.Parse(reader["NewId"].ToString());
                    }

                    transaction.Commit();
                }
            }
            return maxId;
        }

        /// <summary>
        /// Update an existing item in the Project List
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static int Update(Project item)
        {
            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                using (SqlCeCommand command = new SqlCeCommand(ProjectUpdateSql, connection))
                {
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = item.Name;
                    command.Parameters.Add("@ConnectionStringSource", SqlDbType.NVarChar).Value = item.ConnectionStringSource;
                    command.Parameters.Add("@ConnectionStringDestination", SqlDbType.NVarChar).Value = item.ConnectionStringDestination;
                    command.Parameters.Add("@Type", SqlDbType.Int).Value = item.Type;
                    command.Parameters.Add("@ProjectId", SqlDbType.Int).Value = item.Id;

                    command.ExecuteNonQuery();
                }
            }
            return item.Id;
        }
        #endregion

        /// <summary>
        /// Delete an item from the project list
        /// </summary>
        /// <param name="Id"></param>
        public static void Delete(int Id)
        {
            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                using (SqlCeCommand command = new SqlCeCommand("DELETE FROM Project WHERE ProjectId = " + Id.ToString(), connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Save an item, decide whether to insert or update.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int Save(Project item)
        {
            if (item.Id == 0)
                return Add(item);

            return Update(item);
        }

        public static void SaveLastConfiguration(String ConnectionStringSource, String ConnectionStringDestination)
        {
            if (GetLastConfiguration() != null)
            {
                using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCeCommand command = new SqlCeCommand("UPDATE Project SET ConnectionStringSource = '" + ConnectionStringSource + "', ConnectionStringDestination = '" + ConnectionStringDestination + "' WHERE Internal = 1", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCeCommand command = new SqlCeCommand("INSERT INTO Project (Name, ConnectionStringSource, ConnectionStringDestination, Options, Type, Internal) VALUES ('LastConfiguration','" + ConnectionStringSource + "','" + ConnectionStringDestination + "','',1,1)", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static Project GetLastConfiguration()
        {
            Project item = null;
            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                using (SqlCeCommand command = new SqlCeCommand("SELECT * FROM Project WHERE Internal = 1 ORDER BY Name", connection))
                {
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = new Project()
                            {
                                Id = int.Parse(reader["ProjectId"].ToString()),
                                ConnectionStringSource = reader["ConnectionStringSource"].ToString(),
                                ConnectionStringDestination = reader["ConnectionStringDestination"].ToString(),
                                Type = (ProjectType)Convert.ToInt16(reader["Type"]),
                                Name = reader["Name"].ToString()
                            };
                        }
                    }
                }
            }
            return item;

        }

        public static List<Project> GetAll()
        {
            List<Project> items = new List<Project>();
            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                using (SqlCeCommand command = new SqlCeCommand("SELECT * FROM Project WHERE Internal = 0 ORDER BY Name", connection))
                {
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Project item = new Project()
                            {
                                Id = int.Parse(reader["ProjectId"].ToString()),
                                ConnectionStringSource = reader["ConnectionStringSource"].ToString(),
                                ConnectionStringDestination = reader["ConnectionStringDestination"].ToString(),
                                Type = (ProjectType)Convert.ToInt16(reader["Type"]),
                                Name = reader["Name"].ToString()
                            };
                            items.Add(item);
                        }
                    }
                }
            }
            return items;
        }
    }
}
