namespace Hello_World
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myButton = new System.Windows.Forms.Button();
            this.cuteSpace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myButton.BackgroundImage")));
            this.myButton.Location = new System.Drawing.Point(33, 27);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(138, 101);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "Click me";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // cuteSpace
            // 
            this.cuteSpace.Location = new System.Drawing.Point(195, 27);
            this.cuteSpace.Name = "cuteSpace";
            this.cuteSpace.Size = new System.Drawing.Size(233, 26);
            this.cuteSpace.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuteSpace);
            this.Controls.Add(this.myButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.TextBox cuteSpace;
    }
}

