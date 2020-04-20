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
            this.CashReturnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CashGivenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmCheckoutButton
            // 
            this.ConfirmCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmCheckoutButton.Location = new System.Drawing.Point(49, 113);
            this.ConfirmCheckoutButton.Name = "ConfirmCheckoutButton";
            this.ConfirmCheckoutButton.Size = new System.Drawing.Size(144, 23);
            this.ConfirmCheckoutButton.TabIndex = 13;
            this.ConfirmCheckoutButton.Text = "Confirm Checkout";
            this.ConfirmCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // CashReturnBox
            // 
            this.CashReturnBox.Location = new System.Drawing.Point(88, 77);
            this.CashReturnBox.Name = "CashReturnBox";
            this.CashReturnBox.Size = new System.Drawing.Size(132, 20);
            this.CashReturnBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cash Return";
            // 
            // CashGivenBox
            // 
            this.CashGivenBox.Location = new System.Drawing.Point(88, 51);
            this.CashGivenBox.Name = "CashGivenBox";
            this.CashGivenBox.Size = new System.Drawing.Size(132, 20);
            this.CashGivenBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cash Given";
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(88, 25);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(132, 20);
            this.TotalBillBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Bill";
            // 
            // CashFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 150);
            this.Controls.Add(this.ConfirmCheckoutButton);
            this.Controls.Add(this.CashReturnBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashGivenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashFrom";
            this.Text = "CashFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmCheckoutButton;
        public System.Windows.Forms.TextBox CashReturnBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox CashGivenBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
    }
}