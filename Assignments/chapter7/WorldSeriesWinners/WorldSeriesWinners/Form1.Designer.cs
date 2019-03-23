namespace WorldSeriesWinners
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
            this.myListbox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myListbox
            // 
            this.myListbox.FormattingEnabled = true;
            this.myListbox.ItemHeight = 20;
            this.myListbox.Location = new System.Drawing.Point(12, 12);
            this.myListbox.Name = "myListbox";
            this.myListbox.Size = new System.Drawing.Size(503, 364);
            this.myListbox.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(521, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(88, 85);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(521, 103);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 85);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please load teams first, \r\nthen click a team name \r\nand then hit select!\r\n";
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(12, 381);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(0, 20);
            this.myLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.myListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox myListbox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myLabel;
    }
}

