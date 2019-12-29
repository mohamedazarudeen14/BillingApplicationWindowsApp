using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using CommonClasses;

namespace AOneStoreBillingSystem
{
    public partial class AdminLogin : Form
    {
        public Admin admin;
        private BackgroundWorker backgroundWorker;
        private bool isAnyButtonClicked = false;

        public AdminLogin()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void Showpassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            adminPassword_textBox.UseSystemPasswordChar = !Showpassword_checkBox.Checked;
        }

        private void adminPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            adminPassword_textBox.UseSystemPasswordChar = true;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            isAnyButtonClicked = true;
            Loginbutton.Enabled = false;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += AuthenticateAdmin;
            backgroundWorker.RunWorkerCompleted += ShowAdminHomePage;
            if (!string.IsNullOrWhiteSpace(adminUserId_textBox.Text) && !string.IsNullOrWhiteSpace(adminPassword_textBox.Text))
            {
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Admin_FillAllFields");
                Loginbutton.Enabled = true;
            }
        }

        private void AuthenticateAdmin(object sender, DoWorkEventArgs e)
        {
            e.Result = admin.IsAdminAuthenticated(adminUserId_textBox.Text, adminPassword_textBox.Text);
        }

        private void ShowAdminHomePage(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isAuthenticated = (bool)e.Result;
            if (isAuthenticated)
            {
                Close();
                AdminHomePage adminHomePage = new AdminHomePage(adminUserId_textBox.Text);    
                adminHomePage.Show();
            }
            else
            {
                MessageBox.Show("Admin_InvalidUserNamePassword");
            }
            Loginbutton.Enabled = true;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            isAnyButtonClicked = true;
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void AdminLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Loginbutton_Click(null, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAnyButtonClicked && sender != null && string.Equals((sender as Form).Name, "AdminLogin"))
            {
                Application.Exit();
            }
        }
    }
}
