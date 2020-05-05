﻿namespace AOneStoreBillingSystem
{
    partial class AdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            this.AdminHomePage_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddCashier_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchProduct_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminHomePage_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminHomePage_MenuStrip
            // 
            this.AdminHomePage_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCashier_MenuStrip,
            this.transactionDetailsToolStripMenuItem,
            this.StockDetailsToolStripMenuItem,
            this.SearchProduct_MenuItem,
            this.logoutToolStripMenuItem});
            this.AdminHomePage_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminHomePage_MenuStrip.Name = "AdminHomePage_MenuStrip";
            this.AdminHomePage_MenuStrip.Size = new System.Drawing.Size(1354, 29);
            this.AdminHomePage_MenuStrip.TabIndex = 6;
            this.AdminHomePage_MenuStrip.Text = "menuStrip1";
            // 
            // AddCashier_MenuStrip
            // 
            this.AddCashier_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddCashier_MenuStrip.Name = "AddCashier_MenuStrip";
            this.AddCashier_MenuStrip.Size = new System.Drawing.Size(106, 25);
            this.AddCashier_MenuStrip.Text = "Add Cashier";
            this.AddCashier_MenuStrip.Click += new System.EventHandler(this.AddCashier_MenuStrip_Click);
            // 
            // transactionDetailsToolStripMenuItem
            // 
            this.transactionDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.transactionDetailsToolStripMenuItem.Name = "transactionDetailsToolStripMenuItem";
            this.transactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 25);
            this.transactionDetailsToolStripMenuItem.Text = "Transaction Details";
            this.transactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailsToolStripMenuItem_Click);
            // 
            // StockDetailsToolStripMenuItem
            // 
            this.StockDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem";
            this.StockDetailsToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.StockDetailsToolStripMenuItem.Text = "Stock Details";
            this.StockDetailsToolStripMenuItem.Click += new System.EventHandler(this.StockDetailsToolStripMenuItem_Click);
            // 
            // SearchProduct_MenuItem
            // 
            this.SearchProduct_MenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchProduct_MenuItem.Name = "SearchProduct_MenuItem";
            this.SearchProduct_MenuItem.Size = new System.Drawing.Size(127, 25);
            this.SearchProduct_MenuItem.Text = "Search Product";
            this.SearchProduct_MenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.ControlBox = false;
            this.Controls.Add(this.AdminHomePage_MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.AdminHomePage_MenuStrip;
            this.MinimizeBox = false;
            this.Name = "AdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AdminHomePage_MenuStrip.ResumeLayout(false);
            this.AdminHomePage_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip AdminHomePage_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddCashier_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchProduct_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}