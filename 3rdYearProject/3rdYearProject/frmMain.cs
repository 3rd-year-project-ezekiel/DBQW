using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdYearProject
{
    public partial class frmMain : Form
    {
        List<Databases> databases;
        List<Tables> tables;
        List<Tables> selectedTables = new List<Tables>();
        List<Columns> columns;
        List<string> SqlQueryList;
        List<string> selectedColumns = new List<string>();
        List<string> selectedListofColumns = new List<string>();
        List<string> conditionList = new List<string>();
        Dictionary<string, List<string>> columnDictionary = new Dictionary<string, List<string>>();

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
        }

       public void DisableComponenets()
        {
            tbcExstra.Enabled = false;
            cmbTables.Enabled = false;
            tvEntities.Enabled = false;
            btnAddsSource.Enabled = false;
            btnRemove.Enabled = false;

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

        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
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
            SqlQueryList = (List<string>)lstDisplay.DataSource;
            lstDisplay.DataSource =  SqlQueryList.SqlQueryBuilderAlgorithm("USE DATABASE", cmbDatabaseList.SelectedValue.ToString());
             
        }

        int item = 0;
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvEntities.Enabled = true;
            btnAddsSource.Enabled = true;
            btnRemove.Enabled = true;
            bool found = false;
            Tables newTable = (Tables)cmbTables.SelectedItem;
            if(item != 0)
            {
                foreach(Tables sItem in selectedTables)
                {
                    if (sItem.TableNames == newTable.TableNames)
                    {
                        found = true;
                    }
                }
                if (found == true)
                {
                    MessageBox.Show("Cant add the same Column", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (found == false)
            {
                selectedTables.Add(new Tables(newTable.TableNames));
                tvEntities.Nodes.Add(newTable.TableNames);
                Columns column = new Columns();
                columns = column.GetColumns(cmbDatabaseList.SelectedValue.ToString(), newTable.TableNames.ToString());
                foreach (Columns dataItem in columns)
                {
                    tvEntities.Nodes[item].Nodes.Add(dataItem.ColumnName);
                }
                item++;
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void mnuSelect_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuSelect);
            RemoveUnneccassary();
            AddTabsForSelect();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuDelete);
            RemoveUnneccassary();
            AddTabsForDelete();

        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuUpdate);
            RemoveUnneccassary();
            AddTabsForUpdate();
        }

        private void cblEntities_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // bruuuuuuuuuuuuu
            // sup bruuuuuuuuu
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //TreeNode[] nodes = tvEntities.Nodes.Find(tvEntities.SelectedNode.ToString(), true);

            foreach (TreeNode item in tvEntities.Nodes)
            {
                foreach (TreeNode treeNode in item.Nodes)
                {
                    try
                    {
                        if (treeNode.Checked != false)
                        {

                            treeNode.Remove();
                        }
                    }
                    catch (NullReferenceException)
                    {


                    }
                   
                    
                }

                if (item.Checked==true || (item.GetNodeCount(true))==0)
                {
                    item.Remove();

                    columnDictionary.Remove(item.Text.ToString());
                }
            }
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

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuInsert);
            //SqlQueryList = (List<string>)lstDisplay.DataSource;
            //lstDisplay.DataSource = SqlQueryList.SqlQueryBuilderAlgorithm("INSERT");
            RemoveUnneccassary();
            AddTabsForInsert();
           

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public void MenuStripColour(ToolStripMenuItem SelectedItem)
        {
            mnuSelect.BackColor = Color.Transparent;
            mnuInsert.BackColor = Color.Transparent;
            mnuDelete.BackColor = Color.Transparent;
            mnuUpdate.BackColor = Color.Transparent;
            SelectedItem.BackColor = Color.Blue;
        }

        private void BtnAddsSource_Click(object sender, EventArgs e)
        {
            tbcExstra.Enabled = true;
            foreach (TreeNode item in tvEntities.Nodes)
            {
               
                selectedColumns.Clear();
                foreach (TreeNode treeNode in item.Nodes)
                {
                   
                    if (treeNode.Checked==true)
                    {
                        if (!columnDictionary.ContainsKey(item.Text.ToString()))
                        {
                            columnDictionary.Add(item.Text.ToString(), new List<string>());
                            columnDictionary[item.Text.ToString()].Add(treeNode.Text.ToString());
                        }
                        else {
                            columnDictionary[item.Text.ToString()].Add(treeNode.Text.ToString());
                        }
                        
                        
                    }
                }
              
            }
            selectedListofColumns.Clear();
            foreach (KeyValuePair<string,List<string>> item in columnDictionary)
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

        private void CmbSourceTableJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {
                if (cmbSourceTableJoin.SelectedItem.ToString()==item.Key)
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
                lstWhereItems.Items.Add(string.Format("{0}{1}{2}", columnName, condition, value));

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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string columnName = cmbOrderColumns.SelectedItem.ToString();


                if (cmbOrderType.SelectedItem.ToString() == "Select Order Type")
                {

                    throw new NullReferenceException();
                }
                string sortType = cmbOrderType.SelectedItem.ToString();
                lstOrderedItems.Items.Add(string.Format("{0} {1}", columnName, sortType));
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
            


            lstGroupedItems.Items.Add(string.Format("{0}", columnName));
        }

        private void BtnRemoveGroupBy_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstGroupedItems.SelectedIndex;

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

                lstHavingItems.Items.Add(string.Format("{0}{1}{2}", columnName, condition, value));
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

                lstInsertItems.Items.Add(string.Format("Table:{0} Column:{1} Value:{2}", table,columnName, value));
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

                lstSetitems.Items.Add(string.Format("{0}{1}{2}", columnName, condition, value));
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveSetItems_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstSetitems.SelectedIndex;

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
    }
}
