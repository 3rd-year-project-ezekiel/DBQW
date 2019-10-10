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
    public partial class frmDatabaseCreation : Form
    {
        Databases database = new Databases();
        private List<string> creationDetails = new List<string>();
        string filePath = string.Empty;
        public frmDatabaseCreation()
        {
            InitializeComponent();
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

            bool validated = Validation(creationDetails);

            if (validated==true)
            {
                MessageBox.Show("Please provide all details to the text boxes","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                
                if (database.CreateDatabase(creationDetails))
                {
                    MessageBox.Show("Database have been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    frmTableCreation tableCreation = new frmTableCreation();
                    this.Hide();
                    tableCreation.Show();
                }
                else
                {
                    MessageBox.Show("Failed to create Database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            


        }

        public bool Validation(List<string> checkList)
        {
            bool empty = false;
            foreach (string item in checkList)
            {
                if (item.ToString()=="")
                {
                    empty = true;
                }
            }

            return empty;
        }

        private void BtnFilePath_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                txtFile.Text = sSelectedPath;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
