namespace Celcius_to_fahrenheit
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
            this.FahrenheitCalcs = new System.Windows.Forms.ListBox();
            this.Calc = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrenheitCalcs
            // 
            this.FahrenheitCalcs.FormattingEnabled = true;
            this.FahrenheitCalcs.ItemHeight = 20;
            this.FahrenheitCalcs.Location = new System.Drawing.Point(57, 11);
            this.FahrenheitCalcs.Name = "FahrenheitCalcs";
            this.FahrenheitCalcs.Size = new System.Drawing.Size(244, 344);
            this.FahrenheitCalcs.TabIndex = 2;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(46, 389);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(93, 33);
            this.Calc.TabIndex = 3;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(226, 389);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 33);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.FahrenheitCalcs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox FahrenheitCalcs;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Exit;
    }
}

