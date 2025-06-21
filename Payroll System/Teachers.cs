using Microsoft.Win32.SafeHandles;
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
    public partial class Teachers : Form
    {
        //calls from the other database which was registerd from the input staff
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30;");
        public Teachers()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToString("MMMM dd, yyyy");
            passwordinput.UseSystemPasswordChar = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//hides this form
            if (CommonClass.staffselection == null || CommonClass.staffselection.IsDisposed) //call the common class
            {
                CommonClass.staffselection = new Selection(); //redefining to add context to this document
            }
            CommonClass.staffselection.Show(); //allows to show the form
            CommonClass.staffselection.BringToFront(); //brings it to font
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (userinputlogin.Text == "" || passwordinput.Text == "") // checks if the userinputlogin and password input is valued
            {
                MessageBox.Show("Please fill in your information to proceed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //shows if there's no inputted value
            }
            else
            {
                if (ConnectData.State != ConnectionState.Open) //checks if the connection is open
                {
                    try
                    {
                        ConnectData.Open(); //opens the connection
                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password"; //selects the data from the table 
                        using (SqlCommand cmd = new SqlCommand(selectData, ConnectData)) //calls the sqlcommand as cmd
                        {
                            cmd.Parameters.AddWithValue("@username", userinputlogin.Text); //gets the value of userinputlogin.text value if it met on the table
                            cmd.Parameters.AddWithValue("@password", passwordinput.Text); //same process, but different function
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); //declares a varable to sql dataadapter to fill in the bridge
                            DataTable table = new DataTable(); // declares a variable for datatable
                            adapter.Fill(table); // calls the sqldataadapter with the table to check if the user exist on the data
                            if (table.Rows.Count >= 1) // if all is met it will success!
                            {
                                MessageBox.Show("Login Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //messagebox will show if its sucess
                                CommonClass.staffusernamedashboard = userinputlogin.Text; //gets the value of the userinputlogin into the variable staffusername
                                TeacherDashboard teacherdashboard = new TeacherDashboard(userinputlogin.Text); //teacherdashboard

                                if (string.IsNullOrEmpty(CommonClass.staffusernamedashboard))
                                {
                                    MessageBox.Show("No matching user found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    this.Hide(); // Hide login form
                                    CommonClass.teacherdash = new TeacherDashboard(CommonClass.staffusernamedashboard); // Pass full name
                                    CommonClass.teacherdash.Show(); this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching user found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to server" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ConnectData.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Time.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                passwordinput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordinput.UseSystemPasswordChar = true;
            }

        }

        private void showpassword_CheckStateChanged(object sender, EventArgs e)
        {
        }
    }
} 
