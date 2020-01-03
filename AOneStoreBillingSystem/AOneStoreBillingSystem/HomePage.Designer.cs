namespace AOneStoreBillingSystem
{
    partial class HomePage
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
            this.Admin_Btn = new System.Windows.Forms.Button();
            this.Cashier_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_Btn
            // 
            this.Admin_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_Btn.Location = new System.Drawing.Point(35, 43);
            this.Admin_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_Btn.Name = "Admin_Btn";
            this.Admin_Btn.Size = new System.Drawing.Size(138, 55);
            this.Admin_Btn.TabIndex = 1;
            this.Admin_Btn.Text = "Admin";
            this.Admin_Btn.UseVisualStyleBackColor = true;
            this.Admin_Btn.Click += new System.EventHandler(this.Admin_Btn_Click);
            // 
            // Cashier_Btn
            // 
            this.Cashier_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashier_Btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cashier_Btn.Location = new System.Drawing.Point(212, 43);
            this.Cashier_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cashier_Btn.Name = "Cashier_Btn";
            this.Cashier_Btn.Size = new System.Drawing.Size(126, 55);
            this.Cashier_Btn.TabIndex = 2;
            this.Cashier_Btn.Text = "Cashier";
            this.Cashier_Btn.UseVisualStyleBackColor = true;
            this.Cashier_Btn.Click += new System.EventHandler(this.Cashier_Btn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 141);
            this.Controls.Add(this.Cashier_Btn);
            this.Controls.Add(this.Admin_Btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Select Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_Btn;
        private System.Windows.Forms.Button Cashier_Btn;
    }
}