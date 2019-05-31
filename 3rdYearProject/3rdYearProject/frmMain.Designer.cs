namespace _3rdYearProject
{
    partial class frmMain
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuProgrammability = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabaseList = new System.Windows.Forms.ComboBox();
            this.cblEntities = new System.Windows.Forms.CheckedListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnInsertIntoDB = new System.Windows.Forms.Button();
            this.tcClause = new System.Windows.Forms.TabControl();
            this.tpJoin = new System.Windows.Forms.TabPage();
            this.lnklblRemoveJoin = new System.Windows.Forms.LinkLabel();
            this.lnklblAddJoin = new System.Windows.Forms.LinkLabel();
            this.tpWhere = new System.Windows.Forms.TabPage();
            this.lnklblRemoveWhere = new System.Windows.Forms.LinkLabel();
            this.lnklblAddWhere = new System.Windows.Forms.LinkLabel();
            this.tpGroupBy = new System.Windows.Forms.TabPage();
            this.lnklblRemoveGroupBy = new System.Windows.Forms.LinkLabel();
            this.lnklblAddGroupBy = new System.Windows.Forms.LinkLabel();
            this.tbOrderBy = new System.Windows.Forms.TabPage();
            this.lnklblRemoveOrderBy = new System.Windows.Forms.LinkLabel();
            this.lnklblAddOrderBy = new System.Windows.Forms.LinkLabel();
            this.tbHaving = new System.Windows.Forms.TabPage();
            this.lnklblRemoveHaving = new System.Windows.Forms.LinkLabel();
            this.lnklblAddHaving = new System.Windows.Forms.LinkLabel();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.mnuMenu.SuspendLayout();
            this.tcClause.SuspendLayout();
            this.tpJoin.SuspendLayout();
            this.tpWhere.SuspendLayout();
            this.tpGroupBy.SuspendLayout();
            this.tbOrderBy.SuspendLayout();
            this.tbHaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect,
            this.mnuInsert,
            this.mnuDelete,
            this.mnuUpdate,
            this.mmuProgrammability,
            this.mnuData,
            this.mnuLogout});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuSelect
            // 
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(61, 24);
            this.mnuSelect.Text = "Select";
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(57, 24);
            this.mnuInsert.Text = "Insert";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(65, 24);
            this.mnuDelete.Text = "Delete";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(70, 24);
            this.mnuUpdate.Text = "Update";
            // 
            // mmuProgrammability
            // 
            this.mmuProgrammability.Name = "mmuProgrammability";
            this.mmuProgrammability.Size = new System.Drawing.Size(132, 24);
            this.mmuProgrammability.Text = "Programmability";
            // 
            // mnuData
            // 
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(53, 24);
            this.mnuData.Text = "Data";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(68, 24);
            this.mnuLogout.Text = "Logout";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(12, 45);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 17);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // cmbDatabaseList
            // 
            this.cmbDatabaseList.FormattingEnabled = true;
            this.cmbDatabaseList.Location = new System.Drawing.Point(88, 42);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(121, 24);
            this.cmbDatabaseList.TabIndex = 2;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // cblEntities
            // 
            this.cblEntities.FormattingEnabled = true;
            this.cblEntities.Location = new System.Drawing.Point(15, 109);
            this.cblEntities.Name = "cblEntities";
            this.cblEntities.Size = new System.Drawing.Size(197, 140);
            this.cblEntities.TabIndex = 3;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(16, 280);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(100, 280);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnInsertIntoDB
            // 
            this.btnInsertIntoDB.Location = new System.Drawing.Point(181, 280);
            this.btnInsertIntoDB.Name = "btnInsertIntoDB";
            this.btnInsertIntoDB.Size = new System.Drawing.Size(146, 23);
            this.btnInsertIntoDB.TabIndex = 7;
            this.btnInsertIntoDB.Text = "Insert into database";
            this.btnInsertIntoDB.UseVisualStyleBackColor = true;
            // 
            // tcClause
            // 
            this.tcClause.Controls.Add(this.tpJoin);
            this.tcClause.Controls.Add(this.tpWhere);
            this.tcClause.Controls.Add(this.tpGroupBy);
            this.tcClause.Controls.Add(this.tbOrderBy);
            this.tcClause.Controls.Add(this.tbHaving);
            this.tcClause.Location = new System.Drawing.Point(264, 45);
            this.tcClause.Name = "tcClause";
            this.tcClause.SelectedIndex = 0;
            this.tcClause.Size = new System.Drawing.Size(509, 204);
            this.tcClause.TabIndex = 8;
            // 
            // tpJoin
            // 
            this.tpJoin.Controls.Add(this.lnklblRemoveJoin);
            this.tpJoin.Controls.Add(this.lnklblAddJoin);
            this.tpJoin.Location = new System.Drawing.Point(4, 25);
            this.tpJoin.Name = "tpJoin";
            this.tpJoin.Padding = new System.Windows.Forms.Padding(3);
            this.tpJoin.Size = new System.Drawing.Size(501, 175);
            this.tpJoin.TabIndex = 0;
            this.tpJoin.Text = "Joins";
            this.tpJoin.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveJoin
            // 
            this.lnklblRemoveJoin.AutoSize = true;
            this.lnklblRemoveJoin.Location = new System.Drawing.Point(7, 46);
            this.lnklblRemoveJoin.Name = "lnklblRemoveJoin";
            this.lnklblRemoveJoin.Size = new System.Drawing.Size(60, 17);
            this.lnklblRemoveJoin.TabIndex = 1;
            this.lnklblRemoveJoin.TabStop = true;
            this.lnklblRemoveJoin.Text = "Remove";
            // 
            // lnklblAddJoin
            // 
            this.lnklblAddJoin.AutoSize = true;
            this.lnklblAddJoin.Location = new System.Drawing.Point(7, 17);
            this.lnklblAddJoin.Name = "lnklblAddJoin";
            this.lnklblAddJoin.Size = new System.Drawing.Size(33, 17);
            this.lnklblAddJoin.TabIndex = 0;
            this.lnklblAddJoin.TabStop = true;
            this.lnklblAddJoin.Text = "Add";
            // 
            // tpWhere
            // 
            this.tpWhere.Controls.Add(this.lnklblRemoveWhere);
            this.tpWhere.Controls.Add(this.lnklblAddWhere);
            this.tpWhere.Location = new System.Drawing.Point(4, 25);
            this.tpWhere.Name = "tpWhere";
            this.tpWhere.Padding = new System.Windows.Forms.Padding(3);
            this.tpWhere.Size = new System.Drawing.Size(501, 175);
            this.tpWhere.TabIndex = 1;
            this.tpWhere.Text = "Where";
            this.tpWhere.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveWhere
            // 
            this.lnklblRemoveWhere.AutoSize = true;
            this.lnklblRemoveWhere.Location = new System.Drawing.Point(15, 41);
            this.lnklblRemoveWhere.Name = "lnklblRemoveWhere";
            this.lnklblRemoveWhere.Size = new System.Drawing.Size(60, 17);
            this.lnklblRemoveWhere.TabIndex = 3;
            this.lnklblRemoveWhere.TabStop = true;
            this.lnklblRemoveWhere.Text = "Remove";
            // 
            // lnklblAddWhere
            // 
            this.lnklblAddWhere.AutoSize = true;
            this.lnklblAddWhere.Location = new System.Drawing.Point(15, 12);
            this.lnklblAddWhere.Name = "lnklblAddWhere";
            this.lnklblAddWhere.Size = new System.Drawing.Size(33, 17);
            this.lnklblAddWhere.TabIndex = 2;
            this.lnklblAddWhere.TabStop = true;
            this.lnklblAddWhere.Text = "Add";
            // 
            // tpGroupBy
            // 
            this.tpGroupBy.Controls.Add(this.lnklblRemoveGroupBy);
            this.tpGroupBy.Controls.Add(this.lnklblAddGroupBy);
            this.tpGroupBy.Location = new System.Drawing.Point(4, 25);
            this.tpGroupBy.Name = "tpGroupBy";
            this.tpGroupBy.Size = new System.Drawing.Size(501, 175);
            this.tpGroupBy.TabIndex = 2;
            this.tpGroupBy.Text = "Group By";
            this.tpGroupBy.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveGroupBy
            // 
            this.lnklblRemoveGroupBy.AutoSize = true;
            this.lnklblRemoveGroupBy.Location = new System.Drawing.Point(12, 41);
            this.lnklblRemoveGroupBy.Name = "lnklblRemoveGroupBy";
            this.lnklblRemoveGroupBy.Size = new System.Drawing.Size(60, 17);
            this.lnklblRemoveGroupBy.TabIndex = 3;
            this.lnklblRemoveGroupBy.TabStop = true;
            this.lnklblRemoveGroupBy.Text = "Remove";
            // 
            // lnklblAddGroupBy
            // 
            this.lnklblAddGroupBy.AutoSize = true;
            this.lnklblAddGroupBy.Location = new System.Drawing.Point(12, 12);
            this.lnklblAddGroupBy.Name = "lnklblAddGroupBy";
            this.lnklblAddGroupBy.Size = new System.Drawing.Size(33, 17);
            this.lnklblAddGroupBy.TabIndex = 2;
            this.lnklblAddGroupBy.TabStop = true;
            this.lnklblAddGroupBy.Text = "Add";
            // 
            // tbOrderBy
            // 
            this.tbOrderBy.Controls.Add(this.lnklblRemoveOrderBy);
            this.tbOrderBy.Controls.Add(this.lnklblAddOrderBy);
            this.tbOrderBy.Location = new System.Drawing.Point(4, 25);
            this.tbOrderBy.Name = "tbOrderBy";
            this.tbOrderBy.Size = new System.Drawing.Size(501, 175);
            this.tbOrderBy.TabIndex = 3;
            this.tbOrderBy.Text = "Order By";
            this.tbOrderBy.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveOrderBy
            // 
            this.lnklblRemoveOrderBy.AutoSize = true;
            this.lnklblRemoveOrderBy.Location = new System.Drawing.Point(17, 43);
            this.lnklblRemoveOrderBy.Name = "lnklblRemoveOrderBy";
            this.lnklblRemoveOrderBy.Size = new System.Drawing.Size(60, 17);
            this.lnklblRemoveOrderBy.TabIndex = 3;
            this.lnklblRemoveOrderBy.TabStop = true;
            this.lnklblRemoveOrderBy.Text = "Remove";
            // 
            // lnklblAddOrderBy
            // 
            this.lnklblAddOrderBy.AutoSize = true;
            this.lnklblAddOrderBy.Location = new System.Drawing.Point(17, 14);
            this.lnklblAddOrderBy.Name = "lnklblAddOrderBy";
            this.lnklblAddOrderBy.Size = new System.Drawing.Size(33, 17);
            this.lnklblAddOrderBy.TabIndex = 2;
            this.lnklblAddOrderBy.TabStop = true;
            this.lnklblAddOrderBy.Text = "Add";
            // 
            // tbHaving
            // 
            this.tbHaving.Controls.Add(this.lnklblRemoveHaving);
            this.tbHaving.Controls.Add(this.lnklblAddHaving);
            this.tbHaving.Location = new System.Drawing.Point(4, 25);
            this.tbHaving.Name = "tbHaving";
            this.tbHaving.Size = new System.Drawing.Size(501, 175);
            this.tbHaving.TabIndex = 4;
            this.tbHaving.Text = "Having";
            this.tbHaving.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveHaving
            // 
            this.lnklblRemoveHaving.AutoSize = true;
            this.lnklblRemoveHaving.Location = new System.Drawing.Point(13, 40);
            this.lnklblRemoveHaving.Name = "lnklblRemoveHaving";
            this.lnklblRemoveHaving.Size = new System.Drawing.Size(60, 17);
            this.lnklblRemoveHaving.TabIndex = 3;
            this.lnklblRemoveHaving.TabStop = true;
            this.lnklblRemoveHaving.Text = "Remove";
            // 
            // lnklblAddHaving
            // 
            this.lnklblAddHaving.AutoSize = true;
            this.lnklblAddHaving.Location = new System.Drawing.Point(13, 11);
            this.lnklblAddHaving.Name = "lnklblAddHaving";
            this.lnklblAddHaving.Size = new System.Drawing.Size(33, 17);
            this.lnklblAddHaving.TabIndex = 2;
            this.lnklblAddHaving.TabStop = true;
            this.lnklblAddHaving.Text = "Add";
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(88, 79);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(121, 24);
            this.cmbTables.TabIndex = 9;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(13, 82);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(51, 17);
            this.lblTables.TabIndex = 10;
            this.lblTables.Text = "Tables";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(16, 309);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(757, 212);
            this.lstDisplay.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.tcClause);
            this.Controls.Add(this.btnInsertIntoDB);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cblEntities);
            this.Controls.Add(this.cmbDatabaseList);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMain";
            this.Text = "main";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tcClause.ResumeLayout(false);
            this.tpJoin.ResumeLayout(false);
            this.tpJoin.PerformLayout();
            this.tpWhere.ResumeLayout(false);
            this.tpWhere.PerformLayout();
            this.tpGroupBy.ResumeLayout(false);
            this.tpGroupBy.PerformLayout();
            this.tbOrderBy.ResumeLayout(false);
            this.tbOrderBy.PerformLayout();
            this.tbHaving.ResumeLayout(false);
            this.tbHaving.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cmbDatabaseList;
        private System.Windows.Forms.CheckedListBox cblEntities;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnInsertIntoDB;
        private System.Windows.Forms.TabControl tcClause;
        private System.Windows.Forms.TabPage tpJoin;
        private System.Windows.Forms.TabPage tpWhere;
        private System.Windows.Forms.TabPage tpGroupBy;
        private System.Windows.Forms.TabPage tbOrderBy;
        private System.Windows.Forms.TabPage tbHaving;
        private System.Windows.Forms.LinkLabel lnklblRemoveJoin;
        private System.Windows.Forms.LinkLabel lnklblAddJoin;
        private System.Windows.Forms.LinkLabel lnklblRemoveWhere;
        private System.Windows.Forms.LinkLabel lnklblAddWhere;
        private System.Windows.Forms.LinkLabel lnklblRemoveGroupBy;
        private System.Windows.Forms.LinkLabel lnklblAddGroupBy;
        private System.Windows.Forms.LinkLabel lnklblRemoveOrderBy;
        private System.Windows.Forms.LinkLabel lnklblAddOrderBy;
        private System.Windows.Forms.LinkLabel lnklblRemoveHaving;
        private System.Windows.Forms.LinkLabel lnklblAddHaving;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ToolStripMenuItem mmuProgrammability;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}