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
    public partial class frmData : Form
    {
        #region Form
        public frmMain mainForm;
        private List<Databases> databaseList;
        private List<Tables> tableList;

        public frmData()
        {
            InitializeComponent();

            cmbTable.Enabled = false;
            cmbDatabase.Enabled = false;

            Databases databaseClass = new Databases();
            databaseList = databaseClass.GetDatabases();
            cmbDatabase.DataSource = null;
            cmbDatabase.DataSource = databaseList;
            cmbDatabase.DisplayMember = "NameOfDatabase";
            cmbDatabase.ValueMember = "NameOfDatabase";
            cmbDatabase.SelectedIndex = -1;
            
            cmbDatabase.Enabled = true;

        }

        #endregion

        #region Form Functunality

        
        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTable.Enabled)
            {
                Tables tableName = (Tables)cmbTable.SelectedItem;
                Databases databaseName = (Databases)cmbDatabase.Items[cmbDatabase.SelectedIndex];
                Tables tableClass = new Tables();
                dgvData.DataSource = null;
                dgvData.DataSource = tableClass.GetTableContents(databaseName.NameOfDatabase, tableName.TableNames);
            }
            
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.Enabled)
            {
                cmbTable.Enabled = false;
                Databases databaseName = (Databases)cmbDatabase.Items[cmbDatabase.SelectedIndex];
                Tables tableClass = new Tables();
                tableList = tableClass.GetTables(databaseName.NameOfDatabase);
                cmbTable.DataSource = null;
                cmbTable.DataSource = tableList;
                cmbTable.DisplayMember = "tableNames";
                cmbTable.ValueMember = "tableNames";
                cmbTable.SelectedIndex = -1;
                cmbTable.Enabled = true;
                dgvData.DataSource = null;
            }
                
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            this.Close();
        }
        #endregion
    }
}
