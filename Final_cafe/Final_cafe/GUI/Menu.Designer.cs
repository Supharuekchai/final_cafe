namespace Final_cafe.GUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.X_button = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.Panel();
            this.CategoriesFlowPanel = new System.Windows.Forms.Panel();
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.CheckOutButton = new System.Windows.Forms.Label();
            this.CategoryGroupBox.SuspendLayout();
            this.ProductsGroupBox.SuspendLayout();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // X_button
            // 
            this.X_button.AutoSize = true;
            this.X_button.BackColor = System.Drawing.Color.Transparent;
            this.X_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.X_button.ForeColor = System.Drawing.Color.AliceBlue;
            this.X_button.Location = new System.Drawing.Point(1056, 0);
            this.X_button.Name = "X_button";
            this.X_button.Size = new System.Drawing.Size(26, 25);
            this.X_button.TabIndex = 1;
            this.X_button.Text = "X";
            this.X_button.Click += new System.EventHandler(this.X_button_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name.Location = new System.Drawing.Point(36, 594);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(162, 25);
            this.name.TabIndex = 2;
            this.name.Text = "welcome_and_name";
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CategoryGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryGroupBox.Location = new System.Drawing.Point(67, 121);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(645, 136);
            this.CategoryGroupBox.TabIndex = 3;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "หมวดหมู่";
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ProductsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductsGroupBox.Location = new System.Drawing.Point(67, 263);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(645, 299);
            this.ProductsGroupBox.TabIndex = 4;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "สินค้า";
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.Location = new System.Drawing.Point(6, 21);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(633, 272);
            this.ProductsFlowPanel.TabIndex = 0;
            // 
            // CategoriesFlowPanel
            // 
            this.CategoriesFlowPanel.Location = new System.Drawing.Point(6, 21);
            this.CategoriesFlowPanel.Name = "CategoriesFlowPanel";
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(633, 104);
            this.CategoriesFlowPanel.TabIndex = 5;
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BillGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BillGroupBox.Location = new System.Drawing.Point(718, 121);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Size = new System.Drawing.Size(305, 441);
            this.BillGroupBox.TabIndex = 5;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "Bill";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.DeleteColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(3, 18);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(299, 420);
            this.ProductsGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(716, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ราคารวม";
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
            this.ProductNameColumn.FillWeight = 143.9252F;
            this.ProductNameColumn.HeaderText = "สินค้า";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.FillWeight = 56.07477F;
            this.ProductPriceColumn.HeaderText = "ราคา";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductQuantityColumn.HeaderText = "จำนวน";
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.Width = 50;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "ลบ";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 30;
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalBillBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalBillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TotalBillBox.Location = new System.Drawing.Point(806, 593);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(151, 24);
            this.TotalBillBox.TabIndex = 7;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.AutoSize = true;
            this.CheckOutButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckOutButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckOutButton.Location = new System.Drawing.Point(963, 594);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(53, 25);
            this.CheckOutButton.TabIndex = 8;
            this.CheckOutButton.Text = "สั่งซื้อ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 653);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.X_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.CategoryGroupBox.ResumeLayout(false);
            this.ProductsGroupBox.ResumeLayout(false);
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.Panel CategoriesFlowPanel;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.Panel ProductsFlowPanel;
        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label CheckOutButton;
    }
}