namespace final_cafe
{
    partial class ViewAllSales
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
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SaleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.close = new System.Windows.Forms.Label();
            this.DateTimecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.BackColor = System.Drawing.Color.SaddleBrown;
            this.SalesGroupBox.Controls.Add(this.SalesGridView);
            this.SalesGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalesGroupBox.Location = new System.Drawing.Point(12, 50);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(604, 337);
            this.SalesGroupBox.TabIndex = 2;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales";
            // 
            // SalesGridView
            // 
            this.SalesGridView.AllowUserToAddRows = false;
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.BackgroundColor = System.Drawing.Color.Chocolate;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDColumn,
            this.TimeColumn,
            this.SalesmanColumn,
            this.TotalBillColumn,
            this.ProductsColumn});
            this.SalesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridView.Location = new System.Drawing.Point(3, 16);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.Size = new System.Drawing.Size(598, 318);
            this.SalesGridView.TabIndex = 0;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.Name = "SaleIDColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            // 
            // SalesmanColumn
            // 
            this.SalesmanColumn.HeaderText = "Salesman";
            this.SalesmanColumn.Name = "SalesmanColumn";
            // 
            // TotalBillColumn
            // 
            this.TotalBillColumn.HeaderText = "Total Bill";
            this.TotalBillColumn.Name = "TotalBillColumn";
            // 
            // ProductsColumn
            // 
            this.ProductsColumn.HeaderText = "Products";
            this.ProductsColumn.Name = "ProductsColumn";
            this.ProductsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(608, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 65;
            this.close.Tag = "";
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // DateTimecomboBox
            // 
            this.DateTimecomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimecomboBox.FormattingEnabled = true;
            this.DateTimecomboBox.Location = new System.Drawing.Point(405, 23);
            this.DateTimecomboBox.Name = "DateTimecomboBox";
            this.DateTimecomboBox.Size = new System.Drawing.Size(211, 21);
            this.DateTimecomboBox.TabIndex = 66;
            this.DateTimecomboBox.SelectedIndexChanged += new System.EventHandler(this.DateTimecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(371, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "วันที่";
            // 
            // ViewAllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(628, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimecomboBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.SalesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllSales";
            this.Text = "ViewAllSales";
            this.Load += new System.EventHandler(this.ViewAllSales_Load);
            this.SalesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ProductsColumn;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.ComboBox DateTimecomboBox;
        private System.Windows.Forms.Label label1;
    }
}