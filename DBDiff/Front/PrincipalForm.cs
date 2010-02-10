using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DBDiff.Schema;
using DBDiff.Schema.Events;
using DBDiff.Schema.Misc;
using DBDiff.Schema.SQLServer.Generates.Front;
using DBDiff.Schema.SQLServer.Generates.Generates;
using DBDiff.Schema.SQLServer.Generates.Model;
using DBDiff.Schema.SQLServer.Generates.Options;
using DBDiff.Settings;
using Menees.DiffUtils;
using System.Collections.Generic;
/*using DBDiff.Schema.SQLServer2000;
using DBDiff.Schema.SQLServer2000.Model;
using DBDiff.Schema.SQLServer2000.Compare;
/*using DBDiff.Schema.Sybase;
using DBDiff.Schema.Sybase.Options;
using DBDiff.Schema.Sybase.Model;*/

/*using DBDiff.Schema.MySQL;
using DBDiff.Schema.MySQL.Options;
using DBDiff.Schema.MySQL.Model;
*/

namespace DBDiff.Front
{
    public partial class PrincipalForm : Form
    {
        //private MySqlOption MySQLfilter = new MySqlOption();
        //private AseOption AseFilter = new AseOption();

        private Project ActiveProject;
        private IFront mySqlConnectFront1;
        private IFront mySqlConnectFront2;
        private readonly SqlOption SqlFilter = new SqlOption();

        public PrincipalForm()
        {
            InitializeComponent();
            ShowSQL2005();
            txtNewObject.ConfigurationManager.Language = "mssql";
            txtNewObject.IsReadOnly = false;
            txtNewObject.Styles.LineNumber.BackColor = Color.White;
            txtNewObject.Styles.LineNumber.IsVisible = false;
            txtOldObject.ConfigurationManager.Language = "mssql";
            txtOldObject.IsReadOnly = false;
            txtOldObject.Styles.LineNumber.BackColor = Color.White;
            txtOldObject.Styles.LineNumber.IsVisible = false;
            Project LastConfiguration = Project.GetLastConfiguration();
            if (LastConfiguration != null)
            {
                mySqlConnectFront1.ConnectionString = LastConfiguration.ConnectionStringSource;
                mySqlConnectFront2.ConnectionString = LastConfiguration.ConnectionStringDestination;
            }
        }

        /*private void ProcesarSybase()
        {
            DBDiff.Schema.Sybase.Model.Database origen;
            DBDiff.Schema.Sybase.Model.Database destino;

            DBDiff.Schema.Sybase.Generate sql = new DBDiff.Schema.Sybase.Generate();
            sql.ConnectioString = txtConnectionOrigen.Text;
            
            AseFilter.OptionFilter.FilterTrigger = false;

            origen = sql.Process(AseFilter);

            sql.ConnectioString = txtConnectionDestino.Text;
            destino = sql.Process(AseFilter);

            this.txtScript.SQLType = SQLEnum.SQLTypeEnum.Sybase;
            this.txtDiferencias.SQLType = SQLEnum.SQLTypeEnum.Sybase;
            //origen = DBDiff.Schema.Sybase.Generate.Compare(origen, destino);

            this.txtScript.Text = origen.ToSQL();
            //this.txtDiferencias.Text = origen.ToSQLDiff();
        }*/

        /*private void ProcesarMySQL()
        {
            DBDiff.Schema.MySQL.Model.Database origen;
            DBDiff.Schema.MySQL.Model.Database destino;

            DBDiff.Schema.MySQL.Generate sql = new DBDiff.Schema.MySQL.Generate();
            sql.ConnectioString = mySqlConnectFront1.ConnectionString;
            origen = sql.Process(MySQLfilter);

            sql.ConnectioString = mySqlConnectFront2.ConnectionString;
            destino = sql.Process(MySQLfilter);

            //this.txtScript.SQLType = SQLEnum.SQLTypeEnum.MySQL;
            //this.txtDiferencias.SQLType = SQLEnum.SQLTypeEnum.MySQL;
            origen = DBDiff.Schema.MySQL.Generate.Compare(origen, destino);
            this.txtDiferencias.Text = origen.ToSQLDiff();
        }
        */

