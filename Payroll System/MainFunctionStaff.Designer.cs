namespace Payroll_System
{
    partial class MainFunctionStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFunctionStaff));
            FirstHalf = new RadioButton();
            LastHalf = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            CalculateSalary = new Button();
            HourRateinput = new TextBox();
            Loadsinput = new TextBox();
            HourInputAB = new TextBox();
            RateInputAB = new TextBox();
            SSSinput = new TextBox();
            Philhlthinput = new TextBox();
            pagibiginput = new TextBox();
            label15 = new Label();
            label16 = new Label();
            BeforeTaxCompute = new Button();
            CaptionBeforetax = new Label();
            CaptionAfterTax = new Label();
            ReturnBTN = new Button();
            label12 = new Label();
            Beforetaxtxt = new TextBox();
            Aftertaxtxt = new TextBox();
            AbsenseLebel = new TextBox();
            Clearbtn = new Button();
            SendToStaff = new Button();
            EmpNameLabel = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            lateinput = new TextBox();
            absencededuct = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            PerpetualName = new Label();
            Payrollname = new Label();
            pictureBox1 = new PictureBox();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            headeryellow = new Panel();
            UserBox = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // FirstHalf
            // 
            FirstHalf.AutoSize = true;
            FirstHalf.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            FirstHalf.Location = new Point(803, 113);
            FirstHalf.Margin = new Padding(6, 5, 6, 5);
            FirstHalf.Name = "FirstHalf";
            FirstHalf.Size = new Size(83, 35);
            FirstHalf.TabIndex = 0;
            FirstHalf.TabStop = true;
            FirstHalf.Text = "1-15";
            FirstHalf.UseVisualStyleBackColor = true;
            FirstHalf.CheckedChanged += FirstHalf_CheckedChanged;
            // 
            // LastHalf
            // 
            LastHalf.AutoSize = true;
            LastHalf.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            LastHalf.Location = new Point(898, 113);
            LastHalf.Margin = new Padding(6, 5, 6, 5);
            LastHalf.Name = "LastHalf";
            LastHalf.Size = new Size(133, 35);
            LastHalf.TabIndex = 1;
            LastHalf.TabStop = true;
            LastHalf.Text = "16-30/31";
            LastHalf.UseVisualStyleBackColor = true;
            LastHalf.CheckedChanged += LastHalf_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(35, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 2;
            label1.Text = "Hour Rate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label2.Location = new Point(87, 75);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 3;
            label2.Text = "Loads:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label4.Location = new Point(63, 116);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 5;
            label4.Text = "Absence:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label5.Location = new Point(256, 9);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 31);
            label5.TabIndex = 6;
            label5.Text = "- Deduction -";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label8.Location = new Point(278, 1);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 31);
            label8.TabIndex = 9;
            label8.Text = "- Taxes -";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label9.Location = new Point(109, 31);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 31);
            label9.TabIndex = 10;
            label9.Text = "SSS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label10.Location = new Point(27, 71);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(150, 31);
            label10.TabIndex = 11;
            label10.Text = "PhilHealth:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label11.Location = new Point(55, 108);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(122, 31);
            label11.TabIndex = 12;
            label11.Text = "Pag-Ibig:";
            // 
            // CalculateSalary
            // 
            CalculateSalary.Location = new Point(64, 124);
            CalculateSalary.Name = "CalculateSalary";
            CalculateSalary.Size = new Size(215, 59);
            CalculateSalary.TabIndex = 13;
            CalculateSalary.Text = "Compute After Deduction";
            CalculateSalary.UseVisualStyleBackColor = true;
            CalculateSalary.Click += CalculateSalary_Click;
            // 
            // HourRateinput
            // 
            HourRateinput.BorderStyle = BorderStyle.FixedSingle;
            HourRateinput.Location = new Point(182, 35);
            HourRateinput.Name = "HourRateinput";
            HourRateinput.Size = new Size(340, 30);
            HourRateinput.TabIndex = 15;
            HourRateinput.TextChanged += HourRateinput_TextChanged;
            // 
            // Loadsinput
            // 
            Loadsinput.BorderStyle = BorderStyle.FixedSingle;
            Loadsinput.Location = new Point(182, 76);
            Loadsinput.Name = "Loadsinput";
            Loadsinput.Size = new Size(340, 30);
            Loadsinput.TabIndex = 16;
            // 
            // HourInputAB
            // 
            HourInputAB.Location = new Point(182, 117);
            HourInputAB.Name = "HourInputAB";
            HourInputAB.PlaceholderText = "Hour";
            HourInputAB.Size = new Size(70, 30);
            HourInputAB.TabIndex = 17;
            // 
            // RateInputAB
            // 
            RateInputAB.Location = new Point(283, 117);
            RateInputAB.Name = "RateInputAB";
            RateInputAB.PlaceholderText = "Rate";
            RateInputAB.Size = new Size(79, 30);
            RateInputAB.TabIndex = 18;
            RateInputAB.TextChanged += RateInputAB_TextChanged;
            // 
            // SSSinput
            // 
            SSSinput.BorderStyle = BorderStyle.FixedSingle;
            SSSinput.Location = new Point(178, 36);
            SSSinput.Name = "SSSinput";
            SSSinput.Size = new Size(340, 30);
            SSSinput.TabIndex = 22;
            SSSinput.TextChanged += SSSinput_TextChanged;
            // 
            // Philhlthinput
            // 
            Philhlthinput.BorderStyle = BorderStyle.FixedSingle;
            Philhlthinput.Location = new Point(178, 72);
            Philhlthinput.Name = "Philhlthinput";
            Philhlthinput.Size = new Size(340, 30);
            Philhlthinput.TabIndex = 23;
            // 
            // pagibiginput
            // 
            pagibiginput.BorderStyle = BorderStyle.FixedSingle;
            pagibiginput.Location = new Point(178, 108);
            pagibiginput.Name = "pagibiginput";
            pagibiginput.Size = new Size(340, 30);
            pagibiginput.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(258, 123);
            label15.Name = "label15";
            label15.Size = new Size(19, 22);
            label15.TabIndex = 27;
            label15.Text = "*";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(369, 123);
            label16.Name = "label16";
            label16.Size = new Size(21, 22);
            label16.TabIndex = 28;
            label16.Text = "=";
            // 
            // BeforeTaxCompute
            // 
            BeforeTaxCompute.Location = new Point(66, 132);
            BeforeTaxCompute.Name = "BeforeTaxCompute";
            BeforeTaxCompute.Size = new Size(210, 29);
            BeforeTaxCompute.TabIndex = 29;
            BeforeTaxCompute.Text = "Compute Before Tax";
            BeforeTaxCompute.UseVisualStyleBackColor = true;
            BeforeTaxCompute.Click += BeforeTaxCompute_Click;
            // 
            // CaptionBeforetax
            // 
            CaptionBeforetax.AutoSize = true;
            CaptionBeforetax.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            CaptionBeforetax.Location = new Point(66, 23);
            CaptionBeforetax.Margin = new Padding(6, 0, 6, 0);
            CaptionBeforetax.Name = "CaptionBeforetax";
            CaptionBeforetax.Size = new Size(203, 31);
            CaptionBeforetax.TabIndex = 32;
            CaptionBeforetax.Text = "Expected Salary";
            // 
            // CaptionAfterTax
            // 
            CaptionAfterTax.AutoSize = true;
            CaptionAfterTax.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            CaptionAfterTax.Location = new Point(34, 31);
            CaptionAfterTax.Margin = new Padding(6, 0, 6, 0);
            CaptionAfterTax.Name = "CaptionAfterTax";
            CaptionAfterTax.Size = new Size(284, 31);
            CaptionAfterTax.TabIndex = 33;
            CaptionAfterTax.Text = "Salary After Deduction";
            // 
            // ReturnBTN
            // 
            ReturnBTN.Location = new Point(22, 624);
            ReturnBTN.Name = "ReturnBTN";
            ReturnBTN.Size = new Size(114, 58);
            ReturnBTN.TabIndex = 35;
            ReturnBTN.Text = "Return";
            ReturnBTN.UseVisualStyleBackColor = true;
            ReturnBTN.Click += ReturnBTN_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label12.Location = new Point(629, 115);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 31);
            label12.TabIndex = 36;
            label12.Text = "FROM/TO:";
            // 
            // Beforetaxtxt
            // 
            Beforetaxtxt.BorderStyle = BorderStyle.FixedSingle;
            Beforetaxtxt.Location = new Point(29, 88);
            Beforetaxtxt.Name = "Beforetaxtxt";
            Beforetaxtxt.PlaceholderText = "    This will change into number";
            Beforetaxtxt.ReadOnly = true;
            Beforetaxtxt.Size = new Size(283, 30);
            Beforetaxtxt.TabIndex = 39;
            // 
            // Aftertaxtxt
            // 
            Aftertaxtxt.BorderStyle = BorderStyle.FixedSingle;
            Aftertaxtxt.Location = new Point(27, 88);
            Aftertaxtxt.Name = "Aftertaxtxt";
            Aftertaxtxt.PlaceholderText = "      This will change into number";
            Aftertaxtxt.ReadOnly = true;
            Aftertaxtxt.Size = new Size(283, 30);
            Aftertaxtxt.TabIndex = 40;
            Aftertaxtxt.TextChanged += Aftertaxtxt_TextChanged;
            // 
            // AbsenseLebel
            // 
            AbsenseLebel.BorderStyle = BorderStyle.FixedSingle;
            AbsenseLebel.Location = new Point(411, 117);
            AbsenseLebel.Name = "AbsenseLebel";
            AbsenseLebel.Size = new Size(111, 30);
            AbsenseLebel.TabIndex = 41;
            AbsenseLebel.TextChanged += textBox1_TextChanged;
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(592, 624);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(106, 59);
            Clearbtn.TabIndex = 43;
            Clearbtn.Text = "Clear All";
            Clearbtn.UseVisualStyleBackColor = true;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // SendToStaff
            // 
            SendToStaff.Location = new Point(1011, 624);
            SendToStaff.Name = "SendToStaff";
            SendToStaff.Size = new Size(133, 59);
            SendToStaff.TabIndex = 44;
            SendToStaff.Text = "Send To Staff";
            SendToStaff.UseVisualStyleBackColor = true;
            SendToStaff.Click += SendToStaff_Click;
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.AutoSize = true;
            EmpNameLabel.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            EmpNameLabel.Location = new Point(3, 114);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(82, 31);
            EmpNameLabel.TabIndex = 47;
            EmpNameLabel.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label3.Location = new Point(274, 1);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 49;
            label3.Text = "- Income -";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AbsenseLebel);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(RateInputAB);
            panel1.Controls.Add(HourInputAB);
            panel1.Controls.Add(Loadsinput);
            panel1.Controls.Add(HourRateinput);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 168);
            panel1.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label6.Location = new Point(65, 43);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 31);
            label6.TabIndex = 7;
            label6.Text = "Absents:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label7.Location = new Point(101, 84);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 31);
            label7.TabIndex = 8;
            label7.Text = "Late:";
            // 
            // lateinput
            // 
            lateinput.BorderStyle = BorderStyle.FixedSingle;
            lateinput.Location = new Point(181, 84);
            lateinput.Name = "lateinput";
            lateinput.Size = new Size(340, 30);
            lateinput.TabIndex = 21;
            // 
            // absencededuct
            // 
            absencededuct.BorderStyle = BorderStyle.FixedSingle;
            absencededuct.Location = new Point(180, 43);
            absencededuct.Name = "absencededuct";
            absencededuct.Size = new Size(340, 30);
            absencededuct.TabIndex = 42;
            absencededuct.TextChanged += absencededuct_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(absencededuct);
            panel2.Controls.Add(lateinput);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(16, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 134);
            panel2.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pagibiginput);
            panel3.Controls.Add(Philhlthinput);
            panel3.Controls.Add(SSSinput);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(16, 467);
            panel3.Name = "panel3";
            panel3.Size = new Size(582, 151);
            panel3.TabIndex = 52;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Beforetaxtxt);
            panel4.Controls.Add(CaptionBeforetax);
            panel4.Controls.Add(BeforeTaxCompute);
            panel4.Location = new Point(705, 162);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 196);
            panel4.TabIndex = 53;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(Aftertaxtxt);
            panel5.Controls.Add(CaptionAfterTax);
            panel5.Controls.Add(CalculateSalary);
            panel5.Location = new Point(707, 399);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 188);
            panel5.TabIndex = 54;
            // 
            // PerpetualName
            // 
            PerpetualName.AutoSize = true;
            PerpetualName.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            PerpetualName.ForeColor = Color.White;
            PerpetualName.Location = new Point(323, 9);
            PerpetualName.Name = "PerpetualName";
            PerpetualName.Size = new Size(588, 45);
            PerpetualName.TabIndex = 0;
            PerpetualName.Text = "Perpetual Help College of Manila\r\n";
            // 
            // Payrollname
            // 
            Payrollname.AutoSize = true;
            Payrollname.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            Payrollname.ForeColor = Color.White;
            Payrollname.Location = new Point(479, 50);
            Payrollname.Name = "Payrollname";
            Payrollname.Size = new Size(261, 38);
            Payrollname.TabIndex = 1;
            Payrollname.Text = "PHCM PayPoint";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(196, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Location = new Point(2, 1);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1164, 104);
            Header1Blue.TabIndex = 45;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(917, -3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 56;
            pictureBox12.TabStop = false;
            // 
            // headeryellow
            // 
            headeryellow.BackColor = Color.Yellow;
            headeryellow.Location = new Point(2, 98);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1166, 10);
            headeryellow.TabIndex = 46;
            // 
            // UserBox
            // 
            UserBox.AutoSize = true;
            UserBox.Font = new Font("Times New Roman", 20F);
            UserBox.Location = new Point(82, 116);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(312, 31);
            UserBox.TabIndex = 55;
            UserBox.Text = "Will change into staff name";
            // 
            // MainFunctionStaff
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1167, 695);
            Controls.Add(UserBox);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(EmpNameLabel);
            Controls.Add(headeryellow);
            Controls.Add(Header1Blue);
            Controls.Add(SendToStaff);
            Controls.Add(Clearbtn);
            Controls.Add(label12);
            Controls.Add(ReturnBTN);
            Controls.Add(LastHalf);
            Controls.Add(FirstHalf);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 15F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "MainFunctionStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Function";
            Load += Main_Function_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton FirstHalf;
        private RadioButton LastHalf;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button CalculateSalary;
        private TextBox HourRateinput;
        private TextBox Loadsinput;
        private TextBox HourInputAB;
        private TextBox RateInputAB;
        private TextBox SSSinput;
        private TextBox Philhlthinput;
        private TextBox pagibiginput;
        private Label label15;
        private Label label16;
        private Button BeforeTaxCompute;
        private Label CaptionBeforetax;
        private Label CaptionAfterTax;
        private Button ReturnBTN;
        private Label label12;
        private TextBox Beforetaxtxt;
        private TextBox Aftertaxtxt;
        private TextBox AbsenseLebel;
        private Button Clearbtn;
        private Button SendToStaff;
        private Label EmpNameLabel;
        private TextBox userlabel;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private TextBox lateinput;
        private TextBox absencededuct;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label PerpetualName;
        private Label Payrollname;
        private PictureBox pictureBox1;
        private Panel Header1Blue;
        private Panel headeryellow;
        private Label UserBox;
        private PictureBox pictureBox12;
    }
}