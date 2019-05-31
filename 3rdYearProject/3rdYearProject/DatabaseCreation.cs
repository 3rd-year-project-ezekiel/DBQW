using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace _3rdYearProject
{
    public partial class frmDatabaseCreation : Form
    {
        Databases database = new Databases();
        private List<string> creationDetails = new List<string>();
        private string connectionString;
        string filePath = string.Empty;
        public frmDatabaseCreation()
        {
            InitializeComponent();
        }
        
        public frmDatabaseCreation(string connectionStringParam)
        {
            InitializeComponent();
            connectionString = connectionStringParam;
        }
        
        private void FrmDatabaseCreation_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string databaseName = txtDBName.Text;
            string filePath = txtFile.Text;
            string size = txtSize.Text;
            string logName = txtLogName.Text;
            creationDetails.Add(databaseName);
            creationDetails.Add(filePath);
            creationDetails.Add(size);
            creationDetails.Add(logName);

            database.CreateDatabase(creationDetails, connectionString);

            MessageBox.Show("Database have been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnFilePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    
                   
                }
            }
        }
    }
}
