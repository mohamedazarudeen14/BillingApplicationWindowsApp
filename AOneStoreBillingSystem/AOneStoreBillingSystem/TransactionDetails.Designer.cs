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
            System.Windows.Forms.DataGridView TransactionDataGridView;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FromDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDetails_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.From_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetDetails_button = new System.Windows.Forms.Button();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TransactionDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(TransactionDataGridView)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(403, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TransactionDataGridView
            // 
            TransactionDataGridView.AllowUserToResizeColumns = false;
            TransactionDataGridView.AllowUserToResizeRows = false;
            TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            TransactionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TransactionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            TransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.BillNumber,
            this.TotalBillAmount,
            this.TotalCostAmount,
            this.TotalProfitAmount,
            this.SalesDate});
            TransactionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            TransactionDataGridView.Location = new System.Drawing.Point(403, 71);
            TransactionDataGridView.Name = "TransactionDataGridView";
            TransactionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TransactionDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TransactionDataGridView.Size = new System.Drawing.Size(710, 440);
            TransactionDataGridView.TabIndex = 4;
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
            this.GetDetails_button.Location = new System.Drawing.Point(227, 360);
            this.GetDetails_button.Name = "GetDetails_button";
            this.GetDetails_button.Size = new System.Drawing.Size(107, 45);
            this.GetDetails_button.TabIndex = 7;
            this.GetDetails_button.Text = "Get Details";
            this.GetDetails_button.UseVisualStyleBackColor = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "S.No";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BillNumber
            // 
            this.BillNumber.HeaderText = "Bill Number";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            this.BillNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BillNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalBillAmount
            // 
            this.TotalBillAmount.HeaderText = "Total Bill Amount";
            this.TotalBillAmount.Name = "TotalBillAmount";
            this.TotalBillAmount.ReadOnly = true;
            this.TotalBillAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalCostAmount
            // 
            this.TotalCostAmount.HeaderText = "Total Cost Amount";
            this.TotalCostAmount.Name = "TotalCostAmount";
            this.TotalCostAmount.ReadOnly = true;
            this.TotalCostAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalCostAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalProfitAmount
            // 
            this.TotalProfitAmount.HeaderText = "Total Profit Amount";
            this.TotalProfitAmount.Name = "TotalProfitAmount";
            this.TotalProfitAmount.ReadOnly = true;
            this.TotalProfitAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalProfitAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SalesDate
            // 
            this.SalesDate.HeaderText = "Sales Date";
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.ReadOnly = true;
            this.SalesDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 552);
            this.ControlBox = false;
            this.Controls.Add(this.GetDetails_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From_label);
            this.Controls.Add(TransactionDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransactionDetails_label);
            this.Controls.Add(this.ToDateDatePicker);
            this.Controls.Add(this.FromDateDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionDetails";
            this.Text = "TransactionDetails";
            ((System.ComponentModel.ISupportInitialize)(TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDateDatePicker;
        private System.Windows.Forms.DateTimePicker ToDateDatePicker;
        private System.Windows.Forms.Label TransactionDetails_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetDetails_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfitAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDate;
    }
}