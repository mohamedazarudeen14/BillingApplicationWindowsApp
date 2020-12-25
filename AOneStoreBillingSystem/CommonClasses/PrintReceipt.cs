using System.Windows.Forms;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing;
using System;

namespace CommonClasses
{
    public class PrintReceipt
    {
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        private PrintDialog prnDialog;
        private PrintPreviewDialog prnPreview;
        private PrintDocument prnDocument;
        private Container components = null;

        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvSubTitle4;
        private string InvSubTitle5;
        private string InvSubTitle6;
        private string InvImage;

        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
        private string CustomerName;
        private string CustomerCity;
        private string SellerName;
        private string SaleID;
        private string SaleDate;
        private decimal SaleFreight;
        private decimal SubTotal;
        private decimal InvoiceTotal;
        private bool ReadInvoice;
        private int AmountPosition;

        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);

        //Bill Data
        private DataGridView billGridViwData;
        private string totalAmount;
        private string billNumber;

        public PrintReceipt(DataGridView billGridView, string totalAmount, string billNumber)
        {
            this.billGridViwData = billGridView;
            this.totalAmount = totalAmount;
            this.billNumber = billNumber;
            this.prnDialog = new PrintDialog();
            this.prnPreview = new PrintPreviewDialog();
            this.prnDocument = new PrintDocument();
            // The Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
        }

        private void ReadInvoiceHead()
        {
            //Titles and Image of invoice:
            InvTitle = "RAJKUMAR DEPARTMENTAL STORES";
            InvSubTitle1 = "751 mullai street";
            InvSubTitle2 = "new housing unit";
            InvSubTitle3 = "THANJAVUR - 5";
            InvSubTitle4 = "Contact:9865720990";
            InvSubTitle5 = "GTIN:33BLBPA5690R1ZS3";
            InvSubTitle6 = "CASH BILL";

            //InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";
        }

        private void SetInvoiceHead(Graphics g)
        {
            ReadInvoiceHead();

            CurrentY = topMargin;
            CurrentX = leftMargin;
            //int ImageHeight = 0;

            // Draw Invoice image:
            //if (System.IO.File.Exists(InvImage))
            //{
            //    Bitmap oInvImage = new Bitmap(InvImage);
            //    // Set Image Left to center Image:
            //    int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
            //    ImageHeight = oInvImage.Height; // Get Image Height
            //    g.DrawImage(oInvImage, xImage, CurrentY);
            //}

            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            int lenInvSubTitle4 = (int)g.MeasureString(InvSubTitle4, InvSubTitleFont).Width;
            int lenInvSubTitle5 = (int)g.MeasureString(InvSubTitle5, InvSubTitleFont).Width;
            int lenInvSubTitle6 = (int)g.MeasureString(InvSubTitle6, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;
            int xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2;
            int xInvSubTitle5 = CurrentX + (InvoiceWidth - lenInvSubTitle5) / 2;
            int xInvSubTitle6 = CurrentX + (InvoiceWidth - lenInvSubTitle6) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                //CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }
            if (InvSubTitle4 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle4, InvSubTitleFont, BlueBrush, xInvSubTitle4, CurrentY);
            }
            if (InvSubTitle5 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle5, InvSubTitleFont, BlueBrush, xInvSubTitle5, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Blue, 2), leftMargin, CurrentY, rightMargin, CurrentY);

