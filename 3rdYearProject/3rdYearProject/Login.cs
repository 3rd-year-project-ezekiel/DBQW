using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using BLL;

namespace _3rdYearProject
{
    public partial class Login : Form
    {
        string[] authentication = new string[2];
        
        public Login()
        {
            InitializeComponent();
            txtServerName.Text = @"LOCALHOST\SQLEXPRESS";
            authentication[0] = "Windows Authentication";
            authentication[1] = "SQL Server Authentication";
            dropAuthentication.Items = authentication;
            dropAuthentication.selectedIndex = 0;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnNavClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNavMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopNavPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void dropAuthentication_onItemSelected(object sender, EventArgs e)
        {
            if(dropAuthentication.selectedIndex == 0)
            {
                txtLogin.ReadOnly = true;
                txtLogin.BackColor = Color.Black;
                txtLogin.Text = "";
                txtPassword.ReadOnly = true;
                txtPassword.BackColor = Color.Black;
                txtPassword.Text = "";
            } else
            {
                txtLogin.ReadOnly = false;
                txtLogin.BackColor = Color.White;
                txtPassword.ReadOnly = false;
                txtPassword.BackColor = Color.White;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string conType;
            if (dropAuthentication.selectedIndex == 1)
            {
                username = txtLogin.Text;
                password = txtPassword.Text;
                conType = "SQL Server Authentication";

                if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please provide Username and Password");
                    return;
                }
            }
            else
            {
                conType = "Windows Authentication";
            }

            var connStrBldr = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStrBldr.DataSource = txtServerName.Text;
            connStrBldr.InitialCatalog = "";

            if (dropAuthentication.selectedIndex == 0)
            {
                connStrBldr.IntegratedSecurity = true;
            }
            else
            {
                connStrBldr.IntegratedSecurity = false;
                connStrBldr.UserID = accounts.UserName;
                connStrBldr.Password = accounts.Password;
            }

            bool validUser = true;

            try
            {
                using (SqlConnection con = new SqlConnection(connStrBldr.ToString()))
                {
                    con.Open();
                    //do your lookup on login here
                }
            }
            catch (SqlException) // An exception will be caught if invalid credentials were used.
            {
                validUser = false;
            }

            if (validUser)
            {
                MessageBox.Show("Login successful!");

            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
