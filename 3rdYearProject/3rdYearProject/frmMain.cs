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
            lstDisplay.Items.Add("USE " + databases[databaseItem].NameOfDatabase);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Add("USE " + databases[databaseItem].NameOfDatabase);
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Add("USE " + databases[databaseItem].NameOfDatabase);
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

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Add("USE " + databases[databaseItem].NameOfDatabase);
        }
    }
}
