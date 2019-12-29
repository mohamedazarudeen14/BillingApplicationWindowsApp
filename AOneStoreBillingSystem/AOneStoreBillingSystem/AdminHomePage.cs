using BusinessLayer;
using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
{
    public partial class AdminHomePage : Form
    {
        private string loggedInAdminId;
        public AdminHomePage(string loggedInAdminId)
        {
            this.loggedInAdminId = loggedInAdminId;
            InitializeComponent();
        }

        private void AddCashier_MenuStrip_Click(object sender, EventArgs e)
        {
            CloseOpenedChildForm();
            EnableDisbaledMenuStripItem();
            AddCashierPage addCashier = new AddCashierPage();
            addCashier.MdiParent = this;
            addCashier.StartPosition = FormStartPosition.CenterScreen;
            addCashier.Show();
            AddCashier_MenuStrip.Enabled = false;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.AdminLogout(loggedInAdminId);
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void StockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenedChildForm();
            EnableDisbaledMenuStripItem();
            AddStockPage addStock = new AddStockPage(loggedInAdminId);
            addStock.MdiParent = this;
            addStock.StartPosition = FormStartPosition.CenterScreen;
            addStock.Show();
            StockDetailsToolStripMenuItem.Enabled = false;
        }

        private void CloseOpenedChildForm()
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void EnableDisbaledMenuStripItem()
        {
            for(int i = 0; i < AdminHomePage_MenuStrip.Items.Count; i++)
            {
                if(!AdminHomePage_MenuStrip.Items[i].Enabled)
                {
                    AdminHomePage_MenuStrip.Items[i].Enabled = true;
                }
            }
        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenedChildForm();
            EnableDisbaledMenuStripItem();
            transactionDetailsToolStripMenuItem.Enabled = false;
            TransactionDetails transactionDetails = new TransactionDetails();
            transactionDetails.MdiParent = this;
            transactionDetails.StartPosition = FormStartPosition.CenterScreen;
            transactionDetails.Show();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | Constants.CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
