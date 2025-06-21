using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.DirectoryServices.ActiveDirectory;

namespace Payroll_System
{
    public partial class SendToStaff : Form
    {
        private Bitmap originalImage; //stores the original image of the picture box
        private Bitmap originalImagesystem;
        // Constructor to initialize form with values
        public SendToStaff(
            string empName, string department, string email,
            string basicPay, string netPay, string sss,
            string pagibig, string absents, string lates,
            string PhilHealth, string deduction, string period,
            string username, string folderpath, Form origin)
        {
            InitializeComponent(); // Initialize form first
            DateTime date = DateTime.Now;
            // Assign the correct values to display on the spesific element
            NameofStaffReceipt1.Text = empName;
            StaffPosition1.Text = department;
            EmailINFO1.Text = email;
            DeductSumamary.Text = FormatNumber(deduction);
            NetPaySummary.Text = netPay;
            BasicPayBox.Text = basicPay;
            GrossPaySummary.Text = basicPay;
            SSSBox.Text = FormatNumber(sss);
            PagIbigBox.Text = FormatNumber(pagibig);
            AbsentsBox.Text = FormatNumber(absents);
            TardinessBox.Text = FormatNumber(lates);
            PhilHealthBox.Text = FormatNumber(PhilHealth);
            HandledTxt.Text = username;
            RecievedTxt.Text = empName;
            Date.Text = "Date Generated: " + date.ToString("MM/dd/yyyy"); //gets the current date with the proper formatting
            

            if (pictureBox1.Image != null || pictureBox12 != null) // Ensure pictureBox1 has an image
            {
                originalImage = new Bitmap(pictureBox1.Image); // Store the original image
                originalImagesystem = new Bitmap(pictureBox12.Image);
            }

            FromTo.Text = period; //input the variable from the mainfunction
            this.Refresh();
            disable();
        }



        // Method to set basic employee details
        public void employeedetailsSHS(string empName, string department, string email)
        {
            //inputting the values inputted from the datacell clicked from the list of staff/teachers
            //this will show on the spesific textbox
            NameofStaffReceipt1.Text = empName;
            StaffPosition1.Text = department;
            EmailINFO1.Text = email;
        }


        // Method to disable textboxes readonly mode
        public void disable()
        {
            //making sure that the textbox are not tangable
            NameofStaffReceipt1.Enabled = false;
            StaffPosition1.Enabled = false;
            EmailINFO1.Enabled = false;
            BasicPayBox.Enabled = false;
            AbsentsBox.Enabled = false;
            TardinessBox.Enabled = false;
            SSSBox.Enabled = false;
            PhilHealthBox.Enabled = false;
            PagIbigBox.Enabled = false;
            GrossPaySummary.Enabled = false;
            DeductSumamary.Enabled = false;
            NetPaySummary.Enabled = false;
            FromTo.Enabled = false;
            RecievedTxt.Enabled = false;
            HandledTxt.Enabled = false;
        }

        public void enable()
        {
            NameofStaffReceipt1.Enabled = true;
            StaffPosition1.Enabled = true;
            EmailINFO1.Enabled = true;
            BasicPayBox.Enabled = true;
            AbsentsBox.Enabled = true;
            TardinessBox.Enabled = true;
            SSSBox.Enabled = true;
            PhilHealthBox.Enabled = true;
            PagIbigBox.Enabled = true;
            GrossPaySummary.Enabled = true;
            DeductSumamary.Enabled = true;
            NetPaySummary.Enabled = true;
            FromTo.Enabled = true;
            RecievedTxt.Enabled = true;
            HandledTxt.Enabled = true;
        }

        private string FormatNumber(string value)
        {
            //to format number that has a comma included during thousands   
            if (string.IsNullOrWhiteSpace(value)) return "0"; // Default to zero if empty
            if (decimal.TryParse(value, out decimal number))
            {
                return number.ToString("N2"); // Ensure consistent formatting
            }
            return "0"; // Return zero if conversion fails
        }

