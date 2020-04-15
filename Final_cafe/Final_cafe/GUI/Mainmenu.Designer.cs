namespace Final_cafe
{
    partial class Mainmenu
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
            this.X_button = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X_button
            // 
            this.X_button.AutoSize = true;
            this.X_button.BackColor = System.Drawing.Color.Transparent;
            this.X_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.X_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.X_button.Location = new System.Drawing.Point(762, 9);
            this.X_button.Name = "X_button";
            this.X_button.Size = new System.Drawing.Size(26, 25);
            this.X_button.TabIndex = 3;
            this.X_button.Text = "X";
            this.X_button.Click += new System.EventHandler(this.X_button_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.X_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainmenu";
            this.Text = "final_cafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_button;
    }
}

