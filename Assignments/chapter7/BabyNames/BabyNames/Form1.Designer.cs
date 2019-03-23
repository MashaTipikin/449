namespace BabyNames {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.boyTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.girlTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.boyLabel = new System.Windows.Forms.Label();
            this.girlLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a boy\'s name:";
            // 
            // boyTextbox
            // 
            this.boyTextbox.Location = new System.Drawing.Point(167, 9);
            this.boyTextbox.Name = "boyTextbox";
            this.boyTextbox.Size = new System.Drawing.Size(219, 26);
            this.boyTextbox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(167, 84);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 62);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a girls\' name:";
            // 
            // girlTextbox
            // 
            this.girlTextbox.Location = new System.Drawing.Point(167, 52);
            this.girlTextbox.Name = "girlTextbox";
            this.girlTextbox.Size = new System.Drawing.Size(219, 26);
            this.girlTextbox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(339, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 62);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(253, 84);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 62);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(17, 149);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(0, 20);
            this.boyLabel.TabIndex = 7;
            // 
            // girlLabel
            // 
            this.girlLabel.AutoSize = true;
            this.girlLabel.Location = new System.Drawing.Point(17, 191);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(0, 20);
            this.girlLabel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter a girls\' name or boy\'s name (or both), \r\nthen click search.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girlLabel);
            this.Controls.Add(this.boyLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.girlTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.boyTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boyTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girlTextbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.Label label3;
    }
}

