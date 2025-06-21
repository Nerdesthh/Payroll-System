namespace Payroll_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            registertxt = new LinkLabel();
            showpassword = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            userinputlogin = new TextBox();
            Loginbtn = new Button();
            Username = new Label();
            passwordinput = new TextBox();
            password = new Label();
            Date = new Label();
            datre = new Label();
            HeaderProjectname = new Panel();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            HeaderProjectname.SuspendLayout();
            SuspendLayout();
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(1, 0);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1164, 111);
            Header1Blue.TabIndex = 51;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(946, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 8;
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
            headeryellow.Location = new Point(3, 110);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 52;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 132, 177);
            panel1.Controls.Add(registertxt);
            panel1.Controls.Add(showpassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userinputlogin);
            panel1.Controls.Add(Loginbtn);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(passwordinput);
            panel1.Controls.Add(password);
            panel1.Location = new Point(244, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 587);
            panel1.TabIndex = 4;
            // 
            // registertxt
            // 
            registertxt.ActiveLinkColor = Color.White;
            registertxt.AutoSize = true;
            registertxt.Cursor = Cursors.Hand;
            registertxt.Font = new Font("Times New Roman", 15F);
            registertxt.ForeColor = Color.White;
            registertxt.LinkColor = Color.White;
            registertxt.Location = new Point(484, 556);
            registertxt.Name = "registertxt";
            registertxt.Size = new Size(200, 22);
            registertxt.TabIndex = 14;
            registertxt.TabStop = true;
            registertxt.Text = "Don't Have an Account?";
            registertxt.VisitedLinkColor = Color.White;
            registertxt.LinkClicked += registertxt_LinkClicked;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Times New Roman", 15F);
            showpassword.ForeColor = Color.White;
            showpassword.Location = new Point(154, 336);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(157, 26);
            showpassword.TabIndex = 13;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button1.Location = new Point(20, 521);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 12;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 58);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 11;
            label1.Text = "Welcome, Admin!";
            // 
            // userinputlogin
            // 
            userinputlogin.Font = new Font("Segoe UI", 20F);
            userinputlogin.Location = new Point(154, 129);
            userinputlogin.Name = "userinputlogin";
            userinputlogin.Size = new Size(392, 43);
            userinputlogin.TabIndex = 7;
            // 
            // Loginbtn
            // 
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            Loginbtn.Location = new Point(278, 389);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(144, 59);
            Loginbtn.TabIndex = 10;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            Username.ForeColor = Color.White;
            Username.Location = new Point(304, 175);
            Username.Name = "Username";
            Username.Size = new Size(95, 23);
            Username.TabIndex = 1;
            Username.Text = "Username";
            Username.Click += label3_Click;
            // 
            // passwordinput
            // 
            passwordinput.Font = new Font("Segoe UI", 20F);
            passwordinput.Location = new Point(154, 247);
            passwordinput.Name = "passwordinput";
            passwordinput.Size = new Size(392, 43);
            passwordinput.TabIndex = 8;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            password.ForeColor = Color.White;
            password.Location = new Point(304, 293);
            password.Name = "password";
            password.Size = new Size(90, 23);
            password.TabIndex = 2;
            password.Text = "Password";
            password.Click += label1_Click_2;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 20F);
            Date.Location = new Point(947, 550);
            Date.Name = "Date";
            Date.Size = new Size(74, 31);
            Date.TabIndex = 6;
            Date.Text = "Time:";
            Date.Click += label2_Click;
            // 
            // datre
            // 
            datre.AutoSize = true;
            datre.Font = new Font("Times New Roman", 20F);
            datre.Location = new Point(947, 510);
            datre.Name = "datre";
            datre.Size = new Size(71, 31);
            datre.TabIndex = 7;
            datre.Text = "Date:";
            datre.Click += datre_Click;
            // 
            // HeaderProjectname
            // 
            HeaderProjectname.BackColor = Color.Transparent;
            HeaderProjectname.BackgroundImage = (Image)resources.GetObject("HeaderProjectname.BackgroundImage");
            HeaderProjectname.BackgroundImageLayout = ImageLayout.Stretch;
            HeaderProjectname.Controls.Add(datre);
            HeaderProjectname.Controls.Add(Date);
            HeaderProjectname.Controls.Add(panel1);
            HeaderProjectname.Location = new Point(0, 103);
            HeaderProjectname.Name = "HeaderProjectname";
            HeaderProjectname.Size = new Size(1171, 590);
            HeaderProjectname.TabIndex = 1;
            HeaderProjectname.Paint += HeaderProjectname_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 696);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(HeaderProjectname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perpetual Pay Roll System - Group 2";
            Load += Form1_Load;
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HeaderProjectname.ResumeLayout(false);
            HeaderProjectname.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox12;
        private Panel panel1;
        private LinkLabel registertxt;
        private CheckBox showpassword;
        private Button button1;
        private Label label1;
        private TextBox userinputlogin;
        private Button Loginbtn;
        private Label Username;
        private TextBox passwordinput;
        private Label password;
        private Label Date;
        private Label datre;
        private Panel HeaderProjectname;
    }
}
