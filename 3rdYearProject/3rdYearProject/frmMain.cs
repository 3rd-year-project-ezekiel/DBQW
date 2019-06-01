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
        List<Columns> columns;
        List<string> SqlQueryList;
        int databaseItem = 0, tableItem = 0;
        
        public frmMain()
        {
            InitializeComponent();
            Databases database = new Databases();
            databases = database.GetDatabases();
            foreach(Databases dataItem in databases)
            {
                cmbDatabaseList.Items.Add(dataItem.NameOfDatabase);
            }
        }

        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTables.Items.Clear();
            cblEntities.Items.Clear();
            Tables table = new Tables();
            databaseItem = cmbDatabaseList.SelectedIndex;
            tables = table.GetTables(databases[databaseItem].NameOfDatabase.ToString());
            foreach (Tables dataItem in tables)
            {
                cmbTables.Items.Add(dataItem.TableNames);
            }

            SqlQueryList = (List<string>)lstDisplay.DataSource;
            lstDisplay.DataSource =  SqlQueryList.SqlQueryBuilderAlgorithm("USE DATABASE", databases[databaseItem].NameOfDatabase.ToString());
             
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Will di checkbox hierachial maak met tables en columns
            tableItem = cmbTables.SelectedIndex;
            if (cblEntities.Items.Contains(tables[tableItem].TableNames.ToString()))
            {
                MessageBox.Show("Cant add the same Column");
            }
            else
            {
                cblEntities.Items.Add(tables[cmbTables.SelectedIndex].TableNames.ToString());
            }

            Columns column = new Columns();
            columns = column.GetColumns(databases[databaseItem].NameOfDatabase.ToString(), tables[cmbTables.SelectedIndex].TableNames.ToString());
            foreach (Columns dataItem in columns)
            {
                cblEntities.Items.Add(dataItem.ColumnName);
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
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuDelete);
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuUpdate);
        }

        private void cblEntities_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(cblEntities);
            selectedItems = cblEntities.SelectedItems;

            if (cblEntities.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    cblEntities.Items.Remove(selectedItems[i]);
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
            if (cmbDatabaseList.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Please select an database","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string databaseName = cmbDatabaseList.SelectedItem.ToString();
                frmTableCreation tableCreation = new frmTableCreation();
                this.Hide();
                tableCreation.Show();
            }
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            MenuStripColour(mnuInsert);
            //mnuInsert.BackColor = Color.Blue;
            SqlQueryList = (List<string>)lstDisplay.DataSource;
            //lstDisplay.DataSource = SqlQueryList.SqlQueryBuilderAlgorithm("INSERT", tables[tableItem].TableNames.ToString()+"#"+"sweet");

        }

        public void MenuStripColour(ToolStripMenuItem SelectedItem)
        {
            mnuSelect.BackColor = Color.Transparent;
            mnuInsert.BackColor = Color.Transparent;
            mnuDelete.BackColor = Color.Transparent;
            mnuUpdate.BackColor = Color.Transparent;
            SelectedItem.BackColor = Color.Blue;
        }
    }
}
