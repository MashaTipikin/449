namespace StadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cClassTicketsTextBox = new System.Windows.Forms.TextBox();
            this.bClassTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aClassTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.aClassRevenueTextBox = new System.Windows.Forms.TextBox();
            this.bClassRevenueTextBox = new System.Windows.Forms.TextBox();
            this.cClassRevenueTextBox = new System.Windows.Forms.TextBox();
            this.totalRevenueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cClassTicketsTextBox);
            this.groupBox1.Controls.Add(this.bClassTicketsTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aClassTicketsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // cClassTicketsTextBox
            // 
            this.cClassTicketsTextBox.Location = new System.Drawing.Point(57, 143);
            this.cClassTicketsTextBox.Name = "cClassTicketsTextBox";
            this.cClassTicketsTextBox.Size = new System.Drawing.Size(100, 20);
            this.cClassTicketsTextBox.TabIndex = 6;
            // 
            // bClassTicketsTextBox
            // 
            this.bClassTicketsTextBox.Location = new System.Drawing.Point(57, 99);
            this.bClassTicketsTextBox.Name = "bClassTicketsTextBox";
            this.bClassTicketsTextBox.Size = new System.Drawing.Size(100, 20);
            this.bClassTicketsTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // aClassTicketsTextBox
            // 
            this.aClassTicketsTextBox.Location = new System.Drawing.Point(57, 56);
            this.aClassTicketsTextBox.Name = "aClassTicketsTextBox";
            this.aClassTicketsTextBox.Size = new System.Drawing.Size(100, 20);
            this.aClassTicketsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalRevenueTextBox);
            this.groupBox2.Controls.Add(this.cClassRevenueTextBox);
            this.groupBox2.Controls.Add(this.bClassRevenueTextBox);
            this.groupBox2.Controls.Add(this.aClassRevenueTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(506, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class A:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(208, 364);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 74);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(361, 364);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 74);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(506, 364);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 74);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total:";
            // 
            // aClassRevenueTextBox
            // 
            this.aClassRevenueTextBox.Location = new System.Drawing.Point(57, 56);
            this.aClassRevenueTextBox.Name = "aClassRevenueTextBox";
            this.aClassRevenueTextBox.ReadOnly = true;
            this.aClassRevenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.aClassRevenueTextBox.TabIndex = 6;
            // 
            // bClassRevenueTextBox
            // 
            this.bClassRevenueTextBox.Location = new System.Drawing.Point(57, 99);
            this.bClassRevenueTextBox.Name = "bClassRevenueTextBox";
            this.bClassRevenueTextBox.ReadOnly = true;
            this.bClassRevenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.bClassRevenueTextBox.TabIndex = 7;
            // 
            // cClassRevenueTextBox
            // 
            this.cClassRevenueTextBox.Location = new System.Drawing.Point(57, 143);
            this.cClassRevenueTextBox.Name = "cClassRevenueTextBox";
            this.cClassRevenueTextBox.ReadOnly = true;
            this.cClassRevenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.cClassRevenueTextBox.TabIndex = 8;
            // 
            // totalRevenueTextBox
            // 
            this.totalRevenueTextBox.Location = new System.Drawing.Point(81, 177);
            this.totalRevenueTextBox.Name = "totalRevenueTextBox";
            this.totalRevenueTextBox.ReadOnly = true;
            this.totalRevenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalRevenueTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox aClassTicketsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox cClassTicketsTextBox;
        private System.Windows.Forms.TextBox bClassTicketsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalRevenueTextBox;
        private System.Windows.Forms.TextBox cClassRevenueTextBox;
        private System.Windows.Forms.TextBox bClassRevenueTextBox;
        private System.Windows.Forms.TextBox aClassRevenueTextBox;
        private System.Windows.Forms.Label label8;
    }
}

