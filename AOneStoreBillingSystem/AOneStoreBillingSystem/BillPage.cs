﻿using BusinessLayer;
using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
{
    public partial class BillPage : Form
    {
        private Cashier cashier;
        private List<StockDetail> availableProducts;
        private BackgroundWorker backgroundWorker;
        private PrintDocument pdoc = null;
        private decimal totalCostPrice;
        private decimal totalProfit;
        private StockDetail selectedProductForBill;
        private PrintReceipt printReceipt;

        public BillPage()
        {
            InitializeComponent();
            cashier = new Cashier();
            backgroundWorker = new BackgroundWorker();
        }

        private void BillPage_Load(object sender, EventArgs e)
        {
            Bill_Number_textBox.Text = cashier.GetCurrentBillNumber();
            BillDate_textBox.Text = DateTime.Today.ToString("dd-MM-yyyy");
            Product_Search_ListBox.Focus();
        }

        private void Product_Search_Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            availableProducts = cashier.GetAllProducts();
        }

        private void Product_Search_Textbox_TextChanged(object sender, EventArgs e)
        {
            if(ProductId_textBox.Text != string.Empty || Quantity_textBox.Text != string.Empty)
            {
                ProductId_textBox.Text = ProductName_textBox.Text = Price_textBox.Text = Quantity_textBox.Text = MRP_textBox.Text = string.Empty;
                DisableSelectedContentInGridview();
            }

            Product_Search_ListBox.Items.Clear();
            if (Product_Search_Textbox.Text.Length == 0)
            {
                ProductId_textBox.Text = string.Empty;
                ProductName_textBox.Text = string.Empty;
                Price_textBox.Text = string.Empty;
                Quantity_textBox.Text = string.Empty;
                MRP_textBox.Text = string.Empty;
                HideResults();
                return;
            }

            foreach (StockDetail searchedProduct in availableProducts)
            {
                if (searchedProduct.ProductName.ToLower().StartsWith(Product_Search_Textbox.Text.ToLower()) ||
                    searchedProduct.ProductDescription.ToLower().Contains(Product_Search_Textbox.Text.ToLower()) ||
                    searchedProduct.ProductId.ToString().Contains(Product_Search_Textbox.Text))
                {
                    Product_Search_ListBox.Items.Add(searchedProduct.ProductName);
                    Product_Search_ListBox.Visible = true;
                }
            }
        }

        void HideResults()
        {
            Product_Search_ListBox.Visible = false;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Product_Search_Textbox.Focus();
            int validationCheck;
            if (DisableSelectedContentInGridview(true))
            {
                if (Quantity_textBox.Text == string.Empty || !int.TryParse(Quantity_textBox.Text, out validationCheck) || Quantity_textBox.Text == "0")
                {
                    Error_Message_Label.Text = Constants.ENTER_VALID_QUANTITY_ERROR_MESSAGE;
                    HideWarningMessage();
                }
                else if(Convert.ToInt64(Quantity_textBox.Text) <= Convert.ToInt64(QuantityAvailableTextBox.Text))
                {
                    Error_Message_Label.Text = "Entered Quantity is greater than Available Quantity";
                    HideWarningMessage();
                }
                else
                {
                    BilledProducts_GridView.SelectedRows[0].Cells[3].Value = Quantity_textBox.Text;
                    BilledProducts_GridView.SelectedRows[0].Cells[5].Value = MRP_textBox.Text;
                    BilledProducts_GridView.SelectedRows[0].Cells[6].Value = Convert.ToDecimal(BilledProducts_GridView.SelectedRows[0].Cells[4].Value) * Convert.ToInt32(Quantity_textBox.Text) - ((Convert.ToDecimal(BilledProducts_GridView.SelectedRows[0].Cells[4].Value) * Convert.ToInt32(Quantity_textBox.Text)) / 100);
                    BilledProducts_GridView_RowsRemoved();
                    DisableSelectedContentInGridview();
                    AssignEmptyToAvailableTextboxes();
                }
            }
            else
            {
                if (ProductId_textBox.Text == string.Empty)
                {
                    Error_Message_Label.Text = Constants.SELECT_ANY_PRODUCT_ERROR_MESSAGE;
                    HideWarningMessage();
                }
                else if (Quantity_textBox.Text == string.Empty || !int.TryParse(Quantity_textBox.Text, out validationCheck) || Quantity_textBox.Text == "0")
                {
                    Error_Message_Label.Text = Constants.ENTER_VALID_QUANTITY_ERROR_MESSAGE;
                    HideWarningMessage();
                }
                else if (Convert.ToInt64(QuantityAvailableTextBox.Text) < Convert.ToInt64(Quantity_textBox.Text))
                {
                    Error_Message_Label.Text = "Entered Quantity is greater than Available Quantity";
                    HideWarningMessage();
                }
                else
                {
                    this.BilledProducts_GridView.Rows.Add((BilledProducts_GridView.Rows.Count + 1).ToString(), ProductId_textBox.Text, ProductName_textBox.Text, Quantity_textBox.Text, Price_textBox.Text, MRP_textBox.Text, int.Parse(Quantity_textBox.Text) * decimal.Parse(Price_textBox.Text));
                    totalCostPrice += Convert.ToDecimal(Quantity_textBox.Text) * selectedProductForBill.BuyingPrice;
                    totalProfit += (Convert.ToDecimal(Quantity_textBox.Text) * selectedProductForBill.SellingPrice) - (Convert.ToDecimal(Quantity_textBox.Text) * selectedProductForBill.BuyingPrice);
                    AssignEmptyToAvailableTextboxes();

                    if (TotalBill_Amount_textBox.Text != string.Empty)
                    {
                        TotalBill_Amount_textBox.Text = (Convert.ToDecimal(TotalBill_Amount_textBox.Text) + Convert.ToDecimal(BilledProducts_GridView.Rows[BilledProducts_GridView.Rows.Count - 1].Cells[6].Value)).ToString("N", new CultureInfo("en-IN"));
                    }
                    else
                    {
                        TotalBill_Amount_textBox.Text = Convert.ToDecimal(BilledProducts_GridView.Rows[0].Cells[6].Value).ToString("N", new CultureInfo("en-IN"));
                    }
                    BilledProducts_GridView_RowsAdded();
                    if (BilledProducts_GridView.Rows.Count == 1)
                    {
                        BilledProducts_GridView.Rows[0].Selected = false;
                    }
                }
            }     
        }

        private void HideWarningMessage()
        {
            var t = new Timer();
            t.Interval = 5000; // it will Tick in 5 seconds
            t.Tick += (s, e) =>
            {
                Error_Message_Label.Text = string.Empty;
                t.Stop();
            };
            t.Start();
        }

        private void Print_Bill_Btn_Click(object sender, EventArgs e)
        {
            Product_Search_Textbox.Focus();
            if (BilledProducts_GridView.Rows.Count > 0)
            {
                Print_Bill_Btn.Enabled = Add_Product_Btn.Enabled = Remove_Btn.Enabled = Product_Search_Textbox.Enabled = Quantity_textBox.Enabled = false;               
                Error_Message_Label.Text = "UPDATING CURRENT BILL";
                printReceipt = new PrintReceipt(BilledProducts_GridView, TotalBill_Amount_textBox.Text, Bill_Number_textBox.Text);
                printReceipt.DisplayDialog();
                cashier.QuantityReductionForSelectedProduct(Bill_Number_textBox.Text, Convert.ToDecimal(TotalBill_Amount_textBox.Text), totalCostPrice, totalProfit, BilledProducts_GridView);
                Print_Bill_Btn.Enabled = Add_Product_Btn.Enabled = Remove_Btn.Enabled = Product_Search_Textbox.Enabled = Quantity_textBox.Enabled = true;
                TotalBill_Amount_textBox.Text = string.Empty;
                totalCostPrice = totalProfit = 0;
                selectedProductForBill = null;
                BilledProducts_GridView.Rows.Clear();
                BillDate_textBox.Text = DateTime.Today.ToString("dd-MM-yyyy");
                backgroundWorker.DoWork += GetCurrentBillNumber;
                backgroundWorker.RunWorkerCompleted += WriteCurrentBillNumberTextBox;
                StartToGetCurrentBillNumber();
                HideWarningMessage();
            }
            else
            {
                Error_Message_Label.Text = "Add Products For Bill";
                HideWarningMessage();
            }        
        }
             
        private void BilledProducts_GridView_RowsAdded()
        {
            if (BilledProducts_GridView.Rows.Count > 1)
            {
                for (int i = 0; i < BilledProducts_GridView.Rows.Count - 1; i++)
                {
                    if (BilledProducts_GridView.Rows[BilledProducts_GridView.Rows.Count - 1].Cells[1].Value.Equals(BilledProducts_GridView.Rows[i].Cells[1].Value))
                    {
                        BilledProducts_GridView.Rows[i].Cells[3].Value = Convert.ToDouble(BilledProducts_GridView.Rows[i].Cells[3].Value) + Convert.ToDouble(BilledProducts_GridView.Rows[BilledProducts_GridView.Rows.Count - 1].Cells[3].Value);
                        BilledProducts_GridView.Rows[i].Cells[6].Value = Convert.ToDecimal(BilledProducts_GridView.Rows[i].Cells[6].Value) + Convert.ToDecimal(BilledProducts_GridView.Rows[BilledProducts_GridView.Rows.Count - 1].Cells[6].Value);
                        BilledProducts_GridView.Rows.Remove(BilledProducts_GridView.Rows[BilledProducts_GridView.Rows.Count - 1]);
                        break;
                    }
                }
            }
        }

        private void GetCurrentBillNumber(object sender, DoWorkEventArgs e)
        {
            e.Result = cashier.GetCurrentBillNumber();
        }

        private void WriteCurrentBillNumberTextBox(object sender, RunWorkerCompletedEventArgs e)
        {
            string currentBillNumber = (string)e.Result;
            Bill_Number_textBox.Text = currentBillNumber;
        }

        private void StartToGetCurrentBillNumber()
        {
            var t = new Timer();
            t.Interval = 5000; // it will Tick in 5 seconds
            t.Tick += (s, e) =>
            {
                backgroundWorker.RunWorkerAsync();
                t.Stop();
            };
            t.Start();
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            if(BilledProducts_GridView.SelectedRows.Count > 0)
            {
                double selectedProductId = Convert.ToDouble(BilledProducts_GridView.SelectedRows[0].Cells[1].Value);
                StockDetail selectedProduct = cashier.GetAllProducts().Single(obj => obj.ProductId == selectedProductId);
                totalCostPrice -= Convert.ToDecimal(BilledProducts_GridView.SelectedRows[0].Cells[3].Value) * selectedProduct.BuyingPrice;
                totalProfit -= (Convert.ToDecimal(BilledProducts_GridView.SelectedRows[0].Cells[3].Value) * selectedProduct.SellingPrice) - (Convert.ToDecimal(BilledProducts_GridView.SelectedRows[0].Cells[3].Value) * selectedProduct.BuyingPrice);
                BilledProducts_GridView.Rows.Remove(BilledProducts_GridView.SelectedRows[0]);              
                BilledProducts_GridView_RowsRemoved();
                DisableSelectedContentInGridview();
                AssignEmptyToAvailableTextboxes();
            } 
            else
            {
                Error_Message_Label.Text = "Select Any Billed Product To Remove";
                HideWarningMessage();
            }         
        }

        private void BilledProducts_GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedBilledProduct = BilledProducts_GridView.SelectedCells;
            if (selectedBilledProduct != null)
            {
                ProductId_textBox.Text = selectedBilledProduct[1].Value.ToString();
                ProductName_textBox.Text = selectedBilledProduct[2].Value.ToString();
                Quantity_textBox.Text = selectedBilledProduct[3].Value.ToString();
                Price_textBox.Text = selectedBilledProduct[4].Value.ToString();
                MRP_textBox.Text = selectedBilledProduct[5].Value.ToString();
            }
        }

        private void BilledProducts_GridView_RowsRemoved()
        {
            decimal totalBill = 0;
            int serialIdUpdate = 1;
            if(BilledProducts_GridView.Rows.Count > 0)
            {
                for(int i = 0; i < BilledProducts_GridView.Rows.Count; i++)
                {
                    BilledProducts_GridView.Rows[i].Cells[0].Value = serialIdUpdate;
                    totalBill += Convert.ToDecimal(BilledProducts_GridView.Rows[i].Cells[6].Value);
                    serialIdUpdate++;
                }
                TotalBill_Amount_textBox.Text = totalBill.ToString("N", new CultureInfo("en-IN"));
            }
            else
            {
                TotalBill_Amount_textBox.Text = string.Empty;
            }
        }
                    
        private bool DisableSelectedContentInGridview(bool isCalledWhenProductAdded = false)
        {
            if (BilledProducts_GridView.Rows.Count > 0)
            {
                if (!isCalledWhenProductAdded)
                {
                    for (int i = 0; i < BilledProducts_GridView.Rows.Count; i++)
                    {
                        if (BilledProducts_GridView.Rows[i].Selected)
                        {
                            BilledProducts_GridView.Rows[i].Selected = false;
                            return true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < BilledProducts_GridView.Rows.Count; i++)
                    {
                        if (BilledProducts_GridView.Rows[i].Selected)
                        {
                            return true;
                        }
                    }
                }               
            }
            return false;
        }

        private void AssignEmptyToAvailableTextboxes()
        {
            Product_Search_Textbox.Text = string.Empty;
            ProductId_textBox.Text = string.Empty;
            ProductName_textBox.Text = string.Empty;
            Price_textBox.Text = string.Empty;
            MRP_textBox.Text = string.Empty;
            Quantity_textBox.Text = string.Empty;
            QuantityAvailableTextBox.Text = string.Empty;
            Error_Message_Label.Text = string.Empty;
        }

        private void BillPage_KeyUp(object sender, KeyEventArgs e)
        {
            //DialogResult result;
            if (e.KeyCode == Keys.F2)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Take Bill?", "Final Bill", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                    Print_Bill_Btn_Click(null, null);
                Product_Search_Textbox.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if(!Product_Search_ListBox.Visible)
                {
                    Add_button_Click(null, null);
                    //Product_Search_Textbox.Focus();
                }                      
                else
                {
                    Product_Search_ListBox_MouseClick(null, null);
                    if (ProductId_textBox.Text != string.Empty)
                    {
                        Quantity_textBox.Focus();
                    }
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                if(Product_Search_ListBox.Visible && Product_Search_ListBox.Items.Count > 0)
                {
                    Product_Search_ListBox.Focus();
                }
            }
            else if (e.KeyCode == Keys.Down && Product_Search_ListBox.Items.Count > 0)
            {
                if(Product_Search_ListBox.Visible)
                {
                    Product_Search_ListBox.Focus();
                }
            }
        }

        private void Product_Search_ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Product_Search_ListBox.SelectedIndex != -1)
            {
                Product_Search_Textbox.Text = ProductName_textBox.Text = Product_Search_ListBox.Items[Product_Search_ListBox.SelectedIndex].ToString();
                availableProducts.Where(obj => obj.ProductName.Equals(Product_Search_Textbox.Text)).ToList().ForEach(obj => { selectedProductForBill = obj; ProductId_textBox.Text = obj.ProductId.ToString(); QuantityAvailableTextBox.Text = obj.QuantityAvailable.ToString(); Price_textBox.Text = obj.SellingPrice.ToString("#,##0.00"); MRP_textBox.Text = obj.MRP.ToString("#,##0.00"); });
                HideResults();
            }
            if (ProductId_textBox.Text != string.Empty)
            {
                Quantity_textBox.Focus();
            }
        }
    }
}