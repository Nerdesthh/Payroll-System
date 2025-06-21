namespace Payroll_System
{
    partial class TeacherDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            panel2 = new Panel();
            calculator = new Button();
            paysliphistory = new Button();
            button1 = new Button();
            label2 = new Label();
            staffusernametext = new LinkLabel();
            panel1 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Time = new Label();
            Date = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(98, 132, 177);
            panel2.Controls.Add(calculator);
            panel2.Controls.Add(paysliphistory);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(staffusernametext);
            panel2.Location = new Point(260, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 593);
            panel2.TabIndex = 26;
            // 
            // calculator
            // 
            calculator.Cursor = Cursors.Hand;
            calculator.Font = new Font("Times New Roman", 20F);
            calculator.Location = new Point(146, 349);
            calculator.Name = "calculator";
            calculator.Size = new Size(370, 82);
            calculator.TabIndex = 29;
            calculator.Text = "Calculator";
            calculator.UseVisualStyleBackColor = true;
            calculator.Click += calculator_Click;
            // 
            // paysliphistory
            // 
            paysliphistory.Cursor = Cursors.Hand;
            paysliphistory.Font = new Font("Times New Roman", 20F);
            paysliphistory.Location = new Point(146, 175);
            paysliphistory.Name = "paysliphistory";
            paysliphistory.Size = new Size(370, 82);
            paysliphistory.TabIndex = 28;
            paysliphistory.Text = "Payslip History";
            paysliphistory.UseVisualStyleBackColor = true;
            paysliphistory.Click += paysliphistory_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 25F);
            button1.Location = new Point(508, 520);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 27;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 75);
            label2.Name = "label2";
            label2.Size = new Size(331, 45);
            label2.TabIndex = 18;
            label2.Text = "Teachers Function";
            // 
            // staffusernametext
            // 
            staffusernametext.ActiveLinkColor = Color.FromArgb(0, 0, 0, 0);
            staffusernametext.AutoSize = true;
            staffusernametext.DisabledLinkColor = Color.FromArgb(0, 0, 0, 0);
            staffusernametext.Font = new Font("Times New Roman", 18F);
            staffusernametext.ForeColor = Color.White;
            staffusernametext.LinkBehavior = LinkBehavior.HoverUnderline;
            staffusernametext.LinkColor = Color.FromArgb(0, 0, 0, 0);
            staffusernametext.Location = new Point(3, 18);
            staffusernametext.Name = "staffusernametext";
            staffusernametext.Size = new Size(403, 27);
            staffusernametext.TabIndex = 17;
            staffusernametext.TabStop = true;
            staffusernametext.Text = "This will changed into \"Welcome, User!\"";
            staffusernametext.VisitedLinkColor = Color.FromArgb(0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Payrollname);
            panel1.Controls.Add(PerpetualName);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 111);
            panel1.TabIndex = 49;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(949, 7);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 60;
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
            headeryellow.Location = new Point(0, 108);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1170, 10);
            headeryellow.TabIndex = 50;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.Transparent;
            Time.Font = new Font("Times New Roman", 20F);
            Time.Location = new Point(950, 655);
            Time.Name = "Time";
            Time.Size = new Size(74, 31);
            Time.TabIndex = 58;
            Time.Text = "Time:";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.Transparent;
            Date.Font = new Font("Times New Roman", 20F);
            Date.Location = new Point(950, 611);
            Date.Name = "Date";
            Date.Size = new Size(71, 31);
            Date.TabIndex = 59;
            Date.Text = "Date:";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 695);
            Controls.Add(Date);
            Controls.Add(Time);
            Controls.Add(headeryellow);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TeacherDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashboard";
            Load += TeacherDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private LinkLabel staffusernametext;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private Button calculator;
        private Button paysliphistory;
        private System.Windows.Forms.Timer timer1;
        private Label Time;
        private Label Date;
        private PictureBox pictureBox12;
    }
}