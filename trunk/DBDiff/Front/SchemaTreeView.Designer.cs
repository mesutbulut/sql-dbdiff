namespace DBDiff.Front
{
    partial class SchemaTreeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemaTreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkOld = new System.Windows.Forms.CheckBox();
            this.chkNew = new System.Windows.Forms.CheckBox();
            this.chkDiferent = new System.Windows.Forms.CheckBox();
            this.chkShowExistingObjects = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 67);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(266, 186);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder");
            this.imageList1.Images.SetKeyName(1, "Table");
            this.imageList1.Images.SetKeyName(2, "Procedure");
            this.imageList1.Images.SetKeyName(3, "User");
            this.imageList1.Images.SetKeyName(4, "Column");
            this.imageList1.Images.SetKeyName(5, "Index");
            this.imageList1.Images.SetKeyName(6, "Rol");
            this.imageList1.Images.SetKeyName(7, "Schema");
            this.imageList1.Images.SetKeyName(8, "View");
            this.imageList1.Images.SetKeyName(9, "Function");
            this.imageList1.Images.SetKeyName(10, "XMLSchema");
            this.imageList1.Images.SetKeyName(11, "Database");
            this.imageList1.Images.SetKeyName(12, "UDT");
            this.imageList1.Images.SetKeyName(13, "Assembly");
            this.imageList1.Images.SetKeyName(14, "PartitionFunction");
            this.imageList1.Images.SetKeyName(15, "PartitionScheme");
            // 
            // chkOld
            // 
            this.chkOld.AutoSize = true;
            this.chkOld.Checked = true;
            this.chkOld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOld.Location = new System.Drawing.Point(135, 44);
            this.chkOld.Name = "chkOld";
            this.chkOld.Size = new System.Drawing.Size(130, 17);
            this.chkOld.TabIndex = 1;
            this.chkOld.Text = "Show Missing Objects";
            this.chkOld.UseVisualStyleBackColor = true;
            this.chkOld.CheckedChanged += new System.EventHandler(this.chkOld_CheckedChanged);
            // 
            // chkNew
            // 
            this.chkNew.AutoSize = true;
            this.chkNew.Checked = true;
            this.chkNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNew.Location = new System.Drawing.Point(4, 44);
            this.chkNew.Name = "chkNew";
            this.chkNew.Size = new System.Drawing.Size(117, 17);
            this.chkNew.TabIndex = 2;
            this.chkNew.Text = "Show New Objects";
            this.chkNew.UseVisualStyleBackColor = true;
            this.chkNew.CheckedChanged += new System.EventHandler(this.chkNew_CheckedChanged);
            // 
            // chkDiferent
            // 
            this.chkDiferent.AutoSize = true;
            this.chkDiferent.Checked = true;
            this.chkDiferent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiferent.Location = new System.Drawing.Point(135, 21);
            this.chkDiferent.Name = "chkDiferent";
            this.chkDiferent.Size = new System.Drawing.Size(135, 17);
            this.chkDiferent.TabIndex = 3;
            this.chkDiferent.Text = "Show Different Objects";
            this.chkDiferent.UseVisualStyleBackColor = true;
            this.chkDiferent.CheckedChanged += new System.EventHandler(this.chkDiferent_CheckedChanged);
            // 
            // chkShowExistingObjects
            // 
            this.chkShowExistingObjects.AutoSize = true;
            this.chkShowExistingObjects.Checked = true;
            this.chkShowExistingObjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowExistingObjects.Location = new System.Drawing.Point(4, 21);
            this.chkShowExistingObjects.Name = "chkShowExistingObjects";
            this.chkShowExistingObjects.Size = new System.Drawing.Size(131, 17);
            this.chkShowExistingObjects.TabIndex = 4;
            this.chkShowExistingObjects.Text = "Show Existing Objects";
            this.chkShowExistingObjects.UseVisualStyleBackColor = true;
            this.chkShowExistingObjects.CheckedChanged += new System.EventHandler(this.chkShowExistingObjects_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Drop object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alter Object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Object";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(173, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 12);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 12);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(89, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 12);
            this.panel4.TabIndex = 11;
            // 
            // SchemaTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chkShowExistingObjects);
            this.Controls.Add(this.chkDiferent);
            this.Controls.Add(this.chkNew);
            this.Controls.Add(this.chkOld);
            this.Controls.Add(this.treeView1);
            this.Name = "SchemaTreeView";
            this.Size = new System.Drawing.Size(270, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chkOld;
        private System.Windows.Forms.CheckBox chkNew;
        private System.Windows.Forms.CheckBox chkDiferent;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkShowExistingObjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
