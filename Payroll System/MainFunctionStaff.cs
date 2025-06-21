using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Payroll_System
{


    public partial class MainFunctionStaff : Form
    {
        private string empName;
        private string department;
        private string email;
        private string deduction = "some_value"; // Ensure deduction is properly initialized
        private string period;
        private string username;
        private string folderpath;
        private Form origin;



        public MainFunctionStaff(string empName, string department, string email, string period, string username, string folderpath, Form origin)
        {
            InitializeComponent();
            //will redefine the variable on this form to the variable from the other form which has an existing variable
            
            //example for empname "this.empName" is the variable declared inside of this form, therefore I added its value as empName comming from the other form
            this.empName = empName;
            this.department = department;
            this.email = email;
            this.period = period;
            this.username = username;

            UserBox.Text = empName;
            disable(); //calls the disable method to disable the selected textbox
            this.folderpath = folderpath;
            this.origin = origin;
        }

        private void SendToStaff_Click(object sender, EventArgs e)
        {
        //if the user did not fill in the required fields
            if(HourRateinput.Text == "" && Loadsinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: Hour Rate & Loads", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (HourRateinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: Hour Rate", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Loadsinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: Loads", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SSSinput.Text == "" && pagibiginput.Text == "" && Philhlthinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: SSS, PagIbig & PhilHealth", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pagibiginput.Text == "" && Philhlthinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: PagIbig & PhilHealth", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pagibiginput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: PagIbig", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SSSinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: SSS", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Philhlthinput.Text == "")
            {
                MessageBox.Show("Please input the following textbox to proceed: PhilHealth", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Beforetaxtxt.Text == "" && Aftertaxtxt.Text == "")
            {
                MessageBox.Show("Please click the calculate button to proceed: Before Tax & After Tax", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Beforetaxtxt.Text == "")
            {
                MessageBox.Show("Please click the calculate button to proceed: Before Tax", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Aftertaxtxt.Text == "")
            {
                MessageBox.Show("Please click the calculate button to proceed: After Tax", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else // proceeds to the other form where the staff sends the reciept
            {
                // Convert PhilHealthinput.Text to string (since textboxes store strings)
                string philhealthValue = Philhlthinput.Text;  // Keep it as a string

                // Ensure deduction is also treated as a string
                string deductionValue = deduction.ToString();  // Convert if necessary

                // Ensure LateInput.Text is passed correctly
                string lateValue = lateinput.Text; // Keep as string, unless conversion is needed

                // Create the SendToStaff form with properly formatted values
                SendToStaff sendForm = new SendToStaff(
                    empName, department, email,
                    Beforetaxtxt.Text, Aftertaxtxt.Text, SSSinput.Text,
                    pagibiginput.Text, absencededuct.Text, lateinput.Text,
                    Philhlthinput.Text, deduction, period, username, folderpath, origin
                );
                this.Close();
                sendForm.ShowDialog(); // Open the form after setting data

            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

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
                if (HourInputAB.Text == "" && lateinput.Text == "")
                {
                    //absencededuct text will be automatically valued as 0
                    absencededuct.Text = (0).ToString("N1");
                    AbsenseLebel.Text = (0).ToString("N1");
                    lateinput.Text = (0).ToString("N1");
                    HourInputAB.Text = (0).ToString("N1");

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

        //same process on the other code
        private void ReturnBTN_Click(object sender, EventArgs e)
        {
                this.Close(); // Close SendToStaff

            // Debugging: Check what origin is before showing it
            if (CommonClass.origin != null && !CommonClass.origin.IsDisposed)
            {
                CommonClass.origin.Show();
                CommonClass.origin.BringToFront();
            }
            else
            {
                // If origin is lost, go back to Dashboard
                if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
                {
                    CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
                }
                CommonClass.MainBoard.Show();
                CommonClass.MainBoard.BringToFront();
            }
        }

        private void LastHalf_CheckedChanged(object sender, EventArgs e) //here it will add the string value if the lasthalf radio button has clicked
        {
            if (LastHalf.Checked)
            {
                period = "16-31"; // it will get the value of the variable period as 16-31
            }

        }
        private void FirstHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstHalf.Checked)
            {
                period = "1-15"; // it wil get the value of the varible period as 1-15
            }

        }


        private void HourRateinput_TextChanged(object sender, EventArgs e)
        {

        }


        private void Main_Function_Load(object sender, EventArgs e)
        {

        }
        //this function will add all deduction then minusing them on the beforetax
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

        public void clearall()
        {
            //clear out of all input
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

        public void disable()
        {
            //this will disable the input function of the textbox 
            absencededuct.Enabled = false;
            AbsenseLebel.Enabled = false;
            UserBox.Enabled = false;
            Beforetaxtxt.Enabled = false;
            Aftertaxtxt.Enabled = false;
            RateInputAB.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }


        private void SSSinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void absencededuct_TextChanged(object sender, EventArgs e)
        {

        }


        public void SetEmployeeDetails(string empName)
        {
            //empname has the value from the stafflisttable (any form)
            UserBox.Text = empName;
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RateInputAB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Aftertaxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