        private void ProcesarSQL2005()
        {
            try
            {
                Database origen;
                Database destino;

                if ((!String.IsNullOrEmpty(mySqlConnectFront1.DatabaseName) &&
                     (!String.IsNullOrEmpty(mySqlConnectFront2.DatabaseName))))
                {
                    Generate sql1 = new Generate();
                    Generate sql2 = new Generate();

                    sql1.ConnectionString = mySqlConnectFront1.ConnectionString;
                    sql1.Options = SqlFilter;

                    sql2.ConnectionString = mySqlConnectFront2.ConnectionString;
                    sql2.Options = SqlFilter;

                    ProgressForm progres = new ProgressForm("Source Database", "Destination Database", sql2, sql1);
                    progres.ShowDialog(this);
                    origen = progres.Source;
                    destino = progres.Destination;

                    txtDiferencias.ConfigurationManager.Language = "mssql";
                    txtDiferencias.IsReadOnly = false;
                    txtDiferencias.Styles.LineNumber.BackColor = Color.White;
                    txtDiferencias.Styles.LineNumber.IsVisible = false;
                    txtDiferencias.Text = destino.ToSqlDiff().ToSQL();
                    txtDiferencias.IsReadOnly = true;
                    schemaTreeView1.DatabaseSource = destino;
                    schemaTreeView1.DatabaseDestination = origen;
                    schemaTreeView1.OnSelectItem += new SchemaTreeView.SchemaHandler(schemaTreeView1_OnSelectItem);
                    textBox1.Text = origen.ActionMessage.Message;

                    btnCopy.Enabled = true;
                    btnSaveAs.Enabled = true;
                }
                else
                    MessageBox.Show(Owner, "Please select a valid connection string", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            catch (SchemaException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new SchemaException("Invalid database connection. Please check the database connection\r\n" +
                                          ex.Message);
            }
        }

        private void schemaTreeView1_OnSelectItem(string ObjectFullName)
        {
            txtNewObject.IsReadOnly = false;
            txtOldObject.IsReadOnly = false;
            txtNewObject.Text = string.Empty;
            txtOldObject.Text = string.Empty;

            Database database = (Database) schemaTreeView1.DatabaseSource;
            if (database.Find(ObjectFullName) != null)
            {
                if (database.Find(ObjectFullName).Status != Enums.ObjectStatusType.DropStatus)
                    txtNewObject.Text = database.Find(ObjectFullName).ToSql();
            }

            database = (Database) schemaTreeView1.DatabaseDestination;
            if (database.Find(ObjectFullName) != null)
            {
                if (database.Find(ObjectFullName).Status != Enums.ObjectStatusType.CreateStatus)
                    txtOldObject.Text = database.Find(ObjectFullName).ToSql();
            }
            txtNewObject.IsReadOnly = true;
            txtOldObject.IsReadOnly = true;

            //Make sure we have a new and an old object before we try and do a diff.
            if (!string.IsNullOrEmpty(txtNewObject.Text) && !string.IsNullOrEmpty(txtOldObject.Text))
            {
                TextDiff textDiff = new TextDiff(HashType.HashCode, true, true);
                
                //Make 2 lists, containing every line from the old and the new sql queries
                List<string> oldLines, newLines; 
                newLines = new List<string>(txtNewObject.Text.Split('\n'));
                oldLines = new List<string>(txtOldObject.Text.Split('\n'));

                EditScript editScript = textDiff.Execute(newLines, oldLines);
                diffControl.SetData(newLines, oldLines, editScript, "New", "Old");
            }
        }

        /*private void ProcesarSQL2000()
        {
            DBDiff.Schema.SQLServer2000.Model.Database origen;
            DBDiff.Schema.SQLServer2000.Model.Database destino;

            DBDiff.Schema.SQLServer2000.Generate sql = new DBDiff.Schema.SQLServer2000.Generate();

            lblMessage.Text = "Leyendo tablas de origen...";
            sql.OnTableProgress += new Progress.ProgressHandler(sql_OnTableProgress);
            //sql.ConnectioString = txtConnectionOrigen.Text;
            origen = sql.Process();

            //sql.ConnectioString = txtConnectionDestino.Text;
            lblMessage.Text = "Leyendo tablas de destino...";
            destino = sql.Process();

            origen = DBDiff.Schema.SQLServer2000.Generate.Compare(origen, destino);
            //this.txtScript.SQLType = SQLEnum.SQLTypeEnum.SQLServer;
            //this.txtDiferencias.SQLType = SQLEnum.SQLTypeEnum.SQLServer;
            this.txtDiferencias.Text = origen.ToSQLDiff();
            

        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                
                ProcesarSQL2005();
                
                Project.SaveLastConfiguration(mySqlConnectFront1.ConnectionString, mySqlConnectFront2.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Owner, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ShowSQL2005()
        {
            mySqlConnectFront2 = new SqlServerConnectFront();
            mySqlConnectFront1 = new SqlServerConnectFront();
            mySqlConnectFront1.Location = new Point(1, 1);
            mySqlConnectFront1.Name = "mySqlConnectFront1";
            mySqlConnectFront1.Anchor =
                (AnchorStyles) ((int) AnchorStyles.Bottom + (int) AnchorStyles.Left + (int) AnchorStyles.Right);

            mySqlConnectFront1.TabIndex = 10;
            mySqlConnectFront1.Text = "Source Database:";
            mySqlConnectFront2.Location = new Point(1, 1);
            mySqlConnectFront2.Name = "mySqlConnectFront2";
            mySqlConnectFront2.Anchor =
                (AnchorStyles) ((int) AnchorStyles.Bottom + (int) AnchorStyles.Left + (int) AnchorStyles.Right);
            mySqlConnectFront2.TabIndex = 10;
            mySqlConnectFront1.Visible = true;
            mySqlConnectFront2.Visible = true;
            mySqlConnectFront2.Text = "Destination Database:";
            ((SqlServerConnectFront) mySqlConnectFront1).UserName = "sa";
            ((SqlServerConnectFront) mySqlConnectFront1).Password = "";
            ((SqlServerConnectFront) mySqlConnectFront1).ServerName = "(local)";
            ((SqlServerConnectFront) mySqlConnectFront2).UserName = "sa";
            ((SqlServerConnectFront) mySqlConnectFront2).Password = "";
            ((SqlServerConnectFront) mySqlConnectFront2).ServerName = "(local)";
            ((SqlServerConnectFront) mySqlConnectFront1).DatabaseIndex = 1;
            ((SqlServerConnectFront) mySqlConnectFront2).DatabaseIndex = 2;
            PanelDestination.Controls.Add((Control) mySqlConnectFront2);
            PanelSource.Controls.Add((Control) mySqlConnectFront1);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog(Owner);
                if (!String.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false);
                    writer.Write(txtDiferencias.Text);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDiferencias.Text);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionForm form = new OptionForm();
            form.Show(Owner, SqlFilter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDiferencias.Text = "";
        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ActiveProject == null)
                {
                    ActiveProject = new Project
                                        {
                                            ConnectionStringSource = mySqlConnectFront1.ConnectionString,
                                            ConnectionStringDestination = mySqlConnectFront2.ConnectionString,
                                            Name = mySqlConnectFront1.DatabaseName + " - " + mySqlConnectFront2.DatabaseName,
                                            Type = Project.ProjectType.SQLServer
                                        };
                }
                ActiveProject.Id = Project.Save(ActiveProject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            try
            {
                ListProjectsForm form = new ListProjectsForm(Project.GetAll());
                form.OnSelect += new ListProjectHandler(form_OnSelect);
                form.OnDelete += new ListProjectHandler(form_OnDelete);
                form.OnRename += new ListProjectHandler(form_OnRename);
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void form_OnRename(Project itemSelected)
        {
            try
            {
                Project.Save(itemSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_OnDelete(Project itemSelected)
        {
            try
            {
                Project.Delete(itemSelected.Id);
                if (ActiveProject != null)
                {
                    if (ActiveProject.Id == itemSelected.Id)
                    {
                        ActiveProject = null;
                        mySqlConnectFront1.ConnectionString = "";
                        mySqlConnectFront2.ConnectionString = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void form_OnSelect(Project itemSelected)
        {
            try
            {
                if (itemSelected != null)
                {
                    ActiveProject = itemSelected;
                    mySqlConnectFront1.ConnectionString = itemSelected.ConnectionStringSource;
                    mySqlConnectFront2.ConnectionString = itemSelected.ConnectionStringDestination;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            mySqlConnectFront1.ConnectionString = "";
            mySqlConnectFront2.ConnectionString = "";
            ActiveProject = null;
        }
    }
}