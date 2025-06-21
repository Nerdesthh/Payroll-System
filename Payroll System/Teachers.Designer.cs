namespace Payroll_System
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            panel1 = new Panel();
            showpassword = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            userinputlogin = new TextBox();
            Loginbtn = new Button();
            Username = new Label();
            passwordinput = new TextBox();
            password = new Label();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            panel2 = new Panel();
            pictureBox12 = new PictureBox();
            headeryellow = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Date = new Label();
            Time = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 132, 177);
            panel1.Controls.Add(showpassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userinputlogin);
            panel1.Controls.Add(Loginbtn);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(passwordinput);
            panel1.Controls.Add(password);
            panel1.Location = new Point(243, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 598);
            panel1.TabIndex = 19;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Times New Roman", 15F);
            showpassword.ForeColor = Color.White;
            showpassword.Location = new Point(154, 329);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(157, 26);
            showpassword.TabIndex = 13;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            showpassword.CheckStateChanged += showpassword_CheckStateChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            button1.Location = new Point(13, 527);
            button1.Name = "button1";
            button1.Size = new Size(123, 49);
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
            label1.Location = new Point(234, 48);
            label1.Name = "label1";
            label1.Size = new Size(247, 38);
            label1.TabIndex = 11;
            label1.Text = "Welcome, Staff!";
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
            Loginbtn.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            Loginbtn.Location = new Point(284, 393);
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
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Payrollname);
            panel2.Controls.Add(PerpetualName);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1168, 111);
            panel2.TabIndex = 54;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(947, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 54;
            pictureBox12.TabStop = false;
            // 
            // headeryellow
            // 
            headeryellow.BackColor = Color.Yellow;
            headeryellow.Location = new Point(-2, 108);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1170, 10);
            headeryellow.TabIndex = 55;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.Transparent;
            Date.Font = new Font("Times New Roman", 20F);
            Date.Location = new Point(946, 613);
            Date.Name = "Date";
            Date.Size = new Size(71, 31);
            Date.TabIndex = 56;
            Date.Text = "Date:";
            Date.Click += label2_Click;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.Transparent;
            Time.Font = new Font("Times New Roman", 20F);
            Time.Location = new Point(946, 656);
            Time.Name = "Time";
            Time.Size = new Size(74, 31);
            Time.TabIndex = 57;
            Time.Text = "Time:";
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 696);
            Controls.Add(Time);
            Controls.Add(Date);
            Controls.Add(panel2);
            Controls.Add(headeryellow);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teachers";
            Load += Teachers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox userinputlogin;
        private Button Loginbtn;
        private Label Username;
        private TextBox passwordinput;
        private Label password;
        private Button button1;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel panel2;
        private Panel headeryellow;
        private System.Windows.Forms.Timer timer1;
        private Label Date;
        private Label Time;
        private CheckBox showpassword;
        private PictureBox pictureBox12;
    }
}