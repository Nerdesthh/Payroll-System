using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class Dashboard : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\loginData.mdf"";Integrated Security=True;Connect Timeout=30;");

        public Dashboard(string username, string password)
        {
            InitializeComponent();
            //welcome label will replace its value into a username recieved from the login.
            Welcome.Text = "Welcome, " + username + "!";
            DateTime dateTime = DateTime.Now;
            datre.Text = dateTime.ToString("MMMM dd, yyyy");

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserData(CommonClass.Username);
            timer1.Start();
        }

        private void LoadUserData(string username) //loads the image!
        {
            try
            {
                connect.Open();
                string query = "SELECT image, fullnme FROM admin WHERE username = @username"; // Replace with your actual query where you retrieve user data (@username)
                using (SqlCommand cmd = new SqlCommand(query, connect)) //using the query as CMD to retrieve user data
                {
                    cmd.Parameters.AddWithValue("@username", username); // Add the username parameter
                    using (SqlDataReader reader = cmd.ExecuteReader()) ///using the query as CMD to retrieve user data which is reader
                    {
                        if (reader.Read()) //reader variable to read the datas from the database
                        {
                            string imagePath = reader["image"].ToString(); // Retrieve the image path from the database
                            CommonClass.adminfullname = reader["fullnme"].ToString(); // Retrieve the full name from the database

                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath)) // Check if the image path is not empty and the file exists
                            {
                                picture.Image = Image.FromFile(imagePath); // Load the image into the PictureBox
                            }
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
                connect.Close();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                //resetting the values for the commonclass' admin credential variable
                CommonClass.Username = null;
                CommonClass.passwordadmin = null;
                CommonClass.adminfullname = null;
                CommonClass.imagestaff = null;

                this.Close();
                if (CommonClass.Loginpage == null || CommonClass.Loginpage.IsDisposed)
                {
                    CommonClass.Loginpage = new Login();
                }
                CommonClass.Loginpage.Show();
                CommonClass.Loginpage.BringToFront();
            }
        }

        private void welcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            if (CommonClass.editadmin == null || CommonClass.editadmin.IsDisposed)
            {
                string username = CommonClass.Username;
                string password = CommonClass.passwordadmin;
                string fullname = CommonClass.adminfullname;
                CommonClass.editadmin = new editadmin(username, password, fullname);
            }
            CommonClass.editadmin.Show();
            CommonClass.editadmin.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void JHS_Click(object sender, EventArgs e)
        {
            if (CommonClass.adminfullname == "")
            {
                MessageBox.Show("Please edit your User Credentials to proceeed: Click \"Welcome, admin!\"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                if (CommonClass.PayrollJHS == null || CommonClass.PayrollJHS.IsDisposed)
                {
                    string fullname = CommonClass.adminfullname;
                    //instaintaining a login page trough the use of commonclass
                    CommonClass.PayrollJHS = new JuniorHigh(fullname);
                }

                CommonClass.PayrollJHS.Show();
                CommonClass.PayrollJHS.BringToFront();
            }

        }

        private void SHS_Click(object sender, EventArgs e)
        {
            if (CommonClass.adminfullname == "")
            {
                MessageBox.Show("Please edit your User Credentials to proceeed: Click \"Welcome, admin!\"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                if (CommonClass.PayrollSHS == null || CommonClass.PayrollSHS.IsDisposed)
                {
                    string fullname = CommonClass.adminfullname;
                    //instaintaining a login page trough the use of commonclass
                    CommonClass.PayrollSHS = new SeniorHigh(fullname);
                }

                CommonClass.PayrollSHS.Show();
                CommonClass.PayrollSHS.BringToFront();
            }

        }

        private void CollegeLink_Click(object sender, EventArgs e)
        {
            this.Close();

            if (CommonClass.adminfullname == null)
            {
                MessageBox.Show("Please edit your User Credentials to proceeed: Click \"Welcome, admin!\"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CommonClass.PayrollCollege == null || CommonClass.PayrollCollege.IsDisposed)
            {
                string fullname = CommonClass.adminfullname;
                CommonClass.PayrollCollege = new College(fullname);
            }

            CommonClass.PayrollCollege.Show();
            CommonClass.PayrollCollege.BringToFront();

        }
    }
}

