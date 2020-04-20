namespace final_cafe
{
    partial class Customer_Form
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
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.ProductsGroupBox.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(737, 455);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckOutButton.TabIndex = 20;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(546, 504);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(210, 20);
            this.TotalBillBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Bill";
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Location = new System.Drawing.Point(483, 21);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Size = new System.Drawing.Size(370, 469);
            this.BillGroupBox.TabIndex = 17;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "Bill";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.TotalPriceColumn,
            this.DeleteColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(364, 450);
            this.ProductsGridView.TabIndex = 0;
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductIDColumn.FillWeight = 50F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.Width = 30;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.Width = 30;
            // 
            // TotalPriceColumn
            // 
            this.TotalPriceColumn.HeaderText = "Product Total";
            this.TotalPriceColumn.Name = "TotalPriceColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 30;
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Location = new System.Drawing.Point(15, 234);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(459, 300);
            this.ProductsGroupBox.TabIndex = 16;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.AutoScroll = true;
            this.ProductsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(453, 281);
            this.ProductsFlowPanel.TabIndex = 0;
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Location = new System.Drawing.Point(15, 21);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(462, 207);
            this.CategoryGroupBox.TabIndex = 15;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Categories";
            // 
            // CategoriesFlowPanel
            // 
            this.CategoriesFlowPanel.AutoScroll = true;
            this.CategoriesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CategoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.CategoriesFlowPanel.Name = "CategoriesFlowPanel";
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(456, 188);
            this.CategoriesFlowPanel.TabIndex = 0;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ProductsGroupBox.ResumeLayout(false);
            this.CategoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel CategoriesFlowPanel;
    }
}