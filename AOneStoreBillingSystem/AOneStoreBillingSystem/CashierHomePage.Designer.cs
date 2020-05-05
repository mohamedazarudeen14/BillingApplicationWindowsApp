namespace AOneStoreBillingSystem
{
    partial class CashierHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHomePage));
            this.Cashier_HomePage_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Bill_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Product_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut_Cashier_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Cashier_HomePage_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cashier_HomePage_MenuStrip
            // 
            this.Cashier_HomePage_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bill_MenuStrip,
            this.Search_Product_MenuStrip,
            this.LogOut_Cashier_MenuStrip});
            this.Cashier_HomePage_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Cashier_HomePage_MenuStrip.Name = "Cashier_HomePage_MenuStrip";
            this.Cashier_HomePage_MenuStrip.Size = new System.Drawing.Size(1354, 29);
            this.Cashier_HomePage_MenuStrip.TabIndex = 7;
            this.Cashier_HomePage_MenuStrip.Text = "menuStrip1";
            // 
            // Bill_MenuStrip
            // 
            this.Bill_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Bill_MenuStrip.Name = "Bill_MenuStrip";
            this.Bill_MenuStrip.Size = new System.Drawing.Size(43, 25);
            this.Bill_MenuStrip.Text = "Bill";
            this.Bill_MenuStrip.Click += new System.EventHandler(this.Bill_MenuStrip_Click);
            // 
            // Search_Product_MenuStrip
            // 
            this.Search_Product_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Search_Product_MenuStrip.Name = "Search_Product_MenuStrip";
            this.Search_Product_MenuStrip.Size = new System.Drawing.Size(127, 25);
            this.Search_Product_MenuStrip.Text = "Search Product";
            this.Search_Product_MenuStrip.Click += new System.EventHandler(this.Product_Information_MenuStrip_Click);
            // 
            // LogOut_Cashier_MenuStrip
            // 
            this.LogOut_Cashier_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LogOut_Cashier_MenuStrip.Name = "LogOut_Cashier_MenuStrip";
            this.LogOut_Cashier_MenuStrip.Size = new System.Drawing.Size(78, 25);
            this.LogOut_Cashier_MenuStrip.Text = "Log Out";
            this.LogOut_Cashier_MenuStrip.Click += new System.EventHandler(this.LogOut_Cashier_MenuStrip_Click);
            // 
            // CashierHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.ControlBox = false;
            this.Controls.Add(this.Cashier_HomePage_MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "CashierHomePage";
            this.Text = "CashierHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierHomePage_Load);
            this.Cashier_HomePage_MenuStrip.ResumeLayout(false);
            this.Cashier_HomePage_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Cashier_HomePage_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Bill_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Search_Product_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LogOut_Cashier_MenuStrip;
    }
}