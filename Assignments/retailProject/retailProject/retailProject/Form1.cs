using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retailProject {
    public partial class Form1 : Form {

        List<RetailItem> myList = new List<RetailItem>();

        public Form1() {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        } // end of ExitButton

        private void AddItemButton_Click(object sender, EventArgs e) {
            try {
                string descriptionInput;
                int unitsInput;
                double priceInput;

                descriptionInput = descriptionTextBox.Text;
                unitsInput = Int32.Parse(unitsOnHandTextBox.Text);
                priceInput = double.Parse(priceTextBox.Text);

                myList.Add(new RetailItem(descriptionInput, unitsInput, priceInput));

                resultBox.Rows.Clear();

                loadIntoDataGridView();

                MessageBox.Show("Added your item!");
            } catch (Exception) {
                MessageBox.Show("Units on hand and price must be a number!");
            }
        } // end of AddItemButton

        private void Form1_Load(object sender, EventArgs e) {
           loadFromTxtFile(); //when form loads, call load function
            loadIntoDataGridView(); //load dataGridView with data from list
        } // end of form1_load

        private void loadIntoDataGridView() {
            for(int i = 0; i < myList.Count; i++) { //cycle thru the list
                int row = resultBox.Rows.Add(); //add a new row to the data grid view

                resultBox.Rows[row].Cells[0].Value = (i + 1);   //item number counter
                resultBox.Rows[row].Cells[1].Value = myList[i].ItemDescription; //for item "i" in my list, display its description - units on hand - and price
                resultBox.Rows[row].Cells[2].Value = myList[i].UnitsOnHand;
                resultBox.Rows[row].Cells[3].Value = "$" + myList[i].Price;
            }
        } //end of loadIntoDataGridView

        private void loadFromTxtFile() {
            try {
                StreamReader inFile = new StreamReader("item.txt");

                string itemDescription,
                    unitsOnHand,
                    price,
                    currentLine;

                currentLine = inFile.ReadLine();
                while (currentLine != null) {
                    itemDescription = currentLine;

                    currentLine = inFile.ReadLine();
                    unitsOnHand = currentLine;

                    currentLine = inFile.ReadLine();
                    price = currentLine;

                    myList.Add(new RetailItem(itemDescription, Int32.Parse(unitsOnHand), double.Parse(price)));

                    currentLine = inFile.ReadLine();
                }

                inFile.Close();

            } catch (Exception) {
                MessageBox.Show("No text file");
            }
        } // end of loadFromTxtFile

        private void SaveButton_Click(object sender, EventArgs e) {   
            try {
                StreamWriter outFile = new StreamWriter("item.txt"); //open txt file
                string outDescription,  //hold retail item stuff
                       outUnitsonHand,
                       outPrice;

                for(int i = 0; i < myList.Count; i++) { //cycle entire list
                    outDescription = myList[i].ItemDescription; //get description for this retail item
                    outUnitsonHand = myList[i].UnitsOnHand.ToString(); //get units on hand for this retail item
                    outPrice = myList[i].Price.ToString(); //get price for this retail item

                    outFile.WriteLine(outDescription); //store in txt file
                    outFile.WriteLine(outUnitsonHand);
                    outFile.WriteLine(outPrice);
                }
                MessageBox.Show("Saved!");

                outFile.Close();                                                                 //close file
            } catch (Exception) {   //couldnt find file
                MessageBox.Show("Can't find items.txt!");
            }
        } // end of saveButton
    } // end of Form1 class

    public class RetailItem {

        public RetailItem(string itemDescription_, int unitsOnHand_, double price_) {
            itemDescription = itemDescription_;
            unitsOnHand = unitsOnHand_;
            price = price_;
        }

        private string itemDescription;
        public string ItemDescription {
            get {
                return itemDescription;
            }
            set {
                itemDescription = value;
            }
        }

        private int unitsOnHand;
        public int UnitsOnHand {
            get {
                return unitsOnHand;
            }
            set {
                unitsOnHand = value;
            }
        }

        private double price;
        private string unitsOnHand1;
        private string currentLine;

        public double Price {
            get {
                return price;
            }
            set {
                price = value;
            }
        }
    } //end of RetailItem class
        
} //end of namespace RetailProject