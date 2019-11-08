using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace _3rdYearProject
{
    public partial class frmSelectDataDisplay : Form
    {
        public frmSelectDataDisplay()
        {
            InitializeComponent();
        }

        public void DisplayOnDataGrid(DataTable tabel)
        {
            dgvDataDisplay.DataSource = tabel;
        }
    }
}
