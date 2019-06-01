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
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabaseList = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
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
            this.cblEntities = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuData,
            this.mnuLogout,
            this.createToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(738, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuSelect
            // 
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(50, 20);
            this.mnuSelect.Text = "Select";
            this.mnuSelect.Click += new System.EventHandler(this.mnuSelect_Click);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(48, 20);
            this.mnuInsert.Text = "Insert";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(52, 20);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(57, 20);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuData
            // 
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(43, 20);
            this.mnuData.Text = "Data";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(57, 20);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(9, 37);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // cmbDatabaseList
            // 
            this.cmbDatabaseList.FormattingEnabled = true;
            this.cmbDatabaseList.Location = new System.Drawing.Point(66, 34);
            this.cmbDatabaseList.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(158, 21);
            this.cmbDatabaseList.TabIndex = 2;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(11, 298);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(56, 19);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnInsertIntoDB
            // 
            this.btnInsertIntoDB.Location = new System.Drawing.Point(71, 298);
            this.btnInsertIntoDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertIntoDB.Name = "btnInsertIntoDB";
            this.btnInsertIntoDB.Size = new System.Drawing.Size(110, 19);
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
            this.tcClause.Location = new System.Drawing.Point(273, 34);
            this.tcClause.Margin = new System.Windows.Forms.Padding(2);
            this.tcClause.Name = "tcClause";
            this.tcClause.SelectedIndex = 0;
            this.tcClause.Size = new System.Drawing.Size(454, 255);
            this.tcClause.TabIndex = 8;
            // 
            // tpJoin
            // 
            this.tpJoin.Controls.Add(this.lnklblRemoveJoin);
            this.tpJoin.Controls.Add(this.lnklblAddJoin);
            this.tpJoin.Location = new System.Drawing.Point(4, 22);
            this.tpJoin.Margin = new System.Windows.Forms.Padding(2);
            this.tpJoin.Name = "tpJoin";
            this.tpJoin.Padding = new System.Windows.Forms.Padding(2);
            this.tpJoin.Size = new System.Drawing.Size(446, 229);
            this.tpJoin.TabIndex = 0;
            this.tpJoin.Text = "Joins";
            this.tpJoin.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveJoin
            // 
            this.lnklblRemoveJoin.AutoSize = true;
            this.lnklblRemoveJoin.Location = new System.Drawing.Point(5, 37);
            this.lnklblRemoveJoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblRemoveJoin.Name = "lnklblRemoveJoin";
            this.lnklblRemoveJoin.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemoveJoin.TabIndex = 1;
            this.lnklblRemoveJoin.TabStop = true;
            this.lnklblRemoveJoin.Text = "Remove";
            // 
            // lnklblAddJoin
            // 
            this.lnklblAddJoin.AutoSize = true;
            this.lnklblAddJoin.Location = new System.Drawing.Point(5, 14);
            this.lnklblAddJoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblAddJoin.Name = "lnklblAddJoin";
            this.lnklblAddJoin.Size = new System.Drawing.Size(26, 13);
            this.lnklblAddJoin.TabIndex = 0;
            this.lnklblAddJoin.TabStop = true;
            this.lnklblAddJoin.Text = "Add";
            // 
            // tpWhere
            // 
            this.tpWhere.Controls.Add(this.lnklblRemoveWhere);
            this.tpWhere.Controls.Add(this.lnklblAddWhere);
            this.tpWhere.Location = new System.Drawing.Point(4, 22);
            this.tpWhere.Margin = new System.Windows.Forms.Padding(2);
            this.tpWhere.Name = "tpWhere";
            this.tpWhere.Padding = new System.Windows.Forms.Padding(2);
            this.tpWhere.Size = new System.Drawing.Size(446, 229);
            this.tpWhere.TabIndex = 1;
            this.tpWhere.Text = "Where";
            this.tpWhere.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveWhere
            // 
            this.lnklblRemoveWhere.AutoSize = true;
            this.lnklblRemoveWhere.Location = new System.Drawing.Point(11, 33);
            this.lnklblRemoveWhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblRemoveWhere.Name = "lnklblRemoveWhere";
            this.lnklblRemoveWhere.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemoveWhere.TabIndex = 3;
            this.lnklblRemoveWhere.TabStop = true;
            this.lnklblRemoveWhere.Text = "Remove";
            // 
            // lnklblAddWhere
            // 
            this.lnklblAddWhere.AutoSize = true;
            this.lnklblAddWhere.Location = new System.Drawing.Point(11, 10);
            this.lnklblAddWhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblAddWhere.Name = "lnklblAddWhere";
            this.lnklblAddWhere.Size = new System.Drawing.Size(26, 13);
            this.lnklblAddWhere.TabIndex = 2;
            this.lnklblAddWhere.TabStop = true;
            this.lnklblAddWhere.Text = "Add";
            // 
            // tpGroupBy
            // 
            this.tpGroupBy.Controls.Add(this.lnklblRemoveGroupBy);
            this.tpGroupBy.Controls.Add(this.lnklblAddGroupBy);
            this.tpGroupBy.Location = new System.Drawing.Point(4, 22);
            this.tpGroupBy.Margin = new System.Windows.Forms.Padding(2);
            this.tpGroupBy.Name = "tpGroupBy";
            this.tpGroupBy.Size = new System.Drawing.Size(446, 229);
            this.tpGroupBy.TabIndex = 2;
            this.tpGroupBy.Text = "Group By";
            this.tpGroupBy.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveGroupBy
            // 
            this.lnklblRemoveGroupBy.AutoSize = true;
            this.lnklblRemoveGroupBy.Location = new System.Drawing.Point(9, 33);
            this.lnklblRemoveGroupBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblRemoveGroupBy.Name = "lnklblRemoveGroupBy";
            this.lnklblRemoveGroupBy.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemoveGroupBy.TabIndex = 3;
            this.lnklblRemoveGroupBy.TabStop = true;
            this.lnklblRemoveGroupBy.Text = "Remove";
            // 
            // lnklblAddGroupBy
            // 
            this.lnklblAddGroupBy.AutoSize = true;
            this.lnklblAddGroupBy.Location = new System.Drawing.Point(9, 10);
            this.lnklblAddGroupBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblAddGroupBy.Name = "lnklblAddGroupBy";
            this.lnklblAddGroupBy.Size = new System.Drawing.Size(26, 13);
            this.lnklblAddGroupBy.TabIndex = 2;
            this.lnklblAddGroupBy.TabStop = true;
            this.lnklblAddGroupBy.Text = "Add";
            // 
            // tbOrderBy
            // 
            this.tbOrderBy.Controls.Add(this.lnklblRemoveOrderBy);
            this.tbOrderBy.Controls.Add(this.lnklblAddOrderBy);
            this.tbOrderBy.Location = new System.Drawing.Point(4, 22);
            this.tbOrderBy.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrderBy.Name = "tbOrderBy";
            this.tbOrderBy.Size = new System.Drawing.Size(446, 229);
            this.tbOrderBy.TabIndex = 3;
            this.tbOrderBy.Text = "Order By";
            this.tbOrderBy.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveOrderBy
            // 
            this.lnklblRemoveOrderBy.AutoSize = true;
            this.lnklblRemoveOrderBy.Location = new System.Drawing.Point(13, 35);
            this.lnklblRemoveOrderBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblRemoveOrderBy.Name = "lnklblRemoveOrderBy";
            this.lnklblRemoveOrderBy.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemoveOrderBy.TabIndex = 3;
            this.lnklblRemoveOrderBy.TabStop = true;
            this.lnklblRemoveOrderBy.Text = "Remove";
            // 
            // lnklblAddOrderBy
            // 
            this.lnklblAddOrderBy.AutoSize = true;
            this.lnklblAddOrderBy.Location = new System.Drawing.Point(13, 11);
            this.lnklblAddOrderBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblAddOrderBy.Name = "lnklblAddOrderBy";
            this.lnklblAddOrderBy.Size = new System.Drawing.Size(26, 13);
            this.lnklblAddOrderBy.TabIndex = 2;
            this.lnklblAddOrderBy.TabStop = true;
            this.lnklblAddOrderBy.Text = "Add";
            // 
            // tbHaving
            // 
            this.tbHaving.Controls.Add(this.lnklblRemoveHaving);
            this.tbHaving.Controls.Add(this.lnklblAddHaving);
            this.tbHaving.Location = new System.Drawing.Point(4, 22);
            this.tbHaving.Margin = new System.Windows.Forms.Padding(2);
            this.tbHaving.Name = "tbHaving";
            this.tbHaving.Size = new System.Drawing.Size(446, 229);
            this.tbHaving.TabIndex = 4;
            this.tbHaving.Text = "Having";
            this.tbHaving.UseVisualStyleBackColor = true;
            // 
            // lnklblRemoveHaving
            // 
            this.lnklblRemoveHaving.AutoSize = true;
            this.lnklblRemoveHaving.Location = new System.Drawing.Point(10, 32);
            this.lnklblRemoveHaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblRemoveHaving.Name = "lnklblRemoveHaving";
            this.lnklblRemoveHaving.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemoveHaving.TabIndex = 3;
            this.lnklblRemoveHaving.TabStop = true;
            this.lnklblRemoveHaving.Text = "Remove";
            // 
            // lnklblAddHaving
            // 
            this.lnklblAddHaving.AutoSize = true;
            this.lnklblAddHaving.Location = new System.Drawing.Point(10, 9);
            this.lnklblAddHaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklblAddHaving.Name = "lnklblAddHaving";
            this.lnklblAddHaving.Size = new System.Drawing.Size(26, 13);
            this.lnklblAddHaving.TabIndex = 2;
            this.lnklblAddHaving.TabStop = true;
            this.lnklblAddHaving.Text = "Add";
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(66, 64);
            this.cmbTables.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(158, 21);
            this.cmbTables.TabIndex = 9;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(10, 67);
            this.lblTables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(39, 13);
            this.lblTables.TabIndex = 10;
            this.lblTables.Text = "Tables";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(11, 321);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(716, 173);
            this.lstDisplay.TabIndex = 11;
            // 
            // cblEntities
            // 
            this.cblEntities.FormattingEnabled = true;
            this.cblEntities.Location = new System.Drawing.Point(11, 90);
            this.cblEntities.Name = "cblEntities";
            this.cblEntities.Size = new System.Drawing.Size(170, 184);
            this.cblEntities.TabIndex = 13;
            this.cblEntities.SelectedIndexChanged += new System.EventHandler(this.cblEntities_SelectedIndexChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(186, 93);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 19);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.DatabaseToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.TableToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 505);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cblEntities);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.tcClause);
            this.Controls.Add(this.btnInsertIntoDB);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbDatabaseList);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnExecute;
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
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.CheckedListBox cblEntities;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
    }
}