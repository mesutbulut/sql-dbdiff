using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBDiff.Front;

namespace DBDiff
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Front.Error errorDialog = new Error();
            errorDialog.Exception = e.Exception;
            errorDialog.ShowDialog();
        }
    }
}