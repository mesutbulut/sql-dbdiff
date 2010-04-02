using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBDiff.Schema.SQLServer.Generates.Model;

namespace DBDiff.Schema.SQLServer.Generates.Generates.SQLCommands
{
    internal class DatabaseSQLCommand
    {
        public static string GetDatabaseProperties(DatabaseInfo.VersionNumber version, Database databaseSchema)
        {
            switch (version)
            {
                case DatabaseInfo.VersionNumber.SQLServer2000:
                case DatabaseInfo.VersionNumber.SQLServer2005:
                case DatabaseInfo.VersionNumber.SQLServer2008:
                    return string.Format("SELECT DATABASEPROPERTYEX('{0}','IsFulltextEnabled') AS IsFullTextEnabled, DATABASEPROPERTYEX('{0}','Collation') AS Collation", databaseSchema.Name);
                    break;
                default:
                    return string.Empty;
                    break;
            }
        }

        public static string GetDatabases(DatabaseInfo.VersionNumber version)
        {
            switch (version)
            {
                case DatabaseInfo.VersionNumber.SQLServer2000:
                    return "SELECT name, dbid FROM master.dbo.sysdatabases ORDER BY Name";
                    break;
                case DatabaseInfo.VersionNumber.SQLServer2005:
                case DatabaseInfo.VersionNumber.SQLServer2008:
                    return "SELECT name, database_id FROM sys.databases ORDER BY Name"; 
                    break;
                default:
                    return string.Empty;
            }            
        }
    }
}
