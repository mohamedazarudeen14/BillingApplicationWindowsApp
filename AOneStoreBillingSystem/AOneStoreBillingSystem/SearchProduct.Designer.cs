namespace AOneStoreBillingSystem
{
    partial class SearchProduct
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
            this.ProductIDorNameLabel = new System.Windows.Forms.Label();
            this.ProductIDorNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AllProduct_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.MRP_textBox = new System.Windows.Forms.TextBox();
            this.MRP_label = new System.Windows.Forms.Label();
            this.UpdateProduct_button = new System.Windows.Forms.Button();
            this.SellingPrice_textBox = new System.Windows.Forms.TextBox();
            this.BuyingPrice_textBox = new System.Windows.Forms.TextBox();
            this.SellingPrice_lable = new System.Windows.Forms.Label();
            this.BuyingPrice_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductIDorNameLabel
            // 
            this.ProductIDorNameLabel.AutoSize = true;
            this.ProductIDorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDorNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProductIDorNameLabel.Location = new System.Drawing.Point(27, 19);
            this.ProductIDorNameLabel.Name = "ProductIDorNameLabel";
            this.ProductIDorNameLabel.Size = new System.Drawing.Size(167, 20);
            this.ProductIDorNameLabel.TabIndex = 0;
            this.ProductIDorNameLabel.Text = "Product ID or Name";
            // 
            // ProductIDorNameTextBox
            // 
            this.ProductIDorNameTextBox.Location = new System.Drawing.Point(221, 21);
            this.ProductIDorNameTextBox.Name = "ProductIDorNameTextBox";
            this.ProductIDorNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.ProductIDorNameTextBox.TabIndex = 1;
            this.ProductIDorNameTextBox.TextChanged += new System.EventHandler(this.Product_Search_Textbox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Location = new System.Drawing.Point(421, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 35);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AllProduct_ListView
            // 
            this.AllProduct_ListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.AllProduct_ListView.AutoArrange = false;
            this.AllProduct_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllProduct_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.AllProduct_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProduct_ListView.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProduct_ListView.FullRowSelect = true;
            this.AllProduct_ListView.GridLines = true;
            this.AllProduct_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AllProduct_ListView.HideSelection = false;
            this.AllProduct_ListView.LabelWrap = false;
            this.AllProduct_ListView.Location = new System.Drawing.Point(31, 228);
            this.AllProduct_ListView.Name = "AllProduct_ListView";
            this.AllProduct_ListView.Size = new System.Drawing.Size(665, 189);
            this.AllProduct_ListView.TabIndex = 48;
            this.AllProduct_ListView.UseCompatibleStateImageBehavior = false;
            this.AllProduct_ListView.View = System.Windows.Forms.View.Details;
            this.AllProduct_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.AllProduct_ListView_ColumnWidthChanging);
            this.AllProduct_ListView.Click += new System.EventHandler(this.AllProduct_ListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SI.No";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Id";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BuyingPrice";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Selling Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MRP";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(149, 182);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(216, 20);
            this.Quantity_textBox.TabIndex = 62;
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Location = new System.Drawing.Point(28, 182);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(46, 13);
            this.Quantity_label.TabIndex = 61;
            this.Quantity_label.Text = "Quantity";
            // 
            // MRP_textBox
            // 
            this.MRP_textBox.Location = new System.Drawing.Point(149, 143);
            this.MRP_textBox.Name = "MRP_textBox";
            this.MRP_textBox.Size = new System.Drawing.Size(216, 20);
            this.MRP_textBox.TabIndex = 60;
            // 
            // MRP_label
            // 
            this.MRP_label.AutoSize = true;
            this.MRP_label.Location = new System.Drawing.Point(28, 146);
            this.MRP_label.Name = "MRP_label";
            this.MRP_label.Size = new System.Drawing.Size(31, 13);
            this.MRP_label.TabIndex = 59;
            this.MRP_label.Text = "MRP";
            // 
            // UpdateProduct_button
            // 
            this.UpdateProduct_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateProduct_button.Enabled = false;
            this.UpdateProduct_button.Location = new System.Drawing.Point(421, 120);
            this.UpdateProduct_button.Name = "UpdateProduct_button";
            this.UpdateProduct_button.Size = new System.Drawing.Size(114, 29);
            this.UpdateProduct_button.TabIndex = 57;
            this.UpdateProduct_button.Text = "Update";
            this.UpdateProduct_button.UseVisualStyleBackColor = false;
            this.UpdateProduct_button.Click += new System.EventHandler(this.UpdateProduct_button_Click);
            // 
            // SellingPrice_textBox
            // 
            this.SellingPrice_textBox.Location = new System.Drawing.Point(149, 106);
            this.SellingPrice_textBox.Name = "SellingPrice_textBox";
            this.SellingPrice_textBox.Size = new System.Drawing.Size(216, 20);
            this.SellingPrice_textBox.TabIndex = 55;
            // 
            // BuyingPrice_textBox
            // 
            this.BuyingPrice_textBox.Location = new System.Drawing.Point(149, 70);
            this.BuyingPrice_textBox.Name = "BuyingPrice_textBox";
            this.BuyingPrice_textBox.Size = new System.Drawing.Size(216, 20);
            this.BuyingPrice_textBox.TabIndex = 54;
            // 
            // SellingPrice_lable
            // 
            this.SellingPrice_lable.AutoSize = true;
            this.SellingPrice_lable.Location = new System.Drawing.Point(28, 109);
            this.SellingPrice_lable.Name = "SellingPrice_lable";
            this.SellingPrice_lable.Size = new System.Drawing.Size(65, 13);
            this.SellingPrice_lable.TabIndex = 53;
            this.SellingPrice_lable.Text = "Selling Price";
            // 
            // BuyingPrice_label
            // 
            this.BuyingPrice_label.AutoSize = true;
            this.BuyingPrice_label.Location = new System.Drawing.Point(28, 73);
            this.BuyingPrice_label.Name = "BuyingPrice_label";
            this.BuyingPrice_label.Size = new System.Drawing.Size(66, 13);
            this.BuyingPrice_label.TabIndex = 52;
            this.BuyingPrice_label.Text = "Buying Price";
            // 
            // SearchProduct
            // 
            this.ClientSize = new System.Drawing.Size(722, 451);
            this.ControlBox = false;
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.MRP_textBox);
            this.Controls.Add(this.MRP_label);
            this.Controls.Add(this.UpdateProduct_button);
            this.Controls.Add(this.SellingPrice_textBox);
            this.Controls.Add(this.BuyingPrice_textBox);
            this.Controls.Add(this.SellingPrice_lable);
            this.Controls.Add(this.BuyingPrice_label);
            this.Controls.Add(this.AllProduct_ListView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProductIDorNameTextBox);
            this.Controls.Add(this.ProductIDorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SearchProduct";
            this.Load += new System.EventHandler(this.SearchProduct_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchProduct_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductIDorNameLabel;
        private System.Windows.Forms.TextBox ProductIDorNameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView AllProduct_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.TextBox MRP_textBox;
        private System.Windows.Forms.Label MRP_label;
        private System.Windows.Forms.Button UpdateProduct_button;
        private System.Windows.Forms.TextBox SellingPrice_textBox;
        private System.Windows.Forms.TextBox BuyingPrice_textBox;
        private System.Windows.Forms.Label SellingPrice_lable;
        private System.Windows.Forms.Label BuyingPrice_label;
    }
}