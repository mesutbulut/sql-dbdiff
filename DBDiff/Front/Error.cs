using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBDiff.Front
{
    public partial class Error : Form
    {
        public Exception Exception { get; set; }

        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            txtErrorLog.Text = Exception.Message + "\r\n" + Exception.StackTrace;
            if (Exception.InnerException != null)
                txtErrorLog.Text += "\r\n" + Exception.InnerException.StackTrace;
        }

        private void lnkIssuePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://code.google.com/p/sql-dbdiff/issues/entry");
        }
    }
}
