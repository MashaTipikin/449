using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomNumber {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void generateButtton_Click(object sender, EventArgs e) {
            String userInput = amountTextboxes.Text; //bring in amount of numbers to generate
            int userInputInt = 0;
            Random rnd = new Random();

            if (!int.TryParse(userInput, out userInputInt)) { //check if was a number
                MessageBox.Show("Not a number!");
                return;
            }

            if(userInputInt < 0) {  //check if greater than 0
                MessageBox.Show("Can't be less than 0!");
                return;
            }

            if(mySaveFileDialog.ShowDialog() == DialogResult.OK) { //open save dialog
                using (StreamWriter inFile = new StreamWriter(mySaveFileDialog.FileName)) { //save text file
                    for (int i = 0; i < userInputInt; i++) { //loop X times based off user input
                        inFile.WriteLine(rnd.Next(1, 101)); //write to file
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void saveFileButton_Click(object sender, EventArgs e) {
            mySaveFileDialog.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            fromFileListBox.Items.Clear(); //clear list box
        }

        private void openFileButton_Click(object sender, EventArgs e) {
            int sum = 0,
                count = 0;
            string line = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) { //open save dialog
                using (StreamReader inFile = new StreamReader(openFileDialog1.FileName)) { //save text file
                    line = inFile.ReadLine();
                    while (line != null) {
                        fromFileListBox.Items.Add(Int32.Parse(line));

                        sum += Int32.Parse(line);
                        count++;

                        line = inFile.ReadLine();
                    }
                }
            }
            fromFileListBox.Items.Add("");
            fromFileListBox.Items.Add("Sum of the numbers -> " + sum);
            fromFileListBox.Items.Add("Amount of numbers in file -> " + count);
        }
    }
}
