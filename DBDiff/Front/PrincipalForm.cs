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

namespace DBDiff.Front
{
    public partial class PrincipalForm : Form
    {
        #region Private Variables
        private Project ActiveProject;
        private IFront mySqlConnectFront1;
        private IFront mySqlConnectFront2;
        private readonly SqlOption SqlFilter;
        #endregion

        #region Constructor
        public PrincipalForm()
        {
            InitializeComponent();
            SqlFilter = new SqlOption();


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
        #endregion

        #region Private Methods
        private void ProcessMsSQL()
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
        private void ShowSQL2005()
        {
            mySqlConnectFront2 = new SqlServerConnectFront();
            mySqlConnectFront1 = new SqlServerConnectFront();
            mySqlConnectFront1.Location = new Point(1, 1);
            mySqlConnectFront1.Name = "mySqlConnectFront1";
            mySqlConnectFront1.Anchor =
                (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right);

            mySqlConnectFront1.TabIndex = 10;
            mySqlConnectFront1.Text = "Source Database:";
            mySqlConnectFront2.Location = new Point(1, 1);
            mySqlConnectFront2.Name = "mySqlConnectFront2";
            mySqlConnectFront2.Anchor =
                (AnchorStyles)((int)AnchorStyles.Bottom + (int)AnchorStyles.Left + (int)AnchorStyles.Right);
            mySqlConnectFront2.TabIndex = 10;
            mySqlConnectFront1.Visible = true;
            mySqlConnectFront2.Visible = true;
            mySqlConnectFront2.Text = "Destination Database:";
            ((SqlServerConnectFront)mySqlConnectFront1).UserName = "sa";
            ((SqlServerConnectFront)mySqlConnectFront1).Password = "";
            ((SqlServerConnectFront)mySqlConnectFront1).ServerName = "(local)";
            ((SqlServerConnectFront)mySqlConnectFront2).UserName = "sa";
            ((SqlServerConnectFront)mySqlConnectFront2).Password = "";
            ((SqlServerConnectFront)mySqlConnectFront2).ServerName = "(local)";
            ((SqlServerConnectFront)mySqlConnectFront1).DatabaseIndex = 1;
            ((SqlServerConnectFront)mySqlConnectFront2).DatabaseIndex = 2;
            PanelDestination.Controls.Add((Control)mySqlConnectFront2);
            PanelSource.Controls.Add((Control)mySqlConnectFront1);
        }
        #endregion

        #region Form/Control Events
        private void Form_Load(object sender, EventArgs e)
        {
            //Set the Title of the form
            this.Text = string.Format("SQL-DBDiff v{0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

            txtDiferencias.Text = "";
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

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ProcessMsSQL();

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

        private void btnSaveProject_Click(object sender, EventArgs e)
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
        #endregion
    }
}