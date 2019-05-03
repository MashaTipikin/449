namespace retailProject {
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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UnitsOnHandLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(174, 221);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 26);
            this.priceTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(174, 104);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // unitsOnHandTextBox
            // 
            this.unitsOnHandTextBox.Location = new System.Drawing.Point(174, 166);
            this.unitsOnHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitsOnHandTextBox.Multiline = true;
            this.unitsOnHandTextBox.Name = "unitsOnHandTextBox";
            this.unitsOnHandTextBox.Size = new System.Drawing.Size(100, 26);
            this.unitsOnHandTextBox.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(10, 221);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(100, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Enter a Price";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 104);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(145, 20);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Enter a Description";
            // 
            // UnitsOnHandLabel
            // 
            this.UnitsOnHandLabel.AutoSize = true;
            this.UnitsOnHandLabel.Location = new System.Drawing.Point(10, 166);
            this.UnitsOnHandLabel.Name = "UnitsOnHandLabel";
            this.UnitsOnHandLabel.Size = new System.Drawing.Size(111, 20);
            this.UnitsOnHandLabel.TabIndex = 5;
            this.UnitsOnHandLabel.Text = "Units on Hand";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(14, 262);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(91, 44);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(14, 383);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultBox.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.resultBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.resultBox.Location = new System.Drawing.Point(281, 14);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBox.Name = "resultBox";
            this.resultBox.RowTemplate.Height = 28;
            this.resultBox.Size = new System.Drawing.Size(722, 374);
            this.resultBox.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units on Hand";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 322);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 44);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.UnitsOnHandLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.unitsOnHandTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitsOnHandTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label UnitsOnHandLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView resultBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button saveButton;
    }
}

