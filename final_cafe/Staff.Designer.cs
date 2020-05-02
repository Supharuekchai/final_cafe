namespace final_cafe
{
    partial class Staff
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
            this.close = new System.Windows.Forms.Label();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.AddStaff = new System.Windows.Forms.Button();
            this.StaffIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditStaffColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteStaffColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(614, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 69;
            this.close.Tag = "";
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.StaffGridView);
            this.ProductsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.ProductsGroupBox.Location = new System.Drawing.Point(12, 30);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(612, 335);
            this.ProductsGroupBox.TabIndex = 70;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Staffs";
            // 
            // StaffGridView
            // 
            this.StaffGridView.AllowUserToAddRows = false;
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.BackgroundColor = System.Drawing.Color.Chocolate;
            this.StaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffIDColumn,
            this.StaffNameColumn,
            this.StaffCodeColumn,
            this.GenderColumn,
            this.StaffPasswordColumn,
            this.StaffLevelColumn,
            this.EditStaffColumn,
            this.DeleteStaffColumn});
            this.StaffGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffGridView.Location = new System.Drawing.Point(3, 16);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.Size = new System.Drawing.Size(606, 316);
            this.StaffGridView.TabIndex = 0;
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // AddStaff
            // 
            this.AddStaff.Location = new System.Drawing.Point(549, 371);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(75, 23);
            this.AddStaff.TabIndex = 71;
            this.AddStaff.Text = "เพิ่ม";
            this.AddStaff.UseVisualStyleBackColor = true;
            // 
            // StaffIDColumn
            // 
            this.StaffIDColumn.HeaderText = "StaffID";
            this.StaffIDColumn.Name = "StaffIDColumn";
            // 
            // StaffNameColumn
            // 
            this.StaffNameColumn.HeaderText = "Staff Name";
            this.StaffNameColumn.Name = "StaffNameColumn";
            // 
            // StaffCodeColumn
            // 
            this.StaffCodeColumn.HeaderText = "StaffCode";
            this.StaffCodeColumn.Name = "StaffCodeColumn";
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            // 
            // StaffPasswordColumn
            // 
            this.StaffPasswordColumn.HeaderText = "StaffPassword";
            this.StaffPasswordColumn.Name = "StaffPasswordColumn";
            this.StaffPasswordColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StaffLevelColumn
            // 
            this.StaffLevelColumn.HeaderText = "StaffLevel";
            this.StaffLevelColumn.Name = "StaffLevelColumn";
            // 
            // EditStaffColumn
            // 
            this.EditStaffColumn.HeaderText = "Edit";
            this.EditStaffColumn.Name = "EditStaffColumn";
            this.EditStaffColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditStaffColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteStaffColumn
            // 
            this.DeleteStaffColumn.HeaderText = "Delete";
            this.DeleteStaffColumn.Name = "DeleteStaffColumn";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(638, 402);
            this.Controls.Add(this.AddStaff);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "SalesSummary";
            this.Load += new System.EventHandler(this.SalesSummary_Load);
            this.ProductsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffLevelColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditStaffColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStaffColumn;
    }
}