        //when the send to staff button is clicked, this code will capture this window as an image
        //this will NOT trigger unless send to staff is clicked!
        private string CaptureFormAsImage(string folderpath)
        {
            printbutton.Visible = false;
            ButtonForEmail.Visible = false;
            returnbtn.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None; 
            this.WindowState = FormWindowState.Normal;
            this.Refresh(); // Refresh UI to apply changes

            // Ensure folder path is set before proceeding
            CommonClass.stafffolder = folderpath;

            if (string.IsNullOrEmpty(folderpath))
            {
                MessageBox.Show("Folder path is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty; // Exit early to prevent errors
            }
            DateTime date = DateTime.Now;

            string filePath = Path.Combine(folderpath, FromTo.Text + "-" + date.ToString("MMMM") + "-" + date.ToString("yyyy") + ".png");

            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }

            Bitmap bmp = new Bitmap(1378, 768); //gets the image of the form with the specified width and height
            this.DrawToBitmap(bmp, new Rectangle(0, 0, 1378, 768)); //draws the image to the bitmap
            
            this.FormBorderStyle = FormBorderStyle.Sizable; //restores the border
            this.WindowState = FormWindowState.Normal; //restores the form
            printbutton.Visible = true;
            ButtonForEmail.Visible = true;
            returnbtn.Visible = true;
            this.Refresh(); // Refresh UI to apply changes


            bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            return filePath;
        }




        private void SendToStaff_Load(object sender, EventArgs e) { }
        //this function will send the image via email
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Capture form and get file path
                string imagePath = CaptureFormAsImage(CommonClass.stafffolder);

                // Email details
                string senderEmail = "emailplaceholder"; // senderEmail variable is valued as the HR's gmail
                string senderPassword = "cevl oolu ijne jjgc"; // Used App Password for Gmail
                string recipientEmail = EmailINFO1.Text; // Get email from the staff's input field

                // Create email
                MailMessage mail = new MailMessage(); //creates a callable variable for MailMessage as mail
                mail.From = new MailAddress(senderEmail); //where the email is coming from
                mail.To.Add(recipientEmail); //adds the recipient's email
                mail.Subject = "Payslip"; //subject email
                mail.Body = "Dear Staff, \n\nPlease find your payslip attached.\n\nBest regards, \nHR Team"; //value of the email's body
                mail.Attachments.Add(new Attachment(imagePath)); //the attachment of the email that is captuerd by the image from the CaptureFormAsImage function

                // SMTP Configuration (for Gmail)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // calls the SMTP configuration for Gmail to send the email
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword); //credentials that was inputted by the variable SenderEmail and SenderPassword
                smtp.EnableSsl = true; //enables SSL

                // Send email
                smtp.Send(mail);//after the credentials, this will send the email
                MessageBox.Show("Payslip sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);// if the email is sent, this will show up
            }

            //if there's an error, this error will show up.
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StaffPosition1_TextChanged(object sender, EventArgs e) { }

        private void AbsentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameofStaffReceipt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeductSumamary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Form origin = CommonClass.origin;

