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
            this.mnuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramability = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabaseList = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInsertIntoDB = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.cblEntities = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.mnuSubMenu = new System.Windows.Forms.MenuStrip();
            this.mnuJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHaving = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.mnuSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgramability,
            this.mnuSelect,
            this.mnuInsert,
            this.mnuDelete,
            this.mnuUpdate,
            this.mnuCreate,
            this.mnuData,
            this.mnuLogout});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(984, 28);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuSelect
            // 
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(61, 24);
            this.mnuSelect.Text = "Select";
            this.mnuSelect.Click += new System.EventHandler(this.mnuSelect_Click);
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
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(70, 24);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
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
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuCreate
            // 
            this.mnuCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSubDatabase,
            this.mnuSubTable});
            this.mnuCreate.Name = "mnuCreate";
            this.mnuCreate.Size = new System.Drawing.Size(64, 24);
            this.mnuCreate.Text = "Create";
            // 
            // mnuSubDatabase
            // 
            this.mnuSubDatabase.Name = "mnuSubDatabase";
            this.mnuSubDatabase.Size = new System.Drawing.Size(216, 26);
            this.mnuSubDatabase.Text = "Database";
            this.mnuSubDatabase.Click += new System.EventHandler(this.DatabaseToolStripMenuItem_Click);
            // 
            // mnuSubTable
            // 
            this.mnuSubTable.Name = "mnuSubTable";
            this.mnuSubTable.Size = new System.Drawing.Size(216, 26);
            this.mnuSubTable.Text = "Table";
            this.mnuSubTable.Click += new System.EventHandler(this.TableToolStripMenuItem_Click);
            // 
            // mnuProgramability
            // 
            this.mnuProgramability.Name = "mnuProgramability";
            this.mnuProgramability.Size = new System.Drawing.Size(132, 24);
            this.mnuProgramability.Text = "Programmability";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(12, 46);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 17);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "Database";
            // 
            // cmbDatabaseList
            // 
            this.cmbDatabaseList.FormattingEnabled = true;
            this.cmbDatabaseList.Location = new System.Drawing.Point(88, 42);
            this.cmbDatabaseList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(209, 24);
            this.cmbDatabaseList.TabIndex = 2;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(15, 367);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 32);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnInsertIntoDB
            // 
            this.btnInsertIntoDB.Location = new System.Drawing.Point(88, 367);
            this.btnInsertIntoDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertIntoDB.Name = "btnInsertIntoDB";
            this.btnInsertIntoDB.Size = new System.Drawing.Size(147, 32);
            this.btnInsertIntoDB.TabIndex = 7;
            this.btnInsertIntoDB.Text = "Insert into database";
            this.btnInsertIntoDB.UseVisualStyleBackColor = true;
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(88, 79);
            this.cmbTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(209, 24);
            this.cmbTables.TabIndex = 9;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
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
            this.lstDisplay.Location = new System.Drawing.Point(15, 395);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(953, 212);
            this.lstDisplay.TabIndex = 11;
            // 
            // cblEntities
            // 
            this.cblEntities.FormattingEnabled = true;
            this.cblEntities.Location = new System.Drawing.Point(15, 111);
            this.cblEntities.Margin = new System.Windows.Forms.Padding(4);
            this.cblEntities.Name = "cblEntities";
            this.cblEntities.Size = new System.Drawing.Size(225, 225);
            this.cblEntities.TabIndex = 13;
            this.cblEntities.SelectedIndexChanged += new System.EventHandler(this.cblEntities_SelectedIndexChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(248, 114);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.mnuSubMenu);
            this.pnlSubMenu.Location = new System.Drawing.Point(350, 42);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(604, 294);
            this.pnlSubMenu.TabIndex = 15;
            // 
            // mnuSubMenu
            // 
            this.mnuSubMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuJoin,
            this.mnuWhere,
            this.mnuGroupBy,
            this.mnuOrderBy,
            this.mnuHaving});
            this.mnuSubMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuSubMenu.Name = "mnuSubMenu";
            this.mnuSubMenu.Size = new System.Drawing.Size(604, 28);
            this.mnuSubMenu.TabIndex = 0;
            this.mnuSubMenu.Text = "menuStrip1";
            // 
            // mnuJoin
            // 
            this.mnuJoin.Name = "mnuJoin";
            this.mnuJoin.Size = new System.Drawing.Size(53, 24);
            this.mnuJoin.Text = "Joins";
            // 
            // mnuWhere
            // 
            this.mnuWhere.Name = "mnuWhere";
            this.mnuWhere.Size = new System.Drawing.Size(64, 24);
            this.mnuWhere.Text = "Where";
            // 
            // mnuGroupBy
            // 
            this.mnuGroupBy.Name = "mnuGroupBy";
            this.mnuGroupBy.Size = new System.Drawing.Size(82, 24);
            this.mnuGroupBy.Text = "Group By";
            // 
            // mnuOrderBy
            // 
            this.mnuOrderBy.Name = "mnuOrderBy";
            this.mnuOrderBy.Size = new System.Drawing.Size(79, 24);
            this.mnuOrderBy.Text = "Order By";
            // 
            // mnuHaving
            // 
            this.mnuHaving.Name = "mnuHaving";
            this.mnuHaving.Size = new System.Drawing.Size(68, 24);
            this.mnuHaving.Text = "Having";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 622);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cblEntities);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.btnInsertIntoDB);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbDatabaseList);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "main";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSubMenu.PerformLayout();
            this.mnuSubMenu.ResumeLayout(false);
            this.mnuSubMenu.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.CheckedListBox cblEntities;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuSubDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuSubTable;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramability;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.MenuStrip mnuSubMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuJoin;
        private System.Windows.Forms.ToolStripMenuItem mnuWhere;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupBy;
        private System.Windows.Forms.ToolStripMenuItem mnuOrderBy;
        private System.Windows.Forms.ToolStripMenuItem mnuHaving;
    }
}