namespace Payroll_System
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            panel1 = new Panel();
            Credits = new Button();
            label1 = new Label();
            teacher = new Button();
            admin = new Button();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            panel1.SuspendLayout();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 132, 177);
            panel1.Controls.Add(Credits);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teacher);
            panel1.Controls.Add(admin);
            panel1.Location = new Point(250, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 579);
            panel1.TabIndex = 17;
            // 
            // Credits
            // 
            Credits.Cursor = Cursors.Hand;
            Credits.Font = new Font("Times New Roman", 25F);
            Credits.Location = new Point(228, 410);
            Credits.Name = "Credits";
            Credits.Size = new Size(232, 91);
            Credits.TabIndex = 3;
            Credits.Text = "Credits";
            Credits.UseVisualStyleBackColor = true;
            Credits.Click += Credits_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 51);
            label1.Name = "label1";
            label1.Size = new Size(450, 38);
            label1.TabIndex = 2;
            label1.Text = "Welcome to PHCM PayPoint!";
            // 
            // teacher
            // 
            teacher.Cursor = Cursors.Hand;
            teacher.Font = new Font("Times New Roman", 25F);
            teacher.Location = new Point(229, 259);
            teacher.Name = "teacher";
            teacher.Size = new Size(232, 91);
            teacher.TabIndex = 1;
            teacher.Text = "Teachers";
            teacher.UseVisualStyleBackColor = true;
            teacher.Click += teacher_Click;
            // 
            // admin
            // 
            admin.Cursor = Cursors.Hand;
            admin.Font = new Font("Times New Roman", 25F);
            admin.Location = new Point(228, 112);
            admin.Name = "admin";
            admin.Size = new Size(232, 91);
            admin.TabIndex = 0;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = true;
            admin.Click += admin_Click;
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(0, -7);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1168, 119);
            Header1Blue.TabIndex = 47;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(954, 8);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 5;
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
            headeryellow.Location = new Point(2, 111);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 48;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 696);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selection";
            Load += Selection_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button teacher;
        private Button admin;
        private Panel Header1Blue;
        private PictureBox pictureBox1;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private Button Credits;
        private PictureBox pictureBox12;
    }
}