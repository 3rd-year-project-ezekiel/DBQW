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

        private void mnuInsert_Click(object sender, EventArgs e)
        {

        }

        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tables table = new Tables();
            tables = table.GetTables(databases[cmbDatabaseList.SelectedIndex].NameOfDatabase.ToString());
            foreach (Tables dataItem in tables)
            {
                cmbTables.Items.Add(dataItem.TableNames);
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblEntities.Items.Contains(tables[cmbTables.SelectedIndex].TableNames.ToString()))
            {
                MessageBox.Show("Cant add the same Column");
            }
            else
            {
                cblEntities.Items.Add(tables[cmbTables.SelectedIndex].TableNames.ToString());
            }
        }

        private void cblEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(cblEntities);
            selectedItems = cblEntities.SelectedItems;

            if (cblEntities.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    cblEntities.Items.Remove(selectedItems[i]);
            }
        }
    }
}
