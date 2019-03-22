namespace RandomNumber {
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
            this.amountTextboxes = new System.Windows.Forms.TextBox();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButtton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fromFileListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amountTextboxes
            // 
            this.amountTextboxes.Location = new System.Drawing.Point(363, 9);
            this.amountTextboxes.Name = "amountTextboxes";
            this.amountTextboxes.Size = new System.Drawing.Size(100, 26);
            this.amountTextboxes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many numbers would you like to generate?";
            // 
            // generateButtton
            // 
            this.generateButtton.Location = new System.Drawing.Point(469, 6);
            this.generateButtton.Name = "generateButtton";
            this.generateButtton.Size = new System.Drawing.Size(94, 39);
            this.generateButtton.TabIndex = 2;
            this.generateButtton.Text = "Generate";
            this.generateButtton.UseVisualStyleBackColor = true;
            this.generateButtton.Click += new System.EventHandler(this.generateButtton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fromFileListBox
            // 
            this.fromFileListBox.FormattingEnabled = true;
            this.fromFileListBox.ItemHeight = 20;
            this.fromFileListBox.Location = new System.Drawing.Point(16, 61);
            this.fromFileListBox.Name = "fromFileListBox";
            this.fromFileListBox.Size = new System.Drawing.Size(341, 364);
            this.fromFileListBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(678, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Where would you like to open the file?";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(379, 84);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 31);
            this.openFileButton.TabIndex = 7;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(578, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fromFileListBox);
            this.Controls.Add(this.generateButtton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTextboxes);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTextboxes;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButtton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox fromFileListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button clearButton;
    }
}