            this.Close();
            if (CommonClass.origin != null && !CommonClass.origin.IsDisposed)
            {
                CommonClass.origin.Show();
                CommonClass.origin.BringToFront();
            }
            else
            {
                if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
                {
                    CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
                }
                CommonClass.MainBoard.Show();
                CommonClass.MainBoard.BringToFront();
            }


        }

        private void NetPaySummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertPictureBoxToBlackAndWhite()
        {
            // Ensure pictureBox1 has an image
            if (pictureBox1.Image != null || pictureBox12 != null)
            {
                if (originalImage == null || originalImagesystem == null)
                {
                    originalImage = new Bitmap(pictureBox1.Image);
                    originalImagesystem = new Bitmap(pictureBox12.Image);
                }

                Bitmap original = new Bitmap(pictureBox1.Image);

                // Create a new bitmap for the output with the same PixelFormat
                Bitmap blackAndWhite = new Bitmap(original.Width, original.Height, original.PixelFormat);

                for (int y = 0; y < original.Height; y++) // Loop through each row
                {
                    for (int x = 0; x < original.Width; x++) // Loop through each column
                    {
                        // Get the pixel color
                        Color originalColor = original.GetPixel(x, y); //gets the pixel color by its original size

                        // Preserve transparency
                        if (originalColor.A < 255) // Check for transparency where (.A) is the alpha value of the color which is 0-255 determines if the image is not transparent
                        {
                            blackAndWhite.SetPixel(x, y, Color.Transparent); // Set the new pixel color as transparent
                        }
                        else
                        {
                            // Convert to grayscale using the luminance formula
                            int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                            Color grayColor = Color.FromArgb(originalColor.A, grayValue, grayValue, grayValue); // Set the grayscale color

                            // Set the new pixel color
                            blackAndWhite.SetPixel(x, y, grayColor);
                        }
                    }
                }

                // Set the processed image back to the PictureBox
                pictureBox1.Image = blackAndWhite;

                //sets the SYSTEM logo into black and white
                Bitmap originalsystem = new Bitmap(pictureBox12.Image);
                Bitmap blackAndWhitesystem = new Bitmap(originalsystem.Width, originalsystem.Height, originalsystem.PixelFormat);

                for (int y = 0; y < originalsystem.Height; y++) // Loop through each row
                {
                    for (int x = 0; x < originalsystem.Width; x++) // Loop through each column
                    {
                        // Get the pixel color
                        Color originalColor = originalsystem.GetPixel(x, y); //gets the pixel color by its original size

                        // Preserve transparency
                        if (originalColor.A < 255) // Check for transparency where (.A) is the alpha value of the color which is 0-255 determines if the image is not transparent
                        {
                            blackAndWhitesystem.SetPixel(x, y, Color.Transparent); // Set the new pixel color as transparent
                        }
                        else
                        {
                            // Convert to grayscale using the luminance formula
                            int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                            Color grayColor = Color.FromArgb(originalColor.A, grayValue, grayValue, grayValue); // Set the grayscale color

                            // Set the new pixel color
                            blackAndWhitesystem.SetPixel(x, y, grayColor);
                        }
                    }
                }

                pictureBox12.Image = blackAndWhitesystem;
            }
        }

        private void RevertPictureBoxToOriginal()
        {
            if (originalImage != null || originalImagesystem != null) // Check if the original image exists
            {
                pictureBox1.Image = new Bitmap(originalImage);// Set the original image back
                pictureBox12.Image = new Bitmap(originalImagesystem);
            }
        }

        // Call this method when you need to convert the image


        private void PrintFormContent() //method function to print the reciept
        {
            try
            {
                string imagePath = CaptureFormAsImage(CommonClass.stafffolder); // first capture the form as an image to save it as a file path

                //makes the three buttons and the header not visible on the printed reciept
                ButtonForEmail.Visible = false;
                returnbtn.Visible = false;
                printbutton.Visible = false;

                this.FormBorderStyle = FormBorderStyle.None; //this removes the border
                this.WindowState = FormWindowState.Normal; //this makes the form from normal to prevent it from being maximized
                this.BackColor = Color.White; //this makes the background color turn into white
                ConvertPictureBoxToBlackAndWhite(); //this converts the image (perpetual logo) to black and white


                //this line changes the color of the textboxes into WHITE 
                NameofStaffReceipt1.BackColor = Color.White;
                StaffPosition1.BackColor = Color.White;
                EmailINFO1.BackColor = Color.White;
                FromTo.BackColor = Color.White;
                GrossPaySummary.BackColor = Color.White;
                DeductSumamary.BackColor = Color.White;
                NetPaySummary.BackColor = Color.White;
                RecievedTxt.BackColor = Color.White;
                HandledTxt.BackColor = Color.White;
                Grosspanel.BackColor = Color.White;
                DeductPanel.BackColor = Color.White;
                NetPanel.BackColor = Color.White;
                Header1Blue.BackColor = ColorTranslator.FromHtml("#c3c7c3"); //this changes the color of the header;
                headeryellow.BackColor = ColorTranslator.FromHtml("#e3e3e3a");
                enable();

                this.Refresh(); // Refresh UI to apply changes

                // Capture form as image
                Bitmap bmp = new Bitmap(1370, 680); //gets the image of the form with the specified width and height
                this.DrawToBitmap(bmp, new Rectangle(0, 0, 1370, 680)); //draws the image to the bitmap

                // Create PrintDocument
                PrintDocument printDocument = new PrintDocument(); //declared a variable which creates a print document
                printDocument.PrintPage += (sender, e) => //when the print document is printed
                {
                    // Calculate the dimensions to fit the image into the page
                    int pageWidth = 900; //declared a variable which obtains the width of the print page
                    int pageHeight = 2500; //declared a variable which obtains the height of the print page
                    float scale = Math.Min((float)pageWidth / bmp.Width, (float)pageHeight /(2 * bmp.Height)) * 0.7f; //declared a variable which obtain the scale of the image
                    int imgWidth = (int)(bmp.Width * scale); //declared a variable which obtain the width of the image
                    int imgHeight = (int)(bmp.Height * scale); //declared a variable which obtain the height of the image

                    // Center the image on the page
                    int offsetX = (pageWidth - imgWidth) / 2; //offsets the page and the image
                    

                    //fixes the margin to ensure proper image placement
                    int topMargin = 0;
                    int gapBetweenImages = 50;

                    int firstimageY = topMargin;
                    int secondimageY = firstimageY + imgHeight + gapBetweenImages;


                    //draws the first copy of the image
                    e.Graphics.DrawImage(bmp, offsetX, firstimageY, imgWidth, imgHeight); //draws the image by its carrying variable to the page with its offset and scale
                    //draws the second copy of the image
                    e.Graphics.DrawImage(bmp, offsetX, firstimageY + imgHeight + 50, imgWidth, imgHeight);
                };

                // Print Preview Dialog
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog //create a new print preview dialog
                {
                    Document = printDocument // creates a new print document
                };

                // Show Print Preview Dialog
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
                //after the process the three buttons will be visible
                ButtonForEmail.Visible = true;
                returnbtn.Visible = true;
                printbutton.Visible = true;
                this.FormBorderStyle = FormBorderStyle.Sizable; //restores the border
                this.WindowState = FormWindowState.Normal; //restores the form
                this.BackColor = SystemColors.ActiveCaption; //restores the color
                //restores the color when process is done
                NameofStaffReceipt1.BackColor = SystemColors.ActiveCaption;
                StaffPosition1.BackColor = SystemColors.ActiveCaption;
                EmailINFO1.BackColor = SystemColors.ActiveCaption;
                FromTo.BackColor = SystemColors.ActiveCaption;
                GrossPaySummary.BackColor = Color.WhiteSmoke;
                DeductSumamary.BackColor = Color.WhiteSmoke;
                NetPaySummary.BackColor = Color.WhiteSmoke;
                RecievedTxt.BackColor = SystemColors.ActiveCaption;
                HandledTxt.BackColor = SystemColors.ActiveCaption;
                Grosspanel.BackColor = Color.WhiteSmoke;
                DeductPanel.BackColor = Color.WhiteSmoke;
                NetPanel.BackColor = Color.WhiteSmoke;
                disable();
                Header1Blue.BackColor = Color.RoyalBlue;
                headeryellow.BackColor = Color.Yellow;
                RevertPictureBoxToOriginal(); // calls the method to revert the color of the image

                this.Refresh(); // Refresh UI




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //automatic error if something went wrong
            }
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            PrintFormContent(); //when the button is clicked, the form will be printed
        }

        private void HandledTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}

