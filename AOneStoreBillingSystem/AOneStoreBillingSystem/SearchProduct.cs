using BusinessLayer;
using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
{
    public partial class SearchProduct : Form
    {
        private Admin admin;
        private BackgroundWorker backgroundWorkerForStock;
        private string selectedProductId;
        private StockDetail selectedProductDetails;
        public SearchProduct()
        {
            admin = new Admin();
            InitializeComponent();
            ProductIDorNameTextBox.Focus();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AllProduct_ListView.Items.Clear();
            int i = 1;
            List<StockDetail> allProduct = admin.GetAllStockDetails();
            if (allProduct.Count > 0)
            {
                if (ProductIDorNameLabel.Text != string.Empty)
                {
                    foreach (StockDetail searchedProd in allProduct)
                    {
                        if (searchedProd.ProductName.ToLower().Contains(ProductIDorNameTextBox.Text.ToLower()) || searchedProd.ProductDescription.ToLower().Contains(ProductIDorNameTextBox.Text.ToLower()) || searchedProd.ProductId.ToString().Contains(ProductIDorNameTextBox.Text))
                        {
                            AllProduct_ListView.Items.Add(new ListViewItem(new string[] { (i++).ToString(), searchedProd.ProductId.ToString(), searchedProd.ProductName.ToString(), searchedProd.BuyingPrice.ToString(), searchedProd.SellingPrice.ToString(), searchedProd.MRP.ToString(), searchedProd.QuantityAvailable.ToString() }));
                        }
                    }
                }
                ProductIDorNameTextBox.Text = string.Empty;
            }
        }

        private void SearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter && ProductIDorNameTextBox.Focused == true)
            {
                SearchButton_Click(null, null);
            }
            if (e.KeyCode == Keys.Enter && AllProduct_ListView.Focused == true)
            {
                AllProduct_ListView_Click(null, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
                if(BuyingPrice_textBox.Focused == true || SellingPrice_textBox.Focused == true || MRP_textBox.Focused == true || Quantity_textBox.Focused == true)
                {
                    UpdateProduct_button_Click(null, null);
                }
            }
        }
       
        private void AllProduct_ListView_Click(object sender, EventArgs e)
        {
            BuyingPrice_textBox.Focus();
            UpdateProduct_button.Enabled = true;
            var selectedProduct = AllProduct_ListView.SelectedItems;
            selectedProductId = selectedProduct[0].SubItems[1].Text;

            if (!backgroundWorkerForStock.IsBusy)
            {
                backgroundWorkerForStock = new BackgroundWorker();
                backgroundWorkerForStock.DoWork += GetSelecetdProductDetails;
                backgroundWorkerForStock.RunWorkerCompleted += LoadDataIntoTextBoxesForSelectedProduct;
                backgroundWorkerForStock.RunWorkerAsync();
            }
            else
            {
                backgroundWorkerForStock.CancelAsync();
                backgroundWorkerForStock.RunWorkerAsync();
            }
        }

        private void GetSelecetdProductDetails(object sender, DoWorkEventArgs e)
        {
            StockDetail selectedCashierDetails = admin.GetSelectedProductDetails(int.Parse(selectedProductId));
            e.Result = selectedCashierDetails;
        }

        private void LoadDataIntoTextBoxesForSelectedProduct(object sender, RunWorkerCompletedEventArgs e)
        {
            selectedProductDetails = (StockDetail)e.Result;
            BuyingPrice_textBox.Text = selectedProductDetails.BuyingPrice.ToString();
            SellingPrice_textBox.Text = selectedProductDetails.SellingPrice.ToString();
            MRP_textBox.Text = selectedProductDetails.MRP.ToString();
            Quantity_textBox.Text = selectedProductDetails.QuantityAvailable.ToString();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            backgroundWorkerForStock = new BackgroundWorker();
            backgroundWorkerForStock.RunWorkerAsync();
        }

        private void UpdateProduct_button_Click(object sender, EventArgs e)
        {
            AllProduct_ListView.Items.Clear();
            if (!string.IsNullOrEmpty(BuyingPrice_textBox.Text) && !string.IsNullOrEmpty(SellingPrice_textBox.Text) && !string.IsNullOrEmpty(MRP_textBox.Text) && !string.IsNullOrEmpty(Quantity_textBox.Text))
            {
                if (!selectedProductDetails.SellingPrice.Equals(SellingPrice_textBox.Text) || !selectedProductDetails.BuyingPrice.Equals(BuyingPrice_textBox.Text) || !selectedProductDetails.QuantityAvailable.Equals(Quantity_textBox.Text) || !selectedProductDetails.MRP.Equals(MRP_textBox.Text))
                {
                    BackgroundWorker backgroundWorker = new BackgroundWorker();
                    backgroundWorker.DoWork += UpdateProductDetails;
                    backgroundWorker.RunWorkerCompleted += UpdateProcductDetailsCompleted;
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(Constants.PRODUCT_DETAILS_NOT_EDITED);
                }
            }
            else
            {
                MessageBox.Show(Constants.ENTER_ALL_TEXTFIELD_MESSAGE);
            }
        }

        private void UpdateProductDetails(object sender, DoWorkEventArgs e)
        {
            e.Result = admin.UpdateProductDetails(int.Parse(selectedProductDetails.ProductId.ToString()), Convert.ToDecimal(BuyingPrice_textBox.Text), Convert.ToDecimal(SellingPrice_textBox.Text), Convert.ToDecimal(MRP_textBox.Text), int.Parse(Quantity_textBox.Text));
            if ((bool)e.Result)
            {
                MessageBox.Show("Update Successfully");
                selectedProductDetails.BuyingPrice = Convert.ToDecimal(BuyingPrice_textBox.Text);
                selectedProductDetails.SellingPrice = Convert.ToDecimal(SellingPrice_textBox.Text);
                selectedProductDetails.MRP = Convert.ToDecimal(MRP_textBox.Text);
                selectedProductDetails.QuantityAvailable = int.Parse(Quantity_textBox.Text);
            }
        }

        private void UpdateProcductDetailsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;
            AllProduct_ListView.Items.Add(new ListViewItem(new string[] { (i++).ToString(), selectedProductDetails.ProductId.ToString(), selectedProductDetails.ProductName.ToString(), selectedProductDetails.BuyingPrice.ToString(), selectedProductDetails.SellingPrice.ToString(), selectedProductDetails.MRP.ToString(), selectedProductDetails.QuantityAvailable.ToString() }));
            BuyingPrice_textBox.Text = SellingPrice_textBox.Text = MRP_textBox.Text = Quantity_textBox.Text = string.Empty;
        }

        private void AllProduct_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = AllProduct_ListView.Columns[e.ColumnIndex].Width;
        }
    }
}