﻿using System;
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
        private Dictionary<Tables, List<Columns>> tableDetails = new Dictionary<Tables, List<Columns>>();
        private const int TVIF_STATE = 0x8;
        private const int TVIS_STATEIMAGEMASK = 0xF000;
        private const int TV_FIRST = 0x1100;
        private const int TVM_SETITEM = TV_FIRST + 63;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam,
                                                    ref TVITEM lParam);

        private List<string> variables = new List<string>();
        private string currentSetTable;
        private string currentSetDatabase;
        private int currentDatabaseIndex;
        private Dictionary<string, List<Columns>> tabTableColumnDict = new Dictionary<string, List<Columns>>();
        private List<string> varList = new List<string>();
        #endregion

        #region Global Fields

        SQLBuilder sqlBuilderClass = new SQLBuilder();

        List<Databases> databases;
        List<Tables> tables;
        List<Tables> selectedTables = new List<Tables>();
        List<Columns> columns;
        List<string> selectedColumns = new List<string>();
        List<string> selectedListofColumns = new List<string>();
        List<string> selectedListofTables = new List<string>();
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
            RevertFromProgrammabillity();
            txtSize.Hide();
            lblSize.Hide();
            cbxValue.Hide();
            cbxHavingValue.Hide();
            cbxWhereValue.Hide();
            cbxSetValue.Hide();
            cmbDataTypes.Text = "Select DataType";
            cmbDataTypes.Items.Add("Char");
            cmbDataTypes.Items.Add("VarChar");
            cmbDataTypes.Items.Add("Text");
            cmbDataTypes.Items.Add("NChar");
            cmbDataTypes.Items.Add("Int");
            cmbDataTypes.Items.Add("Money");
            cmbDataTypes.Items.Add("Time");
            cmbDataTypes.Items.Add("Date");
            mnuViews.BackColor = Color.Transparent;
            cmbProgrammingWhere.Text = "Please Select Variable";
            cmbProgrammingHaving.Text = "Please Select Variable";
            cmbProgrammingValues.Text = "Please Select Variable";
            cmbProgrammingSet.Text = "Please Select Variable";

            lblAggr.Hide();
            lblColName.Hide();
            txtColNames.Hide();
            cmbAggrgateFunctions.Hide();

            cmbAggrgateFunctions.Text = "Select Function";
            cmbAggrgateFunctions.Items.Add("Count");
            cmbAggrgateFunctions.Items.Add("Sum");
            cmbAggrgateFunctions.Items.Add("Avg");
            cmbAggrgateFunctions.Items.Add("Min");
            cmbAggrgateFunctions.Items.Add("Max");



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
            DisableComponenets();
            //MenuStripColour(mnuSelect);
            mnuProcedure.BackColor = Color.Transparent;
            
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Form Functionality
        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            int treeviewCount = tvEntities.Nodes.Count - 1;
            for (int i = treeviewCount; i >= 0; i--)
            {

                if (tvEntities.Nodes[i] != null)
                {
                    if ((tvEntities.Nodes[i].Checked == true))
                    {
                        
                        selectedTables.Remove(new Tables(tvEntities.Nodes[i].Text.ToString()));
                        
                        columnDictionary.Remove(tvEntities.Nodes[i].Text.ToString());
                        tvEntities.Nodes[i].Remove();
                     

                    }

                }
            }

            

            if (tvEntities.Nodes.Count == 0)
            {
                tvEntities.Nodes.Clear();
                item = 0;
            }
            else
            {
                item = tvEntities.Nodes.Count;
            }

            ComboBoxPopulationMethod();
            PopulateMainList();

            if (lstMainTable.Items.Count>0)
            {
                lstMainTable.SelectedIndex = 0;
            }
            else
            {
                ClearDataSources();
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
            mnuViews.Enabled = false;
            mnuSelect.Enabled = false;
            mnuInsert.Enabled = false;
            mnuDelete.Enabled = false;
            mnuUpdate.Enabled = false;

        }

        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSetDatabase != ((Databases)cmbDatabaseList.SelectedItem).NameOfDatabase)
            {
                if (lstDisplay.DataSource != null)
                {
                    if (MessageBox.Show("Are you sure you want to replace the Database, doing so will erase the Query", " warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        selectedListofColumns.Clear();
                        item = 0;
                        lstMainTable.Items.Clear();
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
                        ClearDataLists();
                        ClearDataSources();
                        tbcExstra.Enabled = false;
                    }
                    else
                    {
                        cmbDatabaseList.SelectedIndex = currentDatabaseIndex;
                    }
                }
                else
                {
                    currentSetDatabase = ((Databases)cmbDatabaseList.SelectedItem).NameOfDatabase;
                    currentDatabaseIndex = cmbDatabaseList.SelectedIndex;
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
                mnuViews.Enabled = true;
                mnuInsert.Enabled = true;
                mnuSelect.Enabled = true;
                mnuDelete.Enabled = true;
                mnuUpdate.Enabled = true;
                mnuSelect.BackColor = Color.Transparent;
                mnuInsert.BackColor = Color.Transparent;
                mnuDelete.BackColor = Color.Transparent;
                mnuUpdate.BackColor = Color.Transparent;
                mnuViews.BackColor = Color.Transparent;
                mnuProcedure.BackColor = Color.Transparent;
            }
        }

        // select a table from the table combo box and display it in the treeview
        int item = 0; // item trackes how many tables have been added to the treeview
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            // selected tables is a list that holds all of the tables that have to be displayed in the treeview
            bool found = false;
            cmbTableJoinTarget.Items.Clear();
            cmbSourceTableJoin.Items.Clear();
            Tables newTable = (Tables)cmbTables.SelectedItem; // the table selected in the combo box is stored as a new table
            if (item != 0) // if there is an item in the treeview, then check if the table selected, is already in the treeview
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
            if (found == false)    // if the table is not found then it can be added to the treeview
            {
                selectedTables.Add(new Tables(newTable.TableNames)); // adds the table to the table list and the treeview
                selectedListofTables.Add(newTable.TableNames);
                tvEntities.Nodes.Add(newTable.TableNames);  // adds the table to the treeview
                Columns column = new Columns();  
                // columns is a list of columns
                columns = column.GetColumns(cmbDatabaseList.SelectedValue.ToString(), newTable.TableNames.ToString()); // all the columns of the selected table are retrieved to add to the treeview
                int count = 0; 
                foreach (Columns dataItem in columns)
                {
                    tvEntities.Nodes[item].Nodes.Add(String.Format("{0} {1}",dataItem.ColumnName,dataItem.DataType)); // adds the column to the right table in the treeview
                    HideCheckBox(tvEntities, tvEntities.Nodes[item].Nodes[count]); // hides the checkboxes for the columns in the treeview
                    count++;
                }
                item++;
            }
        }

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

        // When menu strip(Select,Insert...) is selected, the TreeView, Add and Remove button gets activated
        public void EnableTreeAndButton()
        {
            btnAddsSource.Enabled = true;
            btnRemove.Enabled = true;
            tvEntities.Enabled = true;
        }
        
        private void BtnAddsSource_Click(object sender, EventArgs e)
        {
            try
            {
                tbcExstra.Enabled = true;
                columnDictionary.Clear();
                selectedColumns.Clear();
                foreach (TreeNode item in tvEntities.Nodes)
                {
                    if (item.Checked == true)
                    {
                        foreach (TreeNode treeNode in item.Nodes)
                        {
                            string itemString = treeNode.Text.ToString();
                            string[] splittedString = itemString.Split(' ');


                            if (!columnDictionary.ContainsKey(item.Text.ToString()))
                            {
                                columnDictionary.Add(item.Text.ToString(), new List<string>());

                                columnDictionary[item.Text.ToString()].Add(splittedString[0]);
                            }
                            else
                            {

                                columnDictionary[item.Text.ToString()].Add(splittedString[0]);
                            }



                        }
                    }
                }

                lstMainTable.Items.Clear();
                ClearDataSources();


                PopulateMainList();
                foreach (KeyValuePair<string, List<string>> tables in columnDictionary)
                {
                    cmbTableJoinTarget.Items.Add(tables.Key);
                    cmbSourceTableJoin.Items.Add(tables.Key);
                }
                lstMainTable.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a table", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public void PopulateMainList()
        {
            lstMainTable.Items.Clear();
            foreach (KeyValuePair<string, List<string>> item in columnDictionary)
            {
                lstMainTable.Items.Add(item.Key);
            }
           
        }
        //ComboBoxPopulationMethod();
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (sqlBuilderClass.ExecuteQuery())
            {
                MessageBox.Show("Query successfully executed");
                if (((string)lstDisplay.Items[2])[0] == 'S' && ((string)lstDisplay.Items[2])[1] == 'E')
                {
                    frmSelectDataDisplay frmDisplaySelectData = new frmSelectDataDisplay();
                    frmDisplaySelectData.Show();
                    frmDisplaySelectData.DisplayOnDataGrid(sqlBuilderClass.GetSelectDataExecute());
                }

            }
        }

        private void ComboBoxPopulationMethod()
        {
            // Located under Tab Mechanics
            ClearDataSources();

            //for Column Names,(Basic SQL CODE ex.Select)
            // all combo boxes recieves the list
            cmbWhereColName.DataSource = selectedListofColumns;
            cmbHavingCol.DataSource = selectedListofColumns;
            cmbOrderColumns.DataSource = selectedListofColumns;
            cmbGroupByColum.DataSource = selectedListofColumns;
            cmbSetCol.DataSource = selectedListofColumns;
            cmbInsertColumns.DataSource = selectedListofColumns;
            cmbColumnManagementList.DataSource = selectedListofColumns;
            cmbColumnsColumnName.DataSource = selectedListofColumns;

          
        }
        
        private void btnQueryCopy_Click(object sender, EventArgs e)
        {
            sqlBuilderClass.CopyQueryToClipboard();
        }
        


        #endregion

        #endregion

        #region Menu Strip

        #region Base Menu Strips ( Insert, Update, Delete, Select, Programability)
        // Procedure Menu Strip
        private void mnuProcedure_Click(object sender, EventArgs e)
        {

            
                if (mnuProcedure.BackColor == Color.Transparent)
                {
                    if (mnuViews.BackColor != Color.Transparent)
                    {

                        MenuStripColour(mnuSelect);
                        ClearDataLists();
                        RemoveUnneccassary();
                        AddTabsForSelect();
                        ClearDataLists();
                        EnableTreeAndButton();

                    }
                    mnuProcedure.BackColor = Color.LightSeaGreen;

                }
                else
                {

                   if (MessageBox.Show("All current script data will be changed if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                       mnuProcedure.BackColor = Color.Transparent;
                   }
                   else
                   {
                       return;
                   }

                }  

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.ProcedureBaseBuilder();
                AddTabsForProcedures();
                lstVarItems.Items.Clear();
                variables.Clear();
                ChangeToProgrammabillity();


        }

        // View Menu Strip
        private void mnuViews_Click(object sender, EventArgs e)
        {
            if (mnuProcedure.BackColor != Color.Transparent)
                mnuProcedure.BackColor = Color.Transparent;

            if (lstDisplay.Items.Count <= 2)
            {
                MenuStripColour(mnuViews);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForViews();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.ViewBaseBuilder(cmbTables.SelectedText);
                return;
            }

            if (MessageBox.Show("All current script data will be lost if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuStripColour(mnuViews);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForViews();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.ViewBaseBuilder(cmbTables.SelectedText);
            }

        }
        
        // Select Menu strip
        private void mnuSelect_Click(object sender, EventArgs e)
        {
          
            if (lstDisplay.Items.Count <= 3)
            {
                MenuStripColour(mnuSelect);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForSelect();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.SelectBaseBuilder(cmbTables.SelectedText);
                return;
            }


            if (MessageBox.Show("All current script data will be lost if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuStripColour(mnuSelect);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForSelect();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.SelectBaseBuilder(cmbTables.SelectedText);
            }
          //  }

            
        }

        // Delete Menu Strip
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (lstDisplay.Items.Count <= 3)
            {
                MenuStripColour(mnuDelete);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForDelete();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.DeleteBaseBuilder(cmbTables.SelectedText);
                return;
            }

            if (MessageBox.Show("All current script data will be lost if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuStripColour(mnuDelete);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForDelete();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.DeleteBaseBuilder(cmbTables.SelectedText);
            }
        }

        // Update Menu Strip
        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (lstDisplay.Items.Count <= 3)
            {
                MenuStripColour(mnuUpdate);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForUpdate();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.UpdateBaseBuilder(cmbTables.SelectedText);
                return;
            }
            if (MessageBox.Show("All current script data will be lost if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuStripColour(mnuUpdate);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForUpdate();
                ClearDataLists();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.UpdateBaseBuilder(cmbTables.SelectedText);
            }
        }

        // Insert Menu
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            if (lstDisplay.Items.Count <= 3)
            {
                MenuStripColour(mnuInsert);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForInsert();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.InsertBaseBuilder(cmbTables.SelectedText);
                return;
            }
            if (MessageBox.Show("All current script data will be lost if continued!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MenuStripColour(mnuInsert);
                ClearDataLists();
                RemoveUnneccassary();
                AddTabsForInsert();
                EnableTreeAndButton();
                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.InsertBaseBuilder(cmbTables.SelectedText);
            }
        }

        // Colour changes of the Sql Menu Strip( Select , Delete , Update , Insert )
        public void MenuStripColour(ToolStripMenuItem SelectedItem)
        {
            mnuSelect.BackColor = Color.Transparent;
            mnuInsert.BackColor = Color.Transparent;
            mnuDelete.BackColor = Color.Transparent;
            mnuUpdate.BackColor = Color.Transparent;
            mnuViews.BackColor = Color.Transparent;
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
        // button on the Menu strip, takes you to a form where you can see what is in your tabels
        private void mnuData_Click(object sender, EventArgs e)
        {
            frmData dataForm = new frmData();
            dataForm.mainForm = (frmMain)Form.ActiveForm;
            dataForm.Show();
            this.Hide();
        }

        public void ChangeToProgrammabillity()
        {
            if (mnuProcedure.BackColor != Color.Transparent)
            {
                cbxHavingValue.Show();
                cbxWhereValue.Show();
                cbxSetValue.Show();
                cbxValue.Show();
                cmbProgrammingHaving.Show();
                cmbProgrammingSet.Show();
                cmbProgrammingValues.Show();
                cmbProgrammingWhere.Show();
                DisableProgrammibillity();
            }
            else
            {
                RevertFromProgrammabillity();
            }
           
        }

        public void RevertFromProgrammabillity()
        {
            cbxHavingValue.Hide();
            cbxWhereValue.Hide();
            cbxSetValue.Hide();
            cbxValue.Hide();
            txtWhereValues.Show();
            txtInsertValues.Show();
            txtSetValues.Show();
            txtHavingValue.Show();
            cmbProgrammingHaving.Hide();
            cmbProgrammingSet.Hide();
            cmbProgrammingValues.Hide();
            cmbProgrammingWhere.Hide();
        }

        public void EnableProgrammibillity()
        {
            cmbProgrammingHaving.Enabled = true;
            cmbProgrammingSet.Enabled = true;
            cmbProgrammingValues.Enabled = true;
            cmbProgrammingWhere.Enabled = true;
        }

        public void DisableProgrammibillity()
        {
            cmbProgrammingHaving.Enabled = false;
            cmbProgrammingSet.Enabled = false;
            cmbProgrammingValues.Enabled = false;
            cmbProgrammingWhere.Enabled = false;
        }
        
        private void DatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatabaseCreation databaseCreation = new frmDatabaseCreation();
            this.Hide();
            databaseCreation.Show();
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmTableCreation tableCreation = new frmTableCreation();
            this.Hide();
            tableCreation.Show();
        }

        #endregion

        #endregion

        #region Tab Controle

        // Validation needs to be added here
        // validation to detrimine what data type the value should be

        #region Add/Remove Tabs

        // Remove Unneccassary, removes all of the tab pages
        public void RemoveUnneccassary()
        {
            tbcExstra.TabPages.Remove(tpColumnManagement);
            tbcExstra.TabPages.Remove(tpOrderBy);
            tbcExstra.TabPages.Remove(tpGroupBy);
            tbcExstra.TabPages.Remove(tpJoins);
            tbcExstra.TabPages.Remove(tpValues);
            tbcExstra.TabPages.Remove(tpHaving);
            tbcExstra.TabPages.Remove(tpWhere);
            tbcExstra.TabPages.Remove(tpSet);
            tbcExstra.TabPages.Remove(tpVariableManagement);
            tbcExstra.TabPages.Remove(tpViews);
            tbcExstra.TabPages.Remove(tpColumns);

        }

        // here the tab pages needed for (procedure, select...) are all added
        public void AddTabsForProcedures()
        {
            if (mnuProcedure.BackColor != Color.Transparent)
            {
                tbcExstra.TabPages.Add(tpVariableManagement);
            }
            else
            {
                tbcExstra.TabPages.Remove(tpVariableManagement);
            }

            if (mnuViews.BackColor != Color.Transparent)
            {
                tbcExstra.TabPages.Remove(tpVariableManagement);
                mnuProcedure.BackColor = Color.Transparent;
            }
        }

        public void AddTabsForViews()
        {
            
            try
            {
                tbcExstra.TabPages.Add(tpViews);
                tbcExstra.TabPages.Add(tpColumnManagement);
                tbcExstra.TabPages.Add(tpWhere);
                tbcExstra.TabPages.Add(tpHaving);
                tbcExstra.TabPages.Add(tpOrderBy);
                tbcExstra.TabPages.Add(tpGroupBy);
            }
            catch (Exception)
            {
            }
        }

        public void AddTabsForSelect()
        {
            
            try
            {
                tbcExstra.TabPages.Add(tpColumnManagement);
                tbcExstra.TabPages.Add(tpWhere);
                tbcExstra.TabPages.Add(tpHaving);
                tbcExstra.TabPages.Add(tpOrderBy);
                tbcExstra.TabPages.Add(tpGroupBy);
                //tbcExstra.TabPages.Add(tpJoins);     Will be added back at a later stage
                AddTabsForProcedures();
            }
            catch (Exception)
            {
            }
        }

        public void AddTabsForInsert()
        {
           
            try
            {
                tbcExstra.TabPages.Add(tpValues);
                tbcExstra.TabPages.Remove(tpWhere);
                AddTabsForProcedures();
            }
            catch (Exception)
            {
            }
        }

        public void AddTabsForUpdate()
        {
           
            try
            {
                tbcExstra.TabPages.Add(tpSet);
                tbcExstra.TabPages.Add(tpWhere);
                AddTabsForProcedures();
            }
            catch (Exception)
            {
            }
        }

        public void AddTabsForDelete()
        {
            try
            {

                tbcExstra.TabPages.Add(tpWhere);
                AddTabsForProcedures();
            }
            catch (Exception)
            {
            }
        }


        #endregion

        #region Tab Mechanics
        // Clears all the combo boxes on the tabs
        public void ClearDataSources()
        {
            cmbWhereColName.DataSource = null;
            cmbHavingCol.DataSource = null;
            cmbOrderColumns.DataSource = null;
            cmbGroupByColum.DataSource = null;
            cmbSetCol.DataSource = null;
            cmbInsertColumns.DataSource = null;
            cmbColumnManagementList.DataSource = null;
            cmbColumnsColumnName.DataSource = null;
            
        }

        // Clears all the clause lists on the tabs
        public void ClearDataLists()
        {
           // lstVarItems.Items.Clear();
            lstGroupedItems.Items.Clear();
            lstHavingItems.Items.Clear();
            lstInsertItems.Items.Clear();
            lstInsertItems.Items.Clear();
            lstJoinItems.Items.Clear();
            lstOrderedItems.Items.Clear();
            lstSetitems.Items.Clear();
            lstWhereItems.Items.Clear();
            lstColumnsItems.Items.Clear();
            lstColumnsManagement.Items.Clear();
            
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

        

        #endregion

        #region Tab Button Functionality
        private void BtnAddWhere_Click(object sender, EventArgs e)
        { //FindWhere
            try
            {

                QueryExceptionHandling queryExceptionHandling = new QueryExceptionHandling();
                string colType = "";
                string value = "";
                bool compatible = false;
                string columnName = cmbWhereColName.SelectedItem.ToString();
                string condition = cmbWhereCondition.SelectedItem.ToString();

                foreach (Columns item in columns)
                {
                    if (item.ColumnName == columnName)
                    {
                        colType = item.DataType;
                    }
                }

                if (mnuProcedure.BackColor != Color.Transparent)
                {

                    if (cbxWhereValue.Checked == false)
                    {
                        if (cmbProgrammingWhere.SelectedItem.ToString() == "Please Select Variable")
                        {
                            throw new NullReferenceException();
                        }
                        else
                        {
                            value = cmbProgrammingWhere.SelectedItem.ToString();
                            string varType = "";
                            foreach (string item in lstVarItems.Items)
                            {
                                string[] splitted = item.Split(' ');
                                if (splitted[0] == cmbProgrammingWhere.Text)
                                {
                                    varType = splitted[1];
                                }
                            }
                            compatible = queryExceptionHandling.CheckVariableCompatibility(colType, varType);
                        }
                    }
                    else
                    {
                        
                        value = txtWhereValues.Text.ToString();
                        if (value == "")
                        {
                            throw new NullReferenceException();
                        }
                        value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                        
                    }

                }
                else
                {

                    value = txtWhereValues.Text;
                    if (value == "")
                    {
                        throw new NullReferenceException();
                    }
                    value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                }

                if (value != "" && value[0] != '@')
                {
                    compatible = true;
                }

                if(compatible)
                {
                    lstWhereItems.Items.Add(string.Format("{0} {1} {2}", columnName, condition, value));

                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.WhereClauseBuilder(columnName + " " + condition + " " + value);
                    txtWhereValues.Clear();
                }
                else
                {
                    MessageBox.Show("The variable type does not match the column type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            catch (Exception f)
            {

                MessageBox.Show(f.ToString());
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
            catch (Exception f)
            {

                MessageBox.Show(f.ToString());
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
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());

            }
        }

        private void BtnAddHaving_Click(object sender, EventArgs e)
        {//FindHaving
            try
            {
                QueryExceptionHandling queryExceptionHandling = new QueryExceptionHandling();
                string colType = "";
                string value = "";
                bool compatible = false;
                string columnName = cmbHavingCol.SelectedItem.ToString();
                string condition = cmbHavingCondition.SelectedItem.ToString();
                foreach (Columns item in columns)
                {
                    if (item.ColumnName == columnName)
                    {
                        colType = item.DataType;
                    }
                }

                    if (mnuProcedure.BackColor != Color.Transparent)
                    {
                    if (cbxHavingValue.Checked == false)
                    {
                        if (cmbProgrammingHaving.SelectedItem.ToString() == "Please Select Variable")
                        {
                            throw new NullReferenceException();
                        }
                        else
                        {
                            value = cmbProgrammingHaving.SelectedItem.ToString();
                            string varType = "";
                            foreach (string item in lstVarItems.Items)
                            {
                                string[] splitted = item.Split(' ');
                                if (splitted[0] == cmbProgrammingWhere.Text)
                                {
                                    varType = splitted[1];
                                }
                            }
                            
                            compatible = queryExceptionHandling.CheckVariableCompatibility(colType, varType);
                        }
                    }
                    else
                    {
                        value = txtHavingValue.Text.ToString();
                        if (value == "")
                        {
                            throw new NullReferenceException();
                        }
                        value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                    }
                }
                else
                {

                    value = txtHavingValue.Text.ToString();
                    if (value == "")
                    {
                        throw new NullReferenceException();
                    }
                    value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                }

                if (value != "" && value[0] != '@')
                {
                    compatible = true;
                }

                if (compatible)
                {
                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.HavingClauseBuilder(columnName + " " + condition + " " + value);

                    lstHavingItems.Items.Add(string.Format("{0} {1} {2}", columnName, condition, value));
                }
                else
                {
                    MessageBox.Show("The variable type does not match the column type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
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
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
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
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void BtnAddValues_Click(object sender, EventArgs e)
        { // FindValue
            try
            {
                QueryExceptionHandling queryExceptionHandling = new QueryExceptionHandling();
                string colType = "";
                string value = "";
                bool compatible = false;
                string columnName = cmbInsertColumns.SelectedItem.ToString();
                foreach (Columns item in columns)
                {
                    if (item.ColumnName == columnName)
                    {
                        colType = item.DataType;
                    }
                }

                if (mnuProcedure.BackColor != Color.Transparent)
                {
                    if (cbxValue.Checked == false)
                    {
                        if (cmbInsertColumns.SelectedItem.ToString() == "Please Select Variable")
                        {
                            throw new NullReferenceException();
                        }
                        else
                        {
                            value = cmbProgrammingValues.SelectedItem.ToString();
                            string varType = "";
                            foreach (string item in lstVarItems.Items)
                            {
                                string[] splitted = item.Split(' ');
                                if (splitted[0] == cmbProgrammingValues.Text)
                                {
                                    varType = splitted[1];
                                }
                            }
                            
                            compatible = queryExceptionHandling.CheckVariableCompatibility(colType, varType);
                        }
                    }
                    else
                    {
                        value = txtInsertValues.Text.ToString();
                        if (value == "")
                        {
                            throw new NullReferenceException();
                        }
                        value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                    }

                }
                else
                {

                    value = txtInsertValues.Text;
                    if (value == "")
                    {
                        throw new NullReferenceException();
                    }
                    value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                }

                if (value != "" && value[0] != '@')
                {
                    compatible = true;
                }
                
                if (compatible)
                {
                    lstDisplay.DataSource = null;


                    lstDisplay.DataSource = sqlBuilderClass.InsertValue(columnName, value);

                    lstInsertItems.Items.Add(string.Format("{0} {1}", columnName, value));
                }
                else
                {
                    MessageBox.Show("The variable type does not match the column type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add/select a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
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
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void BtnAddSet_Click(object sender, EventArgs e)
        { //FindSet
            try
            {
                QueryExceptionHandling queryExceptionHandling = new QueryExceptionHandling();
                string colType = "";
                string value = "";
                bool compatible = false;
                string columnName = cmbSetCol.SelectedItem.ToString();
                foreach (Columns item in columns)
                {
                    if (item.ColumnName == columnName)
                    {
                        colType = item.DataType;
                    }
                }

                if (mnuProcedure.BackColor != Color.Transparent)
                {
                    if (cbxSetValue.Checked == false)
                    {
                        if (cmbProgrammingSet.SelectedItem.ToString() == "Please Select Variable")
                        {
                            throw new NullReferenceException();
                        }
                        else
                        {
                            value = cmbProgrammingSet.SelectedItem.ToString();
                            if (value == "")
                            {
                                throw new NullReferenceException();
                            }
                            string varType = "";
                            foreach (string item in lstVarItems.Items)
                            {
                                string[] splitted = item.Split(' ');
                                if (splitted[0] == cmbProgrammingSet.Text)
                                {
                                    varType = splitted[1];
                                }
                            }
                            compatible = queryExceptionHandling.CheckVariableCompatibility(colType, varType);
                        }
                    }
                    else
                    {
                        value = txtSetValues.Text.ToString();
                        if (value == "")
                        {
                            throw new NullReferenceException();
                        }
                        value = queryExceptionHandling.CheckDataTypeMatch(colType, value);
                    }
                }
                else
                {
                    value = txtSetValues.Text.ToString();
                    if (value == "")
                    {
                        throw new NullReferenceException();
                    }
                    value = queryExceptionHandling.CheckDataTypeMatch(colType, value);

                }

                if (value != "" && value[0] != '@')
                {
                    compatible = true;
                }


                if (compatible)
                {
                    string condition = "=";
                    
                    string tempValueHolder = string.Format("{0} {1} {2}", cmbSetCol.Text, condition, value);

                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.UpdateSet(tempValueHolder);

                    lstSetitems.Items.Add(tempValueHolder);
                }
                else
                {
                    MessageBox.Show("The variable type does not match the column type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.UpdateRemoveSet((string)lstSetitems.SelectedItem);

                lstSetitems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string procedureName = txtProcedureName.Text;
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.ProcedureNameBuilder(procedureName);

        }

        private void BtnRemoveVariables_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstVarItems.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.ProcedureRemoveVarible((string)lstVarItems.SelectedItem);

                lstVarItems.Items.RemoveAt(selectedIndex);
                variables.RemoveAt(selectedIndex);
                if (lstVarItems.Items.Count == 0)
                {
                    DisableProgrammibillity();
                    cmbProgrammingSet.DataSource = null;
                    cmbProgrammingHaving.DataSource = null;
                    cmbProgrammingWhere.DataSource = null;
                    cmbProgrammingValues.DataSource = null;
                    cmbProgrammingWhere.Text = "Please Select Variable";
                    cmbProgrammingHaving.Text = "Please Select Variable";
                    cmbProgrammingValues.Text = "Please Select Variable";
                    cmbProgrammingSet.Text = "Please Select Variable";
                }
               

                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtVarName.Text;
                string datatype = cmbDataTypes.SelectedItem.ToString();

                if (name == "" || datatype == "Select DataType")
                {
                    throw new NullReferenceException();
                }
                string query = "";

                if (txtSize.Text != "")
                {
                    int parsedValue;
                    if (!int.TryParse(txtSize.Text, out parsedValue))
                    {
                        MessageBox.Show("This is a number only field");
                        return;
                    }

                    int size = int.Parse(txtSize.Text);

                    query = string.Format("@{0} {1}({2})", name, datatype, size);

                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.ProcedureAddVaribles("@"+name + " " + datatype,size.ToString());
                    txtSize.Text = "";
                }
                else
                {
                    query = string.Format("@{0} {1}", name, datatype);

                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = sqlBuilderClass.ProcedureAddVaribles("@"+name + " " + datatype);
                }

                

                lstVarItems.Items.Add(query);
                variables.Add("@"+name);

                cmbProgrammingSet.DataSource = null;
                cmbProgrammingHaving.DataSource = null;
                cmbProgrammingWhere.DataSource = null;
                cmbProgrammingValues.DataSource = null;


                cmbProgrammingSet.DataSource = variables;
                cmbProgrammingHaving.DataSource = variables;
                cmbProgrammingWhere.DataSource = variables;
                cmbProgrammingValues.DataSource = variables;

                txtSize.Hide();
                lblSize.Hide();
                txtVarName.Clear();
                cmbDataTypes.Text = "Select DataType";
                if (lstVarItems.Items.Count >= 1)
                {
                    EnableProgrammibillity();
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please complete all details for variable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CmbDataTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string chosenDataType = cmbDataTypes.SelectedItem.ToString();
                if (chosenDataType == "Char")
                {
                    lblSize.Show();
                    txtSize.Show();
                }
                if (chosenDataType == "VarChar")
                {
                    lblSize.Show();
                    txtSize.Show();
                }
                if (chosenDataType == "NChar")
                {
                    lblSize.Show();
                    txtSize.Show();
                }
            }
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void CbxAggregate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAggregate.Checked==true)
            {
                lblAggr.Show();
                cmbAggrgateFunctions.Show();
            }
            else
            {
                lblAggr.Hide();
                cmbAggrgateFunctions.Hide();
            }
        }

        private void CbxAs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAs.Checked == true)
            {
                lblColName.Show();
                txtColNames.Show();
            }
            else
            {
                lblColName.Hide();
                txtColNames.Hide();
            }
        }

        private void BtnAddColumn_Click(object sender, EventArgs e)
        {
            string column = "";
            bool errorCheck = false;
           
            if (cbxAggregate.Checked && cmbAggrgateFunctions.Text == "Select Function")
            {
                MessageBox.Show("Please select function", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCheck = true;
            }
            if (cbxAs.Checked && txtColNames.Text == "" )
            {
                MessageBox.Show("Please enter a name for the column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCheck = true;
            }

            if (errorCheck)
            {
                return;
            }


            if (cmbColumnManagementList.SelectedIndex == -1)
            {
                column = "*";
            }
            else
            {
                column = cmbColumnManagementList.Items[cmbColumnManagementList.SelectedIndex].ToString();
            }
            
            if (cbxAggregate.Checked)
            {
                column = cmbAggrgateFunctions.Items[cmbAggrgateFunctions.SelectedIndex] +"(" + column + ")";
            }

            if (cbxAs.Checked)
            {
                column = column + " AS " + txtColNames.Text.Replace(' ', '_').Replace('\'','*');
            }


            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.SelectAddColumns(column);
            lstColumnsManagement.Items.Add(column);
        }

        private void BtnRemoveColumnMan_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstColumnsManagement.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.SelectRemoveColumn((string)lstColumnsManagement.SelectedItem);

                lstColumnsManagement.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception f)
            {

                MessageBox.Show(false.ToString());
            }
        }

        private void btnAddColumns_Click(object sender, EventArgs e)
        {
            try
            { 
                string columnName = cmbColumnsColumnName.SelectedItem.ToString();


                lstColumnsItems.Items.Add(string.Format("{0}", columnName));

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.SelectAddColumns(columnName);
                //txtWhereValues.Clear();

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No value added.Please add a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveColumns_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstColumnsItems.SelectedIndex;

                lstDisplay.DataSource = null;
                lstDisplay.DataSource = sqlBuilderClass.SelectRemoveColumn(lstColumnsItems.SelectedItem.ToString());

                lstColumnsItems.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Item has been removed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException )
            {

                MessageBox.Show("Please Select Item", "Error: No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception)
            {

                MessageBox.Show(e.ToString(), "Contact your IT guy");
            }
        }
       
        private void btnSaveView_Click(object sender, EventArgs e)
        {
            string viewName = txtViewName.Text;
            lstDisplay.DataSource = null;
            lstDisplay.DataSource = sqlBuilderClass.ViewNameBuilder(viewName);
        }

        private void LstMainTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabTableColumnDict.Clear();
            lstDisplay.DataSource = null;


            selectedListofColumns.Clear();
            lstDisplay.DataSource = sqlBuilderClass.TableBuilder(lstMainTable.SelectedItem.ToString());
            currentSetTable = lstMainTable.SelectedItem.ToString();
            foreach (KeyValuePair<string,List<string>> tableDictionary in columnDictionary)
            {
                if (currentSetTable == tableDictionary.Key)
                {
                    foreach (string columns in tableDictionary.Value)
                    {
                        selectedListofColumns.Add(columns);
                    }
                }
                
            }
            ClearDataSources();
            ComboBoxPopulationMethod();
            Columns column = new Columns();
            List<Columns> thelist = column.GetColumns(cmbDatabaseList.SelectedValue.ToString(), currentSetTable);
            tabTableColumnDict.Add(currentSetTable, thelist);
        }

        private void CbxHavingValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHavingValue.Checked==true)
            {
                txtHavingValue.Show();
                cmbProgrammingHaving.Hide();
            }
            else
            {
                txtHavingValue.Hide();
                cmbProgrammingHaving.Show();
            }
        }

        private void CbxSetValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSetValue.Checked == true)
            {
                txtSetValues.Show();
                cmbProgrammingSet.Hide();
            }
            else
            {
                txtSetValues.Hide();
                cmbProgrammingSet.Show();
            }
        }

        private void CbxValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxValue.Checked == true)
            {
                txtInsertValues.Show();
                cmbProgrammingValues.Hide();
            }
            else
            {
                txtInsertValues.Hide();
                cmbProgrammingValues.Show();
            }
        }

        private void CbxWhereValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWhereValue.Checked == true)
            {
                txtWhereValues.Show();
                cmbProgrammingWhere.Hide();
            }
            else
            {
                txtWhereValues.Hide();
                cmbProgrammingWhere.Show();
            }
        }
        
        #endregion

        #endregion

        
    }
}
