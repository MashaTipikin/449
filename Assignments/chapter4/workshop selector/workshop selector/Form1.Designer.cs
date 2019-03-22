namespace workshop_selector
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
            this.Workshop = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RegCost = new System.Windows.Forms.TextBox();
            this.LodgeCost = new System.Windows.Forms.TextBox();
            this.RegCostLabel = new System.Windows.Forms.Label();
            this.LodgeCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Workshop
            // 
            this.Workshop.FormattingEnabled = true;
            this.Workshop.Items.AddRange(new object[] {
            "Handling stress",
            "Time management",
            "Supervision skills",
            "Negotiation",
            "How to interview"});
            this.Workshop.Location = new System.Drawing.Point(42, 92);
            this.Workshop.Name = "Workshop";
            this.Workshop.Size = new System.Drawing.Size(152, 28);
            this.Workshop.TabIndex = 0;
            this.Workshop.Text = "Workshop";
            // 
            // Location
            // 
            this.Location.FormattingEnabled = true;
            this.Location.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.Location.Location = new System.Drawing.Point(42, 153);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(152, 28);
            this.Location.TabIndex = 1;
            this.Location.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(42, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Total Cost";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(194, 304);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(0, 20);
            this.TotalLabel.TabIndex = 3;
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.Menu;
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructions.Location = new System.Drawing.Point(42, 27);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(305, 59);
            this.instructions.TabIndex = 4;
            this.instructions.Text = "Please select your workshop and location to calculate your total cost.";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(53, 350);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 40);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(257, 350);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 40);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegCost
            // 
            this.RegCost.BackColor = System.Drawing.SystemColors.Menu;
            this.RegCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegCost.Location = new System.Drawing.Point(42, 219);
            this.RegCost.Multiline = true;
            this.RegCost.Name = "RegCost";
            this.RegCost.Size = new System.Drawing.Size(150, 26);
            this.RegCost.TabIndex = 7;
            this.RegCost.Text = "Registration Cost";
            // 
            // LodgeCost
            // 
            this.LodgeCost.BackColor = System.Drawing.SystemColors.Menu;
            this.LodgeCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LodgeCost.Location = new System.Drawing.Point(42, 263);
            this.LodgeCost.Multiline = true;
            this.LodgeCost.Name = "LodgeCost";
            this.LodgeCost.Size = new System.Drawing.Size(100, 26);
            this.LodgeCost.TabIndex = 8;
            this.LodgeCost.Text = "Lodging Cost";
            // 
            // RegCostLabel
            // 
            this.RegCostLabel.AutoSize = true;
            this.RegCostLabel.Location = new System.Drawing.Point(198, 219);
            this.RegCostLabel.Name = "RegCostLabel";
            this.RegCostLabel.Size = new System.Drawing.Size(0, 20);
            this.RegCostLabel.TabIndex = 9;
            // 
            // LodgeCostLabel
            // 
            this.LodgeCostLabel.AutoSize = true;
            this.LodgeCostLabel.Location = new System.Drawing.Point(202, 263);
            this.LodgeCostLabel.Name = "LodgeCostLabel";
            this.LodgeCostLabel.Size = new System.Drawing.Size(0, 20);
            this.LodgeCostLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 402);
            this.Controls.Add(this.LodgeCostLabel);
            this.Controls.Add(this.RegCostLabel);
            this.Controls.Add(this.LodgeCost);
            this.Controls.Add(this.RegCost);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Workshop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Workshop;
        private System.Windows.Forms.ComboBox Location;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox RegCost;
        private System.Windows.Forms.TextBox LodgeCost;
        private System.Windows.Forms.Label RegCostLabel;
        private System.Windows.Forms.Label LodgeCostLabel;
    }
}

