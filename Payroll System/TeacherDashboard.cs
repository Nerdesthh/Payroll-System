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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Payroll_System
{
    public partial class TeacherDashboard : Form
    {
        public TeacherDashboard(string staffusername)
        {
            InitializeComponent();

            // Fetch full name and folder path
            string fullName, folderPath;
            GetUserDetailsFromDatabase(staffusername, out fullName, out folderPath);


            // Set global values
            staffusernametext.Text = "Welcome, " + staffusername + "!";
            CommonClass.staffusernamedashboard = staffusername;
            CommonClass.stafffolder = folderPath; // Store folder path globally for use in payslip history
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToString("MMMM dd, yyyy");

        }

        // Method to get both Full Name and Folder Path
        void GetUserDetailsFromDatabase(string staffusername, out string fullName, out string folderPath)
        {
            fullName = null;
            folderPath = null;

            string query = "SELECT full_name, folderpath FROM users WHERE username = @username";

            using (SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\GitHub\Payroll-System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    ConnectData.Open();

                    // Debug: Show the username being queried

                    using (SqlCommand cmd = new SqlCommand(query, ConnectData))
                    {
                        cmd.Parameters.AddWithValue("@username", staffusername);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullName = reader["full_name"].ToString().Trim();
                                folderPath = reader["folderpath"].ToString().Trim(); // Retrieve folder path directly
                            }
                            else
                            {
                                MessageBox.Show("No matching user found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user details: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e) //retruns back to the teacher login interface
        {
            this.Close();
            if (CommonClass.teacherslogin == null || CommonClass.teacherslogin.IsDisposed)
            {
                CommonClass.teacherslogin = new Teachers();
            }
            CommonClass.teacherslogin.Show();
            CommonClass.teacherslogin.BringToFront();
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.Teachercalc == null || CommonClass.Teachercalc.IsDisposed)
            {
                string deduction = "";
                CommonClass.Teachercalc = new Teachercalc(deduction);
            }
            CommonClass.Teachercalc.Show();
            CommonClass.Teachercalc.BringToFront();
        }

        private void paysliphistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.paysliphistory == null || CommonClass.paysliphistory.IsDisposed)
            {
                CommonClass.paysliphistory = new paysliphistory(CommonClass.staffusernamedashboard);
            }
            CommonClass.paysliphistory.Show();
            CommonClass.paysliphistory.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Time.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
