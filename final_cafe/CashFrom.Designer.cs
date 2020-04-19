namespace final_cafe
{
    partial class CashFrom
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
            this.ConfirmCheckoutButton = new System.Windows.Forms.Button();
            this.Point_CashFrom = new System.Windows.Forms.Label();
            this.Name_Cashfrom = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmCheckoutButton
            // 
            this.ConfirmCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmCheckoutButton.Location = new System.Drawing.Point(49, 100);
            this.ConfirmCheckoutButton.Name = "ConfirmCheckoutButton";
            this.ConfirmCheckoutButton.Size = new System.Drawing.Size(144, 23);
            this.ConfirmCheckoutButton.TabIndex = 13;
            this.ConfirmCheckoutButton.Text = "Confirm Checkout";
            this.ConfirmCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // Point_CashFrom
            // 
            this.Point_CashFrom.AutoSize = true;
            this.Point_CashFrom.Location = new System.Drawing.Point(85, 61);
            this.Point_CashFrom.Name = "Point_CashFrom";
            this.Point_CashFrom.Size = new System.Drawing.Size(66, 13);
            this.Point_CashFrom.TabIndex = 11;
            this.Point_CashFrom.Text = "Cash Return";
            // 
            // Name_Cashfrom
            // 
            this.Name_Cashfrom.AutoSize = true;
            this.Name_Cashfrom.Location = new System.Drawing.Point(85, 35);
            this.Name_Cashfrom.Name = "Name_Cashfrom";
            this.Name_Cashfrom.Size = new System.Drawing.Size(62, 13);
            this.Name_Cashfrom.TabIndex = 9;
            this.Name_Cashfrom.Text = "Cash Given";
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(88, 12);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(132, 20);
            this.TotalBillBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Bill";
            // 
            // CashFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 138);
            this.Controls.Add(this.ConfirmCheckoutButton);
            this.Controls.Add(this.Point_CashFrom);
            this.Controls.Add(this.Name_Cashfrom);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Name = "CashFrom";
            this.Text = "CashFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmCheckoutButton;
        private System.Windows.Forms.Label Point_CashFrom;
        private System.Windows.Forms.Label Name_Cashfrom;
        public System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
    }
}