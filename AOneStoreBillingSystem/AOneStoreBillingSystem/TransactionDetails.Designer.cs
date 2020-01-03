namespace AOneStoreBillingSystem
{
    partial class TransactionDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FromDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDetails_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetDetails_button = new System.Windows.Forms.Button();
            this.TransactionDetail_ListView = new System.Windows.Forms.ListView();
            this.SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalBillAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCostPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProfitAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total_Bill_Amount = new System.Windows.Forms.Label();
            this.Total_Cost_Price = new System.Windows.Forms.Label();
            this.Total_Profit_Amount = new System.Windows.Forms.Label();
            this.TotalBillAmount_Textbox = new System.Windows.Forms.TextBox();
            this.TotalCostPrice_Textbox = new System.Windows.Forms.TextBox();
            this.TotalProfitAmount_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FromDateDatePicker
            // 
            this.FromDateDatePicker.Location = new System.Drawing.Point(134, 71);
            this.FromDateDatePicker.Name = "FromDateDatePicker";
            this.FromDateDatePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDateDatePicker.TabIndex = 0;
            // 
            // ToDateDatePicker
            // 
            this.ToDateDatePicker.Location = new System.Drawing.Point(134, 190);
            this.ToDateDatePicker.Name = "ToDateDatePicker";
            this.ToDateDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateDatePicker.TabIndex = 1;
            // 
            // TransactionDetails_label
            // 
            this.TransactionDetails_label.AutoSize = true;
            this.TransactionDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDetails_label.Location = new System.Drawing.Point(399, 33);
            this.TransactionDetails_label.Name = "TransactionDetails_label";
            this.TransactionDetails_label.Size = new System.Drawing.Size(187, 24);
            this.TransactionDetails_label.TabIndex = 2;
            this.TransactionDetails_label.Text = "Transaction Details";
            // 
            // From_label
            // 
            this.From_label.AutoSize = true;
            this.From_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.Location = new System.Drawing.Point(44, 69);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(70, 24);
            this.From_label.TabIndex = 5;
            this.From_label.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO";
            // 
            // GetDetails_button
            // 
            this.GetDetails_button.Location = new System.Drawing.Point(143, 254);
            this.GetDetails_button.Name = "GetDetails_button";
            this.GetDetails_button.Size = new System.Drawing.Size(107, 45);
            this.GetDetails_button.TabIndex = 7;
            this.GetDetails_button.Text = "Get Details";
            this.GetDetails_button.UseVisualStyleBackColor = true;
            this.GetDetails_button.Click += new System.EventHandler(this.GetDetails_button_Click);
            // 
            // TransactionDetail_ListView
            // 
            this.TransactionDetail_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionDetail_ListView.AutoArrange = false;
            this.TransactionDetail_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionDetail_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNumber,
            this.Date,
            this.BillNumber,
            this.TotalBillAmount,
            this.TotalCostPrice,
            this.ProfitAmount});
            this.TransactionDetail_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDetail_ListView.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TransactionDetail_ListView.FullRowSelect = true;
            this.TransactionDetail_ListView.GridLines = true;
            this.TransactionDetail_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TransactionDetail_ListView.HideSelection = false;
            this.TransactionDetail_ListView.LabelWrap = false;
            this.TransactionDetail_ListView.Location = new System.Drawing.Point(403, 71);
            this.TransactionDetail_ListView.Name = "TransactionDetail_ListView";
            this.TransactionDetail_ListView.Size = new System.Drawing.Size(638, 426);
            this.TransactionDetail_ListView.TabIndex = 15;
            this.TransactionDetail_ListView.UseCompatibleStateImageBehavior = false;
            this.TransactionDetail_ListView.View = System.Windows.Forms.View.Details;
            this.TransactionDetail_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.TransactionDetail_ListView_ColumnWidthChanging);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Text = "S.NO.";
            this.SerialNumber.Width = 74;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 103;
            // 
            // BillNumber
            // 
            this.BillNumber.Text = "BillNo.";
            this.BillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillNumber.Width = 98;
            // 
            // TotalBillAmount
            // 
            this.TotalBillAmount.Text = "TotalBillAmount";
            this.TotalBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalBillAmount.Width = 115;
            // 
            // TotalCostPrice
            // 
            this.TotalCostPrice.Text = "TotalCostPrice";
            this.TotalCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalCostPrice.Width = 111;
            // 
            // ProfitAmount
            // 
            this.ProfitAmount.Text = "ProfitAmount";
            this.ProfitAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProfitAmount.Width = 133;
            // 
            // Total_Bill_Amount
            // 
            this.Total_Bill_Amount.AutoSize = true;
            this.Total_Bill_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Bill_Amount.Location = new System.Drawing.Point(45, 338);
            this.Total_Bill_Amount.Name = "Total_Bill_Amount";
            this.Total_Bill_Amount.Size = new System.Drawing.Size(125, 16);
            this.Total_Bill_Amount.TabIndex = 16;
            this.Total_Bill_Amount.Text = "Total Bill Amount";
            // 
            // Total_Cost_Price
            // 
            this.Total_Cost_Price.AutoSize = true;
            this.Total_Cost_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Cost_Price.Location = new System.Drawing.Point(45, 395);
            this.Total_Cost_Price.Name = "Total_Cost_Price";
            this.Total_Cost_Price.Size = new System.Drawing.Size(119, 16);
            this.Total_Cost_Price.TabIndex = 17;
            this.Total_Cost_Price.Text = "Total Cost Price";
            // 
            // Total_Profit_Amount
            // 
            this.Total_Profit_Amount.AutoSize = true;
            this.Total_Profit_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Profit_Amount.Location = new System.Drawing.Point(45, 455);
            this.Total_Profit_Amount.Name = "Total_Profit_Amount";
            this.Total_Profit_Amount.Size = new System.Drawing.Size(139, 16);
            this.Total_Profit_Amount.TabIndex = 18;
            this.Total_Profit_Amount.Text = "Total Profit Amount";
            // 
            // TotalBillAmount_Textbox
            // 
            this.TotalBillAmount_Textbox.Location = new System.Drawing.Point(195, 337);
            this.TotalBillAmount_Textbox.Name = "TotalBillAmount_Textbox";
            this.TotalBillAmount_Textbox.ReadOnly = true;
            this.TotalBillAmount_Textbox.Size = new System.Drawing.Size(139, 20);
            this.TotalBillAmount_Textbox.TabIndex = 19;
            // 
            // TotalCostPrice_Textbox
            // 
            this.TotalCostPrice_Textbox.Location = new System.Drawing.Point(195, 392);
            this.TotalCostPrice_Textbox.Name = "TotalCostPrice_Textbox";
            this.TotalCostPrice_Textbox.ReadOnly = true;
            this.TotalCostPrice_Textbox.Size = new System.Drawing.Size(139, 20);
            this.TotalCostPrice_Textbox.TabIndex = 20;
            // 
            // TotalProfitAmount_Textbox
            // 
            this.TotalProfitAmount_Textbox.Location = new System.Drawing.Point(195, 452);
            this.TotalProfitAmount_Textbox.Name = "TotalProfitAmount_Textbox";
            this.TotalProfitAmount_Textbox.ReadOnly = true;
            this.TotalProfitAmount_Textbox.Size = new System.Drawing.Size(139, 20);
            this.TotalProfitAmount_Textbox.TabIndex = 21;
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 552);
            this.ControlBox = false;
            this.Controls.Add(this.TotalProfitAmount_Textbox);
            this.Controls.Add(this.TotalCostPrice_Textbox);
            this.Controls.Add(this.TotalBillAmount_Textbox);
            this.Controls.Add(this.Total_Profit_Amount);
            this.Controls.Add(this.Total_Cost_Price);
            this.Controls.Add(this.Total_Bill_Amount);
            this.Controls.Add(this.TransactionDetail_ListView);
            this.Controls.Add(this.GetDetails_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.TransactionDetails_label);
            this.Controls.Add(this.ToDateDatePicker);
            this.Controls.Add(this.FromDateDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TransactionDetails";
            this.Text = "TransactionDetails";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransactionDetails_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDateDatePicker;
        private System.Windows.Forms.DateTimePicker ToDateDatePicker;
        private System.Windows.Forms.Label TransactionDetails_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetDetails_button;
        private System.Windows.Forms.ColumnHeader SerialNumber;
        private System.Windows.Forms.ColumnHeader Date;
        public System.Windows.Forms.ListView TransactionDetail_ListView;
        private System.Windows.Forms.ColumnHeader BillNumber;
        private System.Windows.Forms.ColumnHeader TotalBillAmount;
        private System.Windows.Forms.ColumnHeader TotalCostPrice;
        private System.Windows.Forms.ColumnHeader ProfitAmount;
        private System.Windows.Forms.Label Total_Bill_Amount;
        private System.Windows.Forms.Label Total_Cost_Price;
        private System.Windows.Forms.Label Total_Profit_Amount;
        private System.Windows.Forms.TextBox TotalBillAmount_Textbox;
        private System.Windows.Forms.TextBox TotalCostPrice_Textbox;
        private System.Windows.Forms.TextBox TotalProfitAmount_Textbox;
    }
}