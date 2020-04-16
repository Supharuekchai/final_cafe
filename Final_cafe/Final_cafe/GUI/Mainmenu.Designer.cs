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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.X_button = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X_button
            // 
            this.X_button.AutoSize = true;
            this.X_button.BackColor = System.Drawing.Color.Transparent;
            this.X_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.X_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X_button.Location = new System.Drawing.Point(1027, 9);
            this.X_button.Name = "X_button";
            this.X_button.Size = new System.Drawing.Size(26, 25);
            this.X_button.TabIndex = 3;
            this.X_button.Text = "X";
            this.X_button.Click += new System.EventHandler(this.X_button_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome.Location = new System.Drawing.Point(161, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(80, 25);
            this.welcome.TabIndex = 4;
            this.welcome.Text = "welcome";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name.Location = new System.Drawing.Point(386, 10);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(60, 25);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 554);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.X_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "final_cafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_button;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label Name;
    }
}

