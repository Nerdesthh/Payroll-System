namespace Payroll_System
{
    partial class JuniorHigh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuniorHigh));
            JHSDataGrid = new DataGridView();
            panel2 = new Panel();
            EmailJHS = new TextBox();
            ContactJHS = new TextBox();
            EmpNameJHS = new TextBox();
            EmpIDInfoJHS = new TextBox();
            label5 = new Label();
            Contact = new Label();
            EmpNameLabel = new Label();
            EmployeeID = new Label();
            Information = new Label();
            Proceed2MainFuctionJHS = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            ReturnBTn = new Button();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            ((System.ComponentModel.ISupportInitialize)JHSDataGrid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JHSDataGrid
            // 
            JHSDataGrid.AllowUserToAddRows = false;
            JHSDataGrid.AllowUserToDeleteRows = false;
            JHSDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            JHSDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JHSDataGrid.Location = new Point(28, 14);
            JHSDataGrid.Name = "JHSDataGrid";
            JHSDataGrid.ReadOnly = true;
            JHSDataGrid.Size = new Size(941, 372);
            JHSDataGrid.TabIndex = 8;
            JHSDataGrid.CellClick += JHSDataGrid_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(EmailJHS);
            panel2.Controls.Add(ContactJHS);
            panel2.Controls.Add(EmpNameJHS);
            panel2.Controls.Add(EmpIDInfoJHS);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Contact);
            panel2.Controls.Add(EmpNameLabel);
            panel2.Controls.Add(EmployeeID);
            panel2.Controls.Add(Information);
            panel2.Controls.Add(Proceed2MainFuctionJHS);
            panel2.Location = new Point(95, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 123);
            panel2.TabIndex = 15;
            // 
            // EmailJHS
            // 
            EmailJHS.BorderStyle = BorderStyle.FixedSingle;
            EmailJHS.Font = new Font("Times New Roman", 15F);
            EmailJHS.Location = new Point(566, 80);
            EmailJHS.Name = "EmailJHS";
            EmailJHS.ReadOnly = true;
            EmailJHS.Size = new Size(181, 30);
            EmailJHS.TabIndex = 20;
            // 
            // ContactJHS
            // 
            ContactJHS.BorderStyle = BorderStyle.FixedSingle;
            ContactJHS.Font = new Font("Times New Roman", 15F);
            ContactJHS.Location = new Point(566, 37);
            ContactJHS.Name = "ContactJHS";
            ContactJHS.ReadOnly = true;
            ContactJHS.Size = new Size(181, 30);
            ContactJHS.TabIndex = 19;
            // 
            // EmpNameJHS
            // 
            EmpNameJHS.BorderStyle = BorderStyle.FixedSingle;
            EmpNameJHS.Font = new Font("Times New Roman", 15F);
            EmpNameJHS.Location = new Point(164, 85);
            EmpNameJHS.Name = "EmpNameJHS";
            EmpNameJHS.ReadOnly = true;
            EmpNameJHS.Size = new Size(181, 30);
            EmpNameJHS.TabIndex = 18;
            // 
            // EmpIDInfoJHS
            // 
            EmpIDInfoJHS.BorderStyle = BorderStyle.FixedSingle;
            EmpIDInfoJHS.Font = new Font("Times New Roman", 15F);
            EmpIDInfoJHS.Location = new Point(164, 37);
            EmpIDInfoJHS.Name = "EmpIDInfoJHS";
            EmpIDInfoJHS.ReadOnly = true;
            EmpIDInfoJHS.Size = new Size(181, 30);
            EmpIDInfoJHS.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F);
            label5.Location = new Point(500, 88);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.Font = new Font("Times New Roman", 15F);
            Contact.Location = new Point(394, 45);
            Contact.Name = "Contact";
            Contact.Size = new Size(166, 22);
            Contact.TabIndex = 11;
            Contact.Text = "Contact Information";
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.AutoSize = true;
            EmpNameLabel.Font = new Font("Times New Roman", 15F);
            EmpNameLabel.Location = new Point(18, 85);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(140, 22);
            EmpNameLabel.TabIndex = 10;
            EmpNameLabel.Text = "Employee Name";
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSize = true;
            EmployeeID.Font = new Font("Times New Roman", 15F);
            EmployeeID.Location = new Point(38, 45);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(109, 22);
            EmployeeID.TabIndex = 9;
            EmployeeID.Text = "EmployeeID";
            // 
            // Information
            // 
            Information.AutoSize = true;
            Information.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            Information.Location = new Point(324, 3);
            Information.Name = "Information";
            Information.Size = new Size(251, 31);
            Information.TabIndex = 8;
            Information.Text = "- Staff Information -";
            Information.Click += Information_Click;
            // 
            // Proceed2MainFuctionJHS
            // 
            Proceed2MainFuctionJHS.Cursor = Cursors.Hand;
            Proceed2MainFuctionJHS.FlatAppearance.BorderColor = Color.Black;
            Proceed2MainFuctionJHS.FlatAppearance.BorderSize = 10;
            Proceed2MainFuctionJHS.Location = new Point(817, 37);
            Proceed2MainFuctionJHS.Name = "Proceed2MainFuctionJHS";
            Proceed2MainFuctionJHS.Size = new Size(152, 58);
            Proceed2MainFuctionJHS.TabIndex = 7;
            Proceed2MainFuctionJHS.Text = "Proceed to Calculator";
            Proceed2MainFuctionJHS.UseVisualStyleBackColor = true;
            Proceed2MainFuctionJHS.Click += Proceed2MainFuctionJHS_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(JHSDataGrid);
            panel1.Location = new Point(95, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 406);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(446, 126);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 31);
            label1.TabIndex = 13;
            label1.Text = "Juinor High Teacher List";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            button1.Location = new Point(1065, 124);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 12;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReturnBTn
            // 
            ReturnBTn.BackColor = SystemColors.ActiveCaption;
            ReturnBTn.Cursor = Cursors.Hand;
            ReturnBTn.Location = new Point(3, 124);
            ReturnBTn.Name = "ReturnBTn";
            ReturnBTn.Size = new Size(105, 33);
            ReturnBTn.TabIndex = 11;
            ReturnBTn.Text = "Return";
            ReturnBTn.UseVisualStyleBackColor = false;
            ReturnBTn.Click += ReturnBTn_Click;
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(0, 1);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1164, 111);
            Header1Blue.TabIndex = 49;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(929, 4);
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
            headeryellow.Location = new Point(1, 111);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 50;
            // 
            // JuniorHigh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1167, 695);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ReturnBTn);
            Font = new Font("Times New Roman", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "JuniorHigh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JuniorHigh";
            ((System.ComponentModel.ISupportInitialize)JHSDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView JHSDataGrid;
        private Panel panel2;
        private Label label5;
        private Label Contact;
        private Label EmpNameLabel;
        private Label EmployeeID;
        private Label Information;
        private Button Proceed2MainFuctionJHS;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button ReturnBTn;
        private TextBox EmailJHS;
        private TextBox ContactJHS;
        private TextBox EmpNameJHS;
        private TextBox EmpIDInfoJHS;
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private PictureBox pictureBox12;
    }
}