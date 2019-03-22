using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop_selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int RegFee = 0;
            int Days = 0;
            string registrationInput = Workshop.SelectedItem.ToString();
            if(registrationInput == "Handling stress") // tests if user selected .. as input
            {
                RegCostLabel.Text = "$1000"; // displays registration fee 
                Days = 3; // assigns days
                RegFee = 1000; // assigns registration fee
            }
            else if(registrationInput == "Time management")
            {
                RegCostLabel.Text = "$800";
                Days = 3;
                RegFee = 800;
            }
            else if(registrationInput == "Supervision skills")
            {
                RegCostLabel.Text = "$1500";
                Days = 3;
                RegFee = 1500;
            }
            else if(registrationInput =="Negotiation")
            {
                RegCostLabel.Text = "$1300";
                Days = 5;
                RegFee = 1300;
            }
            else
            {
                RegCostLabel.Text = "$500";
                Days = 1;
                RegFee = 500;
            }

            int lodgingFee = 0;
            string lodgingInput = Location.SelectedItem.ToString();
            if (lodgingInput == "Austin") // tests if user selected .. as input
            {
                lodgingFee = 150 * Days; // my maths for my lodging fee
                LodgeCostLabel.Text = "$" + lodgingFee.ToString(); // displays lodging fee
            }
            else if (lodgingInput == "Chicago")
            {
                lodgingFee = 225 * Days;
                LodgeCostLabel.Text = "$" + lodgingFee.ToString();
            }
            else if (lodgingInput == "Dallas")
            {
                lodgingFee = 175 * Days;
                LodgeCostLabel.Text = "$" + lodgingFee.ToString();
            }
            else if (lodgingInput == "Orlando")
            {
                lodgingFee = 300 * Days;
                LodgeCostLabel.Text = "$" + lodgingFee.ToString();
            }
            else if (lodgingInput == "Phoenix")
            {
                lodgingFee = 175 * Days;
                LodgeCostLabel.Text = "$" + lodgingFee.ToString();
            }
            else
            {
                lodgingFee = 150 * Days;
                LodgeCostLabel.Text = "$" + lodgingFee.ToString();
            }

            int total;
            total = RegFee + lodgingFee; // math for my total
            TotalLabel.Text = "$" + total.ToString(); // displays total


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // closes it
        }
    }
}
