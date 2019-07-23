﻿namespace _3rdYearProject
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
            this.mnuProgramability = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabaseList = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInsertIntoDB = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.mnuSubMenu = new System.Windows.Forms.MenuStrip();
            this.mnuJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHaving = new System.Windows.Forms.ToolStripMenuItem();
            this.tvEntities = new System.Windows.Forms.TreeView();
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
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(738, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuProgramability
            // 
            this.mnuProgramability.Name = "mnuProgramability";
            this.mnuProgramability.Size = new System.Drawing.Size(108, 20);
            this.mnuProgramability.Text = "Programmability";
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
            // mnuCreate
            // 
            this.mnuCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSubDatabase,
            this.mnuSubTable});
            this.mnuCreate.Name = "mnuCreate";
            this.mnuCreate.Size = new System.Drawing.Size(53, 20);
            this.mnuCreate.Text = "Create";
            // 
            // mnuSubDatabase
            // 
            this.mnuSubDatabase.Name = "mnuSubDatabase";
            this.mnuSubDatabase.Size = new System.Drawing.Size(122, 22);
            this.mnuSubDatabase.Text = "Database";
            this.mnuSubDatabase.Click += new System.EventHandler(this.DatabaseToolStripMenuItem_Click);
            // 
            // mnuSubTable
            // 
            this.mnuSubTable.Name = "mnuSubTable";
            this.mnuSubTable.Size = new System.Drawing.Size(122, 22);
            this.mnuSubTable.Text = "Table";
            this.mnuSubTable.Click += new System.EventHandler(this.TableToolStripMenuItem_Click);
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
            this.cmbDatabaseList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(158, 21);
            this.cmbDatabaseList.TabIndex = 2;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(11, 298);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(56, 26);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnInsertIntoDB
            // 
            this.btnInsertIntoDB.Location = new System.Drawing.Point(66, 298);
            this.btnInsertIntoDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertIntoDB.Name = "btnInsertIntoDB";
            this.btnInsertIntoDB.Size = new System.Drawing.Size(110, 26);
            this.btnInsertIntoDB.TabIndex = 7;
            this.btnInsertIntoDB.Text = "Insert into database";
            this.btnInsertIntoDB.UseVisualStyleBackColor = true;
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(66, 64);
            this.cmbTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(716, 173);
            this.lstDisplay.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(191, 102);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 28);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.mnuSubMenu);
            this.pnlSubMenu.Location = new System.Drawing.Point(262, 34);
            this.pnlSubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(453, 239);
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
            this.mnuSubMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuSubMenu.Size = new System.Drawing.Size(453, 24);
            this.mnuSubMenu.TabIndex = 0;
            this.mnuSubMenu.Text = "menuStrip1";
            // 
            // mnuJoin
            // 
            this.mnuJoin.Name = "mnuJoin";
            this.mnuJoin.Size = new System.Drawing.Size(45, 20);
            this.mnuJoin.Text = "Joins";
            // 
            // mnuWhere
            // 
            this.mnuWhere.Name = "mnuWhere";
            this.mnuWhere.Size = new System.Drawing.Size(53, 20);
            this.mnuWhere.Text = "Where";
            // 
            // mnuGroupBy
            // 
            this.mnuGroupBy.Name = "mnuGroupBy";
            this.mnuGroupBy.Size = new System.Drawing.Size(68, 20);
            this.mnuGroupBy.Text = "Group By";
            // 
            // mnuOrderBy
            // 
            this.mnuOrderBy.Name = "mnuOrderBy";
            this.mnuOrderBy.Size = new System.Drawing.Size(65, 20);
            this.mnuOrderBy.Text = "Order By";
            // 
            // mnuHaving
            // 
            this.mnuHaving.Name = "mnuHaving";
            this.mnuHaving.Size = new System.Drawing.Size(57, 20);
            this.mnuHaving.Text = "Having";
            // 
            // tvEntities
            // 
            this.tvEntities.Location = new System.Drawing.Point(12, 102);
            this.tvEntities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(165, 171);
            this.tvEntities.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 505);
            this.Controls.Add(this.tvEntities);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.btnInsertIntoDB);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbDatabaseList);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TreeView tvEntities;
    }
}