using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Teachercalc : Form
    {
        string deduction;
        public Teachercalc(string deduction)
        {
            InitializeComponent();
            disable();
            this.deduction = deduction;
        }
        public void disable()
        {
            //this will disable the input function of the textbox 
            absencededuct.Enabled = false;
            AbsenseLebel.Enabled = false;
            Beforetaxtxt.Enabled = false;
            Aftertaxtxt.Enabled = false;
            RateInputAB.Enabled = false;
        }


        private void BeforeTaxCompute_Click(object sender, EventArgs e)
        {
            //ensure that both hourinput and loadinput.text will have an input value to proceed
            if (HourRateinput.Text == "" && Loadsinput.Text == "")
            {
                MessageBox.Show("Please fill-in the blanks", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //if there's value math will proceed
                decimal hour_rate, loads;
                //hourrate and loads will is declared as decimal into a text
                hour_rate = decimal.Parse(HourRateinput.Text);
                loads = decimal.Parse(Loadsinput.Text);
                decimal beforetax;
                //inputting value for hourtax which to times the hour_rate and loads
                beforetax = hour_rate * loads;
                //"N2" formats the  number to add comma (,) each thousands with decimal number
                Beforetaxtxt.Text = (beforetax).ToString("N2");

                //if hourinput for absents and rateinput is valued into nothing
                //absencedecut and absense label will automatically valued at 0
                if (HourInputAB.Text == "" && RateInputAB.Text == "" && lateinput.Text == "")
                {
                    //absencededuct text will be automatically valued as 0
                    absencededuct.Text = (0).ToString("N2");
                    AbsenseLebel.Text = (0).ToString("N2");
                    lateinput.Text = (0).ToString("N2");
                    HourInputAB.Text = (0).ToString("N2");

                    RateInputAB.Text = HourRateinput.Text;
                }

                //if there's a value on the this block of code of else will trigger
                else
                {
                    //declared hour and rate as the variables for absents
                    decimal hour, rate;
                    //same process above
                    hour = decimal.Parse(HourInputAB.Text);
                    rate = decimal.Parse(RateInputAB.Text);
                    //absenecelebel is valued by hour times rate then format into N2
                    AbsenseLebel.Text = (hour * rate).ToString("N2");
                    absencededuct.Text = (hour * rate).ToString("N2");


                }
            }

        }


        private void CalculateSalary_Click(object sender, EventArgs e) // here comes the math comming from this calculator
        {
            //same process form above where hourinput and loadsinput, is null
            if (string.IsNullOrWhiteSpace(HourRateinput.Text) && string.IsNullOrWhiteSpace(Loadsinput.Text))
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //declaring variables SSS, PHILHEALTH etc. and inputting avalue of zero
                decimal SSS = 0, PHILHEALTH = 0, PAGIBIG = 0, beforetax = 0, deductiontotal = 0, latesdeduct = 0, absents = 0;

                // Safely parse values with default fallbacks
                // displaying sssinput.text textbox with the variable sss and so on...
                decimal.TryParse(SSSinput.Text, out SSS);
                decimal.TryParse(Philhlthinput.Text, out PHILHEALTH);
                decimal.TryParse(pagibiginput.Text, out PAGIBIG);
                decimal.TryParse(Beforetaxtxt.Text, out beforetax);
                decimal.TryParse(absencededuct.Text, out absents);
                decimal.TryParse(lateinput.Text, out latesdeduct);

                // Handle the absence deduction
                if (decimal.TryParse(absencededuct.Text, out absents) == false)
                {
                    absents = 0;  //Default to zero if it's invalid
                }

                // Handle late deduction safely
                if (!string.IsNullOrWhiteSpace(lateinput.Text))
                {
                    decimal.TryParse(lateinput.Text, out latesdeduct);
                }

                // Calculate total deductions properly
                deductiontotal = SSS + PHILHEALTH + PAGIBIG + absents + latesdeduct;

                //  Compute final salary
                decimal afterTax = beforetax - deductiontotal;
                Aftertaxtxt.Text = afterTax.ToString("N2");

                // Store `deductiontotal` as a **string** to pass it correctly
                deduction = deductiontotal.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating salary: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearall()
        {
            HourRateinput.Text = string.Empty;
            Loadsinput.Text = string.Empty;
            HourInputAB.Text = string.Empty;
            RateInputAB.Text = string.Empty;
            AbsenseLebel.Text = string.Empty;
            Beforetaxtxt.Text = string.Empty;
            absencededuct.Text = string.Empty;
            lateinput.Text = string.Empty;
            SSSinput.Text = string.Empty;
            Philhlthinput.Text = string.Empty;
            pagibiginput.Text = string.Empty;
            Aftertaxtxt.Text = string.Empty;

        }

        private void Clearbtn_Click_1(object sender, EventArgs e)
        {
            clearall();

        }

        private void ReturnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            if(CommonClass.teacherdash == null || CommonClass.teacherdash.IsDisposed)
            {
                CommonClass.teacherdash = new TeacherDashboard(CommonClass.staffusernamedashboard);
            }
            CommonClass.teacherdash.Show();
            CommonClass.teacherdash.BringToFront();
        }
    }
}
