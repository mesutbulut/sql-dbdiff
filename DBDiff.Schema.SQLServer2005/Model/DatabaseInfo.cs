using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DBDiff.Schema.SQLServer.Generates.Model
{
    public class DatabaseInfo
    {
        public enum VersionNumber
        {
            SQLServer2000 = 8,
            SQLServer2005 = 9,
            SQLServer2008 = 10
        }

        private string collation;
        private bool hasChangeTracking;
        private bool isChangeTrackingAutoCleanup;
        private int changeTrackingRetentionPeriod;
        private int changeTrackingPeriodUnits;
        private string changeTrackingPeriodUnitsDesc;
        private bool hasFullTextEnabled;

        public DatabaseInfo()
        {
            Version = VersionNumber.SQLServer2005;
        }

        public VersionNumber Version { get; set; }

        public string Collation
        {
            get { return collation; }
            set { collation = value; }
        }

        public bool HasFullTextEnabled
        {
            get { return hasFullTextEnabled; }
            set { hasFullTextEnabled = value; }
        }

        public string ChangeTrackingPeriodUnitsDesc
        {
            get { return changeTrackingPeriodUnitsDesc; }
            set { changeTrackingPeriodUnitsDesc = value; }
        }

        public int ChangeTrackingPeriodUnits
        {
            get { return changeTrackingPeriodUnits; }
            set { changeTrackingPeriodUnits = value; }
        }

        public int ChangeTrackingRetentionPeriod
        {
            get { return changeTrackingRetentionPeriod; }
            set { changeTrackingRetentionPeriod = value; }
        }

        public bool IsChangeTrackingAutoCleanup
        {
            get { return isChangeTrackingAutoCleanup; }
            set { isChangeTrackingAutoCleanup = value; }
        }

        public bool HasChangeTracking
        {
            get { return hasChangeTracking; }
            set { hasChangeTracking = value; }
        }
    }
}
