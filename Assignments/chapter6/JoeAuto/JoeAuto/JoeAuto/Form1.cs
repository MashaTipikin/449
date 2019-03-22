using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double oilLube()
        {
            double sum = 0; //find if oil or/and lube were selected

            if (OilChangeCheckBox.Checked == true)
            {
                sum += 26.00;
            }
            if (LubeJobCheckBox.Checked == true)
            {
                sum += 18.00;
            }
            return sum; //return cost of selection
        }

        private double flush()
        {
            double sum = 0;

            if (RadiatorFlushCheckBox.Checked == true) //find if radiator and/or transmssion were selected
            {
                sum += 30.00;
            }
            if (transmissionFlushCheckBox.Checked == true)
            {
                sum += 80.00;
            }

            return sum; //return cost of selection
        }

        private double misc()
        {
            double sum = 0;

            if (inspectionCheckBox.Checked == true) //find if inspection, muffler, tire were selected
            {
                sum += 15.00;
            }
            if (replaceMufflerCheckBox.Checked == true)
            {
                sum += 100.00;
            }
            if (tireRotationCheckBox.Checked == true)
            {
                sum += 20.00;
            }
            return sum; //return selection cost
        }

        private double totalCost() //call other functions to get a tota cost
        {
            double sum = 0;

            sum += oilLube();
            sum += flush();
            sum += misc();


            return sum;
        }

        private double tax()
        {
            double PartsCost = 0;

            try
            {
                PartsCost = Int32.Parse(PartsInput.Text); //get tax amount

                return .06 * PartsCost;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return 0;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double LaborCost = 0;
            double ServiceLaborTotal = 0;
            double PartsCost = 0;
            double TotalCost = 0;

            try
            {
                PartsCost = Int32.Parse(PartsInput.Text);
                LaborCost = 20 * Int32.Parse(LaborHoursInput.Text);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            ServiceLaborTotal = totalCost() + LaborCost; //find labor cost

            TotalCost = ServiceLaborTotal + PartsCost + tax(); //total cost

            serviceAndLaborLabel.Text = "$" + ServiceLaborTotal.ToString(); //display costs
            partsLabel.Text = "$" + PartsCost.ToString();
            taxLabel.Text = "$" + tax().ToString();
            totalFeesLabel.Text = "$" + TotalCost.ToString();
        }

        private void ClearOilLube()
        {
            OilChangeCheckBox.Checked = false; //uncheck boxes
            LubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            RadiatorFlushCheckBox.Checked = false; //uncheck boxes
            transmissionFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false; //uncheck boxes
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            PartsInput.Text = "";
            LaborHoursInput.Text = "";
        }

        private void ClearFees()
        {
            serviceAndLaborLabel.Text = ""; //uncheck textboxes
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalFeesLabel.Text = "";
        }


        private void clear_Click(object sender, EventArgs e)
        {
            ClearOilLube(); //call all clear functions
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
