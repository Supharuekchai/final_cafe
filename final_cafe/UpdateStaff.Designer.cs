namespace final_cafe
{
    partial class UpdateStaff
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
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffLevelComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(260, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 74;
            this.close.Tag = "";
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.GenderComboBox.Location = new System.Drawing.Point(126, 96);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(146, 21);
            this.GenderComboBox.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Gender";
            // 
            // StaffCodeTextBox
            // 
            this.StaffCodeTextBox.Location = new System.Drawing.Point(126, 70);
            this.StaffCodeTextBox.Name = "StaffCodeTextBox";
            this.StaffCodeTextBox.Size = new System.Drawing.Size(146, 20);
            this.StaffCodeTextBox.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Staff Code";
            // 
            // StaffNameTextBox
            // 
            this.StaffNameTextBox.Location = new System.Drawing.Point(126, 44);
            this.StaffNameTextBox.Name = "StaffNameTextBox";
            this.StaffNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.StaffNameTextBox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Staff Password";
            // 
            // StaffPasswordTextBox
            // 
            this.StaffPasswordTextBox.Location = new System.Drawing.Point(126, 123);
            this.StaffPasswordTextBox.Name = "StaffPasswordTextBox";
            this.StaffPasswordTextBox.Size = new System.Drawing.Size(146, 20);
            this.StaffPasswordTextBox.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Staff Level";
            // 
            // StaffLevelComboBox
            // 
            this.StaffLevelComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffLevelComboBox.FormattingEnabled = true;
            this.StaffLevelComboBox.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.StaffLevelComboBox.Location = new System.Drawing.Point(126, 149);
            this.StaffLevelComboBox.Name = "StaffLevelComboBox";
            this.StaffLevelComboBox.Size = new System.Drawing.Size(146, 21);
            this.StaffLevelComboBox.TabIndex = 78;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(197, 176);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 79;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 209);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.StaffLevelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StaffCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStaff";
            this.Text = "UpdateStaff";
            this.Load += new System.EventHandler(this.UpdateStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StaffCodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StaffNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StaffLevelComboBox;
        private System.Windows.Forms.Button EditButton;
    }
}