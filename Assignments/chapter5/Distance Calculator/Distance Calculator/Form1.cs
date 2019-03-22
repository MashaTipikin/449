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

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter InputFile = new StreamWriter("Answers.txt"); //location of file -> Distance Calculator\Distance Calculator\bin\Debug
                                                                            //try to open file
                int time = 0; // declare variables
                int mph = 0;
                int total = 0;

                time = Int32.Parse(HoursInput.Text); // convert int 
                mph = Int32.Parse(MPHinput.Text);

                for (int i = 0; i < time; i++) // loops based on user input
                {
                    total = (i + 1) * mph; // math 

                    AnswerBox.Items.Add("After hour " + (i + 1) + " the distance is " + total); // displays results in answer box
                    InputFile.WriteLine("After hour " + (i + 1) + " the distance is " + total); // writes results to file 
                }
                InputFile.Close(); // closes file
            }
            catch(Exception ex) //couldn't open file
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {            this.Close(); // closes program
        }
    }
}
