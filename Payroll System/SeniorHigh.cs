using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Payroll_System
{
    public partial class SeniorHigh : Form
    {
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\GitHub\Payroll-System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30");

        public SeniorHigh(string username)
        {
            //triggering function to execute its code
            InitializeComponent();
            displaystaff();
            disable();
            CommonClass.origin = this;

        }
        //if the cell is clicked the spesific content will be shown into the textbox.
        private void ShsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ShsDataGrid.Rows[e.RowIndex];
                //the [1] is called on the employee data 
                EmpIDInfo.Text = row.Cells[1].Value.ToString();
                EmpNameInfo.Text = row.Cells[2].Value.ToString();
                ContactInfo.Text = row.Cells[5].Value.ToString();
                EmailInfo.Text = row.Cells[6].Value.ToString();
                //calling new variables to gather data from main_function (calc) to sendtostaff (email send)
                string empName = row.Cells[2].Value?.ToString() ?? "N/A";
                string department = row.Cells[4].Value?.ToString() ?? "N/A";
                string email = row.Cells[6].Value?.ToString() ?? "N/A";
                string folderpath = row.Cells[9].Value?.ToString() ?? "N/A";
                CommonClass.stafffolder = folderpath;
                string beforetax = "";
                string aftertax = "";
                string sss = "";
                string pagibig = "";
                string lates = "";
                string absents = "";
                string PhilHealth = "";
                string deduction = "";
                string period = "";
                string username = CommonClass.adminfullname;
                CommonClass.origin = this;

                //conditional statement that calls data with its variales 
                if (CommonClass.Maincalc == null || CommonClass.Maincalc.IsDisposed)
                {
                    CommonClass.Maincalc = new MainFunctionStaff(empName, department, email, period, username, folderpath, CommonClass.origin);
                }
                CommonClass.Maincalc.SetEmployeeDetails(empName);

                if (CommonClass.EmailNow == null || CommonClass.EmailNow.IsDisposed)
                {
                    CommonClass.EmailNow = new SendToStaff(empName, department, email, beforetax, aftertax, sss, pagibig, lates, absents, PhilHealth, deduction, period, username, folderpath, CommonClass.origin);
                }
                else
                {
                    CommonClass.EmailNow.employeedetailsSHS(empName, department, email);
                }
            }
        }



        private void disable()
        {
            //disabling textbox to make it non editable
            EmpIDInfo.Enabled = false;
            EmpNameInfo.Enabled = false;
            ContactInfo.Enabled = false;
            EmailInfo.Enabled = false;
        }

        public void displaystaff()
        {
            EmployeeDatas ed = new EmployeeDatas();
            List<EmployeeDatas> listdata = ed.StaffListData("Senior High School");

            // DEBUG: Check if folderpath exists
            foreach (var item in listdata)
            {
                Console.WriteLine($"DEBUG: folderpath = {item.folderpath}");
            }

            ShsDataGrid.DataSource = listdata;
        }


        private void ReturnBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            //the mainboard will show when the return button is clicked
            if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
            {
                //calls the mainboard from the common class
                CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
            }
            //used commonclass to show the dashboard using to the code above
            CommonClass.MainBoard.Show();
            CommonClass.MainBoard.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this will show the input staff where you can input more staff to the system
            this.Close();
            if (CommonClass.Staffinput == null || CommonClass.Staffinput.IsDisposed)
            {
                CommonClass.Staffinput = new InputStaff();
            }
            CommonClass.Staffinput.Show();
            CommonClass.Staffinput.BringToFront();
        }

        private void SeniorHigh_Load(object sender, EventArgs e)
        {

        }

        private void Proceed2MainFuction_Click(object sender, EventArgs e)
        {
            //ensuring the textbox has a value inside of it to proceed with no casualties
            if (EmpIDInfo.Text == "" || EmpNameInfo.Text == "" || ContactInfo.Text == "" || EmailInfo.Text == "")
            {
                MessageBox.Show("Please select a cell!", "Cell Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                if (CommonClass.Maincalc == null || CommonClass.Maincalc.IsDisposed)
                {
                    //calling 3 variables, this is important for the sendtostaff.cs 
                    string empName = "";
                    string department = "";
                    string email = "";
                    string period = "";
                    string username = CommonClass.adminfullname;
                    string folderpath = CommonClass.stafffolder;
                    CommonClass.origin = this;
                    //calling the function with its contained variables
                    CommonClass.Maincalc = new MainFunctionStaff(empName, department, email, period, username, folderpath, CommonClass.origin);
                }
                CommonClass.Maincalc.Show();
                CommonClass.Maincalc.BringToFront();
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShsDataGrid_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

