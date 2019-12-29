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
    public partial class HomePage : Form
    {
        private bool isAnyButtonClicked = false;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            new Admin().CheckDbConnection();
        }

        private void Admin_Btn_Click(object sender, EventArgs e)
        {
            isAnyButtonClicked = true;
            this.Hide();
            AdminLogin adminPage = new AdminLogin();
            adminPage.Show();           
        }

        private void Cashier_Btn_Click(object sender, EventArgs e)
        {
            isAnyButtonClicked = true;
            this.Hide();
            CashierLogin cashierLoginPage = new CashierLogin();
            cashierLoginPage.Show();           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAnyButtonClicked && sender != null && string.Equals((sender as Form).Name, "HomePage"))
            {
                Application.Exit();
            }
        }
    }
}
