
namespace Payroll_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            userdash = new Label();
            Logout = new Button();
            label1 = new Label();
            panel1 = new Panel();
            CollegeLink = new Button();
            SHS = new Button();
            JHS = new Button();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            datre = new Label();
            Date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            picture = new PictureBox();
            Welcome = new LinkLabel();
            panel1.SuspendLayout();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // userdash
            // 
            userdash.AutoSize = true;
            userdash.Location = new Point(1035, 105);
            userdash.Margin = new Padding(4, 0, 4, 0);
            userdash.Name = "userdash";
            userdash.Size = new Size(0, 16);
            userdash.TabIndex = 2;
            // 
            // Logout
            // 
            Logout.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            Logout.Location = new Point(12, 631);
            Logout.Name = "Logout";
            Logout.Size = new Size(147, 52);
            Logout.TabIndex = 14;
            Logout.Text = "Log-Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 29);
            label1.Name = "label1";
            label1.Size = new Size(319, 45);
            label1.TabIndex = 18;
            label1.Text = "Department Lists";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 132, 177);
            panel1.Controls.Add(CollegeLink);
            panel1.Controls.Add(SHS);
            panel1.Controls.Add(JHS);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(250, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 584);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // CollegeLink
            // 
            CollegeLink.Cursor = Cursors.Hand;
            CollegeLink.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            CollegeLink.Location = new Point(133, 387);
            CollegeLink.Name = "CollegeLink";
            CollegeLink.Size = new Size(401, 87);
            CollegeLink.TabIndex = 25;
            CollegeLink.Text = "College";
            CollegeLink.UseVisualStyleBackColor = true;
            CollegeLink.Click += CollegeLink_Click;
            // 
            // SHS
            // 
            SHS.Cursor = Cursors.Hand;
            SHS.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            SHS.Location = new Point(133, 252);
            SHS.Name = "SHS";
            SHS.Size = new Size(401, 87);
            SHS.TabIndex = 24;
            SHS.Text = "Senior High School";
            SHS.UseVisualStyleBackColor = true;
            SHS.Click += SHS_Click;
            // 
            // JHS
            // 
            JHS.Cursor = Cursors.Hand;
            JHS.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            JHS.Location = new Point(133, 113);
            JHS.Name = "JHS";
            JHS.Size = new Size(401, 87);
            JHS.TabIndex = 23;
            JHS.Text = "Junior High School";
            JHS.UseVisualStyleBackColor = true;
            JHS.Click += JHS_Click;
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(-2, -7);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1168, 119);
            Header1Blue.TabIndex = 49;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(942, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 51;
            pictureBox12.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Payrollname
            // 
            Payrollname.AutoSize = true;
            Payrollname.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            Payrollname.ForeColor = Color.White;
            Payrollname.Location = new Point(479, 65);
            Payrollname.Name = "Payrollname";
            Payrollname.Size = new Size(261, 38);
            Payrollname.TabIndex = 1;
            Payrollname.Text = "PHCM PayPoint";
            // 
            // PerpetualName
            // 
            PerpetualName.AutoSize = true;
            PerpetualName.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            PerpetualName.ForeColor = Color.White;
            PerpetualName.Location = new Point(323, 16);
            PerpetualName.Name = "PerpetualName";
            PerpetualName.Size = new Size(588, 45);
            PerpetualName.TabIndex = 0;
            PerpetualName.Text = "Perpetual Help College of Manila\r\n";
            // 
            // headeryellow
            // 
            headeryellow.BackColor = Color.Yellow;
            headeryellow.Location = new Point(0, 111);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 50;
            // 
            // datre
            // 
            datre.AutoSize = true;
            datre.BackColor = Color.Transparent;
            datre.Font = new Font("Times New Roman", 20F);
            datre.ForeColor = Color.Black;
            datre.Location = new Point(940, 608);
            datre.Name = "datre";
            datre.Size = new Size(71, 31);
            datre.TabIndex = 24;
            datre.Text = "Date:";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.Transparent;
            Date.Font = new Font("Times New Roman", 20F);
            Date.ForeColor = Color.Black;
            Date.Location = new Point(940, 652);
            Date.Name = "Date";
            Date.Size = new Size(74, 31);
            Date.TabIndex = 23;
            Date.Text = "Time:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // picture
            // 
            picture.Location = new Point(24, 138);
            picture.Margin = new Padding(4, 3, 4, 3);
            picture.Name = "picture";
            picture.Size = new Size(179, 113);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 6;
            picture.TabStop = false;
            // 
            // Welcome
            // 
            Welcome.ActiveLinkColor = Color.White;
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Cursor = Cursors.Hand;
            Welcome.DisabledLinkColor = Color.White;
            Welcome.Font = new Font("Times New Roman", 18F);
            Welcome.ForeColor = Color.White;
            Welcome.LinkBehavior = LinkBehavior.HoverUnderline;
            Welcome.LinkColor = Color.White;
            Welcome.Location = new Point(0, 263);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(115, 27);
            Welcome.TabIndex = 17;
            Welcome.TabStop = true;
            Welcome.Text = "linkLabel1";
            Welcome.VisitedLinkColor = Color.White;
            Welcome.LinkClicked += welcome_LinkClicked;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 695);
            Controls.Add(picture);
            Controls.Add(Welcome);
            Controls.Add(datre);
            Controls.Add(Date);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(panel1);
            Controls.Add(Logout);
            Controls.Add(userdash);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label userdash;
        private Button Logout;
        private Label label1;
        private Panel panel1;
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private Label datre;
        private Label Date;
        private System.Windows.Forms.Timer timer1;
        private Button JHS;
        private Button CollegeLink;
        private Button SHS;
        private PictureBox picture;
        private LinkLabel Welcome;
        private PictureBox pictureBox12;
    }
}