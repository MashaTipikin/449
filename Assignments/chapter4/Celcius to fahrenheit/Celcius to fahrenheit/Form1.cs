using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celcius_to_fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {

                double fahrenheit = 0;

                for (double i = 0; i <= 20; i++) //loop 20 times
                {
                fahrenheit = ((9.0 / 5.0) * i + 32.0); //c to f conversion
                FahrenheitCalcs.Items.Add(fahrenheit + " °fahrenheit = " + i + " °celsius"); //display conversion results
                }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // closes
        }
    }
}
