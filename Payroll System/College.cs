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

namespace Payroll_System
{
    public partial class College : Form
    {
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30;");

        public College(string username)
        {
            InitializeComponent();
            displaystaff();
            disable();
            CommonClass.origin = this;

        }
        private void disable()
        {
            EmpIDInfo.Enabled = false;
            EmpNameInfo.Enabled = false;
            ContactInfo.Enabled = false;
            EmailInfo.Enabled = false;
        }

        public void displaystaff()
        {

            EmployeeDatas ed = new EmployeeDatas();
            List<EmployeeDatas> listdata = ed.StaffListData("College");

            CollegeDataGrid.DataSource = listdata;

        }



        private void College_Load(object sender, EventArgs e)
        {

        }
        public void Getfolderpath(string username)
        {
            try
            {
                ConnectData.Open();
                string query = "SELECT folderpath, full_name FROM users WHERE username = @username"; // Replace with your actual query where you retrieve user data (@username)
                using (SqlCommand cmd = new SqlCommand(query, ConnectData)) //using the query as CMD to retrieve user data
                {
                    cmd.Parameters.AddWithValue("@username", username); // Add the username parameter
                    using (SqlDataReader reader = cmd.ExecuteReader()) ///using the query as CMD to retrieve user data which is reader
                    {
                        if (reader.Read()) //reader variable to read the datas from the database
                        {
                            string folderpath = reader["folderpath"].ToString(); // Retrieve the image path from the database
                            CommonClass.adminfullname = reader["full_name"].ToString(); // Retrieve the full name from the database
                            CommonClass.stafffolder = folderpath;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectData.Close();

            }
        }


        private void ReturnBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            //
            if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
            {
                CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
            }

            CommonClass.MainBoard.Show();
            CommonClass.MainBoard.BringToFront();

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

        private void Proceed2MainFuction_Click(object sender, EventArgs e)
        {
            if (EmpIDInfo.Text == "" || EmpNameInfo.Text == "" || ContactInfo.Text == "" || EmailInfo.Text == "")
            {
                MessageBox.Show("Please select a cell!", "Cell Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                if (CommonClass.Maincalc == null || CommonClass.Maincalc.IsDisposed)
                {
                    string empName = "";
                    string department = "College";
                    string email = "";
                    string period = "";
                    string username = CommonClass.adminfullname;
                    string folderpath = CommonClass.stafffolder;
                    CommonClass.origin = this;
                    CommonClass.Maincalc = new MainFunctionStaff(empName, department, email, period, username, folderpath, CommonClass.origin);
                }
                CommonClass.Maincalc.Show();
                CommonClass.Maincalc.BringToFront();
            }

        }

        private void CollegeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Getfolderpath(CommonClass.Username);

                DataGridViewRow row = CollegeDataGrid.Rows[e.RowIndex];

                EmpIDInfo.Text = row.Cells[1].Value.ToString();
                EmpNameInfo.Text = row.Cells[2].Value.ToString();
                ContactInfo.Text = row.Cells[5].Value.ToString();
                EmailInfo.Text = row.Cells[6].Value.ToString();
                string folderpath = row.Cells[9].Value.ToString();
                CommonClass.stafffolder = folderpath;

                string empName = row.Cells[2].Value?.ToString() ?? "N/A";
                string department = row.Cells[4].Value?.ToString() ?? "N/A";
                string email = row.Cells[6].Value?.ToString() ?? "N/A";
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

        private void headeryellow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
