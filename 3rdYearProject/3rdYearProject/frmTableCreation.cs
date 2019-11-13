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

        #region Form Fields and Constructor
        private string databaseName;
        private Databases database = new Databases();
        private List<String> tableDetails= new List<string>();
        private List<String> tableColumns = new List<string>();
        private Tables table = new Tables();

        public frmTableCreation()
        {
            InitializeComponent();

        }

        private void FrmTableCreation_Load(object sender, EventArgs e)
        {
            pnlColumnDetails.Enabled = false;
            pnlColumns.Enabled = false;
            cbxDatabaseList.Text = "Please Select Database";

            List<Databases> databaseList = database.GetDatabases();
            foreach (Databases item in databaseList)
            {
                cbxDatabaseList.Items.Add(item.NameOfDatabase);
            }
            lblForeignHeading.Hide();
            lblRef.Hide();
            lblForeignTable.Hide();
            cbxTable.Hide();
            cbxColumn.Hide();
            cbxColumn.Enabled = false;
            txtSize.Hide();
            lblSize.Hide();
            cbxType.Text = "Select DataType";
            cbxType.Items.Add("Char()");
            cbxType.Items.Add("VarChar()");
            cbxType.Items.Add("Text");
            cbxType.Items.Add("NChar()");
            cbxType.Items.Add("Int");
            cbxType.Items.Add("Money");
            cbxType.Items.Add("Time");
            cbxType.Items.Add("Date");
            lblStartValue.Hide();
            lblIncrement.Hide();
            txtIncrementStartValue.Hide();
            txtIncrementValue.Hide();
            lblIndeityHeading.Hide();
            pnlForeign.Hide();
            pnlIdentity.Hide();
        }

        public void ResetFormForColumns()
        {
            pnlForeign.Hide();
            pnlIdentity.Hide();

            cbxColumn.Enabled = false;
            txtSize.Hide();
            lblSize.Hide();
            txtSize.Clear();
            txtColName.Clear();

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
            cbxColumn.Hide();
            cbxTable.Hide();

            cbxType.Text = "Select DataType";

        }

        private void CbxDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTable.Items.Clear();
            pnlColumnDetails.Enabled = true;
            pnlColumns.Enabled = true;
            List<Tables> tableList = table.GetTables(cbxDatabaseList.SelectedItem.ToString());
            foreach (Tables item in tableList)
            {
                cbxTable.Items.Add(item.TableNames);
            }
        }

        public void ClearTable()
        {
            txtTableName.Clear();
            lstColumns.Items.Clear();
        }

        // Back to menu Button
        private void BtnProceed_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        #endregion

        #region Column Mechanics
        // Primary Key Check Box
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

        // Foreign Key Check Box
        private void CbForeignKey_CheckedChanged(object sender, EventArgs e)
        {

            if (cbForeignKey.Checked)
            {
                MessageBox.Show("Note:Try to create Columns with foreign keys after you already created the referenced table", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblForeignHeading.Show();
                pnlForeign.Show();
                lblRef.Show();
                lblForeignTable.Show();
                cbxColumn.Show();
                cbxTable.Show();
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
                pnlForeign.Hide();
                lblForeignHeading.Hide();
                lblRef.Hide();
                lblForeignTable.Hide();
                cbxTable.Hide();
                cbxColumn.Hide();
                cbPrimaryKey.Enabled = true;
                cbUnique.Enabled = true;
                cbIdentity.Enabled = true;
                cbNotNull.Enabled = true;
            }
        }

        // Identity Check Box
        private void CbIdentity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIdentity.Checked)
            {
                pnlIdentity.Show();
                lblStartValue.Show();
                lblIncrement.Show();
                txtIncrementStartValue.Show();
                txtIncrementValue.Show();
                lblIndeityHeading.Show();
            }
            else if (!cbIdentity.Checked)
            {
                pnlIdentity.Hide();
                lblStartValue.Hide();
                lblIncrement.Hide();
                txtIncrementStartValue.Hide();
                txtIncrementValue.Hide();
                lblIndeityHeading.Hide();
            }


        }

        private void CbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.Text == "Select DataType")
            {
                txtSize.Hide();
                lblSize.Hide();
                return;
            }
            if ((cbxType.SelectedItem.ToString() == "Char()") || (cbxType.SelectedItem.ToString() == "VarChar()") || (cbxType.SelectedItem.ToString() == "NChar()"))
            {
                txtSize.Show();
                lblSize.Show();
            }
            else
            {
                txtSize.Hide();
                lblSize.Hide();
            }



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

        private void BtnAAddColumn_Click(object sender, EventArgs e)
        {
            string colName = txtColName.Text.Replace(" ", "_");
            string type = "";
            string constraints = "";

            if (cbForeignKey.Checked)
            {
                string datatype1 = cbxType.Text;
                string datatype2 = " ";
                Columns columns = new Columns();
                List<Columns> temp = new List<Columns>();
                temp = columns.GetColumns(cbxDatabaseList.Text, cbxTable.Text);
                foreach (Columns item in temp)
                {
                    if (item.ColumnName == cbxColumn.Text)
                    {
                        datatype2 = item.DataType.ToString();
                    }
                }
                if (!columns.CheckDataType(datatype1, datatype2))
                {
                    MessageBox.Show("Datatypes of the 2 columns doesnt match. Unable to create foreign key");
                    return;
                }
            }

            if (colName != "")
            {
                if (cbxType.SelectedIndex != -1)
                {
                    if ((cbxType.SelectedItem.ToString() == "Char()") || (cbxType.SelectedItem.ToString() == "VarChar()") || (cbxType.SelectedItem.ToString() == "NChar()"))
                    {
                        if (txtSize.Text != "")
                        {
                            int parsedValue;
                            if (!int.TryParse(txtSize.Text, out parsedValue))
                            {
                                MessageBox.Show("This is a number only field");
                                return;
                            }

                            int size = int.Parse(txtSize.Text);
                            string chosenDataType = cbxType.SelectedItem.ToString();
                            string[] splitSize = chosenDataType.Split('(');
                            type = splitSize[0] + "(" + txtSize.Text + splitSize[1];
                        }

                    }
                    else
                    {
                        txtSize.Hide();
                        lblSize.Hide();
                        type = cbxType.SelectedItem.ToString();
                    }

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
                        constraints += " References " + cbxTable.SelectedItem.ToString() + "(" + cbxColumn.SelectedItem.ToString() + ")";
                    }

                    tableDetails.Add(string.Format("{0} {1} {2}", colName, type, constraints));
                    tableColumns.Add(tableDetails[0]);

                    lstColumns.Items.Add(string.Format("{0} {1} {2}", colName, type, constraints));
                }
                else
                {
                    MessageBox.Show("Please select a Type!", "Empty Type");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Column Name!", "Empty Colm Name");
                return;
            }



            tableDetails.Clear();

            ResetFormForColumns();
        }

        // Foreign Key Table Combo box
        private void CbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Columns col = new Columns();
            cbxColumn.Enabled = true;
            List<Columns> listOfColumns = col.GetColumns(cbxDatabaseList.SelectedItem.ToString(), cbxTable.SelectedItem.ToString());

            cbxColumn.Items.Clear();
            foreach (Columns item in listOfColumns)
            {
                cbxColumn.Items.Add(item.ColumnName);
            }
        }

      

        #endregion

        #region Table Mechanics

        private void BtnRemoveColumn_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstColumns.SelectedIndex;
            tableColumns.RemoveAt(selectedIndex);
            lstColumns.Items.RemoveAt(selectedIndex);
        }


        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            string tableName = txtTableName.Text.Replace(" ", "_");
            if (tableName == "")
            {
                MessageBox.Show("Please enter the table name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstColumns.Items.Count == 0)
            {
                MessageBox.Show("Please create columns for your table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            databaseName = cbxDatabaseList.SelectedItem.ToString();
            if (table.AddTable(tableColumns, databaseName, tableName))
            {
                MessageBox.Show("Table Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTable();
                ResetFormForColumns();
            }
            else
            {
                MessageBox.Show("Table Failed to Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }


        #endregion
        


    }
}
