using Microsoft.VisualBasic.Logging;
using System.Data. SQLite;
using System.Diagnostics.Metrics;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Payroll_System
{
    public partial class Login : Form
    {
        //Sqldatabase that conncets user account in this script
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\GitHub\Payroll-System\Payroll System\loginData.mdf"";Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Now;
            datre.Text = dateTime.ToString("MMMM dd, yyyy");
            passwordinput.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void HeaderProjectname_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (userinputlogin.Text == "" || passwordinput.Text == "")
            {
                //if user fails to input the requirements error will show
                MessageBox.Show("Please fill in your information to proceed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if the user inpuuted the textbox, it will connect to the database to check the account.
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //checking if the login credentials are correct.
                        //username from the sql table where username defined as @username then passowrd defined as @pass
                        string selectData = "SELECT * FROM admin WHERE username = @username AND passowrd = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            //add value from the userinputlogin textbox and input it on usernae using the @username placeholder   
                            cmd.Parameters.AddWithValue("@username", userinputlogin.Text);
                            cmd.Parameters.AddWithValue("@pass", passwordinput.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            //if the login credentials are met, it wil proceed to the MainDashboard
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //includes a property only for "username" for it to see on the dashboard.
                                CommonClass.Username = userinputlogin.Text;
                                CommonClass.passwordadmin = passwordinput.Text;
                                //calls dashboard bringing along with "userinputlogin" data to display through the dashboard.
                                Dashboard dashboard = new Dashboard(userinputlogin.Text, passwordinput.Text);
                                userinputlogin.Text = "";
                                passwordinput.Text = "";
                                dashboard.Show();
                                this.Close();
                            }
                            else
                            {
                                //if the login credentials failed. Incorrect shows up.
                                MessageBox.Show("Incorrect username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    //"Exception ex" shows the full cause of the error, best for debuggung for developers.
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to server" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //if no error has shown, all of the login credentials are met,
                        //the connection between the login script and the sql are going to disconnect.
                        connect.Close();
                    }
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.staffselection == null || CommonClass.staffselection.IsDisposed)
            {
                CommonClass.staffselection = new Selection();
            }
            CommonClass.staffselection.Show();
            CommonClass.staffselection.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToString("hh:mm:ss tt");
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

        private void datre_Click(object sender, EventArgs e)
        {

        }

        private void registertxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //instantiating a class where we can create a variable to call the signup interface
            AdminRegistration signup = new AdminRegistration();
            signup.ShowDialog();

        }
    }
}
