
namespace Payroll_System
{
    partial class InputStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputStaff));
            ReturnSHS = new Button();
            EmployeeImage = new PictureBox();
            groupBox2 = new GroupBox();
            PasswordText = new TextBox();
            label8 = new Label();
            UsernameText = new TextBox();
            InputPhone = new TextBox();
            label5 = new Label();
            Phone = new Label();
            EmailInput = new TextBox();
            label7 = new Label();
            PhoneInput = new TextBox();
            label6 = new Label();
            ImportStaffPic = new Button();
            button4 = new Button();
            employeedel = new Button();
            button2 = new Button();
            button1 = new Button();
            DepartmentCombo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            FMBox = new TextBox();
            EmployeeIDBox = new TextBox();
            EmailTxt = new Label();
            EmployeeDatasGrid = new DataGridView();
            MainPanel = new Panel();
            label1 = new Label();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            ((System.ComponentModel.ISupportInitialize)EmployeeImage).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDatasGrid).BeginInit();
            MainPanel.SuspendLayout();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReturnSHS
            // 
            ReturnSHS.Cursor = Cursors.Hand;
            ReturnSHS.Font = new Font("Times New Roman", 15F);
            ReturnSHS.Location = new Point(12, 654);
            ReturnSHS.Name = "ReturnSHS";
            ReturnSHS.Size = new Size(86, 42);
            ReturnSHS.TabIndex = 6;
            ReturnSHS.Text = "Return";
            ReturnSHS.UseVisualStyleBackColor = true;
            ReturnSHS.Click += button1_Click;
            // 
            // EmployeeImage
            // 
            EmployeeImage.BackColor = Color.Gray;
            EmployeeImage.Location = new Point(902, 7);
            EmployeeImage.Name = "EmployeeImage";
            EmployeeImage.Size = new Size(139, 154);
            EmployeeImage.SizeMode = PictureBoxSizeMode.Zoom;
            EmployeeImage.TabIndex = 8;
            EmployeeImage.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(PasswordText);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(UsernameText);
            groupBox2.Controls.Add(InputPhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Phone);
            groupBox2.Controls.Add(EmailInput);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(PhoneInput);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(ImportStaffPic);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(employeedel);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(DepartmentCombo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(FMBox);
            groupBox2.Controls.Add(EmployeeIDBox);
            groupBox2.Controls.Add(EmployeeImage);
            groupBox2.Controls.Add(EmailTxt);
            groupBox2.Location = new Point(52, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1058, 221);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // PasswordText
            // 
            PasswordText.BorderStyle = BorderStyle.FixedSingle;
            PasswordText.Font = new Font("Times New Roman", 15F);
            PasswordText.Location = new Point(699, 104);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(161, 30);
            PasswordText.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F);
            label8.Location = new Point(702, 139);
            label8.Name = "label8";
            label8.Size = new Size(158, 22);
            label8.TabIndex = 35;
            label8.Text = "Account Password";
            // 
            // UsernameText
            // 
            UsernameText.BorderStyle = BorderStyle.FixedSingle;
            UsernameText.Font = new Font("Times New Roman", 15F);
            UsernameText.Location = new Point(699, 35);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(161, 30);
            UsernameText.TabIndex = 34;
            // 
            // InputPhone
            // 
            InputPhone.BorderStyle = BorderStyle.FixedSingle;
            InputPhone.Font = new Font("Times New Roman", 15F);
            InputPhone.Location = new Point(510, 35);
            InputPhone.Name = "InputPhone";
            InputPhone.Size = new Size(161, 30);
            InputPhone.TabIndex = 31;
            InputPhone.TextChanged += InputPhone_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F);
            label5.Location = new Point(699, 70);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 33;
            label5.Text = "Account Username";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Times New Roman", 15F);
            Phone.Location = new Point(387, 40);
            Phone.Name = "Phone";
            Phone.Size = new Size(126, 22);
            Phone.TabIndex = 32;
            Phone.Text = "Phone Number";
            // 
            // EmailInput
            // 
            EmailInput.BorderStyle = BorderStyle.FixedSingle;
            EmailInput.Font = new Font("Times New Roman", 15F);
            EmailInput.Location = new Point(510, 81);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(161, 30);
            EmailInput.TabIndex = 26;
            EmailInput.TextChanged += EmailInput_TextChanged_1;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 27;
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(0, 0);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(100, 20);
            PhoneInput.TabIndex = 28;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 29;
            // 
            // ImportStaffPic
            // 
            ImportStaffPic.Cursor = Cursors.Hand;
            ImportStaffPic.Font = new Font("Times New Roman", 15F);
            ImportStaffPic.Location = new Point(902, 177);
            ImportStaffPic.Name = "ImportStaffPic";
            ImportStaffPic.Size = new Size(139, 38);
            ImportStaffPic.TabIndex = 21;
            ImportStaffPic.Text = "Import";
            ImportStaffPic.UseVisualStyleBackColor = true;
            ImportStaffPic.Click += ImportStaffPic_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Times New Roman", 15F);
            button4.Location = new Point(619, 177);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 20;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // employeedel
            // 
            employeedel.Cursor = Cursors.Hand;
            employeedel.Font = new Font("Times New Roman", 15F);
            employeedel.Location = new Point(515, 177);
            employeedel.Name = "employeedel";
            employeedel.Size = new Size(98, 38);
            employeedel.TabIndex = 19;
            employeedel.Text = "Delete";
            employeedel.UseVisualStyleBackColor = true;
            employeedel.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 15F);
            button2.Location = new Point(426, 177);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 15F);
            button1.Location = new Point(330, 177);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.Font = new Font("Times New Roman", 15F);
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Items.AddRange(new object[] { "Junior High School", "Senior High School", "College" });
            DepartmentCombo.Location = new Point(145, 136);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(237, 30);
            DepartmentCombo.TabIndex = 16;
            DepartmentCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F);
            label4.Location = new Point(30, 139);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 13;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F);
            label3.Location = new Point(39, 88);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 12;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.Location = new Point(18, 40);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 8;
            label2.Text = "Employee ID";
            // 
            // FMBox
            // 
            FMBox.BorderStyle = BorderStyle.FixedSingle;
            FMBox.Font = new Font("Times New Roman", 15F);
            FMBox.Location = new Point(145, 86);
            FMBox.Name = "FMBox";
            FMBox.Size = new Size(237, 30);
            FMBox.TabIndex = 10;
            // 
            // EmployeeIDBox
            // 
            EmployeeIDBox.BorderStyle = BorderStyle.FixedSingle;
            EmployeeIDBox.Font = new Font("Times New Roman", 15F);
            EmployeeIDBox.Location = new Point(145, 36);
            EmployeeIDBox.Name = "EmployeeIDBox";
            EmployeeIDBox.Size = new Size(237, 30);
            EmployeeIDBox.TabIndex = 9;
            // 
            // EmailTxt
            // 
            EmailTxt.AutoSize = true;
            EmailTxt.Font = new Font("Times New Roman", 15F);
            EmailTxt.Location = new Point(456, 88);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(57, 22);
            EmailTxt.TabIndex = 30;
            EmailTxt.Text = "Email";
            // 
            // EmployeeDatasGrid
            // 
            EmployeeDatasGrid.AllowUserToAddRows = false;
            EmployeeDatasGrid.AllowUserToDeleteRows = false;
            EmployeeDatasGrid.AllowUserToResizeColumns = false;
            EmployeeDatasGrid.AllowUserToResizeRows = false;
            EmployeeDatasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeDatasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDatasGrid.Location = new Point(13, 56);
            EmployeeDatasGrid.Name = "EmployeeDatasGrid";
            EmployeeDatasGrid.ReadOnly = true;
            EmployeeDatasGrid.Size = new Size(1028, 206);
            EmployeeDatasGrid.TabIndex = 8;
            EmployeeDatasGrid.CellClick += dataGridView1_CellContentClick;
            EmployeeDatasGrid.CellContentClick += EmployeeDatasGrid_CellContentClick;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(EmployeeDatasGrid);
            MainPanel.Location = new Point(52, 138);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1058, 278);
            MainPanel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F);
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 39);
            label1.TabIndex = 9;
            label1.Text = "Registered Employees";
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(-1, 2);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1164, 111);
            Header1Blue.TabIndex = 51;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(955, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 53;
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
            headeryellow.Location = new Point(1, 112);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 52;
            // 
            // InputStaff
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1167, 695);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(MainPanel);
            Controls.Add(groupBox2);
            Controls.Add(ReturnSHS);
            Font = new Font("Times New Roman", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InputStaff";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputStaff";
            Load += InputStaff_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDatasGrid).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CommonClass.MainBoard == null || CommonClass.MainBoard.IsDisposed)
            {
                CommonClass.MainBoard = new Dashboard(CommonClass.Username, CommonClass.passwordadmin);
            }
            CommonClass.MainBoard.ShowDialog();
            CommonClass.MainBoard.BringToFront();

        }

        #endregion
        private Button ReturnSHS;
        private PictureBox EmployeeImage;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox FMBox;
        private TextBox EmployeeIDBox;
        private ComboBox DepartmentCombo;
        private Button ImportStaffPic;
        private Button button4;
        private Button employeedel;
        private Button button2;
        private Button button1;
        private TextBox PhoneInput;
        private Label label6;
        private TextBox EmailInput;
        private Label label7;
        private Label Phone;
        private TextBox InputPhone;
        private Label EmailTxt;
        private DataGridView EmployeeDatasGrid;
        private Panel MainPanel;
        private Label label5;
        private Label label1;
        private TextBox PasswordText;
        private Label label8;
        private TextBox UsernameText;
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private PictureBox pictureBox12;
    }
}