using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO; // Add this to handle file operations
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class paysliphistory : Form
    {
        SqlConnection ConnectData = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Payroll System - MAIN\Payroll System222222222\Payroll System\Payroll System\Staffs.mdf"";Integrated Security=True;Connect Timeout=30;");
        private string folderPath;

        public paysliphistory(string fullName)
        {
            InitializeComponent();

            // Directly use the stored folder path
            folderPath = CommonClass.stafffolder;

            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Folder path is not set or does not exist. Using default path.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadImages();
        }


        private string GetMonthYearPart(string fileNameWithoutExtension)
        {
            // Replace commas and any other unwanted characters with dashes
            fileNameWithoutExtension = fileNameWithoutExtension.Replace(",", "-");

            // Split the filename by dashes
            string[] parts = fileNameWithoutExtension.Split('-');

            // Check if the filename contains at least 4 parts (e.g., 1-15-March-2025)
            if (parts.Length >= 4)
            {
                // Check if the month and year parts are valid
                string monthPart = parts[parts.Length - 2]; 
                string yearPart = parts[parts.Length - 1];

                // Only return if the year is numeric and the month is valid
                if (int.TryParse(yearPart, out _) && !string.IsNullOrEmpty(monthPart))
                {
                    return $"{monthPart} {yearPart}";
                }
            }

            return string.Empty; // Return empty if the format is invalid
        }


        private void LoadImages(string searchQuery = "")
        {
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Folder path is not set or does not exist. Using default path.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly) // opens the file manager to select a file
                                           .Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg")) // where it can only select png and jpg format
                                           .ToArray(); // convert them to array


            if (imageFiles.Length == 0) // if the image is contained as null or valued as 0 it will show an messagebox error!
            {
                MessageBox.Show("No images found in the folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int x = 10;  // Keep images aligned to the left
            int y = 10;  // Start from the top
            int imageSpacing = 20;  // Reduced space between blocks
            int labelSpacing = 5;  // Space between label and image
            int fileCount = 0; // Count the number of files

            panel2.Controls.Clear(); // Clear previous images before loading new ones
            panel2.AutoScroll = true; // Enable scrolling if there are many images

            foreach (var imageFile in imageFiles) // a foreach loop, the loop is still running even if the file has shown
            {
                try 
                {

                    // Get the filename without extension
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imageFile);

                    // Extract the month and year part from the filename
                    string monthYearPart = GetMonthYearPart(fileNameWithoutExtension);



                    if (!string.IsNullOrEmpty(searchQuery) && !monthYearPart.Equals(searchQuery, StringComparison.OrdinalIgnoreCase)) // if the search is empty or the value of the search is invalid
                    {
                        continue; // File will not show if the inputted month and year is invalid
                    }

                    // Create Label to show the filename
                    Label label = new Label(); //calls an object where it can read as a variable
                    label.Text = Path.GetFileName(imageFile); // Show full filename
                    label.AutoSize = true; // autosize the label
                    label.Font = new Font("Times New Roman", 12, FontStyle.Bold); //changes the font style in to times new roman and the size into 12

                    // Center the label horizontally
                    int labelX = (panel2.Width - label.PreferredWidth) / 2; // assign the label in at the center of the imagebox where it gets the width of the panel 2
                    label.Location = new Point(labelX, y); // when the results of the position of labelX it will add it as a location for the label to be at the top of the imagebox
                    panel2.Controls.Add(label); //now therefore it will add the full name of the payslip automatically in the system

                    // Create PictureBox to show the image
                    PictureBox pictureBox = new PictureBox(); // creates an object where it can read as a variable
                    pictureBox.Image = Image.FromFile(imageFile); // gets the imagefile from the valueo fthe imagefile of the staff
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // sets the size mode as zoom
                    pictureBox.Width = panel2.Width - 20; // gets the position of the width for the picturebox
                    pictureBox.Height = 300; //sets the height of the picturebox
                    pictureBox.Location = new Point((panel2.Width - pictureBox.Width) / 2, y + label.Height + 5); // sets the location of the picturebox

                    panel2.Controls.Add(pictureBox); // now this statement adds the conditon for adding the picturebox

                    // Move Y down for the next block
                    y += pictureBox.Height + label.Height + 20;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image {imageFile}: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonClass.teacherdash == null || CommonClass.teacherdash.IsDisposed)
            {
                CommonClass.teacherdash = new TeacherDashboard(CommonClass.staffusernamedashboard);
            }
            CommonClass.teacherdash.Show();
            CommonClass.teacherdash.BringToFront();
        }

        private void filelocation_Click(object sender, EventArgs e)
        {
            string folderPath = CommonClass.stafffolder; // Replace with the actual folder path
            Process.Start("explorer.exe", folderPath); //calls file explorer with the spesific folderpath
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchQuery = searchtxt.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a valid month and year (e.g., March 2025)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search with space format: March 2025
            LoadImages(searchQuery); // Pass searchQuery directly
        }
    }
}
