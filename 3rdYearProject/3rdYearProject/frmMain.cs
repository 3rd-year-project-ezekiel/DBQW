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

            SqlQueryList = (List<string>)lstDisplay.DataSource;
            lstDisplay.DataSource =  SqlQueryList.SqlQueryBuilderAlgorithm("USE DATABASE", cmbDatabaseList.SelectedValue.ToString());
             
        }

        int item = 0;
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            // bruuuuuuuuuuuuu
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TreeNode[] nodes = tvEntities.Nodes.Find(tvEntities.SelectedNode.ToString(), true);
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
    }
}
