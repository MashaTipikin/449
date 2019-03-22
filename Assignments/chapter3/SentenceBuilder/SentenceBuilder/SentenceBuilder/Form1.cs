using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenceBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bigAbutton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "A";
        }

        private void smallAbutton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "a";
        }

        private void bigAnButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "An";
        }

        private void smallAnButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "an";
        }

        private void bigTheButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "The";
        }

        private void smallTheButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "the";
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "bicycle";
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "man";
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "woman";
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "dog";
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "cat";
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "car";
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "beautiful";
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "big";
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "small";
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "strange";
        }

        private void lookedButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "looked";
        }

        private void modeButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "rode";
        }

        private void spokeButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "spoke";
        }

        private void laughButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "laugh";
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "drove";
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += " ";
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += ".";
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text += "!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
