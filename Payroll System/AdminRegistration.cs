using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class AdminRegistration : Form
    {

        public AdminRegistration()
        {
            InitializeComponent();
        }

        //connects sql to this class
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\loginData.mdf"";Integrated Security=True;Connect Timeout=30;");
        private void AdminRegistration_Load(object sender, EventArgs e)
        {
        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click_2(object sender, EventArgs e)
        {

        }

        private void passinput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void userinput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            //if the textxbox named userinput and passinput is valued with nothing
            //error will show and will not go to the process
            if (userinput.Text == "" || passinput.Text == "")
            {
                MessageBox.Show("Please fill in your information to proceed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //calls and connects the database
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        //this block of code will attempt to create an account from LoginData.mdf
                        connect.Open();
                        //calls the table named "admin" where username is the userinput text
                        string checkUsername = "Select * FROM admin WHERE username = '"
                            + userinput.Text.Trim() + "'";
                        //instantiate sqlcommand by the variable of checkuser
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            //gives out a bridge named the adapter value to conect to the table
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            //created a variable of a database named as "table" 
                            DataTable table = new DataTable();
                            //used the adapter to fill the table that was recieved from the database
                            adapter.Fill(table);

                            //if the account is already existed, a textbox will show that the account is already existed
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(userinput.Text + " account already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {//else if the inputted account is invalid, proceeds to create an account using sqldatabase
                                //redefining the username,password, date of creation into a value
                                string insertData = "INSERT INTO admin (username, passowrd, date_created) " +
                                    "VALUES(@username,@password,@date)"; //stressfull ahh

                                //created a variable for date and time to get the exact date that is created on that exact date
                                DateTime date = DateTime.Today;
                                //using sqlcommand as a variable cmd to call it
                                //it carries the argument of insertdata where the "@" placeholder was used to communicate with the database
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    //using parameters with addvalue for the username to add data to the account table query
                                    //used the @username place holder indicating the userinput text
                                    //userinput text is a textbox and will store its value to the database (logindata.mdf)
                                    cmd.Parameters.AddWithValue("@username", userinput.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", passinput.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    //after the process, a confirmation box to ensure the information that is inputted.
                                    DialogResult dialogResult = MessageBox.Show("Is the information correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        //if the user is sure enough, the cmd.Execute kineme will save the account to the LoginData.mdf
                                        cmd.ExecuteNonQuery();
                                        //hides the dialog box after execution then return back to the process of creating an account
                                        this.Hide();
                                        //ths will return back
                                        return;
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {
                                        //automatically removes the dialogbox, then returning back to the account process.
                                        return;
                                    }
                                }

                            }

                        }
                    }

                    //if failed to connect to server, Exception Ex will show the exact error that is filled with lines
                    //unreadable but database related
                    catch (Exception ex)
                    {
                        //same explaination to login.cs
                        MessageBox.Show("Error connecting to database:   " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }

            }
        }

        private void PerpetualName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordinput_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterGroup_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
