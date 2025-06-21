namespace Payroll_System
{
    partial class SendToStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToStaff));
            NameLabel = new Label();
            label2 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            TardinessBox = new TextBox();
            AbsentsBox = new TextBox();
            BasicPayBox = new TextBox();
            label15 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            PagIbigBox = new TextBox();
            PhilHealthBox = new TextBox();
            SSSBox = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label11 = new Label();
            label12 = new Label();
            ButtonForEmail = new Button();
            label29 = new Label();
            label30 = new Label();
            label1 = new Label();
            FromTo = new TextBox();
            StaffPosition1 = new TextBox();
            EmailINFO1 = new TextBox();
            NameofStaffReceipt1 = new TextBox();
            GrossPaySummary = new TextBox();
            NetPaySummary = new TextBox();
            label3 = new Label();
            DeductSumamary = new TextBox();
            label27 = new Label();
            label9 = new Label();
            Date = new Label();
            printbutton = new Button();
            returnbtn = new Button();
            printReceipt = new System.Drawing.Printing.PrintDocument();
            printPreviewDialogCarl = new PrintPreviewDialog();
            pictureBox1 = new PictureBox();
            Header1Blue = new Panel();
            pictureBox12 = new PictureBox();
            Payrollname = new Label();
            PerpetualName = new Label();
            headeryellow = new Panel();
            label5 = new Label();
            label6 = new Label();
            HandledTxt = new TextBox();
            RecievedTxt = new TextBox();
            Grosspanel = new Panel();
            DeductPanel = new Panel();
            NetPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Header1Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            Grosspanel.SuspendLayout();
            DeductPanel.SuspendLayout();
            NetPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Times New Roman", 20F);
            NameLabel.Location = new Point(3, 177);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(83, 31);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F);
            label2.Location = new Point(390, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 5;
            label2.Text = "Staff Positon: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20F);
            label4.Location = new Point(115, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 49;
            label4.Text = "- Income -";
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 20F);
            label8.Location = new Point(4, 64);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 31);
            label8.TabIndex = 53;
            label8.Text = "Basic Pay:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TardinessBox);
            panel1.Controls.Add(AbsentsBox);
            panel1.Controls.Add(BasicPayBox);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(58, 211);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 278);
            panel1.TabIndex = 54;
            // 
            // TardinessBox
            // 
            TardinessBox.BackColor = Color.WhiteSmoke;
            TardinessBox.BorderStyle = BorderStyle.None;
            TardinessBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            TardinessBox.HideSelection = false;
            TardinessBox.Location = new Point(158, 196);
            TardinessBox.Margin = new Padding(4, 3, 4, 3);
            TardinessBox.Name = "TardinessBox";
            TardinessBox.ReadOnly = true;
            TardinessBox.Size = new Size(243, 31);
            TardinessBox.TabIndex = 63;
            TardinessBox.TextAlign = HorizontalAlignment.Right;
            // 
            // AbsentsBox
            // 
            AbsentsBox.BackColor = Color.WhiteSmoke;
            AbsentsBox.BorderStyle = BorderStyle.None;
            AbsentsBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            AbsentsBox.HideSelection = false;
            AbsentsBox.Location = new Point(158, 133);
            AbsentsBox.Margin = new Padding(4, 3, 4, 3);
            AbsentsBox.Name = "AbsentsBox";
            AbsentsBox.ReadOnly = true;
            AbsentsBox.Size = new Size(243, 31);
            AbsentsBox.TabIndex = 62;
            AbsentsBox.TextAlign = HorizontalAlignment.Right;
            AbsentsBox.TextChanged += AbsentsBox_TextChanged;
            // 
            // BasicPayBox
            // 
            BasicPayBox.BackColor = Color.WhiteSmoke;
            BasicPayBox.BorderStyle = BorderStyle.None;
            BasicPayBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            BasicPayBox.HideSelection = false;
            BasicPayBox.Location = new Point(158, 64);
            BasicPayBox.Margin = new Padding(4, 3, 4, 3);
            BasicPayBox.Name = "BasicPayBox";
            BasicPayBox.ReadOnly = true;
            BasicPayBox.Size = new Size(243, 31);
            BasicPayBox.TabIndex = 61;
            BasicPayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 20F);
            label15.Location = new Point(8, 196);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(122, 31);
            label15.TabIndex = 55;
            label15.Text = "Tardiness:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 20F);
            label14.Location = new Point(26, 133);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(107, 31);
            label14.TabIndex = 54;
            label14.Text = "Absents:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PagIbigBox);
            panel3.Controls.Add(PhilHealthBox);
            panel3.Controls.Add(SSSBox);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(843, 211);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 278);
            panel3.TabIndex = 55;
            // 
            // PagIbigBox
            // 
            PagIbigBox.BackColor = Color.WhiteSmoke;
            PagIbigBox.BorderStyle = BorderStyle.None;
            PagIbigBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            PagIbigBox.HideSelection = false;
            PagIbigBox.Location = new Point(175, 196);
            PagIbigBox.Margin = new Padding(4, 3, 4, 3);
            PagIbigBox.Name = "PagIbigBox";
            PagIbigBox.ReadOnly = true;
            PagIbigBox.Size = new Size(243, 31);
            PagIbigBox.TabIndex = 67;
            PagIbigBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PhilHealthBox
            // 
            PhilHealthBox.BackColor = Color.WhiteSmoke;
            PhilHealthBox.BorderStyle = BorderStyle.None;
            PhilHealthBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            PhilHealthBox.HideSelection = false;
            PhilHealthBox.Location = new Point(175, 130);
            PhilHealthBox.Margin = new Padding(4, 3, 4, 3);
            PhilHealthBox.Name = "PhilHealthBox";
            PhilHealthBox.ReadOnly = true;
            PhilHealthBox.Size = new Size(243, 31);
            PhilHealthBox.TabIndex = 66;
            PhilHealthBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SSSBox
            // 
            SSSBox.BackColor = Color.WhiteSmoke;
            SSSBox.BorderStyle = BorderStyle.None;
            SSSBox.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            SSSBox.HideSelection = false;
            SSSBox.Location = new Point(175, 64);
            SSSBox.Margin = new Padding(4, 3, 4, 3);
            SSSBox.Name = "SSSBox";
            SSSBox.ReadOnly = true;
            SSSBox.Size = new Size(243, 31);
            SSSBox.TabIndex = 65;
            SSSBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 20F);
            label18.Location = new Point(40, 196);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(109, 31);
            label18.TabIndex = 55;
            label18.Text = "Pag-Ibig:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 20F);
            label17.Location = new Point(7, 130);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(144, 31);
            label17.TabIndex = 54;
            label17.Text = "PhilHealth: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20F);
            label11.Location = new Point(91, 64);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 31);
            label11.TabIndex = 53;
            label11.Text = "SSS:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20F);
            label12.Location = new Point(144, 20);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 31);
            label12.TabIndex = 49;
            label12.Text = "-Deduction -";
            // 
            // ButtonForEmail
            // 
            ButtonForEmail.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            ButtonForEmail.Location = new Point(689, 677);
            ButtonForEmail.Margin = new Padding(4, 3, 4, 3);
            ButtonForEmail.Name = "ButtonForEmail";
            ButtonForEmail.Size = new Size(187, 51);
            ButtonForEmail.TabIndex = 58;
            ButtonForEmail.Text = "Email To Staff";
            ButtonForEmail.UseVisualStyleBackColor = true;
            ButtonForEmail.Click += button1_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Times New Roman", 20F);
            label29.Location = new Point(71, 5);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(128, 31);
            label29.TabIndex = 62;
            label29.Text = "Deduction";
            label29.Click += label29_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Times New Roman", 20F);
            label30.Location = new Point(57, 5);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(163, 31);
            label30.TabIndex = 63;
            label30.Text = "Net Pay Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F);
            label1.Location = new Point(862, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 66;
            label1.Text = "Staff Email:";
            // 
            // FromTo
            // 
            FromTo.BackColor = SystemColors.ActiveCaption;
            FromTo.BorderStyle = BorderStyle.None;
            FromTo.Font = new Font("Times New Roman", 20F);
            FromTo.Location = new Point(162, 129);
            FromTo.Margin = new Padding(4, 3, 4, 3);
            FromTo.Name = "FromTo";
            FromTo.Size = new Size(196, 31);
            FromTo.TabIndex = 67;
            FromTo.TextChanged += textBox4_TextChanged;
            // 
            // StaffPosition1
            // 
            StaffPosition1.BackColor = SystemColors.ActiveCaption;
            StaffPosition1.BorderStyle = BorderStyle.None;
            StaffPosition1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            StaffPosition1.Location = new Point(552, 177);
            StaffPosition1.Margin = new Padding(4, 3, 4, 3);
            StaffPosition1.Name = "StaffPosition1";
            StaffPosition1.ReadOnly = true;
            StaffPosition1.Size = new Size(314, 31);
            StaffPosition1.TabIndex = 69;
            StaffPosition1.TextChanged += StaffPosition1_TextChanged;
            // 
            // EmailINFO1
            // 
            EmailINFO1.BackColor = SystemColors.ActiveCaption;
            EmailINFO1.BorderStyle = BorderStyle.None;
            EmailINFO1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            EmailINFO1.Location = new Point(1012, 178);
            EmailINFO1.Margin = new Padding(4, 3, 4, 3);
            EmailINFO1.Name = "EmailINFO1";
            EmailINFO1.ReadOnly = true;
            EmailINFO1.Size = new Size(355, 31);
            EmailINFO1.TabIndex = 70;
            // 
            // NameofStaffReceipt1
            // 
            NameofStaffReceipt1.BackColor = SystemColors.ActiveCaption;
            NameofStaffReceipt1.BorderStyle = BorderStyle.None;
            NameofStaffReceipt1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            NameofStaffReceipt1.Location = new Point(85, 178);
            NameofStaffReceipt1.Margin = new Padding(4, 3, 4, 3);
            NameofStaffReceipt1.Name = "NameofStaffReceipt1";
            NameofStaffReceipt1.ReadOnly = true;
            NameofStaffReceipt1.Size = new Size(311, 31);
            NameofStaffReceipt1.TabIndex = 71;
            NameofStaffReceipt1.TextChanged += NameofStaffReceipt1_TextChanged;
            // 
            // GrossPaySummary
            // 
            GrossPaySummary.BackColor = Color.WhiteSmoke;
            GrossPaySummary.BorderStyle = BorderStyle.None;
            GrossPaySummary.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            GrossPaySummary.HideSelection = false;
            GrossPaySummary.Location = new Point(54, 37);
            GrossPaySummary.Margin = new Padding(4, 3, 4, 3);
            GrossPaySummary.Name = "GrossPaySummary";
            GrossPaySummary.ReadOnly = true;
            GrossPaySummary.Size = new Size(175, 31);
            GrossPaySummary.TabIndex = 68;
            GrossPaySummary.TextAlign = HorizontalAlignment.Center;
            // 
            // NetPaySummary
            // 
            NetPaySummary.BackColor = Color.WhiteSmoke;
            NetPaySummary.BorderStyle = BorderStyle.None;
            NetPaySummary.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            NetPaySummary.HideSelection = false;
            NetPaySummary.Location = new Point(31, 37);
            NetPaySummary.Margin = new Padding(4, 3, 4, 3);
            NetPaySummary.Name = "NetPaySummary";
            NetPaySummary.ReadOnly = true;
            NetPaySummary.Size = new Size(224, 31);
            NetPaySummary.TabIndex = 73;
            NetPaySummary.TextAlign = HorizontalAlignment.Center;
            NetPaySummary.TextChanged += NetPaySummary_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            label3.Location = new Point(594, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 38);
            label3.TabIndex = 77;
            label3.Text = "P a y s l i p";
            // 
            // DeductSumamary
            // 
            DeductSumamary.BackColor = Color.WhiteSmoke;
            DeductSumamary.BorderStyle = BorderStyle.None;
            DeductSumamary.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            DeductSumamary.HideSelection = false;
            DeductSumamary.Location = new Point(52, 39);
            DeductSumamary.Margin = new Padding(4, 3, 4, 3);
            DeductSumamary.Name = "DeductSumamary";
            DeductSumamary.ReadOnly = true;
            DeductSumamary.Size = new Size(168, 31);
            DeductSumamary.TabIndex = 80;
            DeductSumamary.TextAlign = HorizontalAlignment.Center;
            DeductSumamary.TextChanged += DeductSumamary_TextChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Times New Roman", 20F);
            label27.Location = new Point(77, 3);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(123, 31);
            label27.TabIndex = 60;
            label27.Text = "Gross Pay";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 20F);
            label9.Location = new Point(48, 130);
            label9.Name = "label9";
            label9.Size = new Size(114, 31);
            label9.TabIndex = 81;
            label9.Text = "From/To:";
            label9.Click += label9_Click;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 20F);
            Date.Location = new Point(878, 124);
            Date.Name = "Date";
            Date.Size = new Size(65, 31);
            Date.TabIndex = 82;
            Date.Text = "Date";
            // 
            // printbutton
            // 
            printbutton.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            printbutton.Location = new Point(433, 677);
            printbutton.Name = "printbutton";
            printbutton.Size = new Size(184, 51);
            printbutton.TabIndex = 84;
            printbutton.Text = "Print Receipt";
            printbutton.UseVisualStyleBackColor = true;
            printbutton.Click += printbutton_Click;
            // 
            // returnbtn
            // 
            returnbtn.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            returnbtn.Location = new Point(1226, 677);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(136, 51);
            returnbtn.TabIndex = 85;
            returnbtn.Text = "Return";
            returnbtn.UseVisualStyleBackColor = true;
            returnbtn.Click += returnbtn_Click;
            // 
            // printReceipt
            // 
            printReceipt.DocumentName = "PrintReceiptNaks";
            // 
            // printPreviewDialogCarl
            // 
            printPreviewDialogCarl.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogCarl.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogCarl.ClientSize = new Size(400, 300);
            printPreviewDialogCarl.Document = printReceipt;
            printPreviewDialogCarl.Enabled = true;
            printPreviewDialogCarl.Icon = (Icon)resources.GetObject("printPreviewDialogCarl.Icon");
            printPreviewDialogCarl.Name = "printPreviewDialogCarl";
            printPreviewDialogCarl.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Header1Blue
            // 
            Header1Blue.BackColor = Color.DodgerBlue;
            Header1Blue.Controls.Add(pictureBox12);
            Header1Blue.Controls.Add(Payrollname);
            Header1Blue.Controls.Add(PerpetualName);
            Header1Blue.Controls.Add(pictureBox1);
            Header1Blue.Location = new Point(1, 1);
            Header1Blue.Name = "Header1Blue";
            Header1Blue.Size = new Size(1361, 111);
            Header1Blue.TabIndex = 86;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(1044, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 104);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 95;
            pictureBox12.TabStop = false;
            // 
            // Payrollname
            // 
            Payrollname.AutoSize = true;
            Payrollname.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            Payrollname.ForeColor = Color.White;
            Payrollname.Location = new Point(557, 65);
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
            PerpetualName.Location = new Point(399, 8);
            PerpetualName.Name = "PerpetualName";
            PerpetualName.Size = new Size(588, 45);
            PerpetualName.TabIndex = 0;
            PerpetualName.Text = "Perpetual Help College of Manila\r\n";
            // 
            // headeryellow
            // 
            headeryellow.BackColor = Color.Yellow;
            headeryellow.Location = new Point(3, 111);
            headeryellow.Name = "headeryellow";
            headeryellow.Size = new Size(1363, 10);
            headeryellow.TabIndex = 87;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20F);
            label5.Location = new Point(157, 592);
            label5.Name = "label5";
            label5.Size = new Size(151, 31);
            label5.TabIndex = 88;
            label5.Text = "Handled By:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20F);
            label6.Location = new Point(1069, 592);
            label6.Name = "label6";
            label6.Size = new Size(157, 31);
            label6.TabIndex = 89;
            label6.Text = "Recieved By:";
            // 
            // HandledTxt
            // 
            HandledTxt.BackColor = SystemColors.ActiveCaption;
            HandledTxt.BorderStyle = BorderStyle.None;
            HandledTxt.Font = new Font("Times New Roman", 20F);
            HandledTxt.Location = new Point(38, 626);
            HandledTxt.Margin = new Padding(4, 3, 4, 3);
            HandledTxt.Name = "HandledTxt";
            HandledTxt.Size = new Size(398, 31);
            HandledTxt.TabIndex = 90;
            HandledTxt.TextAlign = HorizontalAlignment.Center;
            HandledTxt.TextChanged += HandledTxt_TextChanged;
            // 
            // RecievedTxt
            // 
            RecievedTxt.BackColor = SystemColors.ActiveCaption;
            RecievedTxt.BorderStyle = BorderStyle.None;
            RecievedTxt.Font = new Font("Times New Roman", 20F);
            RecievedTxt.Location = new Point(949, 627);
            RecievedTxt.Margin = new Padding(4, 3, 4, 3);
            RecievedTxt.Name = "RecievedTxt";
            RecievedTxt.Size = new Size(374, 31);
            RecievedTxt.TabIndex = 91;
            RecievedTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // Grosspanel
            // 
            Grosspanel.BackColor = Color.WhiteSmoke;
            Grosspanel.BorderStyle = BorderStyle.FixedSingle;
            Grosspanel.Controls.Add(GrossPaySummary);
            Grosspanel.Controls.Add(label27);
            Grosspanel.Location = new Point(112, 499);
            Grosspanel.Name = "Grosspanel";
            Grosspanel.Size = new Size(271, 79);
            Grosspanel.TabIndex = 92;
            // 
            // DeductPanel
            // 
            DeductPanel.BackColor = Color.WhiteSmoke;
            DeductPanel.BorderStyle = BorderStyle.FixedSingle;
            DeductPanel.Controls.Add(DeductSumamary);
            DeductPanel.Controls.Add(label29);
            DeductPanel.Location = new Point(518, 499);
            DeductPanel.Name = "DeductPanel";
            DeductPanel.Size = new Size(271, 79);
            DeductPanel.TabIndex = 93;
            // 
            // NetPanel
            // 
            NetPanel.BackColor = Color.WhiteSmoke;
            NetPanel.BorderStyle = BorderStyle.FixedSingle;
            NetPanel.Controls.Add(NetPaySummary);
            NetPanel.Controls.Add(label30);
            NetPanel.Location = new Point(987, 499);
            NetPanel.Name = "NetPanel";
            NetPanel.Size = new Size(271, 79);
            NetPanel.TabIndex = 94;
            // 
            // SendToStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1362, 729);
            Controls.Add(StaffPosition1);
            Controls.Add(NetPanel);
            Controls.Add(DeductPanel);
            Controls.Add(Grosspanel);
            Controls.Add(RecievedTxt);
            Controls.Add(HandledTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Header1Blue);
            Controls.Add(headeryellow);
            Controls.Add(returnbtn);
            Controls.Add(printbutton);
            Controls.Add(Date);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(NameofStaffReceipt1);
            Controls.Add(EmailINFO1);
            Controls.Add(FromTo);
            Controls.Add(label1);
            Controls.Add(ButtonForEmail);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(NameLabel);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 8.25F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SendToStaff";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payslip";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Header1Blue.ResumeLayout(false);
            Header1Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            Grosspanel.ResumeLayout(false);
            Grosspanel.PerformLayout();
            DeductPanel.ResumeLayout(false);
            DeductPanel.PerformLayout();
            NetPanel.ResumeLayout(false);
            NetPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FromWhat;
        private Label NameLabel;
        private Label NameofStaffReceipt;
        private Label label2;
        private Label StaffPosition;
        private Label label4;
        private Label Date;
        private Label label6;
        private Label label8;
        private Panel panel1;
        private Label label15;
        private Label label14;
        private Panel panel3;
        private Label label11;
        private Label label12;
        private Button ButtonForEmail;
        private Label label17;
        private Label label18;
        private Label label29;
        private Label label30;
        private Label label1;
        private Label EmailINFO;
        private TextBox FromTo;
        private TextBox StaffPosition1;
        private TextBox EmailINFO1;
        private TextBox NameofStaffReceipt1;
        private TextBox BasicPayBox;
        private TextBox TardinessBox;
        private TextBox AbsentsBox;
        private TextBox PagIbigBox;
        private TextBox PhilHealthBox;
        private TextBox SSSBox;
        private TextBox GrossPaySummary;
        private TextBox textBox10;
        private TextBox NetPaySummary;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label3;
        private TextBox DeductSumamary;
        private Label label27;
        private Label label9;
        private Button printbutton;
        private Button returnbtn;
        private System.Drawing.Printing.PrintDocument printReceipt;
        private PrintPreviewDialog printPreviewDialogCarl;
        private PictureBox pictureBox1;
        private Panel Header1Blue;
        private Label Payrollname;
        private Label PerpetualName;
        private Panel headeryellow;
        private Label label5;
        private TextBox HandledTxt;
        private TextBox RecievedTxt;
        private Panel Grosspanel;
        private Panel DeductPanel;
        private Panel NetPanel;
        private PictureBox pictureBox12;
    }
}