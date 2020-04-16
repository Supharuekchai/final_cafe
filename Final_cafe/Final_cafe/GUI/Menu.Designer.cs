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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // X_button
            // 
            this.X_button.AutoSize = true;
            this.X_button.BackColor = System.Drawing.Color.Transparent;
            this.X_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.X_button.ForeColor = System.Drawing.Color.AliceBlue;
            this.X_button.Location = new System.Drawing.Point(776, 0);
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
            this.name.Location = new System.Drawing.Point(345, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 25);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 170);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.X_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}