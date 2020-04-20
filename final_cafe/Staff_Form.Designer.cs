namespace final_cafe
{
    partial class Staff_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Form));
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.addProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSales = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameIDMenuLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.ProductsGroupBox.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(759, 504);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckOutButton.TabIndex = 13;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(543, 506);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(210, 20);
            this.TotalBillBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Bill";
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Location = new System.Drawing.Point(480, 23);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Size = new System.Drawing.Size(370, 469);
            this.BillGroupBox.TabIndex = 10;
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
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
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
            this.ProductsGroupBox.Location = new System.Drawing.Point(12, 236);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(459, 300);
            this.ProductsGroupBox.TabIndex = 9;
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
            this.CategoryGroupBox.Location = new System.Drawing.Point(12, 23);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(462, 207);
            this.CategoryGroupBox.TabIndex = 8;
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
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategory,
            this.addProduct,
            this.viewAllProducts,
            this.viewSales,
            this.UserNameIDMenuLabel});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(880, 24);
            this.MainMenuStrip.TabIndex = 7;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // addCategory
            // 
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(92, 20);
            this.addCategory.Text = "Add Category";
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addProduct
            // 
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(86, 20);
            this.addProduct.Text = "Add Product";
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // viewAllProducts
            // 
            this.viewAllProducts.Name = "viewAllProducts";
            this.viewAllProducts.Size = new System.Drawing.Size(111, 20);
            this.viewAllProducts.Text = "View All Products";
            this.viewAllProducts.Click += new System.EventHandler(this.viewAllProducts_Click);
            // 
            // viewSales
            // 
            this.viewSales.Name = "viewSales";
            this.viewSales.Size = new System.Drawing.Size(73, 20);
            this.viewSales.Text = "View Sales";
            this.viewSales.Click += new System.EventHandler(this.viewSales_Click);
            // 
            // UserNameIDMenuLabel
            // 
            this.UserNameIDMenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserNameIDMenuLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserNameIDMenuLabel.BackgroundImage")));
            this.UserNameIDMenuLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserNameIDMenuLabel.Enabled = false;
            this.UserNameIDMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameIDMenuLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameIDMenuLabel.Name = "UserNameIDMenuLabel";
            this.UserNameIDMenuLabel.Size = new System.Drawing.Size(22, 20);
            this.UserNameIDMenuLabel.Text = " ";
            // 
            // Staff_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 551);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Form";
            this.Text = "Staff_Form";
            this.Load += new System.EventHandler(this.Staff_Form_Load);
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ProductsGroupBox.ResumeLayout(false);
            this.CategoryGroupBox.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCategory;
        private System.Windows.Forms.ToolStripMenuItem addProduct;
        private System.Windows.Forms.ToolStripMenuItem viewAllProducts;
        private System.Windows.Forms.ToolStripMenuItem viewSales;
        private System.Windows.Forms.ToolStripMenuItem UserNameIDMenuLabel;
    }
}