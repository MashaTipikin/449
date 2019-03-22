using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            int fatInput;
            int carbInput;
            int fatCalorieTotal;
            int carbCalorieTotal;

            fatInput = Int32.Parse(FatCalorieBox.Text);
            carbInput = Int32.Parse(CarbCalorieBox.Text);

            fatCalorieTotal = fatInput * 9;
            carbCalorieTotal = carbInput * 4;

            fatCalorieLabel.Text = fatCalorieTotal.ToString();
            carbCalorieLabel.Text = carbCalorieTotal.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
