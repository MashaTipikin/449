namespace Distance_Calculator
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CalculationLabel = new System.Windows.Forms.Label();
            this.MPHinput = new System.Windows.Forms.TextBox();
            this.HoursInput = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(74, 384);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(92, 29);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(305, 384);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Vehicle speed in MPH";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(74, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Hours traveled";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculationLabel
            // 
            this.CalculationLabel.AutoSize = true;
            this.CalculationLabel.Location = new System.Drawing.Point(131, 224);
            this.CalculationLabel.Name = "CalculationLabel";
            this.CalculationLabel.Size = new System.Drawing.Size(117, 20);
            this.CalculationLabel.TabIndex = 4;
            this.CalculationLabel.Text = "                           ";
            // 
            // MPHinput
            // 
            this.MPHinput.Location = new System.Drawing.Point(252, 86);
            this.MPHinput.Name = "MPHinput";
            this.MPHinput.Size = new System.Drawing.Size(100, 26);
            this.MPHinput.TabIndex = 5;
            // 
            // HoursInput
            // 
            this.HoursInput.Location = new System.Drawing.Point(252, 150);
            this.HoursInput.Name = "HoursInput";
            this.HoursInput.Size = new System.Drawing.Size(100, 26);
            this.HoursInput.TabIndex = 6;
            // 
            // AnswerBox
            // 
            this.AnswerBox.FormattingEnabled = true;
            this.AnswerBox.ItemHeight = 20;
            this.AnswerBox.Location = new System.Drawing.Point(74, 224);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(306, 124);
            this.AnswerBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.HoursInput);
            this.Controls.Add(this.MPHinput);
            this.Controls.Add(this.CalculationLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label CalculationLabel;
        private System.Windows.Forms.TextBox MPHinput;
        private System.Windows.Forms.TextBox HoursInput;
        private System.Windows.Forms.ListBox AnswerBox;
    }
}

