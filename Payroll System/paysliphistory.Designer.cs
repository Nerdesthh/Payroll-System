namespace Payroll_System
{
    partial class paysliphistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paysliphistory));
            Payrollname = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox1 = new PictureBox();
            PerpetualName = new Label();
            headeryellow = new Panel();
            searchtxt = new TextBox();
            Search = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(98, 132, 177);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(228, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 587);
            panel2.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(232, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 45);
            label2.TabIndex = 18;
            label2.Text = "Payslip History";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 25F);
            button2.Location = new Point(12, 626);
            button2.Name = "button2";
            button2.Size = new Size(157, 57);
            button2.TabIndex = 27;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Payrollname);
            panel1.Controls.Add(PerpetualName);
            panel1.Location = new Point(1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 111);
            panel1.TabIndex = 52;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(932, 11);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 55;
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
            headeryellow.Location = new Point(0, 103);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1173, 10);
            headeryellow.TabIndex = 53;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchtxt.Location = new Point(971, 128);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "E.g. March 2025";
            searchtxt.Size = new Size(184, 32);
            searchtxt.TabIndex = 19;
            // 
            // Search
            // 
            Search.Cursor = Cursors.Hand;
            Search.Font = new Font("Times New Roman", 20F);
            Search.Location = new Point(971, 203);
            Search.Name = "Search";
            Search.Size = new Size(184, 49);
            Search.TabIndex = 54;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // paysliphistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 695);
            Controls.Add(Search);
            Controls.Add(searchtxt);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(headeryellow);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "paysliphistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payslip History";
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

        private Label Payrollname;
        private Panel panel2;
        private Button button2;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label PerpetualName;
        private Panel headeryellow;
        private TextBox searchtxt;
        private Button Search;
        private PictureBox pictureBox12;
    }
}