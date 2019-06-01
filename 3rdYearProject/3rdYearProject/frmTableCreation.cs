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
    public partial class frmTableCreation : Form
    {

        string databaseName;
        List<String> tableDetails= new List<string>();
        List<String> tableColumns = new List<string>();
        private Tables table = new Tables();

        public frmTableCreation()
        {
            InitializeComponent();

        }
        public frmTableCreation(string databaseNameParam)
        {
            InitializeComponent();
            databaseName = databaseNameParam;
        }
        


        

        private void CbPrimaryKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrimaryKey.Checked)
            {
                cbUnique.Enabled = false;
                cbUnique.Checked = false;
                cbNotNull.Enabled = false;
                cbNotNull.Checked = false;
                cbForeignKey.Enabled = false;
                cbForeignKey.Checked = false;
            }
            else
            {
                cbUnique.Enabled = true;
                cbNotNull.Enabled = true;
                cbForeignKey.Enabled = true;
            }
        }

        private void CbForeignKey_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbForeignKey.Checked)
            {
                MessageBox.Show("Note:Try to create Columns with foreign keys after you already created the referenced table", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblForeignHeading.Show();
                lblRef.Show();
                lblForeignTable.Show();
                txtForeignColName.Show();
                txtForeignTable.Show();
                cbPrimaryKey.Enabled = false;
                cbPrimaryKey.Checked = false;
                cbUnique.Enabled = false;
                cbUnique.Checked = false;
                cbIdentity.Enabled = false;
                cbIdentity.Checked = false;
                cbNotNull.Enabled = false;
                cbNotNull.Checked = false;
            }
            else
            {
                lblForeignHeading.Hide();
                lblRef.Hide();
                lblForeignTable.Hide();
                txtForeignColName.Hide();
                txtForeignTable.Hide();
                cbPrimaryKey.Enabled = true;
                cbUnique.Enabled = true;
                cbIdentity.Enabled = true;
                cbNotNull.Enabled = true;
            }
        }

        private void FrmTableCreation_Load(object sender, EventArgs e)
        {
            lblForeignHeading.Hide();
            lblRef.Hide();
            lblForeignTable.Hide();
            txtForeignColName.Hide();
            txtForeignTable.Hide();

            cbxType.Items.Add("Char(10)");
            cbxType.Items.Add("VarChar(50)");
            cbxType.Items.Add("Text");
            cbxType.Items.Add("NChar(10)");
            cbxType.Items.Add("Int");
            cbxType.Items.Add("Money");
            cbxType.Items.Add("Time");
            cbxType.Items.Add("Date");
            lblStartValue.Hide();
            lblIncrement.Hide();
            txtIncrementStartValue.Hide();
            txtIncrementValue.Hide();
            lblIndeityHeading.Hide();


        }
        
        private void BtnAAddColumn_Click(object sender, EventArgs e)
        {
            string colName = txtColName.Text;
            string type = cbxType.SelectedItem.ToString();
            string constraints = "";

            if (cbIdentity.Checked)
            {
                constraints += " Identity(" + txtIncrementStartValue.Text + "," + txtIncrementValue.Text + ") ";
            }
            if (cbPrimaryKey.Checked)
            {
                constraints += " Primary Key ";
            }
            if (cbUnique.Checked)
            {
                constraints += " Unique ";
            }
            if (cbNotNull.Checked)
            {
                constraints += " Not Null ";
            }

            if (cbForeignKey.Checked)
            {
                constraints += " References "+txtForeignTable.Text+"("+txtForeignColName.Text+")";
            }

            tableDetails.Add(string.Format("{0} {1} {2}",colName,type,constraints));
            tableColumns.Add(tableDetails[0]);

            lstColumns.Items.Add(string.Format("{0} {1} {2}", colName, type, constraints));
            tableDetails.Clear();

            ResetFormForColumns();
        }

        public void ResetFormForColumns()
        {
            txtColName.Clear();
            cbxType.SelectedIndex = 0;
            cbPrimaryKey.Checked = false;
            cbForeignKey.Checked = false;
            cbNotNull.Checked = false;
            cbUnique.Checked = false;
            cbIdentity.Checked = false;

            cbPrimaryKey.Enabled = true;
            cbForeignKey.Enabled = true;
            cbNotNull.Enabled = true;
            cbUnique.Enabled = true;
            cbIdentity.Enabled = true;

            lblStartValue.Hide();
            lblIncrement.Hide();
            txtIncrementStartValue.Hide();
            txtIncrementValue.Hide();
            lblIndeityHeading.Hide();

            lblForeignHeading.Hide();
            lblRef.Hide();
            lblForeignTable.Hide();
            txtForeignColName.Hide();
            txtForeignTable.Hide();
        }

        private void CbIdentity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIdentity.Checked)
            {
                lblStartValue.Show();
                lblIncrement.Show();
                txtIncrementStartValue.Show();
                txtIncrementValue.Show();
                lblIndeityHeading.Show();
            }
            else if(!cbIdentity.Checked)
            {
                lblStartValue.Hide();
                lblIncrement.Hide();
                txtIncrementStartValue.Hide();
                txtIncrementValue.Hide();
                lblIndeityHeading.Hide();
            }
            
      
        }

        private void CbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedItem.ToString() != "Int")
            {
                cbIdentity.Checked = false;
                cbIdentity.Enabled = false;
              
            }
            if (cbxType.SelectedItem.ToString() == "Int")
            {
                cbIdentity.Checked = false;
                cbIdentity.Enabled = true;
                
            }
        }

        private void BtnRemoveColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstColumns.SelectedIndex;
            tableColumns.RemoveAt(selectedIndex);
            lstColumns.Items.RemoveAt(selectedIndex);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            string tableName = txtTableName.Text;
            if (tableName=="")
            {
                MessageBox.Show("Please enter the table name","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (lstColumns.Items.Count==0)
            {
                MessageBox.Show("Please create columns for your table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            table.AddTable(tableColumns, databaseName, tableName);

        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            this.Hide();
            mainForm.Show();
        }
    }
}
