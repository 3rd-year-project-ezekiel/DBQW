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
            this.mnuProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViews = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tvEntities = new System.Windows.Forms.TreeView();
            this.tbcExstra = new System.Windows.Forms.TabControl();
            this.tpValues = new System.Windows.Forms.TabPage();
            this.lblEqualsUpdate = new System.Windows.Forms.Label();
            this.btnRemoveValues = new System.Windows.Forms.Button();
            this.lblValuesHead = new System.Windows.Forms.Label();
            this.lstInsertItems = new System.Windows.Forms.ListBox();
            this.lblItemsnsert = new System.Windows.Forms.Label();
            this.btnAddValues = new System.Windows.Forms.Button();
            this.txtInsertValues = new System.Windows.Forms.TextBox();
            this.lblValueValues = new System.Windows.Forms.Label();
            this.lblValuesCol = new System.Windows.Forms.Label();
            this.cmbInsertColumns = new System.Windows.Forms.ComboBox();
            this.tpWhere = new System.Windows.Forms.TabPage();
            this.btnRemoveClauseFromWhere = new System.Windows.Forms.Button();
            this.lblWhereHeading = new System.Windows.Forms.Label();
            this.lstWhereItems = new System.Windows.Forms.ListBox();
            this.lblCurrentWhere = new System.Windows.Forms.Label();
            this.btnAddWhere = new System.Windows.Forms.Button();
            this.txtWhereValues = new System.Windows.Forms.TextBox();
            this.lblWhereValue = new System.Windows.Forms.Label();
            this.cmbWhereCondition = new System.Windows.Forms.ComboBox();
            this.lblWhereCondition = new System.Windows.Forms.Label();
            this.lblColumnNameWhere = new System.Windows.Forms.Label();
            this.cmbWhereColName = new System.Windows.Forms.ComboBox();
            this.tpOrderBy = new System.Windows.Forms.TabPage();
            this.btnAddOrderType = new System.Windows.Forms.Button();
            this.btnRemoveOrderedItem = new System.Windows.Forms.Button();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.cmbOrderColumns = new System.Windows.Forms.ComboBox();
            this.lstOrderedItems = new System.Windows.Forms.ListBox();
            this.lblOrderedHead = new System.Windows.Forms.Label();
            this.lblAscDescHead = new System.Windows.Forms.Label();
            this.lblOrderColumnHead = new System.Windows.Forms.Label();
            this.lblOrderHeading = new System.Windows.Forms.Label();
            this.tpGroupBy = new System.Windows.Forms.TabPage();
            this.lblGroupColumn = new System.Windows.Forms.Label();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnRemoveGroupBy = new System.Windows.Forms.Button();
            this.cmbGroupByColum = new System.Windows.Forms.ComboBox();
            this.lstGroupedItems = new System.Windows.Forms.ListBox();
            this.lblGroupedItemsHead = new System.Windows.Forms.Label();
            this.lblGroupByHead = new System.Windows.Forms.Label();
            this.tpHaving = new System.Windows.Forms.TabPage();
            this.btnRemoveHavingItem = new System.Windows.Forms.Button();
            this.lblHavingHead = new System.Windows.Forms.Label();
            this.lstHavingItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHaving = new System.Windows.Forms.Button();
            this.txtHavingValue = new System.Windows.Forms.TextBox();
            this.lblHavingValueHead = new System.Windows.Forms.Label();
            this.cmbHavingCondition = new System.Windows.Forms.ComboBox();
            this.lblHavingCondition = new System.Windows.Forms.Label();
            this.lblHavingColHead = new System.Windows.Forms.Label();
            this.cmbHavingCol = new System.Windows.Forms.ComboBox();
            this.tpJoins = new System.Windows.Forms.TabPage();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbTableJoinTarget = new System.Windows.Forms.ComboBox();
            this.cmbSourceTableJoin = new System.Windows.Forms.ComboBox();
            this.cmbTargetColumn = new System.Windows.Forms.ComboBox();
            this.btnRemoveJoinItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstJoinItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddJoins = new System.Windows.Forms.Button();
            this.cmbJoinColumns = new System.Windows.Forms.ComboBox();
            this.tpSet = new System.Windows.Forms.TabPage();
            this.lblEquals = new System.Windows.Forms.Label();
            this.btnRemoveSetItems = new System.Windows.Forms.Button();
            this.lblSetHead = new System.Windows.Forms.Label();
            this.lstSetitems = new System.Windows.Forms.ListBox();
            this.lblSetItems = new System.Windows.Forms.Label();
            this.btnAddSet = new System.Windows.Forms.Button();
            this.txtSetValues = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSetCol = new System.Windows.Forms.ComboBox();
            this.tpVariableManagement = new System.Windows.Forms.TabPage();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVar = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.lblProcedureName = new System.Windows.Forms.Label();
            this.cmbDataTypes = new System.Windows.Forms.ComboBox();
            this.btnRemoveVariables = new System.Windows.Forms.Button();
            this.lblVariableHead = new System.Windows.Forms.Label();
            this.lstVarItems = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpViews = new System.Windows.Forms.TabPage();
            this.btnSaveView = new System.Windows.Forms.Button();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblViewHead = new System.Windows.Forms.Label();
            this.tpColumns = new System.Windows.Forms.TabPage();
            this.cbxAggregate = new System.Windows.Forms.CheckBox();
            this.btnRemoveColumnMan = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.lstColumnsManagement = new System.Windows.Forms.ListBox();
            this.lblColName = new System.Windows.Forms.Label();
            this.txtColNames = new System.Windows.Forms.TextBox();
            this.cmbAggrgateFunctions = new System.Windows.Forms.ComboBox();
            this.cmbColumnManagementList = new System.Windows.Forms.ComboBox();
            this.lblListedColumns = new System.Windows.Forms.Label();
            this.cbxAs = new System.Windows.Forms.CheckBox();
            this.lblAggr = new System.Windows.Forms.Label();
            this.lblColumnManHead = new System.Windows.Forms.Label();
            this.lblColumnManagement = new System.Windows.Forms.Label();
            this.btnAddsSource = new System.Windows.Forms.Button();
            this.btnQueryOutPut = new System.Windows.Forms.Button();
            this.cmbProgrammingHaving = new System.Windows.Forms.ComboBox();
            this.cmbProgrammingSet = new System.Windows.Forms.ComboBox();
            this.cmbProgrammingValues = new System.Windows.Forms.ComboBox();
            this.cmbProgrammingWhere = new System.Windows.Forms.ComboBox();
            this.mnuMenu.SuspendLayout();
            this.tbcExstra.SuspendLayout();
            this.tpValues.SuspendLayout();
            this.tpWhere.SuspendLayout();
            this.tpOrderBy.SuspendLayout();
            this.tpGroupBy.SuspendLayout();
            this.tpHaving.SuspendLayout();
            this.tpJoins.SuspendLayout();
            this.tpSet.SuspendLayout();
            this.tpVariableManagement.SuspendLayout();
            this.tpViews.SuspendLayout();
            this.tpColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcedure,
            this.mnuViews,
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
            this.mnuMenu.Size = new System.Drawing.Size(802, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuProcedure
            // 
            this.mnuProcedure.Name = "mnuProcedure";
            this.mnuProcedure.Size = new System.Drawing.Size(78, 20);
            this.mnuProcedure.Text = "Procedures";
            this.mnuProcedure.Click += new System.EventHandler(this.mnuProcedure_Click);
            // 
            // mnuViews
            // 
            this.mnuViews.Name = "mnuViews";
            this.mnuViews.Size = new System.Drawing.Size(49, 20);
            this.mnuViews.Text = "Views";
            this.mnuViews.Click += new System.EventHandler(this.mnuViews_Click);
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
            this.cmbDatabaseList.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(158, 21);
            this.cmbDatabaseList.TabIndex = 2;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(13, 357);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(56, 26);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
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
            this.lstDisplay.Location = new System.Drawing.Point(13, 382);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(772, 173);
            this.lstDisplay.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(195, 146);
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
            this.tvEntities.Margin = new System.Windows.Forms.Padding(2);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(165, 251);
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
            this.tbcExstra.Controls.Add(this.tpSet);
            this.tbcExstra.Controls.Add(this.tpVariableManagement);
            this.tbcExstra.Controls.Add(this.tpViews);
            this.tbcExstra.Controls.Add(this.tpColumns);
            this.tbcExstra.Location = new System.Drawing.Point(286, 34);
            this.tbcExstra.Name = "tbcExstra";
            this.tbcExstra.SelectedIndex = 0;
            this.tbcExstra.Size = new System.Drawing.Size(499, 343);
            this.tbcExstra.TabIndex = 17;
            // 
            // tpValues
            // 
            this.tpValues.Controls.Add(this.cmbProgrammingValues);
            this.tpValues.Controls.Add(this.lblEqualsUpdate);
            this.tpValues.Controls.Add(this.btnRemoveValues);
            this.tpValues.Controls.Add(this.lblValuesHead);
            this.tpValues.Controls.Add(this.lstInsertItems);
            this.tpValues.Controls.Add(this.lblItemsnsert);
            this.tpValues.Controls.Add(this.btnAddValues);
            this.tpValues.Controls.Add(this.txtInsertValues);
            this.tpValues.Controls.Add(this.lblValueValues);
            this.tpValues.Controls.Add(this.lblValuesCol);
            this.tpValues.Controls.Add(this.cmbInsertColumns);
            this.tpValues.Location = new System.Drawing.Point(4, 22);
            this.tpValues.Name = "tpValues";
            this.tpValues.Size = new System.Drawing.Size(491, 317);
            this.tpValues.TabIndex = 5;
            this.tpValues.Text = "Values";
            this.tpValues.UseVisualStyleBackColor = true;
            // 
            // lblEqualsUpdate
            // 
            this.lblEqualsUpdate.AutoSize = true;
            this.lblEqualsUpdate.Location = new System.Drawing.Point(208, 67);
            this.lblEqualsUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEqualsUpdate.Name = "lblEqualsUpdate";
            this.lblEqualsUpdate.Size = new System.Drawing.Size(13, 13);
            this.lblEqualsUpdate.TabIndex = 36;
            this.lblEqualsUpdate.Text = "=";
            // 
            // btnRemoveValues
            // 
            this.btnRemoveValues.Location = new System.Drawing.Point(331, 169);
            this.btnRemoveValues.Name = "btnRemoveValues";
            this.btnRemoveValues.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveValues.TabIndex = 34;
            this.btnRemoveValues.Text = "Remove item";
            this.btnRemoveValues.UseVisualStyleBackColor = true;
            this.btnRemoveValues.Click += new System.EventHandler(this.BtnRemoveValues_Click);
            // 
            // lblValuesHead
            // 
            this.lblValuesHead.AutoSize = true;
            this.lblValuesHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuesHead.Location = new System.Drawing.Point(165, 7);
            this.lblValuesHead.Name = "lblValuesHead";
            this.lblValuesHead.Size = new System.Drawing.Size(74, 24);
            this.lblValuesHead.TabIndex = 33;
            this.lblValuesHead.Text = "Values";
            // 
            // lstInsertItems
            // 
            this.lstInsertItems.FormattingEnabled = true;
            this.lstInsertItems.Location = new System.Drawing.Point(100, 158);
            this.lstInsertItems.Name = "lstInsertItems";
            this.lstInsertItems.Size = new System.Drawing.Size(215, 95);
            this.lstInsertItems.TabIndex = 32;
            // 
            // lblItemsnsert
            // 
            this.lblItemsnsert.AutoSize = true;
            this.lblItemsnsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsnsert.Location = new System.Drawing.Point(120, 130);
            this.lblItemsnsert.Name = "lblItemsnsert";
            this.lblItemsnsert.Size = new System.Drawing.Size(182, 13);
            this.lblItemsnsert.TabIndex = 31;
            this.lblItemsnsert.Text = "Current Items in Having Clause";
            // 
            // btnAddValues
            // 
            this.btnAddValues.Location = new System.Drawing.Point(181, 90);
            this.btnAddValues.Name = "btnAddValues";
            this.btnAddValues.Size = new System.Drawing.Size(71, 23);
            this.btnAddValues.TabIndex = 30;
            this.btnAddValues.Text = "Add";
            this.btnAddValues.UseVisualStyleBackColor = true;
            this.btnAddValues.Click += new System.EventHandler(this.BtnAddValues_Click);
            // 
            // txtInsertValues
            // 
            this.txtInsertValues.Location = new System.Drawing.Point(254, 64);
            this.txtInsertValues.Name = "txtInsertValues";
            this.txtInsertValues.Size = new System.Drawing.Size(101, 20);
            this.txtInsertValues.TabIndex = 29;
            // 
            // lblValueValues
            // 
            this.lblValueValues.AutoSize = true;
            this.lblValueValues.Location = new System.Drawing.Point(286, 44);
            this.lblValueValues.Name = "lblValueValues";
            this.lblValueValues.Size = new System.Drawing.Size(34, 13);
            this.lblValueValues.TabIndex = 28;
            this.lblValueValues.Text = "Value";
            // 
            // lblValuesCol
            // 
            this.lblValuesCol.AutoSize = true;
            this.lblValuesCol.Location = new System.Drawing.Point(81, 44);
            this.lblValuesCol.Name = "lblValuesCol";
            this.lblValuesCol.Size = new System.Drawing.Size(73, 13);
            this.lblValuesCol.TabIndex = 25;
            this.lblValuesCol.Text = "Column Name";
            // 
            // cmbInsertColumns
            // 
            this.cmbInsertColumns.FormattingEnabled = true;
            this.cmbInsertColumns.Location = new System.Drawing.Point(62, 64);
            this.cmbInsertColumns.Name = "cmbInsertColumns";
            this.cmbInsertColumns.Size = new System.Drawing.Size(119, 21);
            this.cmbInsertColumns.TabIndex = 24;
            this.cmbInsertColumns.Text = "Select Column";
            // 
            // tpWhere
            // 
            this.tpWhere.Controls.Add(this.cmbProgrammingWhere);
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
            this.tpWhere.Padding = new System.Windows.Forms.Padding(3);
            this.tpWhere.Size = new System.Drawing.Size(491, 317);
            this.tpWhere.TabIndex = 0;
            this.tpWhere.Text = "Where";
            this.tpWhere.UseVisualStyleBackColor = true;
            // 
            // btnRemoveClauseFromWhere
            // 
            this.btnRemoveClauseFromWhere.Location = new System.Drawing.Point(336, 166);
            this.btnRemoveClauseFromWhere.Name = "btnRemoveClauseFromWhere";
            this.btnRemoveClauseFromWhere.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveClauseFromWhere.TabIndex = 10;
            this.btnRemoveClauseFromWhere.Text = "Remove item";
            this.btnRemoveClauseFromWhere.UseVisualStyleBackColor = true;
            this.btnRemoveClauseFromWhere.Click += new System.EventHandler(this.BtnRemoveClauseFromWhere_Click);
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
            // lstWhereItems
            // 
            this.lstWhereItems.FormattingEnabled = true;
            this.lstWhereItems.Location = new System.Drawing.Point(105, 155);
            this.lstWhereItems.Name = "lstWhereItems";
            this.lstWhereItems.Size = new System.Drawing.Size(215, 95);
            this.lstWhereItems.TabIndex = 8;
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
            // btnAddWhere
            // 
            this.btnAddWhere.Location = new System.Drawing.Point(174, 86);
            this.btnAddWhere.Name = "btnAddWhere";
            this.btnAddWhere.Size = new System.Drawing.Size(71, 23);
            this.btnAddWhere.TabIndex = 6;
            this.btnAddWhere.Text = "Add";
            this.btnAddWhere.UseVisualStyleBackColor = true;
            this.btnAddWhere.Click += new System.EventHandler(this.BtnAddWhere_Click);
            // 
            // txtWhereValues
            // 
            this.txtWhereValues.Location = new System.Drawing.Point(311, 59);
            this.txtWhereValues.Name = "txtWhereValues";
            this.txtWhereValues.Size = new System.Drawing.Size(101, 20);
            this.txtWhereValues.TabIndex = 5;
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
            // cmbWhereCondition
            // 
            this.cmbWhereCondition.FormattingEnabled = true;
            this.cmbWhereCondition.Location = new System.Drawing.Point(165, 59);
            this.cmbWhereCondition.Name = "cmbWhereCondition";
            this.cmbWhereCondition.Size = new System.Drawing.Size(102, 21);
            this.cmbWhereCondition.TabIndex = 3;
            this.cmbWhereCondition.Text = "Select Condition";
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
            // lblColumnNameWhere
            // 
            this.lblColumnNameWhere.AutoSize = true;
            this.lblColumnNameWhere.Location = new System.Drawing.Point(42, 42);
            this.lblColumnNameWhere.Name = "lblColumnNameWhere";
            this.lblColumnNameWhere.Size = new System.Drawing.Size(73, 13);
            this.lblColumnNameWhere.TabIndex = 1;
            this.lblColumnNameWhere.Text = "Column Name";
            // 
            // cmbWhereColName
            // 
            this.cmbWhereColName.FormattingEnabled = true;
            this.cmbWhereColName.Location = new System.Drawing.Point(19, 59);
            this.cmbWhereColName.Name = "cmbWhereColName";
            this.cmbWhereColName.Size = new System.Drawing.Size(119, 21);
            this.cmbWhereColName.TabIndex = 0;
            this.cmbWhereColName.Text = "Select Column";
            // 
            // tpOrderBy
            // 
            this.tpOrderBy.Controls.Add(this.btnAddOrderType);
            this.tpOrderBy.Controls.Add(this.btnRemoveOrderedItem);
            this.tpOrderBy.Controls.Add(this.cmbOrderType);
            this.tpOrderBy.Controls.Add(this.cmbOrderColumns);
            this.tpOrderBy.Controls.Add(this.lstOrderedItems);
            this.tpOrderBy.Controls.Add(this.lblOrderedHead);
            this.tpOrderBy.Controls.Add(this.lblAscDescHead);
            this.tpOrderBy.Controls.Add(this.lblOrderColumnHead);
            this.tpOrderBy.Controls.Add(this.lblOrderHeading);
            this.tpOrderBy.Location = new System.Drawing.Point(4, 22);
            this.tpOrderBy.Name = "tpOrderBy";
            this.tpOrderBy.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderBy.Size = new System.Drawing.Size(491, 317);
            this.tpOrderBy.TabIndex = 1;
            this.tpOrderBy.Text = "Order By";
            this.tpOrderBy.UseVisualStyleBackColor = true;
            // 
            // btnAddOrderType
            // 
            this.btnAddOrderType.Location = new System.Drawing.Point(179, 83);
            this.btnAddOrderType.Name = "btnAddOrderType";
            this.btnAddOrderType.Size = new System.Drawing.Size(71, 23);
            this.btnAddOrderType.TabIndex = 9;
            this.btnAddOrderType.Text = "Add";
            this.btnAddOrderType.UseVisualStyleBackColor = true;
            this.btnAddOrderType.Click += new System.EventHandler(this.BtnAddOrderedItem_Click);
            // 
            // btnRemoveOrderedItem
            // 
            this.btnRemoveOrderedItem.Location = new System.Drawing.Point(306, 150);
            this.btnRemoveOrderedItem.Name = "btnRemoveOrderedItem";
            this.btnRemoveOrderedItem.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveOrderedItem.TabIndex = 7;
            this.btnRemoveOrderedItem.Text = "Remove Item";
            this.btnRemoveOrderedItem.UseVisualStyleBackColor = true;
            this.btnRemoveOrderedItem.Click += new System.EventHandler(this.BtnRemoveOrderedItem_Click);
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(243, 50);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderType.TabIndex = 6;
            this.cmbOrderType.Text = "Select Order Type";
            // 
            // cmbOrderColumns
            // 
            this.cmbOrderColumns.FormattingEnabled = true;
            this.cmbOrderColumns.Location = new System.Drawing.Point(71, 50);
            this.cmbOrderColumns.Name = "cmbOrderColumns";
            this.cmbOrderColumns.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderColumns.TabIndex = 5;
            this.cmbOrderColumns.Text = "Select Column";
            // 
            // lstOrderedItems
            // 
            this.lstOrderedItems.FormattingEnabled = true;
            this.lstOrderedItems.Location = new System.Drawing.Point(160, 128);
            this.lstOrderedItems.Name = "lstOrderedItems";
            this.lstOrderedItems.Size = new System.Drawing.Size(120, 121);
            this.lstOrderedItems.TabIndex = 4;
            // 
            // lblOrderedHead
            // 
            this.lblOrderedHead.AutoSize = true;
            this.lblOrderedHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedHead.Location = new System.Drawing.Point(145, 109);
            this.lblOrderedHead.Name = "lblOrderedHead";
            this.lblOrderedHead.Size = new System.Drawing.Size(159, 16);
            this.lblOrderedHead.TabIndex = 3;
            this.lblOrderedHead.Text = "Current Ordered Items";
            // 
            // lblAscDescHead
            // 
            this.lblAscDescHead.AutoSize = true;
            this.lblAscDescHead.Location = new System.Drawing.Point(273, 34);
            this.lblAscDescHead.Name = "lblAscDescHead";
            this.lblAscDescHead.Size = new System.Drawing.Size(62, 13);
            this.lblAscDescHead.TabIndex = 2;
            this.lblAscDescHead.Text = "ASC/DESC";
            // 
            // lblOrderColumnHead
            // 
            this.lblOrderColumnHead.AutoSize = true;
            this.lblOrderColumnHead.Location = new System.Drawing.Point(113, 34);
            this.lblOrderColumnHead.Name = "lblOrderColumnHead";
            this.lblOrderColumnHead.Size = new System.Drawing.Size(42, 13);
            this.lblOrderColumnHead.TabIndex = 1;
            this.lblOrderColumnHead.Text = "Column";
            // 
            // lblOrderHeading
            // 
            this.lblOrderHeading.AutoSize = true;
            this.lblOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHeading.Location = new System.Drawing.Point(175, 5);
            this.lblOrderHeading.Name = "lblOrderHeading";
            this.lblOrderHeading.Size = new System.Drawing.Size(93, 24);
            this.lblOrderHeading.TabIndex = 0;
            this.lblOrderHeading.Text = "Order By";
            // 
            // tpGroupBy
            // 
            this.tpGroupBy.Controls.Add(this.lblGroupColumn);
            this.tpGroupBy.Controls.Add(this.btnGroupBy);
            this.tpGroupBy.Controls.Add(this.btnRemoveGroupBy);
            this.tpGroupBy.Controls.Add(this.cmbGroupByColum);
            this.tpGroupBy.Controls.Add(this.lstGroupedItems);
            this.tpGroupBy.Controls.Add(this.lblGroupedItemsHead);
            this.tpGroupBy.Controls.Add(this.lblGroupByHead);
            this.tpGroupBy.Location = new System.Drawing.Point(4, 22);
            this.tpGroupBy.Name = "tpGroupBy";
            this.tpGroupBy.Size = new System.Drawing.Size(491, 317);
            this.tpGroupBy.TabIndex = 2;
            this.tpGroupBy.Text = "Group By";
            this.tpGroupBy.UseVisualStyleBackColor = true;
            // 
            // lblGroupColumn
            // 
            this.lblGroupColumn.AutoSize = true;
            this.lblGroupColumn.Location = new System.Drawing.Point(179, 40);
            this.lblGroupColumn.Name = "lblGroupColumn";
            this.lblGroupColumn.Size = new System.Drawing.Size(42, 13);
            this.lblGroupColumn.TabIndex = 17;
            this.lblGroupColumn.Text = "Column";
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(164, 84);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(71, 23);
            this.btnGroupBy.TabIndex = 16;
            this.btnGroupBy.Text = "Add";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.BtnGroupBy_Click);
            // 
            // btnRemoveGroupBy
            // 
            this.btnRemoveGroupBy.Location = new System.Drawing.Point(286, 151);
            this.btnRemoveGroupBy.Name = "btnRemoveGroupBy";
            this.btnRemoveGroupBy.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveGroupBy.TabIndex = 14;
            this.btnRemoveGroupBy.Text = "Remove Item";
            this.btnRemoveGroupBy.UseVisualStyleBackColor = true;
            this.btnRemoveGroupBy.Click += new System.EventHandler(this.BtnRemoveGroupBy_Click);
            // 
            // cmbGroupByColum
            // 
            this.cmbGroupByColum.FormattingEnabled = true;
            this.cmbGroupByColum.Location = new System.Drawing.Point(140, 56);
            this.cmbGroupByColum.Name = "cmbGroupByColum";
            this.cmbGroupByColum.Size = new System.Drawing.Size(121, 21);
            this.cmbGroupByColum.TabIndex = 12;
            this.cmbGroupByColum.Text = "Select Column";
            // 
            // lstGroupedItems
            // 
            this.lstGroupedItems.FormattingEnabled = true;
            this.lstGroupedItems.Location = new System.Drawing.Point(140, 129);
            this.lstGroupedItems.Name = "lstGroupedItems";
            this.lstGroupedItems.Size = new System.Drawing.Size(120, 121);
            this.lstGroupedItems.TabIndex = 11;
            // 
            // lblGroupedItemsHead
            // 
            this.lblGroupedItemsHead.AutoSize = true;
            this.lblGroupedItemsHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupedItemsHead.Location = new System.Drawing.Point(125, 110);
            this.lblGroupedItemsHead.Name = "lblGroupedItemsHead";
            this.lblGroupedItemsHead.Size = new System.Drawing.Size(162, 16);
            this.lblGroupedItemsHead.TabIndex = 10;
            this.lblGroupedItemsHead.Text = "Current Grouped Items";
            // 
            // lblGroupByHead
            // 
            this.lblGroupByHead.AutoSize = true;
            this.lblGroupByHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupByHead.Location = new System.Drawing.Point(150, 8);
            this.lblGroupByHead.Name = "lblGroupByHead";
            this.lblGroupByHead.Size = new System.Drawing.Size(97, 24);
            this.lblGroupByHead.TabIndex = 9;
            this.lblGroupByHead.Text = "Group By";
            // 
            // tpHaving
            // 
            this.tpHaving.Controls.Add(this.cmbProgrammingHaving);
            this.tpHaving.Controls.Add(this.btnRemoveHavingItem);
            this.tpHaving.Controls.Add(this.lblHavingHead);
            this.tpHaving.Controls.Add(this.lstHavingItems);
            this.tpHaving.Controls.Add(this.label2);
            this.tpHaving.Controls.Add(this.btnAddHaving);
            this.tpHaving.Controls.Add(this.txtHavingValue);
            this.tpHaving.Controls.Add(this.lblHavingValueHead);
            this.tpHaving.Controls.Add(this.cmbHavingCondition);
            this.tpHaving.Controls.Add(this.lblHavingCondition);
            this.tpHaving.Controls.Add(this.lblHavingColHead);
            this.tpHaving.Controls.Add(this.cmbHavingCol);
            this.tpHaving.Location = new System.Drawing.Point(4, 22);
            this.tpHaving.Name = "tpHaving";
            this.tpHaving.Size = new System.Drawing.Size(491, 317);
            this.tpHaving.TabIndex = 3;
            this.tpHaving.Text = "Having";
            this.tpHaving.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHavingItem
            // 
            this.btnRemoveHavingItem.Location = new System.Drawing.Point(330, 167);
            this.btnRemoveHavingItem.Name = "btnRemoveHavingItem";
            this.btnRemoveHavingItem.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveHavingItem.TabIndex = 22;
            this.btnRemoveHavingItem.Text = "Remove item";
            this.btnRemoveHavingItem.UseVisualStyleBackColor = true;
            this.btnRemoveHavingItem.Click += new System.EventHandler(this.BtnRemoveHavingItem_Click);
            // 
            // lblHavingHead
            // 
            this.lblHavingHead.AutoSize = true;
            this.lblHavingHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHavingHead.Location = new System.Drawing.Point(164, 5);
            this.lblHavingHead.Name = "lblHavingHead";
            this.lblHavingHead.Size = new System.Drawing.Size(75, 24);
            this.lblHavingHead.TabIndex = 21;
            this.lblHavingHead.Text = "Having";
            // 
            // lstHavingItems
            // 
            this.lstHavingItems.FormattingEnabled = true;
            this.lstHavingItems.Location = new System.Drawing.Point(99, 156);
            this.lstHavingItems.Name = "lstHavingItems";
            this.lstHavingItems.Size = new System.Drawing.Size(215, 95);
            this.lstHavingItems.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current Items in Having Clause";
            // 
            // btnAddHaving
            // 
            this.btnAddHaving.Location = new System.Drawing.Point(168, 87);
            this.btnAddHaving.Name = "btnAddHaving";
            this.btnAddHaving.Size = new System.Drawing.Size(71, 23);
            this.btnAddHaving.TabIndex = 18;
            this.btnAddHaving.Text = "Add";
            this.btnAddHaving.UseVisualStyleBackColor = true;
            this.btnAddHaving.Click += new System.EventHandler(this.BtnAddHaving_Click);
            // 
            // txtHavingValue
            // 
            this.txtHavingValue.Location = new System.Drawing.Point(305, 60);
            this.txtHavingValue.Name = "txtHavingValue";
            this.txtHavingValue.Size = new System.Drawing.Size(101, 20);
            this.txtHavingValue.TabIndex = 17;
            // 
            // lblHavingValueHead
            // 
            this.lblHavingValueHead.AutoSize = true;
            this.lblHavingValueHead.Location = new System.Drawing.Point(335, 43);
            this.lblHavingValueHead.Name = "lblHavingValueHead";
            this.lblHavingValueHead.Size = new System.Drawing.Size(34, 13);
            this.lblHavingValueHead.TabIndex = 16;
            this.lblHavingValueHead.Text = "Value";
            // 
            // cmbHavingCondition
            // 
            this.cmbHavingCondition.FormattingEnabled = true;
            this.cmbHavingCondition.Location = new System.Drawing.Point(159, 60);
            this.cmbHavingCondition.Name = "cmbHavingCondition";
            this.cmbHavingCondition.Size = new System.Drawing.Size(102, 21);
            this.cmbHavingCondition.TabIndex = 15;
            this.cmbHavingCondition.Text = "Select Condition";
            // 
            // lblHavingCondition
            // 
            this.lblHavingCondition.AutoSize = true;
            this.lblHavingCondition.Location = new System.Drawing.Point(188, 43);
            this.lblHavingCondition.Name = "lblHavingCondition";
            this.lblHavingCondition.Size = new System.Drawing.Size(51, 13);
            this.lblHavingCondition.TabIndex = 14;
            this.lblHavingCondition.Text = "Condition";
            // 
            // lblHavingColHead
            // 
            this.lblHavingColHead.AutoSize = true;
            this.lblHavingColHead.Location = new System.Drawing.Point(36, 43);
            this.lblHavingColHead.Name = "lblHavingColHead";
            this.lblHavingColHead.Size = new System.Drawing.Size(73, 13);
            this.lblHavingColHead.TabIndex = 13;
            this.lblHavingColHead.Text = "Column Name";
            // 
            // cmbHavingCol
            // 
            this.cmbHavingCol.FormattingEnabled = true;
            this.cmbHavingCol.Location = new System.Drawing.Point(13, 60);
            this.cmbHavingCol.Name = "cmbHavingCol";
            this.cmbHavingCol.Size = new System.Drawing.Size(119, 21);
            this.cmbHavingCol.TabIndex = 12;
            this.cmbHavingCol.Text = "Select Column";
            // 
            // tpJoins
            // 
            this.tpJoins.Controls.Add(this.lblTarget);
            this.tpJoins.Controls.Add(this.lblSource);
            this.tpJoins.Controls.Add(this.cmbTableJoinTarget);
            this.tpJoins.Controls.Add(this.cmbSourceTableJoin);
            this.tpJoins.Controls.Add(this.cmbTargetColumn);
            this.tpJoins.Controls.Add(this.btnRemoveJoinItems);
            this.tpJoins.Controls.Add(this.label1);
            this.tpJoins.Controls.Add(this.lstJoinItems);
            this.tpJoins.Controls.Add(this.label3);
            this.tpJoins.Controls.Add(this.btnAddJoins);
            this.tpJoins.Controls.Add(this.cmbJoinColumns);
            this.tpJoins.Location = new System.Drawing.Point(4, 22);
            this.tpJoins.Name = "tpJoins";
            this.tpJoins.Size = new System.Drawing.Size(491, 317);
            this.tpJoins.TabIndex = 4;
            this.tpJoins.Text = "Joins";
            this.tpJoins.UseVisualStyleBackColor = true;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(192, 74);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(38, 13);
            this.lblTarget.TabIndex = 42;
            this.lblTarget.Text = "Target";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(192, 30);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 41;
            this.lblSource.Text = "Source";
            // 
            // cmbTableJoinTarget
            // 
            this.cmbTableJoinTarget.FormattingEnabled = true;
            this.cmbTableJoinTarget.Location = new System.Drawing.Point(79, 90);
            this.cmbTableJoinTarget.Name = "cmbTableJoinTarget";
            this.cmbTableJoinTarget.Size = new System.Drawing.Size(119, 21);
            this.cmbTableJoinTarget.TabIndex = 40;
            this.cmbTableJoinTarget.Text = "Select Table";
            this.cmbTableJoinTarget.SelectedIndexChanged += new System.EventHandler(this.CmbTableJoinTarget_SelectedIndexChanged);
            // 
            // cmbSourceTableJoin
            // 
            this.cmbSourceTableJoin.FormattingEnabled = true;
            this.cmbSourceTableJoin.Location = new System.Drawing.Point(79, 46);
            this.cmbSourceTableJoin.Name = "cmbSourceTableJoin";
            this.cmbSourceTableJoin.Size = new System.Drawing.Size(119, 21);
            this.cmbSourceTableJoin.TabIndex = 37;
            this.cmbSourceTableJoin.Text = "Select Table";
            this.cmbSourceTableJoin.SelectedIndexChanged += new System.EventHandler(this.CmbSourceTableJoin_SelectedIndexChanged);
            // 
            // cmbTargetColumn
            // 
            this.cmbTargetColumn.FormattingEnabled = true;
            this.cmbTargetColumn.Location = new System.Drawing.Point(223, 90);
            this.cmbTargetColumn.Name = "cmbTargetColumn";
            this.cmbTargetColumn.Size = new System.Drawing.Size(119, 21);
            this.cmbTargetColumn.TabIndex = 36;
            this.cmbTargetColumn.Text = "Select Column";
            // 
            // btnRemoveJoinItems
            // 
            this.btnRemoveJoinItems.Location = new System.Drawing.Point(330, 194);
            this.btnRemoveJoinItems.Name = "btnRemoveJoinItems";
            this.btnRemoveJoinItems.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveJoinItems.TabIndex = 34;
            this.btnRemoveJoinItems.Text = "Remove item";
            this.btnRemoveJoinItems.UseVisualStyleBackColor = true;
            this.btnRemoveJoinItems.Click += new System.EventHandler(this.BtnRemoveJoinItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Joins";
            // 
            // lstJoinItems
            // 
            this.lstJoinItems.FormattingEnabled = true;
            this.lstJoinItems.Location = new System.Drawing.Point(25, 156);
            this.lstJoinItems.Name = "lstJoinItems";
            this.lstJoinItems.Size = new System.Drawing.Size(289, 95);
            this.lstJoinItems.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Current Items in Join Clause";
            // 
            // btnAddJoins
            // 
            this.btnAddJoins.Location = new System.Drawing.Point(358, 88);
            this.btnAddJoins.Name = "btnAddJoins";
            this.btnAddJoins.Size = new System.Drawing.Size(71, 23);
            this.btnAddJoins.TabIndex = 30;
            this.btnAddJoins.Text = "Add";
            this.btnAddJoins.UseVisualStyleBackColor = true;
            this.btnAddJoins.Click += new System.EventHandler(this.BtnAddJoins_Click);
            // 
            // cmbJoinColumns
            // 
            this.cmbJoinColumns.FormattingEnabled = true;
            this.cmbJoinColumns.Location = new System.Drawing.Point(223, 46);
            this.cmbJoinColumns.Name = "cmbJoinColumns";
            this.cmbJoinColumns.Size = new System.Drawing.Size(119, 21);
            this.cmbJoinColumns.TabIndex = 24;
            this.cmbJoinColumns.Text = "Select Column";
            // 
            // tpSet
            // 
            this.tpSet.Controls.Add(this.cmbProgrammingSet);
            this.tpSet.Controls.Add(this.lblEquals);
            this.tpSet.Controls.Add(this.btnRemoveSetItems);
            this.tpSet.Controls.Add(this.lblSetHead);
            this.tpSet.Controls.Add(this.lstSetitems);
            this.tpSet.Controls.Add(this.lblSetItems);
            this.tpSet.Controls.Add(this.btnAddSet);
            this.tpSet.Controls.Add(this.txtSetValues);
            this.tpSet.Controls.Add(this.label6);
            this.tpSet.Controls.Add(this.label7);
            this.tpSet.Controls.Add(this.label8);
            this.tpSet.Controls.Add(this.cmbSetCol);
            this.tpSet.Location = new System.Drawing.Point(4, 22);
            this.tpSet.Name = "tpSet";
            this.tpSet.Padding = new System.Windows.Forms.Padding(3);
            this.tpSet.Size = new System.Drawing.Size(491, 317);
            this.tpSet.TabIndex = 6;
            this.tpSet.Text = "Set";
            this.tpSet.UseVisualStyleBackColor = true;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(203, 63);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 36;
            this.lblEquals.Text = "=";
            // 
            // btnRemoveSetItems
            // 
            this.btnRemoveSetItems.Location = new System.Drawing.Point(330, 167);
            this.btnRemoveSetItems.Name = "btnRemoveSetItems";
            this.btnRemoveSetItems.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveSetItems.TabIndex = 34;
            this.btnRemoveSetItems.Text = "Remove item";
            this.btnRemoveSetItems.UseVisualStyleBackColor = true;
            this.btnRemoveSetItems.Click += new System.EventHandler(this.BtnRemoveSetItems_Click);
            // 
            // lblSetHead
            // 
            this.lblSetHead.AutoSize = true;
            this.lblSetHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHead.Location = new System.Drawing.Point(187, 5);
            this.lblSetHead.Name = "lblSetHead";
            this.lblSetHead.Size = new System.Drawing.Size(40, 24);
            this.lblSetHead.TabIndex = 33;
            this.lblSetHead.Text = "Set";
            // 
            // lstSetitems
            // 
            this.lstSetitems.FormattingEnabled = true;
            this.lstSetitems.Location = new System.Drawing.Point(99, 156);
            this.lstSetitems.Name = "lstSetitems";
            this.lstSetitems.Size = new System.Drawing.Size(215, 95);
            this.lstSetitems.TabIndex = 32;
            // 
            // lblSetItems
            // 
            this.lblSetItems.AutoSize = true;
            this.lblSetItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetItems.Location = new System.Drawing.Point(119, 128);
            this.lblSetItems.Name = "lblSetItems";
            this.lblSetItems.Size = new System.Drawing.Size(182, 13);
            this.lblSetItems.TabIndex = 31;
            this.lblSetItems.Text = "Current Items in Having Clause";
            // 
            // btnAddSet
            // 
            this.btnAddSet.Location = new System.Drawing.Point(168, 87);
            this.btnAddSet.Name = "btnAddSet";
            this.btnAddSet.Size = new System.Drawing.Size(71, 23);
            this.btnAddSet.TabIndex = 30;
            this.btnAddSet.Text = "Add";
            this.btnAddSet.UseVisualStyleBackColor = true;
            this.btnAddSet.Click += new System.EventHandler(this.BtnAddSet_Click);
            // 
            // txtSetValues
            // 
            this.txtSetValues.Location = new System.Drawing.Point(305, 60);
            this.txtSetValues.Name = "txtSetValues";
            this.txtSetValues.Size = new System.Drawing.Size(101, 20);
            this.txtSetValues.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Condition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Column Name";
            // 
            // cmbSetCol
            // 
            this.cmbSetCol.FormattingEnabled = true;
            this.cmbSetCol.Location = new System.Drawing.Point(13, 60);
            this.cmbSetCol.Name = "cmbSetCol";
            this.cmbSetCol.Size = new System.Drawing.Size(119, 21);
            this.cmbSetCol.TabIndex = 24;
            this.cmbSetCol.Text = "Select Column";
            // 
            // tpVariableManagement
            // 
            this.tpVariableManagement.Controls.Add(this.lblSize);
            this.tpVariableManagement.Controls.Add(this.txtSize);
            this.tpVariableManagement.Controls.Add(this.btnSave);
            this.tpVariableManagement.Controls.Add(this.lblVar);
            this.tpVariableManagement.Controls.Add(this.txtProcedureName);
            this.tpVariableManagement.Controls.Add(this.lblProcedureName);
            this.tpVariableManagement.Controls.Add(this.cmbDataTypes);
            this.tpVariableManagement.Controls.Add(this.btnRemoveVariables);
            this.tpVariableManagement.Controls.Add(this.lblVariableHead);
            this.tpVariableManagement.Controls.Add(this.lstVarItems);
            this.tpVariableManagement.Controls.Add(this.label5);
            this.tpVariableManagement.Controls.Add(this.btnAddVar);
            this.tpVariableManagement.Controls.Add(this.txtVarName);
            this.tpVariableManagement.Controls.Add(this.label9);
            this.tpVariableManagement.Controls.Add(this.label11);
            this.tpVariableManagement.Location = new System.Drawing.Point(4, 22);
            this.tpVariableManagement.Name = "tpVariableManagement";
            this.tpVariableManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariableManagement.Size = new System.Drawing.Size(491, 317);
            this.tpVariableManagement.TabIndex = 7;
            this.tpVariableManagement.Text = "Variables";
            this.tpVariableManagement.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(357, 116);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 29;
            this.lblSize.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(342, 133);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(59, 20);
            this.txtSize.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar.Location = new System.Drawing.Point(200, 69);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(75, 16);
            this.lblVar.TabIndex = 26;
            this.lblVar.Text = "Variables";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(188, 37);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(100, 20);
            this.txtProcedureName.TabIndex = 25;
            // 
            // lblProcedureName
            // 
            this.lblProcedureName.AutoSize = true;
            this.lblProcedureName.Location = new System.Drawing.Point(64, 42);
            this.lblProcedureName.Name = "lblProcedureName";
            this.lblProcedureName.Size = new System.Drawing.Size(90, 13);
            this.lblProcedureName.TabIndex = 24;
            this.lblProcedureName.Text = "Procedure Name:";
            // 
            // cmbDataTypes
            // 
            this.cmbDataTypes.FormattingEnabled = true;
            this.cmbDataTypes.Location = new System.Drawing.Point(174, 133);
            this.cmbDataTypes.Name = "cmbDataTypes";
            this.cmbDataTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbDataTypes.TabIndex = 23;
            this.cmbDataTypes.SelectedIndexChanged += new System.EventHandler(this.CmbDataTypes_SelectedIndexChanged);
            // 
            // btnRemoveVariables
            // 
            this.btnRemoveVariables.Location = new System.Drawing.Point(336, 216);
            this.btnRemoveVariables.Name = "btnRemoveVariables";
            this.btnRemoveVariables.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveVariables.TabIndex = 22;
            this.btnRemoveVariables.Text = "Remove item";
            this.btnRemoveVariables.UseVisualStyleBackColor = true;
            this.btnRemoveVariables.Click += new System.EventHandler(this.BtnRemoveVariables_Click);
            // 
            // lblVariableHead
            // 
            this.lblVariableHead.AutoSize = true;
            this.lblVariableHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableHead.Location = new System.Drawing.Point(124, 6);
            this.lblVariableHead.Name = "lblVariableHead";
            this.lblVariableHead.Size = new System.Drawing.Size(200, 20);
            this.lblVariableHead.TabIndex = 21;
            this.lblVariableHead.Text = "Procedure Management";
            // 
            // lstVarItems
            // 
            this.lstVarItems.FormattingEnabled = true;
            this.lstVarItems.Location = new System.Drawing.Point(109, 216);
            this.lstVarItems.Name = "lstVarItems";
            this.lstVarItems.Size = new System.Drawing.Size(215, 95);
            this.lstVarItems.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Variables";
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(204, 160);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(71, 23);
            this.btnAddVar.TabIndex = 18;
            this.btnAddVar.Text = "Add";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // txtVarName
            // 
            this.txtVarName.Location = new System.Drawing.Point(43, 133);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(101, 20);
            this.txtVarName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Variable Name";
            // 
            // tpViews
            // 
            this.tpViews.Controls.Add(this.btnSaveView);
            this.tpViews.Controls.Add(this.txtViewName);
            this.tpViews.Controls.Add(this.lblViewName);
            this.tpViews.Controls.Add(this.lblViewHead);
            this.tpViews.Location = new System.Drawing.Point(4, 22);
            this.tpViews.Name = "tpViews";
            this.tpViews.Padding = new System.Windows.Forms.Padding(3);
            this.tpViews.Size = new System.Drawing.Size(491, 317);
            this.tpViews.TabIndex = 8;
            this.tpViews.Text = "Views";
            this.tpViews.UseVisualStyleBackColor = true;
            // 
            // btnSaveView
            // 
            this.btnSaveView.Location = new System.Drawing.Point(202, 97);
            this.btnSaveView.Name = "btnSaveView";
            this.btnSaveView.Size = new System.Drawing.Size(71, 23);
            this.btnSaveView.TabIndex = 28;
            this.btnSaveView.Text = "Save";
            this.btnSaveView.UseVisualStyleBackColor = true;
            // 
            // txtViewName
            // 
            this.txtViewName.Location = new System.Drawing.Point(187, 71);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.Size = new System.Drawing.Size(100, 20);
            this.txtViewName.TabIndex = 2;
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Location = new System.Drawing.Point(108, 74);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(64, 13);
            this.lblViewName.TabIndex = 1;
            this.lblViewName.Text = "View Name:";
            // 
            // lblViewHead
            // 
            this.lblViewHead.AutoSize = true;
            this.lblViewHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewHead.Location = new System.Drawing.Point(129, 8);
            this.lblViewHead.Name = "lblViewHead";
            this.lblViewHead.Size = new System.Drawing.Size(183, 24);
            this.lblViewHead.TabIndex = 0;
            this.lblViewHead.Text = "View Management";
            // 
            // tpColumns
            // 
            this.tpColumns.Controls.Add(this.cbxAggregate);
            this.tpColumns.Controls.Add(this.btnRemoveColumnMan);
            this.tpColumns.Controls.Add(this.btnAddColumn);
            this.tpColumns.Controls.Add(this.lstColumnsManagement);
            this.tpColumns.Controls.Add(this.lblColName);
            this.tpColumns.Controls.Add(this.txtColNames);
            this.tpColumns.Controls.Add(this.cmbAggrgateFunctions);
            this.tpColumns.Controls.Add(this.cmbColumnManagementList);
            this.tpColumns.Controls.Add(this.lblListedColumns);
            this.tpColumns.Controls.Add(this.cbxAs);
            this.tpColumns.Controls.Add(this.lblAggr);
            this.tpColumns.Controls.Add(this.lblColumnManHead);
            this.tpColumns.Controls.Add(this.lblColumnManagement);
            this.tpColumns.Location = new System.Drawing.Point(4, 22);
            this.tpColumns.Name = "tpColumns";
            this.tpColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tpColumns.Size = new System.Drawing.Size(491, 317);
            this.tpColumns.TabIndex = 9;
            this.tpColumns.Text = "Columns";
            this.tpColumns.UseVisualStyleBackColor = true;
            // 
            // cbxAggregate
            // 
            this.cbxAggregate.AutoSize = true;
            this.cbxAggregate.Location = new System.Drawing.Point(92, 114);
            this.cbxAggregate.Name = "cbxAggregate";
            this.cbxAggregate.Size = new System.Drawing.Size(75, 17);
            this.cbxAggregate.TabIndex = 12;
            this.cbxAggregate.Text = "Aggregate";
            this.cbxAggregate.UseVisualStyleBackColor = true;
            this.cbxAggregate.CheckedChanged += new System.EventHandler(this.CbxAggregate_CheckedChanged);
            // 
            // btnRemoveColumnMan
            // 
            this.btnRemoveColumnMan.Location = new System.Drawing.Point(410, 190);
            this.btnRemoveColumnMan.Name = "btnRemoveColumnMan";
            this.btnRemoveColumnMan.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveColumnMan.TabIndex = 11;
            this.btnRemoveColumnMan.Text = "Remove";
            this.btnRemoveColumnMan.UseVisualStyleBackColor = true;
            this.btnRemoveColumnMan.Click += new System.EventHandler(this.BtnRemoveColumnMan_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(410, 145);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAddColumn.TabIndex = 10;
            this.btnAddColumn.Text = "Add";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.BtnAddColumn_Click);
            // 
            // lstColumnsManagement
            // 
            this.lstColumnsManagement.FormattingEnabled = true;
            this.lstColumnsManagement.Location = new System.Drawing.Point(101, 190);
            this.lstColumnsManagement.Name = "lstColumnsManagement";
            this.lstColumnsManagement.Size = new System.Drawing.Size(305, 121);
            this.lstColumnsManagement.TabIndex = 9;
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Location = new System.Drawing.Point(197, 149);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(38, 13);
            this.lblColName.TabIndex = 8;
            this.lblColName.Text = "Name:";
            // 
            // txtColNames
            // 
            this.txtColNames.Location = new System.Drawing.Point(250, 146);
            this.txtColNames.Name = "txtColNames";
            this.txtColNames.Size = new System.Drawing.Size(121, 20);
            this.txtColNames.TabIndex = 7;
            // 
            // cmbAggrgateFunctions
            // 
            this.cmbAggrgateFunctions.FormattingEnabled = true;
            this.cmbAggrgateFunctions.Location = new System.Drawing.Point(250, 112);
            this.cmbAggrgateFunctions.Name = "cmbAggrgateFunctions";
            this.cmbAggrgateFunctions.Size = new System.Drawing.Size(121, 21);
            this.cmbAggrgateFunctions.TabIndex = 6;
            // 
            // cmbColumnManagementList
            // 
            this.cmbColumnManagementList.FormattingEnabled = true;
            this.cmbColumnManagementList.Location = new System.Drawing.Point(180, 62);
            this.cmbColumnManagementList.Name = "cmbColumnManagementList";
            this.cmbColumnManagementList.Size = new System.Drawing.Size(121, 21);
            this.cmbColumnManagementList.TabIndex = 5;
            // 
            // lblListedColumns
            // 
            this.lblListedColumns.AutoSize = true;
            this.lblListedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListedColumns.Location = new System.Drawing.Point(226, 169);
            this.lblListedColumns.Name = "lblListedColumns";
            this.lblListedColumns.Size = new System.Drawing.Size(75, 18);
            this.lblListedColumns.TabIndex = 4;
            this.lblListedColumns.Text = "Columns";
            // 
            // cbxAs
            // 
            this.cbxAs.AutoSize = true;
            this.cbxAs.Location = new System.Drawing.Point(92, 149);
            this.cbxAs.Name = "cbxAs";
            this.cbxAs.Size = new System.Drawing.Size(66, 17);
            this.cbxAs.TabIndex = 3;
            this.cbxAs.Text = "Save As";
            this.cbxAs.UseVisualStyleBackColor = true;
            this.cbxAs.CheckedChanged += new System.EventHandler(this.CbxAs_CheckedChanged);
            // 
            // lblAggr
            // 
            this.lblAggr.AutoSize = true;
            this.lblAggr.Location = new System.Drawing.Point(178, 115);
            this.lblAggr.Name = "lblAggr";
            this.lblAggr.Size = new System.Drawing.Size(61, 13);
            this.lblAggr.TabIndex = 2;
            this.lblAggr.Text = "Aggregates";
            // 
            // lblColumnManHead
            // 
            this.lblColumnManHead.AutoSize = true;
            this.lblColumnManHead.Location = new System.Drawing.Point(213, 46);
            this.lblColumnManHead.Name = "lblColumnManHead";
            this.lblColumnManHead.Size = new System.Drawing.Size(50, 13);
            this.lblColumnManHead.TabIndex = 1;
            this.lblColumnManHead.Text = "Columns:";
            // 
            // lblColumnManagement
            // 
            this.lblColumnManagement.AutoSize = true;
            this.lblColumnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnManagement.Location = new System.Drawing.Point(155, 6);
            this.lblColumnManagement.Name = "lblColumnManagement";
            this.lblColumnManagement.Size = new System.Drawing.Size(178, 20);
            this.lblColumnManagement.TabIndex = 0;
            this.lblColumnManagement.Text = "Column Management";
            // 
            // btnAddsSource
            // 
            this.btnAddsSource.Location = new System.Drawing.Point(195, 102);
            this.btnAddsSource.Name = "btnAddsSource";
            this.btnAddsSource.Size = new System.Drawing.Size(75, 39);
            this.btnAddsSource.TabIndex = 18;
            this.btnAddsSource.Text = "Add";
            this.btnAddsSource.UseVisualStyleBackColor = true;
            this.btnAddsSource.Click += new System.EventHandler(this.BtnAddsSource_Click);
            // 
            // btnQueryOutPut
            // 
            this.btnQueryOutPut.Location = new System.Drawing.Point(67, 357);
            this.btnQueryOutPut.Margin = new System.Windows.Forms.Padding(0);
            this.btnQueryOutPut.Name = "btnQueryOutPut";
            this.btnQueryOutPut.Size = new System.Drawing.Size(118, 27);
            this.btnQueryOutPut.TabIndex = 19;
            this.btnQueryOutPut.Text = "Test Query Output";
            this.btnQueryOutPut.UseVisualStyleBackColor = true;
            // 
            // cmbProgrammingHaving
            // 
            this.cmbProgrammingHaving.FormattingEnabled = true;
            this.cmbProgrammingHaving.Location = new System.Drawing.Point(305, 60);
            this.cmbProgrammingHaving.Name = "cmbProgrammingHaving";
            this.cmbProgrammingHaving.Size = new System.Drawing.Size(121, 21);
            this.cmbProgrammingHaving.TabIndex = 23;
            // 
            // cmbProgrammingSet
            // 
            this.cmbProgrammingSet.FormattingEnabled = true;
            this.cmbProgrammingSet.Location = new System.Drawing.Point(299, 59);
            this.cmbProgrammingSet.Name = "cmbProgrammingSet";
            this.cmbProgrammingSet.Size = new System.Drawing.Size(121, 21);
            this.cmbProgrammingSet.TabIndex = 37;
            // 
            // cmbProgrammingValues
            // 
            this.cmbProgrammingValues.FormattingEnabled = true;
            this.cmbProgrammingValues.Location = new System.Drawing.Point(254, 64);
            this.cmbProgrammingValues.Name = "cmbProgrammingValues";
            this.cmbProgrammingValues.Size = new System.Drawing.Size(121, 21);
            this.cmbProgrammingValues.TabIndex = 37;
            // 
            // cmbProgrammingWhere
            // 
            this.cmbProgrammingWhere.FormattingEnabled = true;
            this.cmbProgrammingWhere.Location = new System.Drawing.Point(305, 58);
            this.cmbProgrammingWhere.Name = "cmbProgrammingWhere";
            this.cmbProgrammingWhere.Size = new System.Drawing.Size(121, 21);
            this.cmbProgrammingWhere.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3rdYearProject.Properties.Resources.Option1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 566);
            this.Controls.Add(this.btnAddsSource);
            this.Controls.Add(this.tbcExstra);
            this.Controls.Add(this.tvEntities);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbDatabaseList);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.btnQueryOutPut);
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tbcExstra.ResumeLayout(false);
            this.tpValues.ResumeLayout(false);
            this.tpValues.PerformLayout();
            this.tpWhere.ResumeLayout(false);
            this.tpWhere.PerformLayout();
            this.tpOrderBy.ResumeLayout(false);
            this.tpOrderBy.PerformLayout();
            this.tpGroupBy.ResumeLayout(false);
            this.tpGroupBy.PerformLayout();
            this.tpHaving.ResumeLayout(false);
            this.tpHaving.PerformLayout();
            this.tpJoins.ResumeLayout(false);
            this.tpJoins.PerformLayout();
            this.tpSet.ResumeLayout(false);
            this.tpSet.PerformLayout();
            this.tpVariableManagement.ResumeLayout(false);
            this.tpVariableManagement.PerformLayout();
            this.tpViews.ResumeLayout(false);
            this.tpViews.PerformLayout();
            this.tpColumns.ResumeLayout(false);
            this.tpColumns.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuSubDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuSubTable;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedure;
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
        private System.Windows.Forms.Label lblOrderColumnHead;
        private System.Windows.Forms.Label lblOrderHeading;
        private System.Windows.Forms.Label lblOrderedHead;
        private System.Windows.Forms.Label lblAscDescHead;
        private System.Windows.Forms.Button btnRemoveOrderedItem;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.ComboBox cmbOrderColumns;
        private System.Windows.Forms.ListBox lstOrderedItems;
        private System.Windows.Forms.Button btnRemoveGroupBy;
        private System.Windows.Forms.ComboBox cmbGroupByColum;
        private System.Windows.Forms.ListBox lstGroupedItems;
        private System.Windows.Forms.Label lblGroupedItemsHead;
        private System.Windows.Forms.Label lblGroupByHead;
        private System.Windows.Forms.Button btnRemoveHavingItem;
        private System.Windows.Forms.Label lblHavingHead;
        private System.Windows.Forms.ListBox lstHavingItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHaving;
        private System.Windows.Forms.TextBox txtHavingValue;
        private System.Windows.Forms.Label lblHavingValueHead;
        private System.Windows.Forms.ComboBox cmbHavingCondition;
        private System.Windows.Forms.Label lblHavingCondition;
        private System.Windows.Forms.Label lblHavingColHead;
        private System.Windows.Forms.ComboBox cmbHavingCol;
        private System.Windows.Forms.Button btnRemoveJoinItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstJoinItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddJoins;
        private System.Windows.Forms.ComboBox cmbJoinColumns;
        private System.Windows.Forms.Button btnAddsSource;
        private System.Windows.Forms.ComboBox cmbTargetColumn;
        private System.Windows.Forms.ComboBox cmbTableJoinTarget;
        private System.Windows.Forms.ComboBox cmbSourceTableJoin;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnAddOrderType;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Label lblGroupColumn;
        private System.Windows.Forms.Button btnRemoveValues;
        private System.Windows.Forms.Label lblValuesHead;
        private System.Windows.Forms.ListBox lstInsertItems;
        private System.Windows.Forms.Label lblItemsnsert;
        private System.Windows.Forms.Button btnAddValues;
        private System.Windows.Forms.TextBox txtInsertValues;
        private System.Windows.Forms.Label lblValueValues;
        private System.Windows.Forms.Label lblValuesCol;
        private System.Windows.Forms.ComboBox cmbInsertColumns;
        private System.Windows.Forms.TabPage tpSet;
        private System.Windows.Forms.Button btnRemoveSetItems;
        private System.Windows.Forms.Label lblSetHead;
        private System.Windows.Forms.ListBox lstSetitems;
        private System.Windows.Forms.Label lblSetItems;
        private System.Windows.Forms.Button btnAddSet;
        private System.Windows.Forms.TextBox txtSetValues;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSetCol;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TabPage tpVariableManagement;
        private System.Windows.Forms.Button btnRemoveVariables;
        private System.Windows.Forms.Label lblVariableHead;
        private System.Windows.Forms.ListBox lstVarItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem mnuViews;
        private System.Windows.Forms.Label lblEqualsUpdate;
        private System.Windows.Forms.Button btnQueryOutPut;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label lblProcedureName;
        private System.Windows.Forms.ComboBox cmbDataTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tpViews;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnSaveView;
        private System.Windows.Forms.TextBox txtViewName;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label lblViewHead;
        private System.Windows.Forms.TabPage tpColumns;
        private System.Windows.Forms.CheckBox cbxAggregate;
        private System.Windows.Forms.Button btnRemoveColumnMan;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.ListBox lstColumnsManagement;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.TextBox txtColNames;
        private System.Windows.Forms.ComboBox cmbAggrgateFunctions;
        private System.Windows.Forms.ComboBox cmbColumnManagementList;
        private System.Windows.Forms.Label lblListedColumns;
        private System.Windows.Forms.CheckBox cbxAs;
        private System.Windows.Forms.Label lblAggr;
        private System.Windows.Forms.Label lblColumnManHead;
        private System.Windows.Forms.Label lblColumnManagement;
        private System.Windows.Forms.ComboBox cmbProgrammingValues;
        private System.Windows.Forms.ComboBox cmbProgrammingWhere;
        private System.Windows.Forms.ComboBox cmbProgrammingHaving;
        private System.Windows.Forms.ComboBox cmbProgrammingSet;
    }
}