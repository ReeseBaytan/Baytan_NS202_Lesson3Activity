namespace lesson3
{
    partial class Form1
    {
       
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblDateEnrolled;
        private System.Windows.Forms.DateTimePicker dtpDateEnrolled;
        private System.Windows.Forms.Label lblScholar;
        private System.Windows.Forms.TextBox txtScholar;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cboMode;

        private System.Windows.Forms.DataGridView dgvSchedule;

        private System.Windows.Forms.Label lblTotalCred;
        private System.Windows.Forms.TextBox txtTotalCred;

        private System.Windows.Forms.GroupBox groupFees;
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.Label lblOtherFees;
        private System.Windows.Forms.Label lblComLab;
        private System.Windows.Forms.TextBox txtComLab;
        private System.Windows.Forms.Label lblSAP;
        private System.Windows.Forms.TextBox txtSAP;
        private System.Windows.Forms.Label lblCisco;
        private System.Windows.Forms.TextBox txtCisco;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.Label lblTotalOther;
        private System.Windows.Forms.TextBox txtTotalOther;

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Button btnClearSchedule;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.TextBox txtTotalFees;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtAmountDue;

        
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

       
        private void InitializeComponent()
        {
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblDateEnrolled = new System.Windows.Forms.Label();
            this.dtpDateEnrolled = new System.Windows.Forms.DateTimePicker();
            this.lblScholar = new System.Windows.Forms.Label();
            this.txtScholar = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lblTotalCred = new System.Windows.Forms.Label();
            this.txtTotalCred = new System.Windows.Forms.TextBox();
            this.groupFees = new System.Windows.Forms.GroupBox();
            this.lblTuition = new System.Windows.Forms.Label();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.lblMisc = new System.Windows.Forms.Label();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.lblOtherFees = new System.Windows.Forms.Label();
            this.lblComLab = new System.Windows.Forms.Label();
            this.txtComLab = new System.Windows.Forms.TextBox();
            this.lblSAP = new System.Windows.Forms.Label();
            this.txtSAP = new System.Windows.Forms.TextBox();
            this.lblCisco = new System.Windows.Forms.Label();
            this.txtCisco = new System.Windows.Forms.TextBox();
            this.lblExam = new System.Windows.Forms.Label();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.lblTotalOther = new System.Windows.Forms.Label();
            this.txtTotalOther = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.btnClearSchedule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.txtTotalFees = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.groupFees.SuspendLayout();
            this.SuspendLayout();
           
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(12, 12);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
          
            this.txtStudentName.Location = new System.Drawing.Point(110, 10);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(250, 20);
            this.txtStudentName.TabIndex = 1;
        
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(380, 12);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(67, 13);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student No.:";
            
            this.txtStudentNo.Location = new System.Drawing.Point(450, 10);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(140, 20);
            this.txtStudentNo.TabIndex = 3;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(12, 40);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(49, 13);
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program:";
            // 
            // cboProgram
            // 
            this.cboProgram.Items.AddRange(new object[] {
            "BS Computer Science",
            "BS Information Technology",
            "BS Information Systems"});
            this.cboProgram.Location = new System.Drawing.Point(110, 37);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(250, 21);
            this.cboProgram.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(380, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year Level:";
            // 
            // cboYear
            // 
            this.cboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboYear.Location = new System.Drawing.Point(450, 37);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(140, 21);
            this.cboYear.TabIndex = 7;
            // 
            // lblDateEnrolled
            // 
            this.lblDateEnrolled.AutoSize = true;
            this.lblDateEnrolled.Location = new System.Drawing.Point(12, 70);
            this.lblDateEnrolled.Name = "lblDateEnrolled";
            this.lblDateEnrolled.Size = new System.Drawing.Size(74, 13);
            this.lblDateEnrolled.TabIndex = 8;
            this.lblDateEnrolled.Text = "Date Enrolled:";
            // 
            // dtpDateEnrolled
            // 
            this.dtpDateEnrolled.Location = new System.Drawing.Point(110, 67);
            this.dtpDateEnrolled.Name = "dtpDateEnrolled";
            this.dtpDateEnrolled.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEnrolled.TabIndex = 9;
            // 
            // lblScholar
            // 
            this.lblScholar.AutoSize = true;
            this.lblScholar.Location = new System.Drawing.Point(380, 70);
            this.lblScholar.Name = "lblScholar";
            this.lblScholar.Size = new System.Drawing.Size(46, 13);
            this.lblScholar.TabIndex = 10;
            this.lblScholar.Text = "Scholar:";
            // 
            // txtScholar
            // 
            this.txtScholar.Location = new System.Drawing.Point(450, 67);
            this.txtScholar.Name = "txtScholar";
            this.txtScholar.Size = new System.Drawing.Size(140, 20);
            this.txtScholar.TabIndex = 11;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(620, 12);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "Mode:";
            // 
            // cboMode
            // 
            this.cboMode.Items.AddRange(new object[] {
            "Cash",
            "Installment"});
            this.cboMode.Location = new System.Drawing.Point(660, 9);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(150, 21);
            this.cboMode.TabIndex = 13;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvSchedule.Location = new System.Drawing.Point(12, 110);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(960, 250);
            this.dgvSchedule.TabIndex = 14;
            this.dgvSchedule.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellEndEdit);
            // 
            // lblTotalCred
            // 
            this.lblTotalCred.AutoSize = true;
            this.lblTotalCred.Location = new System.Drawing.Point(12, 370);
            this.lblTotalCred.Name = "lblTotalCred";
            this.lblTotalCred.Size = new System.Drawing.Size(89, 13);
            this.lblTotalCred.TabIndex = 15;
            this.lblTotalCred.Text = "Total Cred. Units:";
            // 
            // txtTotalCred
            // 
            this.txtTotalCred.Location = new System.Drawing.Point(140, 367);
            this.txtTotalCred.Name = "txtTotalCred";
            this.txtTotalCred.ReadOnly = true;
            this.txtTotalCred.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCred.TabIndex = 16;
            // 
            // groupFees
            // 
            this.groupFees.Controls.Add(this.lblTuition);
            this.groupFees.Controls.Add(this.txtTuition);
            this.groupFees.Controls.Add(this.lblMisc);
            this.groupFees.Controls.Add(this.txtMisc);
            this.groupFees.Controls.Add(this.lblOtherFees);
            this.groupFees.Controls.Add(this.lblComLab);
            this.groupFees.Controls.Add(this.txtComLab);
            this.groupFees.Controls.Add(this.lblSAP);
            this.groupFees.Controls.Add(this.txtSAP);
            this.groupFees.Controls.Add(this.lblCisco);
            this.groupFees.Controls.Add(this.txtCisco);
            this.groupFees.Controls.Add(this.lblExam);
            this.groupFees.Controls.Add(this.txtExam);
            this.groupFees.Controls.Add(this.lblTotalOther);
            this.groupFees.Controls.Add(this.txtTotalOther);
            this.groupFees.Location = new System.Drawing.Point(12, 400);
            this.groupFees.Name = "groupFees";
            this.groupFees.Size = new System.Drawing.Size(477, 378);
            this.groupFees.TabIndex = 17;
            this.groupFees.TabStop = false;
            this.groupFees.Text = "Fees";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(10, 20);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(90, 13);
            this.lblTuition.TabIndex = 0;
            this.lblTuition.Text = "Total Tuition Fee:";
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(140, 17);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.ReadOnly = true;
            this.txtTuition.Size = new System.Drawing.Size(120, 20);
            this.txtTuition.TabIndex = 1;
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(10, 50);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(103, 13);
            this.lblMisc.TabIndex = 2;
            this.lblMisc.Text = "Miscellaneous Fees:";
            // 
            // txtMisc
            // 
            this.txtMisc.Location = new System.Drawing.Point(140, 47);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(120, 20);
            this.txtMisc.TabIndex = 3;
            this.txtMisc.Text = "0";
            // 
            // lblOtherFees
            // 
            this.lblOtherFees.AutoSize = true;
            this.lblOtherFees.Location = new System.Drawing.Point(10, 80);
            this.lblOtherFees.Name = "lblOtherFees";
            this.lblOtherFees.Size = new System.Drawing.Size(98, 13);
            this.lblOtherFees.TabIndex = 4;
            this.lblOtherFees.Text = "Other School Fees:";
            // 
            // lblComLab
            // 
            this.lblComLab.AutoSize = true;
            this.lblComLab.Location = new System.Drawing.Point(10, 105);
            this.lblComLab.Name = "lblComLab";
            this.lblComLab.Size = new System.Drawing.Size(76, 13);
            this.lblComLab.TabIndex = 5;
            this.lblComLab.Text = "Com. Lab Fee:";
            // 
            // txtComLab
            // 
            this.txtComLab.Location = new System.Drawing.Point(140, 102);
            this.txtComLab.Name = "txtComLab";
            this.txtComLab.Size = new System.Drawing.Size(120, 20);
            this.txtComLab.TabIndex = 6;
            this.txtComLab.Text = "0";
            // 
            // lblSAP
            // 
            this.lblSAP.AutoSize = true;
            this.lblSAP.Location = new System.Drawing.Point(10, 135);
            this.lblSAP.Name = "lblSAP";
            this.lblSAP.Size = new System.Drawing.Size(52, 13);
            this.lblSAP.TabIndex = 7;
            this.lblSAP.Text = "SAP Fee:";
            // 
            // txtSAP
            // 
            this.txtSAP.Location = new System.Drawing.Point(140, 132);
            this.txtSAP.Name = "txtSAP";
            this.txtSAP.Size = new System.Drawing.Size(120, 20);
            this.txtSAP.TabIndex = 8;
            this.txtSAP.Text = "0";
            // 
            // lblCisco
            // 
            this.lblCisco.AutoSize = true;
            this.lblCisco.Location = new System.Drawing.Point(10, 165);
            this.lblCisco.Name = "lblCisco";
            this.lblCisco.Size = new System.Drawing.Size(84, 13);
            this.lblCisco.TabIndex = 9;
            this.lblCisco.Text = "CISCO Lab Fee:";
            // 
            // txtCisco
            // 
            this.txtCisco.Location = new System.Drawing.Point(140, 162);
            this.txtCisco.Name = "txtCisco";
            this.txtCisco.Size = new System.Drawing.Size(120, 20);
            this.txtCisco.TabIndex = 10;
            this.txtCisco.Text = "0";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(10, 195);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(96, 13);
            this.lblExam.TabIndex = 11;
            this.lblExam.Text = "Exam Booklet Fee:";
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(140, 192);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(120, 20);
            this.txtExam.TabIndex = 12;
            this.txtExam.Text = "0";
            // 
            // lblTotalOther
            // 
            this.lblTotalOther.AutoSize = true;
            this.lblTotalOther.Location = new System.Drawing.Point(10, 235);
            this.lblTotalOther.Name = "lblTotalOther";
            this.lblTotalOther.Size = new System.Drawing.Size(84, 13);
            this.lblTotalOther.TabIndex = 13;
            this.lblTotalOther.Text = "Total Other Fee:";
            // 
            // txtTotalOther
            // 
            this.txtTotalOther.Location = new System.Drawing.Point(140, 232);
            this.txtTotalOther.Name = "txtTotalOther";
            this.txtTotalOther.ReadOnly = true;
            this.txtTotalOther.Size = new System.Drawing.Size(120, 20);
            this.txtTotalOther.TabIndex = 14;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(510, 520);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(140, 35);
            this.btnCompute.TabIndex = 18;
            this.btnCompute.Text = "COMPUTE FEES";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Location = new System.Drawing.Point(660, 520);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(160, 35);
            this.btnClearStudent.TabIndex = 19;
            this.btnClearStudent.Text = "CLEAR STUDENT INFORMATION";
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // btnClearSchedule
            // 
            this.btnClearSchedule.Location = new System.Drawing.Point(510, 560);
            this.btnClearSchedule.Name = "btnClearSchedule";
            this.btnClearSchedule.Size = new System.Drawing.Size(140, 35);
            this.btnClearSchedule.TabIndex = 20;
            this.btnClearSchedule.Text = "CLEAR SCHEDULE OF COURSES";
            this.btnClearSchedule.Click += new System.EventHandler(this.btnClearSchedule_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(660, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 35);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(510, 400);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(148, 13);
            this.lblTotalFees.TabIndex = 22;
            this.lblTotalFees.Text = "TOTAL TUITION AND FEES:";
            // 
            // txtTotalFees
            // 
            this.txtTotalFees.Location = new System.Drawing.Point(700, 397);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.ReadOnly = true;
            this.txtTotalFees.Size = new System.Drawing.Size(160, 20);
            this.txtTotalFees.TabIndex = 23;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(510, 440);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblDiscount.TabIndex = 24;
            this.lblDiscount.Text = "Discount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(700, 437);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(160, 20);
            this.txtDiscount.TabIndex = 25;
            this.txtDiscount.Text = "0";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(510, 480);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(83, 13);
            this.lblAmountDue.TabIndex = 26;
            this.lblAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(700, 477);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(160, 20);
            this.txtAmountDue.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn1.Name = "CourseCode";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Section";
            this.dataGridViewTextBoxColumn2.Name = "Section";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "Description";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Lec. Units";
            this.dataGridViewTextBoxColumn4.Name = "LecUnits";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Lab Units";
            this.dataGridViewTextBoxColumn5.Name = "LabUnits";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cred. Units";
            this.dataGridViewTextBoxColumn6.Name = "CredUnits";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Time";
            this.dataGridViewTextBoxColumn7.Name = "Time";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Day";
            this.dataGridViewTextBoxColumn8.Name = "Day";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Room";
            this.dataGridViewTextBoxColumn9.Name = "Room";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1086, 762);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblDateEnrolled);
            this.Controls.Add(this.dtpDateEnrolled);
            this.Controls.Add(this.lblScholar);
            this.Controls.Add(this.txtScholar);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.lblTotalCred);
            this.Controls.Add(this.txtTotalCred);
            this.Controls.Add(this.groupFees);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnClearStudent);
            this.Controls.Add(this.btnClearSchedule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.txtTotalFees);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtAmountDue);
            this.Name = "Form1";
            this.Text = "Student Enrollment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.groupFees.ResumeLayout(false);
            this.groupFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

