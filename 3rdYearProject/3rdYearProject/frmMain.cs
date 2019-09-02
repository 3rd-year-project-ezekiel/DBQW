using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace _3rdYearProject
{
    public partial class frmMain : Form
    {

        #region Form Constructor , Global Fields And Functunality
        #region Private Fields
        private const int TVIF_STATE = 0x8;
        private const int TVIS_STATEIMAGEMASK = 0xF000;
        private const int TV_FIRST = 0x1100;
        private const int TVM_SETITEM = TV_FIRST + 63;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam,
                                                    ref TVITEM lParam);
        #endregion
        #region Global Fields
        SQLBuilder sqlBuilderClass = new SQLBuilder();

        List<Databases> databases;
        List<Tables> tables;
        List<Tables> selectedTables = new List<Tables>();
        List<Columns> columns;
        List<string> selectedColumns = new List<string>();
        List<string> selectedListofColumns = new List<string>();
        List<string> conditionList = new List<string>();
        Dictionary<string, List<string>> columnDictionary = new Dictionary<string, List<string>>();

        #endregion

        #region Form Constructor
        public frmMain()
        {
            InitializeComponent();
            tvEntities.CheckBoxes = true;
            Databases database = new Databases();
            databases = database.GetDatabases();
            cmbDatabaseList.SelectedIndexChanged -= cmbDatabaseList_SelectedIndexChanged;
            cmbDatabaseList.DataSource = databases;
            cmbDatabaseList.DisplayMember = "NameOfDatabase";
            cmbDatabaseList.ValueMember = "NameOfDatabase";
            cmbDatabaseList.SelectedIndex = -1;
            cmbDatabaseList.SelectedIndexChanged += cmbDatabaseList_SelectedIndexChanged;
            AddConditions();
            cmbHavingCondition.DataSource = conditionList;
            cmbWhereCondition.DataSource = conditionList;
            cmbOrderType.Items.Add("Asc");
            cmbOrderType.Items.Add("Desc");
            RemoveUnneccassary();
            AddTabsForSelect();
            DisableComponenets();
            MenuStripColour(mnuSelect);
            mnuProcedure.BackColor = Color.Transparent;
            cbxType.Text = "Select DataType";
            cbxType.Items.Add("Char(10)");
            cbxType.Items.Add("VarChar(50)");
            cbxType.Items.Add("Text");
            cbxType.Items.Add("NChar(10)");
            cbxType.Items.Add("Int");
            cbxType.Items.Add("Money");
            cbxType.Items.Add("Time");
            cbxType.Items.Add("Date");

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Form Functionality
        #region TreeViewFunctions

        private void HideCheckBox(TreeView tvw, TreeNode node)
        {
            TVITEM tvi = new TVITEM();
            tvi.hItem = node.Handle;
            tvi.mask = TVIF_STATE;
            tvi.stateMask = TVIS_STATEIMAGEMASK;
            tvi.state = 0;
            SendMessage(tvw.Handle, TVM_SETITEM, IntPtr.Zero, ref tvi);
        }

        private struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage;
            public int cChildren;
            public IntPtr lParam;
        }
        public void DoubleCheckRemove()
        {
            foreach (TreeNode item in tvEntities.Nodes)
            {
                if (item != null)
                {
                    if (item.Checked == true)
                    {
                        item.Remove();

                        columnDictionary.Remove(item.Text.ToString());

                    }
                }




            }
        }
        #endregion
        private void BtnAddVariable_Click(object sender, EventArgs e)
        {
            string variableName = "@" + txtVariable.Text;
            string dataType = cbxType.SelectedItem.ToString();

            lstVarList.Items.Add(string.Format("{0} {1}", variableName, dataType));
            
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
          
            foreach (TreeNode item in tvEntities.Nodes)
            {
                if (item != null)
                {
                    if ( item.Checked == true)
                    {
                        item.Remove();

                        columnDictionary.Remove(item.Text.ToString());
                        selectedTables.RemoveAll(p => p.TableNames == item.Text);
                    }
                }

                
                

            }
            DoubleCheckRemove();




            if (tvEntities.Nodes.Count == 0)
            {
                tvEntities.Nodes.Clear();
                item = 0;
            }
            else
            {
                item = tvEntities.Nodes.Count;
            }
        }

        public void DisableComponenets()
        {
            tbcExstra.Enabled = false;
            cmbTables.Enabled = false;
            tvEntities.Enabled = false;
            btnAddsSource.Enabled = false;
            btnRemove.Enabled = false;

            mnuProcedure.Enabled = false;
            mnuSelect.Enabled = false;
            mnuInsert.Enabled = false;
            mnuDelete.Enabled = false;
            mnuUpdate.Enabled = false;

        }

        int item = 0;
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            tvEntities.Enabled = true;
            btnAddsSource.Enabled = true;
            btnRemove.Enabled = true;
            bool found = false;

            Tables newTable = (Tables)cmbTables.SelectedItem;
            if (item != 0)
            {
                foreach (Tables sItem in selectedTables)
                {
                    if (sItem.TableNames == newTable.TableNames)
                    {
                        found = true;
                    }
                }
                if (found == true)
                {
                    MessageBox.Show("Cant add the same Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (found == false)
            {
                selectedTables.Add(new Tables(newTable.TableNames));
                tvEntities.Nodes.Add(newTable.TableNames);
                Columns column = new Columns();
                columns = column.GetColumns(cmbDatabaseList.SelectedValue.ToString(), newTable.TableNames.ToString());
                int count = 0; 
                foreach (Columns dataItem in columns)
                {
                    tvEntities.Nodes[item].Nodes.Add(dataItem.ColumnName);
                    HideCheckBox(tvEntities, tvEntities.Nodes[item].Nodes[count]);
                    count++;
                }
                item++;
            }
        }
       
        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDisplay.DataSource != null)
            {
                if (MessageBox.Show("Are you sure you want to replace the Database, doing so will erase the Query", " warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    item = 0;
                    tvEntities.Nodes.Clear();
                    Tables table = new Tables();
                    tables = table.GetTables(cmbDatabaseList.SelectedValue.ToString());
                    cmbTables.SelectedIndexChanged -= cmbTables_SelectedIndexChanged;
                    cmbTables.DataSource = tables;
                    cmbTables.DisplayMember = "tableNames";
                    cmbTables.ValueMember = "tableNames";
                    cmbTables.SelectedIndex = -1;
                    cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
                    cmbTables.Enabled = true;
                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.DatabaseBaseBuilder(cmbDatabaseList.SelectedValue.ToString());
                }
                else
                {
                    // enter previos database name
                }
            }
            else
            {
                tvEntities.Nodes.Clear();
                Tables table = new Tables();
                tables = table.GetTables(cmbDatabaseList.SelectedValue.ToString());
                cmbTables.SelectedIndexChanged -= cmbTables_SelectedIndexChanged;
                cmbTables.DataSource = tables;
                cmbTables.DisplayMember = "tableNames";
                cmbTables.ValueMember = "tableNames";
                cmbTables.SelectedIndex = -1;
                cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
                cmbTables.Enabled = true;
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.DatabaseBaseBuilder(cmbDatabaseList.SelectedValue.ToString());
            }

            mnuProcedure.Enabled = true;
            mnuInsert.Enabled = true;
            mnuSelect.Enabled = true;
            mnuDelete.Enabled = true;
            mnuUpdate.Enabled = true;

        }

        private void BtnAddsSource_Click(object sender, EventArgs e)
        {
            tbcExstra.Enabled = true;
            columnDictionary.Clear();
            selectedColumns.Clear();
            foreach (TreeNode item in tvEntities.Nodes)
            {
                if (item.Checked==true)
                {
                    foreach (TreeNode treeNode in item.Nodes)
                    {

                        
                            if (!columnDictionary.ContainsKey(item.Text.ToString()))
                            {
                                columnDictionary.Add(item.Text.ToString(), new List<string>());
                                columnDictionary[item.Text.ToString()].Add(treeNode.Text.ToString());
                            }
                            else
                            {
                                columnDictionary[item.Text.ToString()].Add(treeNode.Text.ToString());
                            }


                        
                    }
                }

                
                

            }
            ClearDataSources();
            selectedListofColumns.Clear();
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {

                foreach (string stringItem in item.Value)
                {
                    selectedListofColumns.Add(stringItem);
                }

                cmbTableJoinTarget.Items.Add(item.Key);
                cmbSourceTableJoin.Items.Add(item.Key);
                cmbInsertTable.Items.Add(item.Key);
            }

            //for Column Names,(Basic SQL CODE ex.Select)
            cmbWhereColName.DataSource = selectedListofColumns;
            cmbHavingCol.DataSource = selectedListofColumns;
            cmbOrderColumns.DataSource = selectedListofColumns;
            cmbGroupByColum.DataSource = selectedListofColumns;
            cmbSetCol.DataSource = selectedListofColumns;
        }
        #endregion

        #endregion
        
        #region Menu Strip

        #region Base Menu Strips ( Insert, Update, Delete, Select, Programability)
        // Procedure Menu Strip
        private void mnuProcedure_Click(object sender, EventArgs e)
        {
            if (mnuProcedure.BackColor == Color.Transparent)
                mnuProcedure.BackColor = Color.LightSeaGreen;
            else mnuProcedure.BackColor = Color.Transparent;
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.ProcedureBaseBuilder();

        }
        //Children if Procedure Menu Strip(Select)
        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUnneccassary();
            AddTabsForProcedures("Select");
        }
        //Children if Procedure Menu Strip(Insert)
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUnneccassary();
            AddTabsForProcedures("Insert");
        }
        //Children if Procedure Menu Strip(Update)
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUnneccassary();
            AddTabsForProcedures("Update");
        }
        //Children if Procedure Menu Strip(Delete)
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUnneccassary();
            AddTabsForProcedures("Delete");
        }

        // Select Menu strip
        private void mnuSelect_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuSelect);
            RemoveUnneccassary();
            AddTabsForSelect();
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.SelectBaseBuilder(cmbTables.SelectedText);
        }

        // Delete Menu Strip
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuDelete);
            RemoveUnneccassary();
            AddTabsForDelete();
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.DeleteBaseBuilder(cmbTables.SelectedText);

        }

        // Update Menu Strip
        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuUpdate);
            RemoveUnneccassary();
            AddTabsForUpdate();
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.UpdateBaseBuilder(cmbTables.SelectedText);
        }

        // Insert Menu
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuInsert);
            RemoveUnneccassary();
            AddTabsForInsert();
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.InsertBaseBuilder(cmbTables.SelectedText);
        }

        // Colour changes of the Sql Menu Strip( Select , Delete , Update , Insert )
        public void MenuStripColour(ToolStripMenuItem SelectedItem)
        {
            mnuSelect.BackColor = Color.Transparent;
            mnuInsert.BackColor = Color.Transparent;
            mnuDelete.BackColor = Color.Transparent;
            mnuUpdate.BackColor = Color.Transparent;
            SelectedItem.BackColor = Color.LightBlue;
        }

        #endregion

        #region Other Menu Strip Functions
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void DatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatabaseCreation databaseCreation = new frmDatabaseCreation();
            this.Hide();
            databaseCreation.Show();
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remeber to fix

            //if (cmbDatabaseList.SelectedItem.ToString()=="")
            //{
            //    MessageBox.Show("Please select an database","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            //else
            //{
            //    string databaseName = cmbDatabaseList.SelectedItem.ToString();
            frmTableCreation tableCreation = new frmTableCreation();
            this.Hide();
            tableCreation.Show();
            // }
        }

        #endregion

        #endregion

        #region Tab Controle

        // Validation needs to be added here
        // validation to detrimine what data type the value should be

        #region Add/Remove Tabs

        public void RemoveUnneccassary()
        {
            tbcExstra.TabPages.Remove(tpOrderBy);
            tbcExstra.TabPages.Remove(tpGroupBy);
            tbcExstra.TabPages.Remove(tpJoins);
            tbcExstra.TabPages.Remove(tpValues);
            tbcExstra.TabPages.Remove(tpHaving);
            tbcExstra.TabPages.Remove(tpWhere);
            tbcExstra.TabPages.Remove(tpSet);
            tbcExstra.TabPages.Remove(tpVariableManagement);
        }


        public void AddTabsForProcedures(string choice)
        {
            tbcExstra.TabPages.Add(tpVariableManagement);

            if (choice=="Select")
            {
                AddTabsForSelect();
            }
            if (choice == "Insert")
            {
                AddTabsForInsert();
            }
            if (choice == "Update")
            {
                AddTabsForUpdate();
            }
            if (choice == "Delete")
            {
                AddTabsForDelete();
            }

        }

        public void AddTabsForSelect()
        {
            tbcExstra.TabPages.Add(tpOrderBy);
            tbcExstra.TabPages.Add(tpGroupBy);
            tbcExstra.TabPages.Add(tpJoins);
            tbcExstra.TabPages.Add(tpWhere);
            tbcExstra.TabPages.Add(tpHaving);

        }
        public void AddTabsForInsert()
        {
            tbcExstra.TabPages.Remove(tpWhere);
            tbcExstra.TabPages.Add(tpValues);
        }

        public void AddTabsForUpdate()
        {

            tbcExstra.TabPages.Add(tpWhere);
            tbcExstra.TabPages.Add(tpSet);
        }

        public void AddTabsForDelete()
        {
            tbcExstra.TabPages.Add(tpWhere);
        }


        #endregion

        #region Tab Mechanics
        public void ClearDataSources()
        {
            cmbWhereColName.DataSource = null;
            cmbHavingCol.DataSource = null;
            cmbOrderColumns.DataSource = null;
            cmbGroupByColum.DataSource = null;
            cmbSetCol.DataSource = null;
            cmbTableJoinTarget.Items.Clear();
            cmbSourceTableJoin.Items.Clear();
            cmbInsertTable.Items.Clear();
        }

        public void AddConditions()
        {
            conditionList.Add("=");
            conditionList.Add("!=");
            conditionList.Add(">");
            conditionList.Add(">=");
            conditionList.Add("<=");
            conditionList.Add("<");
        }

        private void CmbSourceTableJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {
                if (cmbSourceTableJoin.SelectedItem.ToString() == item.Key)
                {
                    cmbJoinColumns.DataSource = item.Value;
                }
            }
        }

        private void CmbTableJoinTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {
                if (cmbTableJoinTarget.SelectedItem.ToString() == item.Key)
                {
                    cmbTargetColumn.DataSource = item.Value;
                }
            }
        }

        private void CmbInsertTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {
                if (cmbInsertTable.SelectedItem.ToString() == item.Key)
                {
                    cmbInsertColumns.DataSource = item.Value;
                }
            }
        }

        #endregion

        #region Tab Button Functionality
        private void BtnAddWhere_Click(object sender, EventArgs e)
        {
            try
            {
                string columnName = cmbWhereColName.SelectedItem.ToString();
                string condition = cmbWhereCondition.SelectedItem.ToString();
                string value = txtWhereValues.Text.ToString();
                if (value=="")
                {
                    throw new NullReferenceException();
                }
                lstWhereItems.Items.Add(string.Format("{0} {1} {2}", columnName, condition, value));

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.WhereClauseBuilder(columnName + " " + condition + " " + value);
                txtWhereValues.Clear();
                
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void BtnRemoveClauseFromWhere_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstWhereItems.SelectedIndex;
                // removes from the query
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.WhereClauseRemover((string)lstWhereItems.SelectedItem);

                lstWhereItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddOrderedItem_Click(object sender, EventArgs e)
        {
            try
            {
                string columnName = cmbOrderColumns.SelectedItem.ToString();


                if (cmbOrderType.SelectedItem.ToString() == "Select Order Type")
                {

                    throw new NullReferenceException();
                }
                string sortType = cmbOrderType.SelectedItem.ToString();

                string valueHolder = string.Format("{0} {1}", columnName, sortType);
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.OrderByClauseBuilder(valueHolder);

                lstOrderedItems.Items.Add(valueHolder);
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No sorting type selected.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnRemoveOrderedItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstOrderedItems.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.OrderByClauseRemover((string)lstOrderedItems.SelectedItem);

                lstOrderedItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGroupBy_Click(object sender, EventArgs e)
        {
            string columnName = cmbGroupByColum.SelectedItem.ToString();

            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.GroupByClauseBuilder(columnName);
            
            lstGroupedItems.Items.Add(string.Format("{0}", columnName));
        }

        private void BtnRemoveGroupBy_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstGroupedItems.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.GroupByClauseRemover((string)lstGroupedItems.SelectedItem);

                lstGroupedItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddHaving_Click(object sender, EventArgs e)
        {
            try
            {
                string columnName = cmbHavingCol.SelectedItem.ToString();
                string condition = cmbHavingCondition.SelectedItem.ToString();
                string value = txtHavingValue.Text.ToString();
                if (value=="")
                {
                    throw new NullReferenceException();
                }

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.HavingClauseBuilder(columnName + " " + condition + " " + value);

                lstHavingItems.Items.Add(string.Format("{0} {1} {2}", columnName, condition, value));

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnRemoveHavingItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstHavingItems.SelectedIndex;

                // removes from the query
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.HavingClauseRemover((string)lstHavingItems.SelectedItem);

                lstHavingItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show( "Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddJoins_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceTable = cmbSourceTableJoin.SelectedItem.ToString();
                string sourceColumn = cmbJoinColumns.SelectedItem.ToString();
                string targetTable = cmbTableJoinTarget.SelectedItem.ToString();
                string targetColumn = cmbTargetColumn.SelectedItem.ToString();

                if ((sourceTable == "Select Table") || (sourceColumn == "Select Column") || (targetColumn == "Select Column") || (targetTable == "Select Table"))
                {
                    throw new NullReferenceException();
                }

                lstJoinItems.Items.Add(string.Format("Inner Join {0} On {2}.{3}={0}.{1}", targetTable, targetColumn, sourceTable, sourceColumn));
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Please select all relevant items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void BtnRemoveJoinItems_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstJoinItems.SelectedIndex;

                lstJoinItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddValues_Click(object sender, EventArgs e)
        {
            try
            {
                string table = cmbInsertTable.SelectedItem.ToString();
                string columnName = cmbInsertColumns.SelectedItem.ToString();
                
                string value = txtInsertValues.Text.ToString();
                if (value == "")
                {
                    throw new NullReferenceException();
                }

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.InsertValue(columnName, value);

                //lstInsertItems.Items.Add(string.Format("Table:{0} Column:{1} Value:{2}", table,columnName, value));
                //lstInsertItems.Items.Add(string.Format("{1} {2}",columnName, value));
                lstInsertItems.Items.Add(string.Format(columnName+" "+value));
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveValues_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstInsertItems.SelectedIndex;

                string[] values = ((string)lstInsertItems.SelectedItem).Split(' ');
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.InsertRemoveValue(values[0], values[1]);

                lstInsertItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddSet_Click(object sender, EventArgs e)
        {
            try
            {
                string columnName = cmbSetCol.SelectedItem.ToString();
                string condition = "=";
                string value = txtSetValues.Text.ToString();
                if (value == "")
                {
                    throw new NullReferenceException();
                }

                string tempValueHolder = string.Format("{0} {1} {2}", columnName, condition, value);

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.UpdateSet(tempValueHolder);

                lstSetitems.Items.Add(tempValueHolder);
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRemoveVar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstVarList.SelectedIndex;


                lstVarList.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnRemoveSetItems_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstSetitems.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.UpdateRemoveSet((string)lstSetitems.SelectedItem);

                lstSetitems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }





        #endregion

        #endregion

       
    }
}
