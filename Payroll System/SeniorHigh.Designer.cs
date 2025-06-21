namespace Payroll_System
{
    partial class SeniorHigh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeniorHigh));
            ReturnBTn = new Button();
            button1 = new Button();
            label1 = new Label();
            Proceed2MainFuction = new Button();
            ShsDataGrid = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            EmailInfo = new TextBox();
            ContactInfo = new TextBox();
            EmpNameInfo = new TextBox();
            EmpIDInfo = new TextBox();
            label5 = new Label();
            Contact = new Label();
            EmpNameLabel = new Label();
            EmployeeID = new Label();
            Information = new Label();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            ((System.ComponentModel.ISupportInitialize)ShsDataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReturnBTn
            // 
            ReturnBTn.BackColor = SystemColors.ActiveCaption;
            ReturnBTn.Location = new Point(12, 122);
            ReturnBTn.Name = "ReturnBTn";
            ReturnBTn.Size = new Size(105, 33);
            ReturnBTn.TabIndex = 4;
            ReturnBTn.Text = "Return";
            ReturnBTn.UseVisualStyleBackColor = false;
            ReturnBTn.Click += ReturnBTn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button1.Location = new Point(1056, 122);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(429, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 31);
            label1.TabIndex = 6;
            label1.Text = "Senior High Teacher List";
            // 
            // Proceed2MainFuction
            // 
            Proceed2MainFuction.FlatAppearance.BorderColor = Color.Black;
            Proceed2MainFuction.FlatAppearance.BorderSize = 10;
            Proceed2MainFuction.Location = new Point(830, 40);
            Proceed2MainFuction.Name = "Proceed2MainFuction";
            Proceed2MainFuction.Size = new Size(139, 55);
            Proceed2MainFuction.TabIndex = 7;
            Proceed2MainFuction.Text = "Proceed to Calculator";
            Proceed2MainFuction.UseVisualStyleBackColor = true;
            Proceed2MainFuction.Click += Proceed2MainFuction_Click;
            // 
            // ShsDataGrid
            // 
            ShsDataGrid.AllowUserToAddRows = false;
            ShsDataGrid.AllowUserToDeleteRows = false;
            ShsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShsDataGrid.Location = new Point(28, 14);
            ShsDataGrid.Name = "ShsDataGrid";
            ShsDataGrid.ReadOnly = true;
            ShsDataGrid.Size = new Size(941, 372);
            ShsDataGrid.TabIndex = 8;
            ShsDataGrid.CellClick += ShsDataGrid_CellClick;
            ShsDataGrid.CellContentClick += dataGridView1_CellContentClick;
            ShsDataGrid.CellContentDoubleClick += ShsDataGrid_CellContentDoubleClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(ShsDataGrid);
            panel1.Location = new Point(93, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 406);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(EmailInfo);
            panel2.Controls.Add(ContactInfo);
            panel2.Controls.Add(EmpNameInfo);
            panel2.Controls.Add(EmpIDInfo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Contact);
            panel2.Controls.Add(EmpNameLabel);
            panel2.Controls.Add(EmployeeID);
            panel2.Controls.Add(Information);
            panel2.Controls.Add(Proceed2MainFuction);
            panel2.Location = new Point(93, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 123);
            panel2.TabIndex = 10;
            // 
            // EmailInfo
            // 
            EmailInfo.BorderStyle = BorderStyle.FixedSingle;
            EmailInfo.Font = new Font("Times New Roman", 16F);
            EmailInfo.Location = new Point(566, 71);
            EmailInfo.Name = "EmailInfo";
            EmailInfo.ReadOnly = true;
            EmailInfo.Size = new Size(170, 32);
            EmailInfo.TabIndex = 16;
            // 
            // ContactInfo
            // 
            ContactInfo.BackColor = SystemColors.Control;
            ContactInfo.BorderStyle = BorderStyle.FixedSingle;
            ContactInfo.Font = new Font("Times New Roman", 15F);
            ContactInfo.Location = new Point(566, 31);
            ContactInfo.Name = "ContactInfo";
            ContactInfo.ReadOnly = true;
            ContactInfo.Size = new Size(170, 30);
            ContactInfo.TabIndex = 15;
            // 
            // EmpNameInfo
            // 
            EmpNameInfo.BorderStyle = BorderStyle.FixedSingle;
            EmpNameInfo.Font = new Font("Times New Roman", 15F);
            EmpNameInfo.Location = new Point(154, 73);
            EmpNameInfo.Name = "EmpNameInfo";
            EmpNameInfo.ReadOnly = true;
            EmpNameInfo.Size = new Size(180, 30);
            EmpNameInfo.TabIndex = 14;
            // 
            // EmpIDInfo
            // 
            EmpIDInfo.BorderStyle = BorderStyle.FixedSingle;
            EmpIDInfo.Font = new Font("Times New Roman", 15F);
            EmpIDInfo.Location = new Point(153, 37);
            EmpIDInfo.Name = "EmpIDInfo";
            EmpIDInfo.ReadOnly = true;
            EmpIDInfo.Size = new Size(181, 30);
            EmpIDInfo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F);
            label5.Location = new Point(500, 80);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.Font = new Font("Times New Roman", 15F);
            Contact.Location = new Point(394, 37);
            Contact.Name = "Contact";
            Contact.Size = new Size(166, 22);
            Contact.TabIndex = 11;
            Contact.Text = "Contact Information";
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.AutoSize = true;
            EmpNameLabel.Font = new Font("Times New Roman", 15F);
            EmpNameLabel.Location = new Point(8, 80);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(140, 22);
            EmpNameLabel.TabIndex = 10;
            EmpNameLabel.Text = "Employee Name";
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSize = true;
            EmployeeID.Font = new Font("Times New Roman", 15F);
            EmployeeID.Location = new Point(28, 40);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(109, 22);
            EmployeeID.TabIndex = 9;
            EmployeeID.Text = "EmployeeID";
            // 
            // Information
            // 
            Information.AutoSize = true;
            Information.Font = new Font("Times New Roman", 20F);
            Information.Location = new Point(374, 1);
            Information.Name = "Information";
            Information.Size = new Size(232, 31);
            Information.TabIndex = 8;
            Information.Text = "- Staff Information -";
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.RoyalBlue;
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
            pictureBox12.Location = new Point(941, 4);
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
            headeryellow.Location = new Point(3, 110);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 52;
            // 
            // SeniorHigh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1167, 695);
            Controls.Add(Header1Blue);
            Controls.Add(panel2);
            Controls.Add(headeryellow);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ReturnBTn);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SeniorHigh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeniorHigh";
            Load += SeniorHigh_Load;
            ((System.ComponentModel.ISupportInitialize)ShsDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ReturnBTn;
        private Button button1;
        private Label label1;
        private Button Proceed2MainFuction;
        private DataGridView ShsDataGrid;
        private Panel panel1;
        private Panel panel2;
        private TextBox EmailInfo;
        private TextBox ContactInfo;
        private TextBox EmpNameInfo;
        private TextBox EmpIDInfo;
        private Label label5;
        private Label Contact;
        private Label EmpNameLabel;
        private Label EmployeeID;
        private Label Information;
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private PictureBox pictureBox12;
    }
}