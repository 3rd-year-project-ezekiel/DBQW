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
            this.tvEntities = new System.Windows.Forms.TreeView();
            this.tbcExstra = new System.Windows.Forms.TabControl();
            this.tpValues = new System.Windows.Forms.TabPage();
            this.tpWhere = new System.Windows.Forms.TabPage();
            this.tpOrderBy = new System.Windows.Forms.TabPage();
            this.tpGroupBy = new System.Windows.Forms.TabPage();
            this.tpHaving = new System.Windows.Forms.TabPage();
            this.tpJoins = new System.Windows.Forms.TabPage();
            this.cmbWhereColName = new System.Windows.Forms.ComboBox();
            this.lblColumnNameWhere = new System.Windows.Forms.Label();
            this.lblWhereCondition = new System.Windows.Forms.Label();
            this.cmbWhereCondition = new System.Windows.Forms.ComboBox();
            this.lblWhereValue = new System.Windows.Forms.Label();
            this.txtWhereValues = new System.Windows.Forms.TextBox();
            this.btnAddWhere = new System.Windows.Forms.Button();
            this.lblCurrentWhere = new System.Windows.Forms.Label();
            this.lstWhereItems = new System.Windows.Forms.ListBox();
            this.lblWhereHeading = new System.Windows.Forms.Label();
            this.btnRemoveClauseFromWhere = new System.Windows.Forms.Button();
            this.mnuMenu.SuspendLayout();
            this.tbcExstra.SuspendLayout();
            this.tpWhere.SuspendLayout();
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
            this.mnuMenu.Size = new System.Drawing.Size(751, 24);
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
            this.btnRemove.Location = new System.Drawing.Point(182, 102);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 33);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tvEntities
            // 
            this.tvEntities.Location = new System.Drawing.Point(12, 102);
            this.tvEntities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(165, 171);
            this.tvEntities.TabIndex = 16;
            // 
            // tbcExstra
            // 
            this.tbcExstra.Controls.Add(this.tpValues);
            this.tbcExstra.Controls.Add(this.tpWhere);
            this.tbcExstra.Controls.Add(this.tpOrderBy);
            this.tbcExstra.Controls.Add(this.tpGroupBy);
            this.tbcExstra.Controls.Add(this.tpHaving);
            this.tbcExstra.Controls.Add(this.tpJoins);
            this.tbcExstra.Location = new System.Drawing.Point(286, 34);
            this.tbcExstra.Name = "tbcExstra";
            this.tbcExstra.SelectedIndex = 0;
            this.tbcExstra.Size = new System.Drawing.Size(440, 282);
            this.tbcExstra.TabIndex = 17;
            // 
            // tpValues
            // 
            this.tpValues.Location = new System.Drawing.Point(4, 22);
            this.tpValues.Name = "tpValues";
            this.tpValues.Size = new System.Drawing.Size(432, 256);
            this.tpValues.TabIndex = 5;
            this.tpValues.Text = "Values";
            this.tpValues.UseVisualStyleBackColor = true;
            // 
            // tpWhere
            // 
            this.tpWhere.Controls.Add(this.btnRemoveClauseFromWhere);
            this.tpWhere.Controls.Add(this.lblWhereHeading);
            this.tpWhere.Controls.Add(this.lstWhereItems);
            this.tpWhere.Controls.Add(this.lblCurrentWhere);
            this.tpWhere.Controls.Add(this.btnAddWhere);
            this.tpWhere.Controls.Add(this.txtWhereValues);
            this.tpWhere.Controls.Add(this.lblWhereValue);
            this.tpWhere.Controls.Add(this.cmbWhereCondition);
            this.tpWhere.Controls.Add(this.lblWhereCondition);
            this.tpWhere.Controls.Add(this.lblColumnNameWhere);
            this.tpWhere.Controls.Add(this.cmbWhereColName);
            this.tpWhere.Location = new System.Drawing.Point(4, 22);
            this.tpWhere.Name = "tpWhere";
            this.tpWhere.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpWhere.Size = new System.Drawing.Size(432, 256);
            this.tpWhere.TabIndex = 0;
            this.tpWhere.Text = "Where";
            this.tpWhere.UseVisualStyleBackColor = true;
            // 
            // tpOrderBy
            // 
            this.tpOrderBy.Location = new System.Drawing.Point(4, 22);
            this.tpOrderBy.Name = "tpOrderBy";
            this.tpOrderBy.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpOrderBy.Size = new System.Drawing.Size(432, 256);
            this.tpOrderBy.TabIndex = 1;
            this.tpOrderBy.Text = "Order By";
            this.tpOrderBy.UseVisualStyleBackColor = true;
            // 
            // tpGroupBy
            // 
            this.tpGroupBy.Location = new System.Drawing.Point(4, 22);
            this.tpGroupBy.Name = "tpGroupBy";
            this.tpGroupBy.Size = new System.Drawing.Size(432, 256);
            this.tpGroupBy.TabIndex = 2;
            this.tpGroupBy.Text = "Group By";
            this.tpGroupBy.UseVisualStyleBackColor = true;
            // 
            // tpHaving
            // 
            this.tpHaving.Location = new System.Drawing.Point(4, 22);
            this.tpHaving.Name = "tpHaving";
            this.tpHaving.Size = new System.Drawing.Size(432, 256);
            this.tpHaving.TabIndex = 3;
            this.tpHaving.Text = "Having";
            this.tpHaving.UseVisualStyleBackColor = true;
            // 
            // tpJoins
            // 
            this.tpJoins.Location = new System.Drawing.Point(4, 22);
            this.tpJoins.Name = "tpJoins";
            this.tpJoins.Size = new System.Drawing.Size(432, 256);
            this.tpJoins.TabIndex = 4;
            this.tpJoins.Text = "Joins";
            this.tpJoins.UseVisualStyleBackColor = true;
            // 
            // cmbWhereColName
            // 
            this.cmbWhereColName.FormattingEnabled = true;
            this.cmbWhereColName.Location = new System.Drawing.Point(19, 59);
            this.cmbWhereColName.Name = "cmbWhereColName";
            this.cmbWhereColName.Size = new System.Drawing.Size(119, 21);
            this.cmbWhereColName.TabIndex = 0;
            // 
            // lblColumnNameWhere
            // 
            this.lblColumnNameWhere.AutoSize = true;
            this.lblColumnNameWhere.Location = new System.Drawing.Point(42, 42);
            this.lblColumnNameWhere.Name = "lblColumnNameWhere";
            this.lblColumnNameWhere.Size = new System.Drawing.Size(73, 13);
            this.lblColumnNameWhere.TabIndex = 1;
            this.lblColumnNameWhere.Text = "Column Name";
            // 
            // lblWhereCondition
            // 
            this.lblWhereCondition.AutoSize = true;
            this.lblWhereCondition.Location = new System.Drawing.Point(194, 42);
            this.lblWhereCondition.Name = "lblWhereCondition";
            this.lblWhereCondition.Size = new System.Drawing.Size(51, 13);
            this.lblWhereCondition.TabIndex = 2;
            this.lblWhereCondition.Text = "Condition";
            // 
            // cmbWhereCondition
            // 
            this.cmbWhereCondition.FormattingEnabled = true;
            this.cmbWhereCondition.Location = new System.Drawing.Point(165, 59);
            this.cmbWhereCondition.Name = "cmbWhereCondition";
            this.cmbWhereCondition.Size = new System.Drawing.Size(102, 21);
            this.cmbWhereCondition.TabIndex = 3;
            // 
            // lblWhereValue
            // 
            this.lblWhereValue.AutoSize = true;
            this.lblWhereValue.Location = new System.Drawing.Point(341, 42);
            this.lblWhereValue.Name = "lblWhereValue";
            this.lblWhereValue.Size = new System.Drawing.Size(34, 13);
            this.lblWhereValue.TabIndex = 4;
            this.lblWhereValue.Text = "Value";
            // 
            // txtWhereValues
            // 
            this.txtWhereValues.Location = new System.Drawing.Point(311, 59);
            this.txtWhereValues.Name = "txtWhereValues";
            this.txtWhereValues.Size = new System.Drawing.Size(101, 20);
            this.txtWhereValues.TabIndex = 5;
            // 
            // btnAddWhere
            // 
            this.btnAddWhere.Location = new System.Drawing.Point(174, 86);
            this.btnAddWhere.Name = "btnAddWhere";
            this.btnAddWhere.Size = new System.Drawing.Size(71, 23);
            this.btnAddWhere.TabIndex = 6;
            this.btnAddWhere.Text = "Add";
            this.btnAddWhere.UseVisualStyleBackColor = true;
            // 
            // lblCurrentWhere
            // 
            this.lblCurrentWhere.AutoSize = true;
            this.lblCurrentWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWhere.Location = new System.Drawing.Point(125, 127);
            this.lblCurrentWhere.Name = "lblCurrentWhere";
            this.lblCurrentWhere.Size = new System.Drawing.Size(179, 13);
            this.lblCurrentWhere.TabIndex = 7;
            this.lblCurrentWhere.Text = "Current Items in Where Clause";
            // 
            // lstWhereItems
            // 
            this.lstWhereItems.FormattingEnabled = true;
            this.lstWhereItems.Location = new System.Drawing.Point(105, 155);
            this.lstWhereItems.Name = "lstWhereItems";
            this.lstWhereItems.Size = new System.Drawing.Size(215, 95);
            this.lstWhereItems.TabIndex = 8;
            // 
            // lblWhereHeading
            // 
            this.lblWhereHeading.AutoSize = true;
            this.lblWhereHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereHeading.Location = new System.Drawing.Point(143, 5);
            this.lblWhereHeading.Name = "lblWhereHeading";
            this.lblWhereHeading.Size = new System.Drawing.Size(142, 24);
            this.lblWhereHeading.TabIndex = 9;
            this.lblWhereHeading.Text = "Where Clause";
            // 
            // btnRemoveClauseFromWhere
            // 
            this.btnRemoveClauseFromWhere.Location = new System.Drawing.Point(336, 181);
            this.btnRemoveClauseFromWhere.Name = "btnRemoveClauseFromWhere";
            this.btnRemoveClauseFromWhere.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveClauseFromWhere.TabIndex = 10;
            this.btnRemoveClauseFromWhere.Text = "Remove item";
            this.btnRemoveClauseFromWhere.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 514);
            this.Controls.Add(this.tbcExstra);
            this.Controls.Add(this.tvEntities);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tbcExstra.ResumeLayout(false);
            this.tpWhere.ResumeLayout(false);
            this.tpWhere.PerformLayout();
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
        private System.Windows.Forms.TreeView tvEntities;
        private System.Windows.Forms.TabControl tbcExstra;
        private System.Windows.Forms.TabPage tpWhere;
        private System.Windows.Forms.TabPage tpOrderBy;
        private System.Windows.Forms.TabPage tpGroupBy;
        private System.Windows.Forms.TabPage tpHaving;
        private System.Windows.Forms.TabPage tpJoins;
        private System.Windows.Forms.TabPage tpValues;
        private System.Windows.Forms.Button btnRemoveClauseFromWhere;
        private System.Windows.Forms.Label lblWhereHeading;
        private System.Windows.Forms.ListBox lstWhereItems;
        private System.Windows.Forms.Label lblCurrentWhere;
        private System.Windows.Forms.Button btnAddWhere;
        private System.Windows.Forms.TextBox txtWhereValues;
        private System.Windows.Forms.Label lblWhereValue;
        private System.Windows.Forms.ComboBox cmbWhereCondition;
        private System.Windows.Forms.Label lblWhereCondition;
        private System.Windows.Forms.Label lblColumnNameWhere;
        private System.Windows.Forms.ComboBox cmbWhereColName;
    }
}