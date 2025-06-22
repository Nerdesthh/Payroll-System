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
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Payroll_System
{
    public partial class InputStaff : Form
    {
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\GitHub\Payroll-System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30");
        public InputStaff()
        {
            InitializeComponent();
            //display data from the data grid 
            displaystaffdata();
        }
        private void InputStaff_Load(object sender, EventArgs e) { }
        private void headeryellow_Paint(object sender, PaintEventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmployeeDatasGrid.Rows[e.RowIndex];
                EmployeeIDBox.Text = row.Cells[1].Value.ToString();
                FMBox.Text = row.Cells[2].Value.ToString();
                string imagepath = row.Cells[3].Value.ToString();

                if (imagepath != null)
                {
                    EmployeeImage.Image = Image.FromFile(imagepath);
                }
                else
                {
                    EmployeeImage.Image = null;
                }
                DepartmentCombo.Text = row.Cells[4].Value.ToString();
                InputPhone.Text = row.Cells[5].Value.ToString();
                EmailInput.Text = row.Cells[6].Value.ToString();
                UsernameText.Text = row.Cells[7].Value.ToString();
                PasswordText.Text = row.Cells[8].Value.ToString();

            }
        }


        public void displaystaffdata()
        {
            EmployeeDatas ed = new EmployeeDatas();
            List<EmployeeDatas> listdata = ed.StaffListData();

            EmployeeDatasGrid.DataSource = listdata;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (EmployeeIDBox.Text == "" || FMBox.Text == "" || DepartmentCombo.Text == "" || InputPhone.Text == "" || EmailInput.Text == "" || EmployeeImage.Image == null || UsernameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please fill in all the blanks!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConnectData.State == ConnectionState.Closed)
                {
                    try
                    {
                        ConnectData.Open();
                        string checkStaffID = "SELECT COUNT(*) FROM users WHERE staff_id = @staffID AND delete_date IS NOT NULL";
                        using (SqlCommand checkStaff = new SqlCommand(checkStaffID, ConnectData))
                        {
                            checkStaff.Parameters.AddWithValue("@staffID", EmployeeIDBox.Text.Trim());
                            int count = (int)checkStaff.ExecuteScalar();

                            if (count > 1)
                            {
                                MessageBox.Show(EmployeeIDBox.Text + " is already taken!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users " +
                                    "(staff_id, full_name, image, department, phone_number, insert_date, email, username, password, folderpath ) " +
                                    "VALUES(@staffID, @fullname, @image, @department, @phoneNum, @insertdate, @email, @username, @password, @folderpath)";

                                // Profile Picture Path
                                string path = Path.Combine(@"E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\Directory\",
                                        EmployeeIDBox.Text.Trim() + "-" + FMBox.Text.Trim() + ".jpg");

                                // Payslip Folder Path for this staff
                                string payslipFolderPath = Path.Combine(@"E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\StaffFolder\", EmployeeIDBox.Text.Trim() +
                                    "-" + FMBox.Text.Trim());

                                try
                                {
                                    // Ensure that the payslip folder exists for this staff
                                    if (!Directory.Exists(payslipFolderPath))
                                    {
                                        Directory.CreateDirectory(payslipFolderPath);
                                        Console.WriteLine("Payslip folder created: " + payslipFolderPath);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"An error occurred while creating payslip folder: {ex.Message}");
                                }

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(EmployeeImage.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, ConnectData))
                                {
                                    cmd.Parameters.AddWithValue("@staffID", EmployeeIDBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", FMBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@department", DepartmentCombo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phoneNum", InputPhone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertdate", today);
                                    cmd.Parameters.AddWithValue("@email", EmailInput.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", UsernameText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", PasswordText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@folderpath", payslipFolderPath);

                                    cmd.ExecuteNonQuery();
                                    displaystaffdata();
                                    clearfields();

                                    MessageBox.Show("Added Successfully! Payslip folder created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Something went wrong with the database! - " + ex, "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        ConnectData.Close();
                    }
                }
            }
        }

        //here is the image import process go
        private void ImportStaffPic_Click(object sender, EventArgs e)
        {
            try
            {
                //creates a variable for openfiledialog to get the file image
                OpenFileDialog dialog = new OpenFileDialog();
                //filter the dialog that only JPG or PNG is allowed
                dialog.Filter = "Image Files (*, .jpg; *.png; | *.jpg;*.png;";
                string imagepath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    //employeeimage box is located by image path
                    EmployeeImage.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error as occured on Importing the image!: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void clearfields()
        {
            EmployeeIDBox.Text = "";
            FMBox.Text = "";
            DepartmentCombo.SelectedIndex = -1;
            InputPhone.Text = "";
            EmailInput.Text = "";
            UsernameText.Text = "";
            PasswordText.Text = "";
            EmployeeImage.Image = null;
        }


        private void EmailInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ensures that all required fields has an input
            if (EmployeeIDBox.Text == "" || FMBox.Text == "" || DepartmentCombo.Text == "" || InputPhone.Text == "" || EmailInput.Text == "")
            {
                MessageBox.Show("Please fill in all the blanks!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //confirming if the user wants to update the user's data
                DialogResult confirmationupd = MessageBox.Show("Are you sure you want to update this user? " + "Employee Name: " + FMBox.Text.Trim() + "?", "Data Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationupd == DialogResult.Yes)
                {
                    try
                    {
                        ConnectData.Open();
                        //calling all variable from staff's query to be inputted/called in this block of code
                        string UpdData = "UPDATE users SET full_name = @fullname, department = @department, phone_number = @phoneNum, email = @email,"
                            + "update_date = @updatedate WHERE staff_id = @staffID";
                        //redefining date time as today since it can't be reached anymore
                        DateTime today = DateTime.Now;
                        //doing this again but for update data
                        using (SqlCommand cmd = new SqlCommand(UpdData, ConnectData))
                        {
                            //adding value with the VALUE (ex. @username) that is inputted from the textbox
                            cmd.Parameters.AddWithValue("@fullname", FMBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@department", DepartmentCombo.Text.Trim());
                            cmd.Parameters.AddWithValue("@phoneNum", InputPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", EmailInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@updatedate", today);
                            cmd.Parameters.AddWithValue("@staffID", EmployeeIDBox.Text.Trim());

                            cmd.ExecuteNonQuery();
                            //automatically display the data that is inputted to the table
                            displaystaffdata();
                            MessageBox.Show("Update " + FMBox.Text.Trim() + " Successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                    catch (Exception ex)
                    {
                        //
                        MessageBox.Show("An error as occured on updating the Data!: " + ex, "Update Status Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ConnectData.Close();
                    }

                }
                else
                {
                    //user does NOT want to change the data 
                    MessageBox.Show("Canceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //if this button is clicked, all inputed data will be cleared to reduce time
            EmployeeIDBox.Text = "";
            FMBox.Text = "";
            DepartmentCombo.SelectedIndex = -1;
            InputPhone.Text = "";
            EmailInput.Text = "";
            UsernameText.Text = "";
            PasswordText.Text = "";
            EmployeeImage.Image = null;
        }

        private void EmployeeDatasGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InputPhone_TextChanged(object sender, EventArgs e)
        {

        }
        //Delete function
        private void button3_Click(object sender, EventArgs e)
        {

            if (EmployeeIDBox.Text == "" || FMBox.Text == "" || DepartmentCombo.Text == "" || InputPhone.Text == "" || EmailInput.Text == "")
            {
                MessageBox.Show("Please fill in all the blanks!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //confirming if the user wants to update the user's data
                DialogResult confirmationupd = MessageBox.Show("Are you sure you want to DELETE this user? " + "Employee Name: " + FMBox.Text.Trim() + "?", "Data Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationupd == DialogResult.Yes)
                {
                    try
                    {
                        ConnectData.Open();
                        //calling all variable from staff's query to be inputted/called in this block of code
                        string UpdData = "UPDATE users set delete_date = @deleteDATE " + "WHERE staff_id = @staffID";
                        //redefining date time as today since it can't be reached anymore
                        DateTime today = DateTime.Now;
                        //doing this again but for delete data data
                        using (SqlCommand cmd = new SqlCommand(UpdData, ConnectData))
                        {
                            cmd.Parameters.AddWithValue("@deleteDATE", today);
                            cmd.Parameters.AddWithValue("@staffID", EmployeeIDBox.Text.Trim());

                            cmd.ExecuteNonQuery();
                            //automatically display the data that is inputted to the table
                            displaystaffdata();
                            MessageBox.Show("Deleted" + FMBox.Text.Trim() + " Successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error as occured on updating the Data!: " + ex, "Update Status Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ConnectData.Close();
                    }

                }
                else
                {
                    //user does NOT want to change the data 
                    MessageBox.Show("Canceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}


