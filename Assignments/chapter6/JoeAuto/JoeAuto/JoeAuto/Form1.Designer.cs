namespace JoeAuto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.LubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.RadiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartsInput = new System.Windows.Forms.TextBox();
            this.LaborHoursInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LubeJobCheckBox);
            this.groupBox1.Controls.Add(this.OilChangeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionFlushCheckBox);
            this.groupBox2.Controls.Add(this.RadiatorFlushCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tireRotationCheckBox);
            this.groupBox3.Controls.Add(this.replaceMufflerCheckBox);
            this.groupBox3.Controls.Add(this.inspectionCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LaborHoursInput);
            this.groupBox4.Controls.Add(this.PartsInput);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(220, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalFeesLabel);
            this.groupBox5.Controls.Add(this.taxLabel);
            this.groupBox5.Controls.Add(this.partsLabel);
            this.groupBox5.Controls.Add(this.serviceAndLaborLabel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(13, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 154);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // OilChangeCheckBox
            // 
            this.OilChangeCheckBox.AutoSize = true;
            this.OilChangeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.OilChangeCheckBox.Name = "OilChangeCheckBox";
            this.OilChangeCheckBox.Size = new System.Drawing.Size(99, 17);
            this.OilChangeCheckBox.TabIndex = 5;
            this.OilChangeCheckBox.Text = "Oil Change $26";
            this.OilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // LubeJobCheckBox
            // 
            this.LubeJobCheckBox.AutoSize = true;
            this.LubeJobCheckBox.Location = new System.Drawing.Point(7, 43);
            this.LubeJobCheckBox.Name = "LubeJobCheckBox";
            this.LubeJobCheckBox.Size = new System.Drawing.Size(91, 17);
            this.LubeJobCheckBox.TabIndex = 6;
            this.LubeJobCheckBox.Text = "Lube Job $18";
            this.LubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadiatorFlushCheckBox
            // 
            this.RadiatorFlushCheckBox.AutoSize = true;
            this.RadiatorFlushCheckBox.Location = new System.Drawing.Point(6, 19);
            this.RadiatorFlushCheckBox.Name = "RadiatorFlushCheckBox";
            this.RadiatorFlushCheckBox.Size = new System.Drawing.Size(115, 17);
            this.RadiatorFlushCheckBox.TabIndex = 0;
            this.RadiatorFlushCheckBox.Text = "Radiator Flush $30";
            this.RadiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 43);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(136, 17);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush $80";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(6, 20);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(96, 17);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection $15";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(6, 44);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(85, 17);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Muffler $100";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(6, 68);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(65, 17);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire $20";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor";
            // 
            // PartsInput
            // 
            this.PartsInput.Location = new System.Drawing.Point(45, 20);
            this.PartsInput.Name = "PartsInput";
            this.PartsInput.Size = new System.Drawing.Size(100, 20);
            this.PartsInput.TabIndex = 2;
            // 
            // LaborHoursInput
            // 
            this.LaborHoursInput.Location = new System.Drawing.Point(47, 48);
            this.LaborHoursInput.Name = "LaborHoursInput";
            this.LaborHoursInput.Size = new System.Drawing.Size(100, 20);
            this.LaborHoursInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(288, 235);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(288, 272);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(288, 308);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // serviceAndLaborLabel
            // 
            this.serviceAndLaborLabel.AutoSize = true;
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(134, 20);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(0, 13);
            this.serviceAndLaborLabel.TabIndex = 4;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(134, 51);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(0, 13);
            this.partsLabel.TabIndex = 5;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(134, 93);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 13);
            this.taxLabel.TabIndex = 6;
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(134, 131);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(0, 13);
            this.totalFeesLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 382);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LubeJobCheckBox;
        private System.Windows.Forms.CheckBox OilChangeCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox RadiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox LaborHoursInput;
        private System.Windows.Forms.TextBox PartsInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
    }
}

