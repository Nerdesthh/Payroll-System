using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Payroll_System
{
    public partial class JuniorHigh : Form
    {
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\GitHub\Payroll-System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30");

        public JuniorHigh(string username)
        {
            InitializeComponent();
            DisplayStaffJuniorHS();
            DisableInputs();
            CommonClass.origin = this;
        }

        private void DisableInputs()
        {
            EmpIDInfoJHS.Enabled = false;
            EmpNameJHS.Enabled = false;
            ContactJHS.Enabled = false;
            EmailJHS.Enabled = false;
        }

        public void DisplayStaffJuniorHS()
        {
            EmployeeDatas ed = new EmployeeDatas();
            List<EmployeeDatas> listData = ed.StaffListData("Junior High School");
            JHSDataGrid.DataSource = listData;
        }

        private void ReturnBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
            {
                CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
            }
            CommonClass.MainBoard.Show();
            CommonClass.MainBoard.BringToFront();
        }


        private void JHSDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Prevent errors when clicking the header


            DataGridViewRow row = JHSDataGrid.Rows[e.RowIndex];

            // Used null-safe access to prevent crashes
            //when the user clicked an active cell, it will automatically input the data requitements to proceed to the calc
            EmpIDInfoJHS.Text = row.Cells[1].Value?.ToString() ?? "N/A";
            EmpNameJHS.Text = row.Cells[2].Value?.ToString() ?? "N/A";
            ContactJHS.Text = row.Cells[5].Value?.ToString() ?? "N/A";
            EmailJHS.Text = row.Cells[6].Value?.ToString() ?? "N/A";
            string folderpath = row.Cells[9].Value?.ToString() ?? "N/A";
            CommonClass.stafffolder = folderpath;

            //declaring all the needed variables to proceed/gather to the next step
            string empName = EmpNameJHS.Text;
            string department = "Junior High School";
            string email = EmailJHS.Text;
            string beforetax = "";
            string aftertax = "";
            string sss = "";
            string pagibig = "";
            string absents = "";
            string lates = "";
            string PhilHealth = "";
            string deduction = "";
            string period = "";
            string username = CommonClass.adminfullname;
            CommonClass.origin = this;
            //calling main function which is the calculator
            if (CommonClass.Maincalc == null || CommonClass.Maincalc.IsDisposed)
            {
                CommonClass.Maincalc = new MainFunctionStaff(empName, department, email, period, username, folderpath, CommonClass.origin);
            }

            CommonClass.Maincalc.SetEmployeeDetails(empName);

            if (CommonClass.EmailNow == null || CommonClass.EmailNow.IsDisposed)
            {
                //while calling a .cs file, you need to input its needed variable that is required
                CommonClass.EmailNow = new SendToStaff(empName, department, email, beforetax, aftertax, sss, pagibig, absents, lates, PhilHealth, deduction, period, username, folderpath, CommonClass.origin);
            }
            else
            {
                CommonClass.EmailNow.employeedetailsSHS(empName, department, email);
            }
        }

        private void Proceed2MainFuctionJHS_Click(object sender, EventArgs e)
        {
            //will not proceed if the user did not select an active cell
            if (string.IsNullOrWhiteSpace(EmpIDInfoJHS.Text) ||
            string.IsNullOrWhiteSpace(EmpNameJHS.Text) ||
            string.IsNullOrWhiteSpace(ContactJHS.Text) ||
            string.IsNullOrWhiteSpace(EmailJHS.Text))
            {
                //messagebox will show and instruct the user1
                MessageBox.Show("Please select a valid employee!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //redeclaring a variable since pervious declared variable will not reach, because the function is declared as private
            string empName = EmpNameJHS.Text;
            string department = "Junior High School";
            string email = EmailJHS.Text;
            string aftertax = "";
            string period = "";
            string username = CommonClass.adminfullname;
            string folderpath = CommonClass.stafffolder;
            CommonClass.origin = this;

            this.Hide();
            if (CommonClass.Maincalc == null || CommonClass.Maincalc.IsDisposed)
            {
                string beforetax = "";
                CommonClass.Maincalc = new MainFunctionStaff(empName, department, email, period, username, folderpath, CommonClass.origin);
            }
            CommonClass.Maincalc.Show();
            CommonClass.Maincalc.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.Staffinput == null || CommonClass.Staffinput.IsDisposed)
            {
                CommonClass.Staffinput = new InputStaff();
            }
            CommonClass.Staffinput.Show();
            CommonClass.Staffinput.BringToFront();
        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
