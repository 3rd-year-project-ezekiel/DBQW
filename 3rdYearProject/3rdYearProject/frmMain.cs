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
        public frmMain()
        {
            InitializeComponent();
            Databases database = new Databases();
            List<Databases> databases = database.GetDatabases();
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
            
        }
    }
}
