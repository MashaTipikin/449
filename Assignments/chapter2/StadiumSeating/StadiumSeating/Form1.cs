using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int total = 0; //variable to hold total

            total = total + aClassCalc(); //find totals for each class
            total = total + bClassCalc();
            total = total + cClassCalc();

            totalRevenueTextBox.Text = "$" + total; //show total
        }

        private int aClassCalc()
        {
            int result = 0; //variable to hold total for class A
            int ticketsSold = 0; //variable to hold the amount of tickets sold for class A

            ticketsSold = Int32.Parse(aClassTicketsTextBox.Text); //store ticket amount. and convert to a number
            if(ticketsSold < 0) // tests if user input is negative
            {
                return result = 0;
            }
            result = ticketsSold * 15; //math calculation. tickets sold * the amount

            aClassRevenueTextBox.Text = "$" + result.ToString(); //show total for class. convert to string

            return result;
        }

        private int bClassCalc()
        {
            int result = 0; //variable to hold total for class B
            int ticketsSold = 0; //variable to hold the amount of tickets sold for class B

            ticketsSold = Int32.Parse(bClassTicketsTextBox.Text); //store ticket amount. and convert to a number
            if(ticketsSold < 0) // tests if user input is negative
            {
                return result = 0;
            }
            result = ticketsSold * 12; //math calculation. tickets sold * the amount

            bClassRevenueTextBox.Text = "$" + result.ToString(); //show total for class. convert to string

            return result;
        }

        private int cClassCalc()
        {
            int result = 0; //variable to hold total for class C
            int ticketsSold = 0; //variable to hold the amount of tickets sold for class C

            ticketsSold = Int32.Parse(cClassTicketsTextBox.Text); //store ticket amount. and convert to a number
            if (ticketsSold < 0) // tests if user input is negative
            {
                return result = 0;
            }
            result = ticketsSold * 9; //math calculation. tickets sold * the amount

            cClassRevenueTextBox.Text = "$" + result.ToString(); //show total for class. convert to string

            return result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aClassRevenueTextBox.Text = ""; //clear text boxes
            bClassRevenueTextBox.Text = "";
            cClassRevenueTextBox.Text = "";
            totalRevenueTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close program
        }
    }
}
