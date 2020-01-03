using CommonClasses;
using BusinessLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;

namespace AOneStoreBillingSystem
{
    public partial class TransactionDetails : Form
    {
        private Admin admin;

        public TransactionDetails()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void TransactionDetail_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = TransactionDetail_ListView.Columns[e.ColumnIndex].Width;
        }

        private void GetDetails_button_Click(object sender, EventArgs e)
        {
            TotalBillAmount_Textbox.Text = TotalCostPrice_Textbox.Text = TotalProfitAmount_Textbox.Text = string.Empty;
            TransactionDetail_ListView.Items.Clear();
            DateTime fromDate = FromDateDatePicker.Value;
            DateTime toDate = ToDateDatePicker.Value;
            List<SalesDetail> listOfSalesDetailfromSelectedDate = admin.GetSalesDetailsForSelectedDate(fromDate, toDate);
            if (listOfSalesDetailfromSelectedDate.Count > 0)
            {
                int i = 1;
                TotalBillAmount_Textbox.Text = TotalCostPrice_Textbox.Text = TotalProfitAmount_Textbox.Text = "0";
                foreach (var item in listOfSalesDetailfromSelectedDate)
                {
                    TransactionDetail_ListView.Items.Add(new ListViewItem(new string[] { (i++).ToString(), item.SalesDate.ToString("dd-MM-yyyy"), item.BillNos.ToString(), item.TotalBillAmount.ToString(), item.TotalCostPrice.ToString(), item.ProfitAmount.ToString() }));              
                    TotalProfitAmount_Textbox.Text = (Convert.ToDecimal(TotalProfitAmount_Textbox.Text) + item.ProfitAmount).ToString();
                    TotalBillAmount_Textbox.Text = (Convert.ToDecimal(TotalBillAmount_Textbox.Text) + item.TotalBillAmount).ToString();
                    TotalCostPrice_Textbox.Text = (Convert.ToDecimal(TotalCostPrice_Textbox.Text) + item.TotalCostPrice).ToString();
                }
            }
        }

        private void TransactionDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetDetails_button_Click(null, null);
            }
        }
    }
}
