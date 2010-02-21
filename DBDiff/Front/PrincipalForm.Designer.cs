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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.schemaTreeView1 = new DBDiff.Front.SchemaTreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNewObject = new DBDiff.Scintilla.Scintilla();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtOldObject = new DBDiff.Scintilla.Scintilla();
            this.tabDiff = new System.Windows.Forms.TabPage();
            this.diffControl = new Menees.DiffUtils.Controls.DiffControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiferencias = new DBDiff.Scintilla.Scintilla();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.PanelDestination = new System.Windows.Forms.Panel();
            this.PanelSource = new System.Windows.Forms.Panel();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).BeginInit();
            this.tabDiff.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiferencias)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 516);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 270;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1170, 484);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.schemaTreeView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 478);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop object";
            // 
            // schemaTreeView1
            // 
            this.schemaTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaTreeView1.DatabaseDestination = null;
            this.schemaTreeView1.DatabaseSource = null;
            this.schemaTreeView1.FilterDiferentObjects = true;
            this.schemaTreeView1.FilterMissingObjects = true;
            this.schemaTreeView1.FilterNewObjects = true;
            this.schemaTreeView1.Location = new System.Drawing.Point(0, 35);
            this.schemaTreeView1.Name = "schemaTreeView1";
            this.schemaTreeView1.Size = new System.Drawing.Size(376, 446);
            this.schemaTreeView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alter existing object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exists on Source Only";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(259, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 12);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(4, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 12);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(136, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 12);
            this.panel4.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabDiff);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(777, 481);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtNewObject);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(769, 455);
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
            this.txtNewObject.Size = new System.Drawing.Size(763, 449);
            this.txtNewObject.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtOldObject);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(769, 455);
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
            this.txtOldObject.Size = new System.Drawing.Size(763, 449);
            this.txtOldObject.TabIndex = 0;
            // 
            // tabDiff
            // 
            this.tabDiff.Controls.Add(this.diffControl);
            this.tabDiff.Location = new System.Drawing.Point(4, 22);
            this.tabDiff.Name = "tabDiff";
            this.tabDiff.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiff.Size = new System.Drawing.Size(769, 455);
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
            this.diffControl.Size = new System.Drawing.Size(763, 449);
            this.diffControl.TabIndex = 0;
            this.diffControl.ViewFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Synchronized Script";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDiferencias);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 453);
            this.panel1.TabIndex = 6;
            // 
            // txtDiferencias
            // 
            this.txtDiferencias.CurrentPos = 0;
            this.txtDiferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiferencias.IsReadOnly = true;
            this.txtDiferencias.Location = new System.Drawing.Point(0, 0);
            this.txtDiferencias.Name = "txtDiferencias";
            this.txtDiferencias.Size = new System.Drawing.Size(1040, 449);
            this.txtDiferencias.Styles.LineNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtDiferencias.Styles.LineNumber.IsVisible = false;
            this.txtDiferencias.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1176, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actions Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1044, 453);
            this.textBox1.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "SQL";
            this.saveFileDialog1.Filter = "SQL File|*.sql";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Image = global::DBDiff.Properties.Resources.Control_panel_2;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOptions.Location = new System.Drawing.Point(1197, 246);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(95, 55);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = global::DBDiff.Properties.Resources.Copy;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(1197, 368);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(95, 55);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy Clipboard";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Image = global::DBDiff.Properties.Resources.Floppy;
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAs.Location = new System.Drawing.Point(1197, 307);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(95, 55);
            this.btnSaveAs.TabIndex = 6;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Image = global::DBDiff.Properties.Resources.Compare;
            this.btnCompare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompare.Location = new System.Drawing.Point(1197, 185);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(95, 55);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewProject.Image = global::DBDiff.Properties.Resources.NewProject;
            this.btnNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.Location = new System.Drawing.Point(7, 51);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(113, 33);
            this.btnNewProject.TabIndex = 15;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // PanelDestination
            // 
            this.PanelDestination.BackColor = System.Drawing.SystemColors.Control;
            this.PanelDestination.Location = new System.Drawing.Point(518, 12);
            this.PanelDestination.Name = "PanelDestination";
            this.PanelDestination.Size = new System.Drawing.Size(386, 159);
            this.PanelDestination.TabIndex = 11;
            // 
            // PanelSource
            // 
            this.PanelSource.BackColor = System.Drawing.SystemColors.Control;
            this.PanelSource.Location = new System.Drawing.Point(126, 12);
            this.PanelSource.Name = "PanelSource";
            this.PanelSource.Size = new System.Drawing.Size(386, 159);
            this.PanelSource.TabIndex = 10;
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveProject.Image = global::DBDiff.Properties.Resources.SaveProject;
            this.btnSaveProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProject.Location = new System.Drawing.Point(7, 90);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(113, 33);
            this.btnSaveProject.TabIndex = 13;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnProject.Image = global::DBDiff.Properties.Resources.Open;
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.Location = new System.Drawing.Point(7, 12);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(113, 33);
            this.btnProject.TabIndex = 12;
            this.btnProject.Text = "Open Project";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 697);
            this.Controls.Add(this.PanelDestination);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.PanelSource);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.Text = string.Format("SQL-DBDiff v", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewObject)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldObject)).EndInit();
            this.tabDiff.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiferencias)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private DBDiff.Front.SchemaTreeView schemaTreeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private DBDiff.Scintilla.Scintilla txtDiferencias;
        private System.Windows.Forms.Panel PanelSource;
        private System.Windows.Forms.Panel PanelDestination;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}