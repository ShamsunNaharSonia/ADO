namespace AdmissionManagementSystem
{
    partial class frmAdmission
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
            this.components = new System.ComponentModel.Container();
            this.lblPurchaseId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dtpAdmitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAdmitDate = new System.Windows.Forms.Label();
            this.lblAdmitFee = new System.Windows.Forms.Label();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdmitFee = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblAdmission = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddSemester = new System.Windows.Forms.Button();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgvAdmission = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchaseId
            // 
            this.lblPurchaseId.AutoSize = true;
            this.lblPurchaseId.Location = new System.Drawing.Point(119, -6);
            this.lblPurchaseId.Name = "lblPurchaseId";
            this.lblPurchaseId.Size = new System.Drawing.Size(0, 13);
            this.lblPurchaseId.TabIndex = 20;
            this.lblPurchaseId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(181, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(88, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 34);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(4, 450);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 34);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudentId);
            this.groupBox1.Controls.Add(this.radioBtnFemale);
            this.groupBox1.Controls.Add(this.radioBtnMale);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pbStudent);
            this.groupBox1.Controls.Add(this.dtpAdmitDate);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblAdmitDate);
            this.groupBox1.Controls.Add(this.lblAdmitFee);
            this.groupBox1.Controls.Add(this.lblSemesterName);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdmitFee);
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.lblFatherName);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.txtRegNo);
            this.groupBox1.Controls.Add(this.lblRegistrationNo);
            this.groupBox1.Location = new System.Drawing.Point(4, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 410);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(4, 144);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(69, 17);
            this.lblStudentId.TabIndex = 9;
            this.lblStudentId.Text = "StudentId";
            this.lblStudentId.Visible = false;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(201, 116);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 8;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(147, 116);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 8;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(117, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "  Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(117, 347);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dtpAdmitDate
            // 
            this.dtpAdmitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmitDate.Location = new System.Drawing.Point(124, 254);
            this.dtpAdmitDate.Name = "dtpAdmitDate";
            this.dtpAdmitDate.Size = new System.Drawing.Size(141, 20);
            this.dtpAdmitDate.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(117, 90);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(151, 20);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(123, 199);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(141, 21);
            this.cmbSemester.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(4, 116);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender ";
            // 
            // lblAdmitDate
            // 
            this.lblAdmitDate.AutoSize = true;
            this.lblAdmitDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmitDate.Location = new System.Drawing.Point(2, 258);
            this.lblAdmitDate.Name = "lblAdmitDate";
            this.lblAdmitDate.Size = new System.Drawing.Size(83, 17);
            this.lblAdmitDate.TabIndex = 1;
            this.lblAdmitDate.Text = "Admit Date";
            // 
            // lblAdmitFee
            // 
            this.lblAdmitFee.AutoSize = true;
            this.lblAdmitFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmitFee.Location = new System.Drawing.Point(0, 233);
            this.lblAdmitFee.Name = "lblAdmitFee";
            this.lblAdmitFee.Size = new System.Drawing.Size(77, 17);
            this.lblAdmitFee.TabIndex = 1;
            this.lblAdmitFee.Text = "Admit Fee ";
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.AutoSize = true;
            this.lblSemesterName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterName.Location = new System.Drawing.Point(-2, 203);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(109, 17);
            this.lblSemesterName.TabIndex = 1;
            this.lblSemesterName.Text = "Semester Name";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(123, 166);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(142, 21);
            this.cmbDepartment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department Name ";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(123, 282);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(142, 20);
            this.txtContactNo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact No ";
            // 
            // txtAdmitFee
            // 
            this.txtAdmitFee.Location = new System.Drawing.Point(124, 228);
            this.txtAdmitFee.Name = "txtAdmitFee";
            this.txtAdmitFee.Size = new System.Drawing.Size(141, 20);
            this.txtAdmitFee.TabIndex = 2;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(115, 64);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(150, 20);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(117, 38);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(148, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(0, 64);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(104, 17);
            this.lblFatherName.TabIndex = 1;
            this.lblFatherName.Text = "Father\'s Name ";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(4, 93);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(-1, 38);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(105, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name ";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(117, 12);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(148, 20);
            this.txtRegNo.TabIndex = 2;
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationNo.Location = new System.Drawing.Point(0, 15);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(111, 17);
            this.lblRegistrationNo.TabIndex = 1;
            this.lblRegistrationNo.Text = "Registration No ";
            // 
            // lblAdmission
            // 
            this.lblAdmission.AutoSize = true;
            this.lblAdmission.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmission.Location = new System.Drawing.Point(333, -6);
            this.lblAdmission.Name = "lblAdmission";
            this.lblAdmission.Size = new System.Drawing.Size(199, 30);
            this.lblAdmission.TabIndex = 14;
            this.lblAdmission.Text = "Admission Form";
            this.lblAdmission.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(835, 17);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 18);
            this.lblEmployeeName.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddSemester);
            this.groupBox3.Controls.Add(this.txtSemester);
            this.groupBox3.Controls.Add(this.lblSemester);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(599, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 46);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Semister";
            // 
            // btnAddSemester
            // 
            this.btnAddSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSemester.Location = new System.Drawing.Point(170, 18);
            this.btnAddSemester.Name = "btnAddSemester";
            this.btnAddSemester.Size = new System.Drawing.Size(48, 23);
            this.btnAddSemester.TabIndex = 2;
            this.btnAddSemester.Text = "Add";
            this.btnAddSemester.UseVisualStyleBackColor = true;
            this.btnAddSemester.Click += new System.EventHandler(this.btnAddSemester_Click);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(65, 18);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(99, 20);
            this.txtSemester.TabIndex = 1;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(6, 20);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(59, 13);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Semester";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddDepartment);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.lblProduct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 46);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Location = new System.Drawing.Point(197, 15);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(48, 23);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(81, 17);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(110, 20);
            this.txtDepartment.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(7, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Department";
            // 
            // dgvAdmission
            // 
            this.dgvAdmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmission.Location = new System.Drawing.Point(278, 42);
            this.dgvAdmission.Name = "dgvAdmission";
            this.dgvAdmission.Size = new System.Drawing.Size(642, 385);
            this.dgvAdmission.TabIndex = 26;
            this.dgvAdmission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmission_CellClick);
            this.dgvAdmission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmission_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(5, 318);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(100, 81);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 5;
            this.pbStudent.TabStop = false;
            // 
            // frmAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 600);
            this.Controls.Add(this.dgvAdmission);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblPurchaseId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdmission);
            this.Name = "frmAdmission";
            this.Text = " Admission Form";
            this.Load += new System.EventHandler(this.frmAdmission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSemesterName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblAdmission;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddSemester;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label lblAdmitFee;
        private System.Windows.Forms.TextBox txtAdmitFee;
        private System.Windows.Forms.DataGridView dgvAdmission;
        private System.Windows.Forms.Label lblAdmitDate;
        private System.Windows.Forms.DateTimePicker dtpAdmitDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblStudentId;
    }
}

