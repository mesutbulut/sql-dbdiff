﻿using DBDiff.Schema.SQLServer.Generates.Model;

namespace DBDiff.Schema.SQLServer.Generates.Generates.SQLCommands
{
	internal static class UserDataTypeCommand
	{
		public static string Get(DatabaseInfo.VersionNumber version)
		{
			if (version == DatabaseInfo.VersionNumber.SQLServer2000) return Get2000();
			if (version == DatabaseInfo.VersionNumber.SQLServer2005) return Get2005();
			if (version == DatabaseInfo.VersionNumber.SQLServer2008) return Get2008();
			return "";
		}

		public static string Get2008()
		{
			string sql = "SELECT ISNULL(AF.name,'') AS assembly_name, ISNULL(AT.assembly_id,0) AS assembly_id, ISNULL(assembly_class,'') AS assembly_class, T.max_length, S2.name as defaultowner, O2.name as defaultname, S1.name as ruleowner, O.name as rulename, ISNULL(T2.Name,'') AS basetypename, S.Name AS Owner, T.Name, T.is_assembly_type, T.user_type_id AS tid, T.is_nullable, T.precision, T.scale ";
			sql += "FROM sys.types T ";
			sql += "INNER JOIN sys.schemas S ON S.schema_id = T.schema_id ";
			sql += "LEFT JOIN sys.types T2 ON T2.user_type_id = T.system_type_id ";
			sql += "LEFT JOIN sys.objects O ON O.type = 'R' and O.object_id = T.rule_object_id ";
			sql += "LEFT JOIN sys.schemas S1 ON S1.schema_id = O.schema_id ";
			sql += "LEFT JOIN sys.objects O2 ON O2.type = 'D' and O2.object_id = T.default_object_id ";
			sql += "LEFT JOIN sys.schemas S2 ON S2.schema_id = O2.schema_id ";
			sql += "LEFT JOIN sys.assembly_types AT ON AT.user_type_id = T.user_type_id AND T.is_assembly_type = 1 ";
			sql += "LEFT JOIN sys.assemblies AF ON AF.assembly_id = AT.assembly_id ";
			sql += "WHERE T.is_user_defined = 1 AND T.is_table_type = 0 ORDER BY T.Name";
			return sql;
		}

		public static string Get2005()
		{
			string sql = "select ISNULL(AF.name,'') AS assembly_name, ISNULL(AT.assembly_id,0) AS assembly_id, ISNULL(assembly_class,'') AS assembly_class, T.max_length, S2.name as defaultowner, O2.name as defaultname, S1.name as ruleowner, O.name as rulename, ISNULL(T2.Name,'') AS basetypename, S.Name AS Owner, T.Name, T.is_assembly_type, T.user_type_id AS tid, T.is_nullable, T.precision, T.scale from sys.types T ";
			sql += "INNER JOIN sys.schemas S ON S.schema_id = T.schema_id ";
			sql += "LEFT JOIN sys.types T2 ON T2.user_type_id = T.system_type_id ";
			sql += "LEFT JOIN sys.objects O ON O.type = 'R' and O.object_id = T.rule_object_id ";
			sql += "LEFT JOIN sys.schemas S1 ON S1.schema_id = O.schema_id ";
			sql += "LEFT JOIN sys.objects O2 ON O2.type = 'D' and O2.object_id = T.default_object_id ";
			sql += "LEFT JOIN sys.schemas S2 ON S2.schema_id = O2.schema_id ";
			sql += "LEFT JOIN sys.assembly_types AT ON AT.user_type_id = T.user_type_id AND T.is_assembly_type = 1 ";
			sql += "LEFT JOIN sys.assemblies AF ON AF.assembly_id = AT.assembly_id ";
			sql += "WHERE T.is_user_defined = 1 ORDER BY T.Name";
			return sql;
		}

		public static string Get2000()
		{
			string sql = "select '' AS assembly_name, 0 AS assembly_id, '' AS assembly_class, T.length as max_length, S2.name as defaultowner, O2.name as defaultname, S1.name as ruleowner, O.name as rulename, ISNULL(T2.Name,'') AS basetypename, S.Name AS Owner, T.Name, convert(bit,0) as is_assembly_type, convert(int,T.xusertype) AS tid, T.allownulls as is_nullable, T.xprec as [precision], T.xscale as scale"; 
			sql += " from systypes T ";
			sql += " INNER JOIN sysusers S ON S.uid = T.uid "; 
			sql += " LEFT JOIN systypes T2 ON T2.xusertype = T.xtype "; 
			sql += " LEFT JOIN sysobjects O ON O.type = 'R' and O.id = T.domain ";
			sql += " LEFT JOIN sysusers S1 ON S1.uid = O.uid  ";
			sql += " LEFT JOIN sysobjects O2 ON O2.type = 'D' and O2.id = T.tdefault ";
			sql += " LEFT JOIN sysusers S2 ON S2.uid = O2.uid  ";
			sql += " WHERE T.xusertype>256 ORDER BY T.Name";
			return sql;
		}
	}
}
