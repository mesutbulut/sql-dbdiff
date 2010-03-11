using System.Reflection;
namespace DBDiff.Front
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.schemaView = new DBDiff.Front.SchemaTreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNewObject = new DBDiff.Scintilla.Scintilla();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtOldObject = new DBDiff.Scintilla.Scintilla();
            this.tabDiff = new System.Windows.Forms.TabPage();
            this.diffControl = new Menees.DiffUtils.Controls.DiffControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtDifferences = new DBDiff.Scintilla.Scintilla();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.PanelDestination = new System.Windows.Forms.Panel();
            this.PanelSource = new System.Windows.Forms.Panel();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).BeginInit();
            this.tabDiff.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDifferences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 528);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 385);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.schemaView);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // schemaView
            // 
            this.schemaView.DatabaseDestination = null;
            this.schemaView.DatabaseSource = null;
            this.schemaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schemaView.Location = new System.Drawing.Point(3, 16);
            this.schemaView.Name = "schemaView";
            this.schemaView.ShowDiferentObjects = true;
            this.schemaView.ShowExistingObjects = true;
            this.schemaView.ShowMissingObjects = true;
            this.schemaView.ShowNewObjects = true;
            this.schemaView.Size = new System.Drawing.Size(268, 328);
            this.schemaView.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabDiff);
            this.tabControl2.Location = new System.Drawing.Point(286, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(497, 347);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtNewObject);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(489, 321);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "New object";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtNewObject
            // 
            this.txtNewObject.CurrentPos = 0;
            this.txtNewObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewObject.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewObject.Location = new System.Drawing.Point(3, 3);
            this.txtNewObject.Name = "txtNewObject";
            this.txtNewObject.Scrolling.HorizontalWidth = 100;
            this.txtNewObject.Size = new System.Drawing.Size(483, 315);
            this.txtNewObject.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtOldObject);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(544, 321);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Old object";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtOldObject
            // 
            this.txtOldObject.CurrentPos = 0;
            this.txtOldObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldObject.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldObject.Location = new System.Drawing.Point(3, 3);
            this.txtOldObject.Name = "txtOldObject";
            this.txtOldObject.Scrolling.HorizontalWidth = 100;
            this.txtOldObject.Size = new System.Drawing.Size(538, 315);
            this.txtOldObject.TabIndex = 0;
            // 
            // tabDiff
            // 
            this.tabDiff.Controls.Add(this.diffControl);
            this.tabDiff.Location = new System.Drawing.Point(4, 22);
            this.tabDiff.Name = "tabDiff";
            this.tabDiff.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiff.Size = new System.Drawing.Size(544, 321);
            this.tabDiff.TabIndex = 2;
            this.tabDiff.Text = "Visual Diff";
            this.tabDiff.UseVisualStyleBackColor = true;
            // 
            // diffControl
            // 
            this.diffControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffControl.Location = new System.Drawing.Point(3, 3);
            this.diffControl.Name = "diffControl";
            this.diffControl.ShowWhitespaceInLineDiff = true;
            this.diffControl.Size = new System.Drawing.Size(538, 315);
            this.diffControl.TabIndex = 0;
            this.diffControl.ViewFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCopy);
            this.tabPage1.Controls.Add(this.txtDifferences);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.btnSaveAs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Synchronized Script";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = global::DBDiff.Properties.Resources.Copy;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(743, 67);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(95, 55);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy Clipboard";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtDifferences
            // 
            this.txtDifferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDifferences.CurrentPos = 0;
            this.txtDifferences.IsReadOnly = true;
            this.txtDifferences.Location = new System.Drawing.Point(6, 6);
            this.txtDifferences.Name = "txtDifferences";
            this.txtDifferences.Scrolling.HorizontalWidth = 500;
            this.txtDifferences.Size = new System.Drawing.Size(731, 347);
            this.txtDifferences.Styles.LineNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtDifferences.Styles.LineNumber.IsVisible = false;
            this.txtDifferences.TabIndex = 0;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Image = global::DBDiff.Properties.Resources.Floppy;
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAs.Location = new System.Drawing.Point(743, 6);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(95, 55);
            this.btnSaveAs.TabIndex = 6;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "SQL";
            this.saveFileDialog1.Filter = "SQL File|*.sql";
            // 
            // btnOptions
            // 
            this.btnOptions.Image = global::DBDiff.Properties.Resources.Control_panel_2;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOptions.Location = new System.Drawing.Point(742, 73);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(60, 55);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Image = global::DBDiff.Properties.Resources.Compare;
            this.btnCompare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompare.Location = new System.Drawing.Point(742, 12);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(60, 55);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewProject.Image = global::DBDiff.Properties.Resources.NewProject;
            this.btnNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.Location = new System.Drawing.Point(7, 51);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(93, 33);
            this.btnNewProject.TabIndex = 15;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // PanelDestination
            // 
            this.PanelDestination.BackColor = System.Drawing.SystemColors.Control;
            this.PanelDestination.Location = new System.Drawing.Point(424, 12);
            this.PanelDestination.Name = "PanelDestination";
            this.PanelDestination.Size = new System.Drawing.Size(312, 159);
            this.PanelDestination.TabIndex = 11;
            // 
            // PanelSource
            // 
            this.PanelSource.BackColor = System.Drawing.SystemColors.Control;
            this.PanelSource.Location = new System.Drawing.Point(106, 12);
            this.PanelSource.Name = "PanelSource";
            this.PanelSource.Size = new System.Drawing.Size(312, 159);
            this.PanelSource.TabIndex = 10;
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveProject.Image = global::DBDiff.Properties.Resources.SaveProject;
            this.btnSaveProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProject.Location = new System.Drawing.Point(7, 90);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(93, 33);
            this.btnSaveProject.TabIndex = 13;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnProject.Image = global::DBDiff.Properties.Resources.Open;
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.Location = new System.Drawing.Point(7, 12);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(93, 33);
            this.btnProject.TabIndex = 12;
            this.btnProject.Text = "Open Project";
            this.btnProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 566);
            this.Controls.Add(this.PanelDestination);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.PanelSource);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "PrincipalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).EndInit();
            this.tabDiff.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDifferences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TabPage tabPage2;
        private DBDiff.Scintilla.Scintilla txtDifferences;
        private System.Windows.Forms.Panel PanelSource;
        private System.Windows.Forms.Panel PanelDestination;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private DBDiff.Scintilla.Scintilla txtNewObject;
        private DBDiff.Scintilla.Scintilla txtOldObject;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.TabPage tabDiff;
        private Menees.DiffUtils.Controls.DiffControl diffControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private SchemaTreeView schemaView;
    }
}