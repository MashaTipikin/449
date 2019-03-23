using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace WorldSeriesWinners {
    public partial class Form1 : Form {

        public static List<String> teamList = new List<String>();   //Create list to hold teams
        public static List<String> winList = new List<String>();   //Create list to hold winning teams

        public Form1() {
            InitializeComponent();

            loadTeams(); //load teams and display them right away
            loadWinners(); //load winning teams into a list
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close(); //close when clicked
        }

        private void selectButton_Click(object sender, EventArgs e) {
            int winAmount = 0; //holds the amount of times a team won

            try {
                String user = myListbox.SelectedItem.ToString(); //holds the team the user selected

                foreach (var team in winList) { //go through the list and find out how mnay times that team won
                    if (user.Equals(team)) { //go through the list and compare with the user choice
                        winAmount++; //that team was found, add one to its win count
                    }
                }

                myLabel.Text = user + " won the World Series " + winAmount + " time(s)!"; //display user team plsu amt of wins
            } catch (Exception ex) { //user didnt pick a team
                MessageBox.Show(ex.ToString());
            }
        } //end of selectButton_Click

        private void loadTeams() {
            try {
                StreamReader inFile = new StreamReader("Teams.txt"); //bring in text file
                String currentLine = ""; //string to hold teams from file

                currentLine = inFile.ReadLine(); //read line from txt file
                while (currentLine != null) {    //continue until file is empty
                    teamList.Add(currentLine);  //add the team name to the team list

                    currentLine = inFile.ReadLine(); //read next item
                }
                inFile.Close(); //close team txt file

                foreach (var team in teamList) { //go through the list and print show team in the listbox
                    myListbox.Items.Add(team);
                }
            } catch (Exception ex) { //couldnt find team file
                MessageBox.Show(ex.ToString());
            }
        } //end of loadTeams();

        private void loadWinners() {
            try {
                StreamReader inFile = new StreamReader("WorldSeriesWinners.txt"); //bring in text file
                String currentLine = ""; //string to hold teams from file

                currentLine = inFile.ReadLine(); //read line from txt file
                while (currentLine != null) {    //continue until file is empty
                    winList.Add(currentLine);  //add the team name to the team list

                    currentLine = inFile.ReadLine(); //read next item
                }
                inFile.Close(); //close winners txt file
            } catch (Exception ex) { //couldnt find winners file
                MessageBox.Show(ex.ToString());
            }
        } // end of loadWinners();

    }
}
