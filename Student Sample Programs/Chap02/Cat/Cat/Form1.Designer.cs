namespace Cat
{
    partial class Form1
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
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.kitty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catPictureBox
            // 
            this.catPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catPictureBox.Image = global::Cat.Properties.Resources.Cat;
            this.catPictureBox.Location = new System.Drawing.Point(24, 58);
            this.catPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(342, 331);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 0;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // kitty
            // 
            this.kitty.AutoSize = true;
            this.kitty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitty.Location = new System.Drawing.Point(132, 17);
            this.kitty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kitty.Name = "kitty";
            this.kitty.Size = new System.Drawing.Size(60, 25);
            this.kitty.TabIndex = 1;
            this.kitty.Text = "huhiu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 406);
            this.Controls.Add(this.kitty);
            this.Controls.Add(this.catPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cat";
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.Label kitty;
    }
}

