


namespace Payroll_System
{
    partial class AdminRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistration));
            Header1Blue = new Panel();
            panel1 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            RegisterGroup = new GroupBox();
            ReturnBtn = new Button();
            label2 = new Label();
            regbtn = new Button();
            passinput = new TextBox();
            userinput = new TextBox();
            passwordinput = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Header1Blue.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RegisterGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.MediumBlue;
            Header1Blue.Controls.Add(panel1);
            Header1Blue.Controls.Add(headeryellow);
            Header1Blue.Location = new Point(1, 0);
            Header1Blue.Margin = new Padding(4, 3, 4, 3);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1171, 98);
            Header1Blue.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Payrollname);
            panel1.Controls.Add(PerpetualName);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 111);
            panel1.TabIndex = 51;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(940, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 54;
            pictureBox12.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 6);
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
            Payrollname.Location = new Point(479, 56);
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
            PerpetualName.Location = new Point(323, 6);
            PerpetualName.Name = "PerpetualName";
            PerpetualName.Size = new Size(588, 45);
            PerpetualName.TabIndex = 0;
            PerpetualName.Text = "Perpetual Help College of Manila\r\n";
            // 
            // headeryellow
            // 
            headeryellow.BackColor = Color.LightYellow;
            headeryellow.Location = new Point(-1, 108);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 52;
            // 
            // RegisterGroup
            // 
            RegisterGroup.BackColor = SystemColors.ActiveCaption;
            RegisterGroup.Controls.Add(ReturnBtn);
            RegisterGroup.Controls.Add(label2);
            RegisterGroup.Controls.Add(regbtn);
            RegisterGroup.Controls.Add(passinput);
            RegisterGroup.Controls.Add(userinput);
            RegisterGroup.Controls.Add(passwordinput);
            RegisterGroup.Controls.Add(label1);
            RegisterGroup.Location = new Point(204, 104);
            RegisterGroup.Margin = new Padding(4, 3, 4, 3);
            RegisterGroup.Name = "RegisterGroup";
            RegisterGroup.Padding = new Padding(4, 3, 4, 3);
            RegisterGroup.Size = new Size(854, 593);
            RegisterGroup.TabIndex = 2;
            RegisterGroup.TabStop = false;
            RegisterGroup.Enter += RegisterGroup_Enter;
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(463, 468);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(134, 50);
            ReturnBtn.TabIndex = 4;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25F);
            label2.Location = new Point(259, 82);
            label2.Name = "label2";
            label2.Size = new Size(281, 39);
            label2.TabIndex = 17;
            label2.Text = "Admin Registration";
            label2.Click += label2_Click;
            // 
            // regbtn
            // 
            regbtn.Location = new Point(463, 421);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(134, 50);
            regbtn.TabIndex = 16;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // passinput
            // 
            passinput.Font = new Font("Times New Roman", 20F);
            passinput.Location = new Point(216, 298);
            passinput.Name = "passinput";
            passinput.Size = new Size(381, 38);
            passinput.TabIndex = 15;
            passinput.TextChanged += passinput_TextChanged_1;
            // 
            // userinput
            // 
            userinput.Font = new Font("Times New Roman", 20F);
            userinput.Location = new Point(216, 161);
            userinput.Name = "userinput";
            userinput.Size = new Size(381, 38);
            userinput.TabIndex = 11;
            userinput.TextChanged += userinput_TextChanged_1;
            // 
            // passwordinput
            // 
            passwordinput.AutoSize = true;
            passwordinput.Font = new Font("Times New Roman", 25F);
            passwordinput.Location = new Point(331, 364);
            passwordinput.Name = "passwordinput";
            passwordinput.Size = new Size(147, 39);
            passwordinput.TabIndex = 2;
            passwordinput.Text = "Password";
            passwordinput.Click += passwordinput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F);
            label1.Location = new Point(315, 202);
            label1.Name = "label1";
            label1.Size = new Size(152, 39);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 10);
            panel2.TabIndex = 53;
            // 
            // AdminRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 695);
            Controls.Add(panel2);
            Controls.Add(RegisterGroup);
            Controls.Add(Header1Blue);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "AdminRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AdminRegistration_Load;
            Header1Blue.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            RegisterGroup.ResumeLayout(false);
            RegisterGroup.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }







        #endregion

        private Panel Header1Blue;
        private GroupBox RegisterGroup;
        private Label passwordinput;
        private Label label1;
        private Button registbtn;
        private TextBox userinput;
        private TextBox passinput;
        private Button regbtn;
        private Button ReturnBtn;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private Panel panel2;
        private PictureBox pictureBox12;
    }
}