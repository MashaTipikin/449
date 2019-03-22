namespace WindowsFormsApp1 {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FatCalorieBox = new System.Windows.Forms.TextBox();
            this.CarbCalorieBox = new System.Windows.Forms.TextBox();
            this.fatCalorieLabel = new System.Windows.Forms.Label();
            this.carbCalorieLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(65, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "fat calories";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(65, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "carb calories";
            // 
            // FatCalorieBox
            // 
            this.FatCalorieBox.Location = new System.Drawing.Point(172, 77);
            this.FatCalorieBox.Name = "FatCalorieBox";
            this.FatCalorieBox.Size = new System.Drawing.Size(100, 26);
            this.FatCalorieBox.TabIndex = 2;
            // 
            // CarbCalorieBox
            // 
            this.CarbCalorieBox.Location = new System.Drawing.Point(172, 159);
            this.CarbCalorieBox.Name = "CarbCalorieBox";
            this.CarbCalorieBox.Size = new System.Drawing.Size(100, 26);
            this.CarbCalorieBox.TabIndex = 3;
            // 
            // fatCalorieLabel
            // 
            this.fatCalorieLabel.AutoSize = true;
            this.fatCalorieLabel.Location = new System.Drawing.Point(350, 82);
            this.fatCalorieLabel.Name = "fatCalorieLabel";
            this.fatCalorieLabel.Size = new System.Drawing.Size(0, 20);
            this.fatCalorieLabel.TabIndex = 4;
            // 
            // carbCalorieLabel
            // 
            this.carbCalorieLabel.AutoSize = true;
            this.carbCalorieLabel.Location = new System.Drawing.Point(354, 164);
            this.carbCalorieLabel.Name = "carbCalorieLabel";
            this.carbCalorieLabel.Size = new System.Drawing.Size(0, 20);
            this.carbCalorieLabel.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(123, 273);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(95, 36);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(293, 273);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 36);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 389);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.carbCalorieLabel);
            this.Controls.Add(this.fatCalorieLabel);
            this.Controls.Add(this.CarbCalorieBox);
            this.Controls.Add(this.FatCalorieBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox FatCalorieBox;
        private System.Windows.Forms.TextBox CarbCalorieBox;
        private System.Windows.Forms.Label fatCalorieLabel;
        private System.Windows.Forms.Label carbCalorieLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button Exit;
    }
}

