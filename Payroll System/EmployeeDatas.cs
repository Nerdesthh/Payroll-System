using System.Data.SqlClient;
using System.Data;

namespace Payroll_System
{
    internal class EmployeeDatas
    {
     
        //did not use the commonclass, to avoid conflict on the nested if.
        public int ID { get; set; } //0
        public string EmployeeID { get; set; } //1
        public string FullName { get; set; } //2
        public string Image { get; set; } //3
        public string Department { get; set; } //4
        public string PhoneNumber { get; set; } //5
        public string Email { get; set; } //6
        public string Username { get; set; } //7
        public string Password { get; set; } //8
        public string folderpath { get; set; } //9


        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30;");
        //starts to create data from the datagrid on InputStaff
        public List<EmployeeDatas> StaffListData(string departmentFilter = "")
        {
            List<EmployeeDatas> listdata = new List<EmployeeDatas>();

            try
            {
                if (ConnectData.State == ConnectionState.Closed)
                    ConnectData.Open();

                // Modify the SQL query to filter by department if needed
                string SelectData = "SELECT * FROM users WHERE delete_date IS NULL";

                if (!string.IsNullOrEmpty(departmentFilter))
                {
                    SelectData += " AND department = @department";  // Filter by department
                }

                using (SqlCommand cmd = new SqlCommand(SelectData, ConnectData))
                {
                    if (!string.IsNullOrEmpty(departmentFilter))
                    {
                        cmd.Parameters.AddWithValue("@department", departmentFilter);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeDatas ed = new EmployeeDatas
                            {
                                //these variables are calling the value from the users table
                                ID = Convert.ToInt32(reader["ID"]),
                                EmployeeID = reader["staff_id"].ToString(),
                                FullName = reader["full_name"].ToString(),
                                Image = reader["image"].ToString(),
                                Department = reader["department"].ToString(),
                                PhoneNumber = reader["phone_number"].ToString(),
                                Email = reader["email"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                folderpath = reader["folderpath"].ToString()
                            };

                            listdata.Add(ed);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving data: " + ex.Message);
            }
            finally
            {
                if (ConnectData.State == ConnectionState.Open)
                    ConnectData.Close();
            }

            return listdata;
        }

    }


}

