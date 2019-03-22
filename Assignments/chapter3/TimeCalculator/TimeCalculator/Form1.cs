using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaysLabel.Text = ""; // clear textboxes
            HoursLabel.Text = "";
            minutesLabel.Text = "";
            secondsLabel.Text = "";

            int Input = Int32.Parse(UserInput.Text); // pull user data and create result variables
            int resultDays = 0;
            int resultHours = 0;
            int resultMins = 0;
            int resultSecs = 0;

            resultDays = Input / (24 * 3600); // find days
            Input = Input % (24 * 3600); // trim user input
            resultHours = Input / 3600;
            Input %= 3600;
            resultMins = Input / 60;
            Input %= 60;
            resultSecs = Input;
            
            if(resultDays > 0) // if there are days display them
            {
                DaysLabel.Text = resultDays + " day(s)";
            }
            if(resultHours > 0)
            {
                HoursLabel.Text = resultHours + " hour(s)";
            }
            if(resultMins > 0)
            {
                minutesLabel.Text = resultMins + " min(s)";
            }
            if(resultSecs > 0)
            {
                secondsLabel.Text = resultSecs + " sec(s)";
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            UserInput.Text = ""; // clears input
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // closes window
        }
    }
}
