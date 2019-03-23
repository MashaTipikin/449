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

namespace BabyNames {
    public partial class Form1 : Form {

        public static List<String> boyList = new List<String>();    //hold all boys name from file
        public static List<String> girlList = new List<String>();   //hold all girls name from file

        public Form1() {
            InitializeComponent();

            loadBoys(); //load boys and girls names into Lists
            loadGirls();
        }

        private void loadBoys() {
            try {
                StreamReader inFile = new StreamReader("BoyNames.txt"); //bring in text file
                String currentLine = ""; //string to hold boy names from file

                currentLine = inFile.ReadLine(); //read line from txt file
                while (currentLine != null) {    //continue until file is empty
                    boyList.Add(currentLine);  //add the boy name to the team list

                    currentLine = inFile.ReadLine(); //read next item
                }
                inFile.Close(); //close team txt file
            } catch (Exception ex) { //couldnt find boy file
                MessageBox.Show(ex.ToString());
            }
        } //end of loadBoys()

        private void loadGirls() {
            try {
                StreamReader inFile = new StreamReader("GirlNames.txt"); //bring in text file
                String currentLine = ""; //string to hold girl names from file

                currentLine = inFile.ReadLine(); //read line from txt file
                while (currentLine != null) {    //continue until file is empty
                    girlList.Add(currentLine);  //add the girl name to the team list

                    currentLine = inFile.ReadLine(); //read next item
                }
                inFile.Close(); //close team txt file
            } catch (Exception ex) { //couldnt find girl file
                MessageBox.Show(ex.ToString());
            }

        } //end of loadGirls()

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close(); //close
        } //end of exitButton

        private void clearButton_Click(object sender, EventArgs e) {
            clear();
        } //end of clearButton

        private void clear() {
            boyLabel.Text = "";
            girlLabel.Text = "";

            girlTextbox.Text = ""; //clear textboxes and labes
            boyTextbox.Text = "";
        } //end of clear()

        private void searchButton_Click(object sender, EventArgs e) {
            searchBoys(); //call functions to search for names
            searchGirls();
        } //end of searchButton

        private void searchBoys() {
            try {
                String userName = boyTextbox.Text; //grab the user entered name

                foreach(var boy in boyList) {
                    if(userName.Equals(boy, StringComparison.InvariantCultureIgnoreCase)) { //compare the user entered name with the names in the list, ignoring casing
                        boyLabel.Text = "Yes, " + userName + " was among the popular for boys."; //name was found, display message and stop work
                        return;
                    } else { // didnt find name in the list
                        boyLabel.Text = "No, " + userName + " wasn't among the popular for boys.";
                    }
                }
            } catch (Exception ex) { //user didnt enter a name
                MessageBox.Show(ex.ToString());
            }
        } //end of searchBoys

        private void searchGirls() {
            try {
                String userName = girlTextbox.Text; //grab the user entered name

                foreach (var girl in girlList) {
                    if (userName.Equals(girl, StringComparison.InvariantCultureIgnoreCase)) { //compare the user entered name with the names in the list, ignoring casing
                        girlLabel.Text = "Yes, " + userName + " was among the popular for girls."; //name was found, display message and stop search
                        return;
                    } else { // didnt find name in the list
                        girlLabel.Text = "No, " + userName + " wasn't among the popular for girls.";
                    }
                }
            } catch (Exception ex) { //user didnt enter a name
                MessageBox.Show(ex.ToString());
            }
        } //end of searchGirls

    }
}
