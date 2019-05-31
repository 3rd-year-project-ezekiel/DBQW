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
            dropAuthentication.DataSource = authentication;
            dropAuthentication.SelectedIndex = 0;
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
            if(dropAuthentication.SelectedIndex == 0)
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

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string conType = "";

            if (dropAuthentication.SelectedIndex == 1)
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

            Accounts accounts = new Accounts(username, password, conType);
            bool verified = accounts.LoginAccount(txtServerName.Text);

            if (verified)
            {
                MessageBox.Show("Login successful!");

            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