            CurrentY = CurrentY + InvSubTitleHeight;
            g.DrawString(InvSubTitle6, InvSubTitleFont, BlueBrush, xInvSubTitle6, CurrentY);

            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Blue, 2), leftMargin, CurrentY, rightMargin, CurrentY);
        }

        private void SetOrderData(Graphics g)
        {// Set Company Name, City, Salesperson, Order ID and Order Date
            string FieldValue = "";
            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
            // Set Date:
            CurrentX = leftMargin;
            CurrentY = CurrentY + 8;
            FieldValue = "DATE: " + DateTime.Now;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Bill Number:
            CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            FieldValue = "BILL NO: " + billNumber;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Salesperson:
            //CurrentX = leftMargin;
            //CurrentY = CurrentY + InvoiceFontHeight;
            //FieldValue = "Salesperson: " + SellerName;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            //// Set Order ID:
            //CurrentX = leftMargin;
            //CurrentY = CurrentY + InvoiceFontHeight;
            //FieldValue = "Order ID: " + SaleID;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            //// Set Order Date:
            //CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            //FieldValue = "Order Date: " + SaleDate;
            //g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Draw line:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
        }

        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set Invoice Table:
            string FieldValue = "";
            //int CurrentRecord = 0;
            //int RecordsPerPage = 20; // twenty items in a page
            //decimal Amount = 0;
            //bool StopReading = false;

            // Set Table Head:
            int xProductID = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Product ", InvoiceFont, BlueBrush, xProductID, CurrentY);

            int xProductName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 4;
            g.DrawString("Quantity", InvoiceFont, BlueBrush, xProductName, CurrentY);

            int xUnitPrice = xProductName + (int)g.MeasureString("Product Name", InvoiceFont).Width + 72;
            g.DrawString("Price", InvoiceFont, BlueBrush, xUnitPrice, CurrentY);

            int xAmount = xUnitPrice + (int)g.MeasureString("Unit Price", InvoiceFont).Width + 4;
            g.DrawString("Amount", InvoiceFont, BlueBrush, xAmount, CurrentY);

            //int xDiscount = xAmount + (int)g.MeasureString("Quantity", InvoiceFont).Width + 4;
            //g.DrawString("Discount", InvoiceFont, BlueBrush, xDiscount, CurrentY);

            //AmountPosition = xDiscount + (int)g.MeasureString("Discount", InvoiceFont).Width + 4;
            //g.DrawString("Extended Price", InvoiceFont, BlueBrush, AmountPosition, CurrentY);

            // Set Invoice Table:
            CurrentY = CurrentY + InvoiceFontHeight + 8;

            for (int i = 0; i < billGridViwData.Rows.Count; i++)
            {
                FieldValue = billGridViwData.Rows[i].Cells[2].Value.ToString();
                if (FieldValue.Length > 20)
                    FieldValue = FieldValue.Remove(20, FieldValue.Length - 20);
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);
                FieldValue = billGridViwData.Rows[i].Cells[3].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);
                FieldValue = String.Format("{0:0.00}", billGridViwData.Rows[i].Cells[4].Value.ToString());
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xUnitPrice, CurrentY);
                FieldValue = billGridViwData.Rows[i].Cells[6].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xAmount, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;
            }
            SetInvoiceTotal(g);

            //while (CurrentRecord < RecordsPerPage)
            //{
            //    FieldValue = rdrInvoice["ProductID"].ToString();
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);
            //    FieldValue = rdrInvoice["ProductName"].ToString();
            //    // if Length of (Product Name) > 20, Draw 20 character only
            //    if (FieldValue.Length > 20)
            //        FieldValue = FieldValue.Remove(20, FieldValue.Length - 20);
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);
            //    FieldValue = String.Format("{0:0.00}", rdrInvoice["UnitPrice"]);
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xUnitPrice, CurrentY);
            //    FieldValue = rdrInvoice["Quantity"].ToString();
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity, CurrentY);
            //    FieldValue = String.Format("{0:0.00%}", rdrInvoice["Discount"]);
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xDiscount, CurrentY);

            //    Amount = Convert.ToDecimal(rdrInvoice["ExtendedPrice"]);
            //    // Format Extended Price and Align to Right:
            //    FieldValue = String.Format("{0:0.00}", Amount);
            //    int xAmount = AmountPosition + (int)g.MeasureString("Extended Price", InvoiceFont).Width;
            //    xAmount = xAmount - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
            //    g.DrawString(FieldValue, InvoiceFont, BlackBrush, xAmount, CurrentY);
            //    CurrentY = CurrentY + InvoiceFontHeight;

            //    if (!rdrInvoice.Read())
            //    {
            //        StopReading = true;
            //        break;
            //    }

            //    CurrentRecord++;
            //}

            //if (CurrentRecord < RecordsPerPage)
            //    e.HasMorePages = false;
            //else
            //    e.HasMorePages = true;

            //if (StopReading)
            //{
            //    rdrInvoice.Close();
            //    cnn.Close();
            //    SetInvoiceTotal(g);
            //}

            //g.Dispose();
        }

        private void SetInvoiceTotal(Graphics g)
        {
            // Set Invoice Total:
            // Draw line:
            CurrentY = CurrentY + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
            // Get Right Edge of Invoice:
            int xRightEdg = AmountPosition + (int)g.MeasureString("Amount", InvoiceFont).Width;

            // Write Sub Total:
            int xSubTotal = AmountPosition - (int)g.MeasureString("Sub Total", InvoiceFont).Width;
            CurrentY = CurrentY + 8;
            g.DrawString("Sub Total", InvoiceFont, RedBrush, xSubTotal, CurrentY);
            string TotalValue = String.Format("{0:0.00}", totalAmount);
            int xTotalValue = xRightEdg - (int)g.MeasureString(TotalValue, InvoiceFont).Width;
            g.DrawString(TotalValue, InvoiceFont, BlackBrush, xTotalValue, CurrentY);

            // Write Order Freight:
            int xOrderFreight = AmountPosition - (int)g.MeasureString("Round Off", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Round Off", InvoiceFont, RedBrush, xOrderFreight, CurrentY);
            decimal roundedValue = Convert.ToDecimal(totalAmount) - Math.Round(Convert.ToDecimal(totalAmount));
            string RoundOffValue = String.Format("{0:0.00}", roundedValue.ToString());
            int xFreight = xRightEdg - (int)g.MeasureString(RoundOffValue, InvoiceFont).Width;
            g.DrawString(RoundOffValue, InvoiceFont, BlackBrush, xFreight, CurrentY);

            // Write Invoice Total:
            int xInvoiceTotal = AmountPosition - (int)g.MeasureString("Invoice Total", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Invoice Total", InvoiceFont, RedBrush, xInvoiceTotal, CurrentY);
            string InvoiceValue = String.Format("{0:0.00}", Math.Round(Convert.ToDecimal(totalAmount)));
            int xInvoiceValue = xRightEdg - (int)g.MeasureString(InvoiceValue, InvoiceFont).Width;
            g.DrawString(InvoiceValue, InvoiceFont, BlackBrush, xInvoiceValue, CurrentY);
        }

        public void DisplayDialog()
        {
            try
            {
                prnDialog.Document = this.prnDocument;
                DialogResult ButtonPressed = prnDialog.ShowDialog();
                // If user Click 'OK', Print Invoice
                if (ButtonPressed == DialogResult.OK)
                    prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;

            SetInvoiceHead(e.Graphics); // Draw Invoice Head
            SetOrderData(e.Graphics); // Draw Order Data
            SetInvoiceData(e.Graphics, e); // Draw Invoice Data
        }
    }
}


