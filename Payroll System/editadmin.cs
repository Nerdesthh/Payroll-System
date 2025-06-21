using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Payroll_System
{
    public partial class editadmin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\loginData.mdf"";Integrated Security=True;Connect Timeout=30;");

        public editadmin(string username, string password, string fullname)
        {
            InitializeComponent();
            usrnameedit.Text = username; //get the username from the login form
            passedit.Text = password; //get the password from the login form
            FullName.Text = fullname; //get the fullname from the login form
        }
        private void editadmin_Load(object sender, EventArgs e)
        {
            loadimage(sender, e); //load the image from the loadimage method
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //common way to call the other form which explained on the other forms
            this.Close();
            if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
            {
                CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
            }
            CommonClass.MainBoard.Show();
            CommonClass.MainBoard.BringToFront();
        }

        private void loadimage(object sender, EventArgs e)
        {
            try
            {
                connect.Open();// opens the connection
                string query = "SELECT image, fullnme FROM admin WHERE username = @username";  //declared a variable named query to store the SQL query
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", CommonClass.Username); //add value from the userinputlogin textbox and input it on usernae using the @username placeholder

                    using (SqlDataReader reader = cmd.ExecuteReader()) //read the data
                    {
                        if (reader.Read())//check if there is a data
                        {
                            string imagePath = reader["image"].ToString(); //get the image path as a "image" from the database
                            string fullName = reader["fullnme"].ToString(); //get the full name as a "fullnme" from the database

                            if (!string.IsNullOrEmpty(fullName)) // Check if full name is not empty
                            {
                                FullName.Text = fullName; // Set full name
                            }

                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath)) // Check if image path is not empty and file exists
                            {
                                // Use MemoryStream to avoid file locking issues
                                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) //get the image path as a "image" from the database
                                using (MemoryStream ms = new MemoryStream()) //create a memory stream
                                {
                                    fs.CopyTo(ms); //copy the file to the memory stream
                                    Adminimage.Image = Image.FromStream(ms); //set the image from the memory stream
                                }
                            }
                            else
                            {
                                MessageBox.Show("Image file not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //else error if all the required fields are empty
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have successfully inputted your picture to the system!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (usrnameedit.Text == "" || passedit.Text == "" || Adminimage.Image == null) // Check if any of the required fields are empty
            {
                MessageBox.Show("Please fill up all the fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display an error message
                return;
            }

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Display a confirmation dialog
                if (dialogResult == DialogResult.Yes) // If the user clicks "Yes"
                {
                    connect.Open();
                    string checkuser = "SELECT COUNT(*) FROM admin WHERE username = @username AND passowrd = @currentpassword"; // SQL query to check if the username already exists
                    using (SqlCommand checkstaff = new SqlCommand(checkuser, connect)) // Create a SqlCommand object
                    {
                        checkstaff.Parameters.AddWithValue("@username", CommonClass.Username); // checks if the username already exists
                        checkstaff.Parameters.AddWithValue("@currentpassword", CommonClass.passwordadmin); // checks if the password already exists
                        int count = (int)checkstaff.ExecuteScalar(); // Execute the query and get the count

                        if (count == 1) // If the username already exists
                        {

                            string path = Path.Combine(@"E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\adminimage\", 
                                usrnameedit.Text.Trim() + ".jpg"); // Get the path to save the image



                            if (!Directory.Exists(Path.GetDirectoryName(path))) // Check if the directory to save the image doesn't exist
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(path)); // Create the directory
                            }
                            SaveImage(path); // **Use the safe SaveImage method**

                            if (Adminimage.Image != null)
                            {
                                SaveImageWithNewName("admin", Adminimage.Image);

                            }
                            // **Use the safe SaveImage method**

                            CommonClass.imagestaff = Image.FromFile(path); // Set the image

                            string updadmin = "UPDATE admin SET username = @newusername, passowrd = @newpassword, image = @image, date_updated = @date, fullnme = @fullname WHERE username = @username AND passowrd = @currentpassword";

                            using (SqlCommand cmd = new SqlCommand(updadmin, connect)) // Create a SqlCommand object
                            {
                                cmd.Parameters.AddWithValue("@username", CommonClass.Username); // checks if the username already exists
                                cmd.Parameters.AddWithValue("@currentpassword", CommonClass.passwordadmin); // checks if the password already exists
                                cmd.Parameters.AddWithValue("@newusername", usrnameedit.Text.Trim()); // inputting the new username from usrnameedit textbox
                                cmd.Parameters.AddWithValue("@fullname", FullName.Text.Trim()); // inputting the new fullname from FullName textbox
                                cmd.Parameters.AddWithValue("@newpassword", passedit.Text.Trim()); // inputting the new password from passedit textbox
                                cmd.Parameters.AddWithValue("@image", path); // inputting the new image inputted by the user
                                cmd.Parameters.AddWithValue("@date", DateTime.Now); // inputting the current date from the database
                                cmd.ExecuteNonQuery(); // Execute the query
                            }

                            MessageBox.Show("Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CommonClass.Username = usrnameedit.Text.Trim(); // Set the new username
                            CommonClass.passwordadmin = passedit.Text.Trim(); // Set the new password
                            CommonClass.adminfullname = FullName.Text.Trim(); // Set the new fullname
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have successfully inputted your picture to the system!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
        }

        private void SaveImageWithNewName(string username, Image img)
        {
            try
            {
                if (img != null)
                {
                    username = CommonClass.Username; // Get the username from CommonClass
                    img = Adminimage.Image; // Get the image from Adminimage
                    string directory = @"E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\adminimage\"; //the static path of the image for the admin
                    int count = 1; // Initialize count, it determines on how many times the image has been updated
                    string newFileName; // Initialize newFileName

                    // Find the next available filename
                    do
                    {
                        newFileName = Path.Combine(directory, $"{username}_Update_{count}.jpg"); // Set the new file name with its name and count of how many times it has been updated
                        count++; // Increment count
                    } while (File.Exists(newFileName)); // Check if the file already exists

                    // Save the new image
                    img.Save(newFileName, System.Drawing.Imaging.ImageFormat.Jpeg); // Save the new image

                    // Set the new image and release old one
                    if (Adminimage.Image != null) // Check if the old image is not null
                    {
                        Adminimage.Image.Dispose(); // Dispose the old image
                        Adminimage.Image = null; // Set the old image to null
                    }
                    Adminimage.Image = new Bitmap(newFileName); // Set the new image

                    // Perform cleanup
                    CleanupOldImages(username, directory);

                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have successfully inputted your picture to the system!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CleanupOldImages(string username, string directory) //cleans the old image which limits the image to 3
        {
            try
            {

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(directory)) // Check if username or directory is empty
                {
                    Debug.WriteLine("[ERROR] Cleanup function received empty username or directory."); // shows a debug error when the username or directory is empty
                    return;
                }

                var files = Directory.GetFiles(directory, $"{username}_Update_*.jpg") // Get all files with the specified pattern where username is the username of the admin
                                    .OrderBy(f => File.GetLastWriteTime(f)) // Sort by oldest modified file
                                    .ToList(); // Convert to a list

                Debug.WriteLine($"[DEBUG] Found {files.Count} images for cleanup."); // shows a debug message

                while (files.Count > 3) // Keep only the latest 3 images
                {
                    string fileToDelete = files[0]; // Get the oldest file

                    Debug.WriteLine($"[DEBUG] Attempting to delete: {fileToDelete}"); // shows a debug message where it's attempting to delete

                    // Ensure the file is not locked before deletion
                    if (IsFileLocked(fileToDelete)) // Check if the file is locked
                    {
                        Debug.WriteLine($"[WARNING] File is locked and cannot be deleted: {fileToDelete}"); // shows a warning message
                    }
                    else
                    {
                        File.Delete(fileToDelete); // Delete the file
                        Debug.WriteLine($"[DEBUG] Deleted file: {fileToDelete}"); // shows a debug message
                        files.RemoveAt(0); // Remove the deleted file
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cleaning up old images: " + ex.Message, "Cleanup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"[ERROR] Cleanup Error: {ex.Message}");
            }
        }

        // Helper function to check if the file is locked
        private bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false; // File is not locked
                }
            }
            catch (IOException)
            {
                return true; // File is locked
            }
        }


        private void SaveImage(string filePath)
        {
            try
            {
                if (Adminimage.Image != null) //checks if the image is null 
                {
                    // Ensure the directory exists
                    string directory = Path.GetDirectoryName(filePath); //getss the file path from the image
                    if (!Directory.Exists(directory)) //checks if the directory exists
                    {
                        Directory.CreateDirectory(directory); // creates the directory
                    }

                    // Clone the image to release any locks
                    using (Bitmap bmp = new Bitmap(Adminimage.Image.Width, Adminimage.Image.Height)) // creates a new bitmap
                    {
                        using (Graphics g = Graphics.FromImage(bmp)) // creates a graphics object
                        {
                            g.DrawImage(Adminimage.Image, 0, 0, Adminimage.Image.Width, Adminimage.Image.Height);//draws the image
                        }

                        // Save the cloned image
                        bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg); // saves the image
                    }

                    // Release the old image before assigning a new one
                    if (CommonClass.imagestaff != null) // checks if the image is not null
                    {
                        CommonClass.imagestaff.Dispose(); // disposes the image if its not null
                    }

                    // Reload the saved image to avoid locking it
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) // creates a file stream
                    {
                        CommonClass.imagestaff = new Bitmap(fs); // loads the image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have successfully inputted your picture to the system!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void importimg_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog filepath = new OpenFileDialog()) //opens the file explorer to get the image
                {
                    filepath.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;|All files (*.*)|*.*"; //filters the file explorer where it can only recieve image files

                    if (filepath.ShowDialog() == DialogResult.OK) // checks if the user has chosen a file
                    {
                        // Dispose of the old image before replacing it
                        if (Adminimage.Image != null)
                        {
                            Adminimage.Image.Dispose(); // Dispose the old image
                            Adminimage.Image = null; // Set the Adminimge to null
                            GC.Collect();  // Force garbage (GC) collection 
                            GC.WaitForPendingFinalizers(); // Wait for pending finalizers
                        }

                        string imagepath = filepath.FileName; // where imagepath is the path of the image

                        // Load the new image in a way that prevents file locking
                        using (FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Adminimage.Image = Image.FromStream(fs); //loads the image from the selected image by the user
                        }

                        // Store image path for later saving
                        Adminimage.Tag = imagepath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message + ": " + "This is probably that the image are conflicted to each other\nPlease try again later!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
