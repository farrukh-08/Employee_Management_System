namespace VP_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Search_Employee_label = new System.Windows.Forms.Label();
            this.Search_Employee_Text_Area = new System.Windows.Forms.TextBox();
            this.Search_By_ID = new System.Windows.Forms.Button();
            this.Search_By_Name = new System.Windows.Forms.Button();
            this.list_by = new System.Windows.Forms.Label();
            this.List_Type_combo_box = new System.Windows.Forms.ComboBox();
            this.List_By_Department = new System.Windows.Forms.Button();
            this.Remove_Employee = new System.Windows.Forms.Label();
            this.Remove_Employee_Text_Area = new System.Windows.Forms.TextBox();
            this.Remove_By_id = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Employee_id = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phoneno = new System.Windows.Forms.Label();
            this.departmentid = new System.Windows.Forms.Label();
            this.positionid = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.Add_Employee_ID = new System.Windows.Forms.TextBox();
            this.Add_Employee_FirstName = new System.Windows.Forms.TextBox();
            this.Add_Employee_LastName = new System.Windows.Forms.TextBox();
            this.Add_Employee_Email = new System.Windows.Forms.TextBox();
            this.Add_Employee_PhoneNO = new System.Windows.Forms.TextBox();
            this.List_All = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_EMP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_BY_Position = new System.Windows.Forms.ComboBox();
            this.Sortpostion = new System.Windows.Forms.Button();
            this.agetextarea = new System.Windows.Forms.TextBox();
            this.AGE_LABEL = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.RichTextBox();
            this.run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_Panel_Label = new System.Windows.Forms.Label();
            this.GENDER_LABEL = new System.Windows.Forms.Label();
            this.gendertextarea = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.employee_password = new System.Windows.Forms.TextBox();
            this.Grant_Admin_Access_Label = new System.Windows.Forms.Label();
            this.Grant_Admin_Acess_txtArea = new System.Windows.Forms.TextBox();
            this.Grant_Admin_Access_Button = new System.Windows.Forms.Button();
            this.Remove_Admin_Access_Button = new System.Windows.Forms.Button();
            this.Remove_Admin_Access_txtArea = new System.Windows.Forms.TextBox();
            this.Remove_Admin_Access_Label = new System.Windows.Forms.Label();
            this.adminbutton = new System.Windows.Forms.Button();
            this.ShortAttendanceNotice = new System.Windows.Forms.Button();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.HireDate = new System.Windows.Forms.DateTimePicker();
            this.Department_combo_box = new System.Windows.Forms.ComboBox();
            this.Position_combo_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Employee_label
            // 
            this.Search_Employee_label.AutoSize = true;
            this.Search_Employee_label.BackColor = System.Drawing.SystemColors.Info;
            this.Search_Employee_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_Employee_label.Location = new System.Drawing.Point(22, 85);
            this.Search_Employee_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Search_Employee_label.Name = "Search_Employee_label";
            this.Search_Employee_label.Size = new System.Drawing.Size(140, 18);
            this.Search_Employee_label.TabIndex = 0;
            this.Search_Employee_label.Text = "Search Employee";
            this.Search_Employee_label.Click += new System.EventHandler(this.Search_Employee_label_Click);
            // 
            // Search_Employee_Text_Area
            // 
            this.Search_Employee_Text_Area.BackColor = System.Drawing.SystemColors.Info;
            this.Search_Employee_Text_Area.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_Employee_Text_Area.Location = new System.Drawing.Point(170, 85);
            this.Search_Employee_Text_Area.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Employee_Text_Area.Name = "Search_Employee_Text_Area";
            this.Search_Employee_Text_Area.Size = new System.Drawing.Size(341, 24);
            this.Search_Employee_Text_Area.TabIndex = 1;
            this.Search_Employee_Text_Area.TextChanged += new System.EventHandler(this.Search_Employee_Text_Area_TextChanged);
            // 
            // Search_By_ID
            // 
            this.Search_By_ID.BackColor = System.Drawing.SystemColors.Info;
            this.Search_By_ID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_By_ID.Location = new System.Drawing.Point(519, 85);
            this.Search_By_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Search_By_ID.Name = "Search_By_ID";
            this.Search_By_ID.Size = new System.Drawing.Size(94, 26);
            this.Search_By_ID.TabIndex = 2;
            this.Search_By_ID.Text = "ID";
            this.Search_By_ID.UseVisualStyleBackColor = false;
            this.Search_By_ID.Click += new System.EventHandler(this.Search_By_ID_Click);
            // 
            // Search_By_Name
            // 
            this.Search_By_Name.BackColor = System.Drawing.SystemColors.Info;
            this.Search_By_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search_By_Name.Location = new System.Drawing.Point(621, 85);
            this.Search_By_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Search_By_Name.Name = "Search_By_Name";
            this.Search_By_Name.Size = new System.Drawing.Size(94, 26);
            this.Search_By_Name.TabIndex = 3;
            this.Search_By_Name.Text = "NAME";
            this.Search_By_Name.UseVisualStyleBackColor = false;
            this.Search_By_Name.Click += new System.EventHandler(this.Search_By_Name_Click);
            // 
            // list_by
            // 
            this.list_by.AutoSize = true;
            this.list_by.BackColor = System.Drawing.SystemColors.Info;
            this.list_by.ForeColor = System.Drawing.SystemColors.Highlight;
            this.list_by.Location = new System.Drawing.Point(13, 126);
            this.list_by.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.list_by.Name = "list_by";
            this.list_by.Size = new System.Drawing.Size(151, 18);
            this.list_by.TabIndex = 4;
            this.list_by.Text = "List By Department";
            // 
            // List_Type_combo_box
            // 
            this.List_Type_combo_box.BackColor = System.Drawing.SystemColors.Info;
            this.List_Type_combo_box.ForeColor = System.Drawing.SystemColors.Highlight;
            this.List_Type_combo_box.FormattingEnabled = true;
            this.List_Type_combo_box.Location = new System.Drawing.Point(172, 126);
            this.List_Type_combo_box.Margin = new System.Windows.Forms.Padding(4);
            this.List_Type_combo_box.Name = "List_Type_combo_box";
            this.List_Type_combo_box.Size = new System.Drawing.Size(200, 26);
            this.List_Type_combo_box.TabIndex = 5;
            this.List_Type_combo_box.SelectedIndexChanged += new System.EventHandler(this.List_Type_combo_box_SelectedIndexChanged);
            // 
            // List_By_Department
            // 
            this.List_By_Department.BackColor = System.Drawing.SystemColors.Info;
            this.List_By_Department.ForeColor = System.Drawing.SystemColors.Highlight;
            this.List_By_Department.Location = new System.Drawing.Point(380, 125);
            this.List_By_Department.Margin = new System.Windows.Forms.Padding(4);
            this.List_By_Department.Name = "List_By_Department";
            this.List_By_Department.Size = new System.Drawing.Size(94, 26);
            this.List_By_Department.TabIndex = 6;
            this.List_By_Department.Text = "List";
            this.List_By_Department.UseVisualStyleBackColor = false;
            this.List_By_Department.Click += new System.EventHandler(this.List_By_Department_Click);
            // 
            // Remove_Employee
            // 
            this.Remove_Employee.AutoSize = true;
            this.Remove_Employee.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_Employee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Employee.Location = new System.Drawing.Point(13, 175);
            this.Remove_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Remove_Employee.Name = "Remove_Employee";
            this.Remove_Employee.Size = new System.Drawing.Size(149, 18);
            this.Remove_Employee.TabIndex = 7;
            this.Remove_Employee.Text = "Remove Employee";
            this.Remove_Employee.Click += new System.EventHandler(this.Remove_Employee_Click);
            // 
            // Remove_Employee_Text_Area
            // 
            this.Remove_Employee_Text_Area.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_Employee_Text_Area.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Employee_Text_Area.Location = new System.Drawing.Point(170, 173);
            this.Remove_Employee_Text_Area.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Employee_Text_Area.Name = "Remove_Employee_Text_Area";
            this.Remove_Employee_Text_Area.Size = new System.Drawing.Size(341, 24);
            this.Remove_Employee_Text_Area.TabIndex = 8;
            this.Remove_Employee_Text_Area.TextChanged += new System.EventHandler(this.Remove_Employee_Text_Area_TextChanged);
            // 
            // Remove_By_id
            // 
            this.Remove_By_id.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_By_id.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_By_id.Location = new System.Drawing.Point(519, 173);
            this.Remove_By_id.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_By_id.Name = "Remove_By_id";
            this.Remove_By_id.Size = new System.Drawing.Size(94, 26);
            this.Remove_By_id.TabIndex = 9;
            this.Remove_By_id.Text = "ID";
            this.Remove_By_id.UseVisualStyleBackColor = false;
            this.Remove_By_id.Click += new System.EventHandler(this.Remove_By_id_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(38, 721);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add Record";
            // 
            // Employee_id
            // 
            this.Employee_id.AutoSize = true;
            this.Employee_id.BackColor = System.Drawing.SystemColors.Info;
            this.Employee_id.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Employee_id.Location = new System.Drawing.Point(13, 332);
            this.Employee_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Employee_id.Name = "Employee_id";
            this.Employee_id.Size = new System.Drawing.Size(103, 18);
            this.Employee_id.TabIndex = 12;
            this.Employee_id.Text = "Employee ID";
            this.Employee_id.Click += new System.EventHandler(this.Employee_id_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.SystemColors.Info;
            this.firstname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstname.Location = new System.Drawing.Point(27, 396);
            this.firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(91, 18);
            this.firstname.TabIndex = 13;
            this.firstname.Text = "First Name";
            this.firstname.Click += new System.EventHandler(this.firstname_Click);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.SystemColors.Info;
            this.lastname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastname.Location = new System.Drawing.Point(27, 425);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(89, 18);
            this.lastname.TabIndex = 14;
            this.lastname.Text = "Last Name";
            this.lastname.Click += new System.EventHandler(this.lastname_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.Info;
            this.email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email.Location = new System.Drawing.Point(68, 520);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(50, 18);
            this.email.TabIndex = 15;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // phoneno
            // 
            this.phoneno.AutoSize = true;
            this.phoneno.BackColor = System.Drawing.SystemColors.Info;
            this.phoneno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phoneno.Location = new System.Drawing.Point(38, 549);
            this.phoneno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(80, 18);
            this.phoneno.TabIndex = 16;
            this.phoneno.Text = "Phone no";
            this.phoneno.Click += new System.EventHandler(this.phoneno_Click);
            // 
            // departmentid
            // 
            this.departmentid.AutoSize = true;
            this.departmentid.BackColor = System.Drawing.SystemColors.Info;
            this.departmentid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.departmentid.Location = new System.Drawing.Point(2, 616);
            this.departmentid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentid.Name = "departmentid";
            this.departmentid.Size = new System.Drawing.Size(116, 18);
            this.departmentid.TabIndex = 17;
            this.departmentid.Text = "Department ID";
            this.departmentid.Click += new System.EventHandler(this.departmentid_Click);
            // 
            // positionid
            // 
            this.positionid.AutoSize = true;
            this.positionid.BackColor = System.Drawing.SystemColors.Info;
            this.positionid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.positionid.Location = new System.Drawing.Point(27, 648);
            this.positionid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionid.Name = "positionid";
            this.positionid.Size = new System.Drawing.Size(91, 18);
            this.positionid.TabIndex = 18;
            this.positionid.Text = "Position ID";
            this.positionid.Click += new System.EventHandler(this.positionid_Click);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.BackColor = System.Drawing.SystemColors.Info;
            this.salary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salary.Location = new System.Drawing.Point(63, 680);
            this.salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(55, 18);
            this.salary.TabIndex = 19;
            this.salary.Text = "Salary";
            // 
            // Add_Employee_ID
            // 
            this.Add_Employee_ID.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Employee_ID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_Employee_ID.Location = new System.Drawing.Point(124, 329);
            this.Add_Employee_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Employee_ID.Name = "Add_Employee_ID";
            this.Add_Employee_ID.Size = new System.Drawing.Size(274, 24);
            this.Add_Employee_ID.TabIndex = 23;
            this.Add_Employee_ID.TextChanged += new System.EventHandler(this.Add_Employee_ID_TextChanged);
            // 
            // Add_Employee_FirstName
            // 
            this.Add_Employee_FirstName.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Employee_FirstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_Employee_FirstName.Location = new System.Drawing.Point(126, 393);
            this.Add_Employee_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Employee_FirstName.Name = "Add_Employee_FirstName";
            this.Add_Employee_FirstName.Size = new System.Drawing.Size(274, 24);
            this.Add_Employee_FirstName.TabIndex = 24;
            this.Add_Employee_FirstName.TextChanged += new System.EventHandler(this.Add_Employee_FirstName_TextChanged);
            // 
            // Add_Employee_LastName
            // 
            this.Add_Employee_LastName.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Employee_LastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_Employee_LastName.Location = new System.Drawing.Point(124, 425);
            this.Add_Employee_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Employee_LastName.Name = "Add_Employee_LastName";
            this.Add_Employee_LastName.Size = new System.Drawing.Size(274, 24);
            this.Add_Employee_LastName.TabIndex = 25;
            this.Add_Employee_LastName.TextChanged += new System.EventHandler(this.Add_Employee_LastName_TextChanged);
            // 
            // Add_Employee_Email
            // 
            this.Add_Employee_Email.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Employee_Email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_Employee_Email.Location = new System.Drawing.Point(126, 517);
            this.Add_Employee_Email.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Employee_Email.Name = "Add_Employee_Email";
            this.Add_Employee_Email.Size = new System.Drawing.Size(274, 24);
            this.Add_Employee_Email.TabIndex = 26;
            this.Add_Employee_Email.TextChanged += new System.EventHandler(this.Add_Employee_Email_TextChanged);
            // 
            // Add_Employee_PhoneNO
            // 
            this.Add_Employee_PhoneNO.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Employee_PhoneNO.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Add_Employee_PhoneNO.Location = new System.Drawing.Point(126, 549);
            this.Add_Employee_PhoneNO.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Employee_PhoneNO.Name = "Add_Employee_PhoneNO";
            this.Add_Employee_PhoneNO.Size = new System.Drawing.Size(274, 24);
            this.Add_Employee_PhoneNO.TabIndex = 27;
            this.Add_Employee_PhoneNO.TextChanged += new System.EventHandler(this.Add_Employee_PhoneNO_TextChanged);
            // 
            // List_All
            // 
            this.List_All.BackColor = System.Drawing.SystemColors.Info;
            this.List_All.ForeColor = System.Drawing.SystemColors.Highlight;
            this.List_All.Location = new System.Drawing.Point(482, 126);
            this.List_All.Margin = new System.Windows.Forms.Padding(4);
            this.List_All.Name = "List_All";
            this.List_All.Size = new System.Drawing.Size(94, 26);
            this.List_All.TabIndex = 32;
            this.List_All.Text = "List All";
            this.List_All.UseVisualStyleBackColor = false;
            this.List_All.Click += new System.EventHandler(this.List_All_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(462, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 529);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // addsalary
            // 
            this.addsalary.BackColor = System.Drawing.SystemColors.Info;
            this.addsalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addsalary.Location = new System.Drawing.Point(124, 677);
            this.addsalary.Margin = new System.Windows.Forms.Padding(4);
            this.addsalary.Name = "addsalary";
            this.addsalary.Size = new System.Drawing.Size(274, 24);
            this.addsalary.TabIndex = 40;
            this.addsalary.TextChanged += new System.EventHandler(this.addsalary_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(39, 584);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Hire Date";
            // 
            // ADD_EMP
            // 
            this.ADD_EMP.BackColor = System.Drawing.SystemColors.Info;
            this.ADD_EMP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ADD_EMP.Location = new System.Drawing.Point(199, 712);
            this.ADD_EMP.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_EMP.Name = "ADD_EMP";
            this.ADD_EMP.Size = new System.Drawing.Size(173, 34);
            this.ADD_EMP.TabIndex = 46;
            this.ADD_EMP.Text = "Add";
            this.ADD_EMP.UseVisualStyleBackColor = false;
            this.ADD_EMP.Click += new System.EventHandler(this.ADD_EMP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "List By Position";
            // 
            // list_BY_Position
            // 
            this.list_BY_Position.BackColor = System.Drawing.SystemColors.Info;
            this.list_BY_Position.ForeColor = System.Drawing.SystemColors.Highlight;
            this.list_BY_Position.FormattingEnabled = true;
            this.list_BY_Position.Location = new System.Drawing.Point(158, 225);
            this.list_BY_Position.Name = "list_BY_Position";
            this.list_BY_Position.Size = new System.Drawing.Size(174, 26);
            this.list_BY_Position.TabIndex = 48;
            // 
            // Sortpostion
            // 
            this.Sortpostion.BackColor = System.Drawing.SystemColors.Info;
            this.Sortpostion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Sortpostion.Location = new System.Drawing.Point(349, 227);
            this.Sortpostion.Name = "Sortpostion";
            this.Sortpostion.Size = new System.Drawing.Size(75, 24);
            this.Sortpostion.TabIndex = 49;
            this.Sortpostion.Text = "Sort";
            this.Sortpostion.UseVisualStyleBackColor = false;
            this.Sortpostion.Click += new System.EventHandler(this.Sortpostion_Click);
            // 
            // agetextarea
            // 
            this.agetextarea.BackColor = System.Drawing.SystemColors.Info;
            this.agetextarea.ForeColor = System.Drawing.SystemColors.Highlight;
            this.agetextarea.Location = new System.Drawing.Point(124, 486);
            this.agetextarea.Name = "agetextarea";
            this.agetextarea.Size = new System.Drawing.Size(274, 24);
            this.agetextarea.TabIndex = 50;
            // 
            // AGE_LABEL
            // 
            this.AGE_LABEL.AutoSize = true;
            this.AGE_LABEL.BackColor = System.Drawing.SystemColors.Info;
            this.AGE_LABEL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AGE_LABEL.Location = new System.Drawing.Point(82, 486);
            this.AGE_LABEL.Name = "AGE_LABEL";
            this.AGE_LABEL.Size = new System.Drawing.Size(36, 18);
            this.AGE_LABEL.TabIndex = 51;
            this.AGE_LABEL.Text = "Age";
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.SystemColors.Info;
            this.query.ForeColor = System.Drawing.SystemColors.Highlight;
            this.query.Location = new System.Drawing.Point(1149, 89);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(267, 96);
            this.query.TabIndex = 54;
            this.query.Text = "";
            this.query.TextChanged += new System.EventHandler(this.query_TextChanged);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.SystemColors.Info;
            this.run.ForeColor = System.Drawing.SystemColors.Highlight;
            this.run.Location = new System.Drawing.Point(1240, 191);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 55;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(1208, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "ENTER QUERY";
            // 
            // Admin_Panel_Label
            // 
            this.Admin_Panel_Label.AutoSize = true;
            this.Admin_Panel_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Admin_Panel_Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Panel_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Admin_Panel_Label.Location = new System.Drawing.Point(534, 19);
            this.Admin_Panel_Label.Name = "Admin_Panel_Label";
            this.Admin_Panel_Label.Size = new System.Drawing.Size(450, 32);
            this.Admin_Panel_Label.TabIndex = 57;
            this.Admin_Panel_Label.Text = "EMPOYEE MANAGMENT PANEL";
            // 
            // GENDER_LABEL
            // 
            this.GENDER_LABEL.AutoSize = true;
            this.GENDER_LABEL.BackColor = System.Drawing.SystemColors.Info;
            this.GENDER_LABEL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GENDER_LABEL.Location = new System.Drawing.Point(57, 459);
            this.GENDER_LABEL.Name = "GENDER_LABEL";
            this.GENDER_LABEL.Size = new System.Drawing.Size(63, 18);
            this.GENDER_LABEL.TabIndex = 58;
            this.GENDER_LABEL.Text = "Gender";
            // 
            // gendertextarea
            // 
            this.gendertextarea.BackColor = System.Drawing.SystemColors.Info;
            this.gendertextarea.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gendertextarea.Location = new System.Drawing.Point(126, 456);
            this.gendertextarea.Name = "gendertextarea";
            this.gendertextarea.Size = new System.Drawing.Size(274, 24);
            this.gendertextarea.TabIndex = 59;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.Info;
            this.password.ForeColor = System.Drawing.SystemColors.Highlight;
            this.password.Location = new System.Drawing.Point(35, 364);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 18);
            this.password.TabIndex = 60;
            this.password.Text = "Password";
            // 
            // employee_password
            // 
            this.employee_password.BackColor = System.Drawing.SystemColors.Info;
            this.employee_password.ForeColor = System.Drawing.SystemColors.Highlight;
            this.employee_password.Location = new System.Drawing.Point(124, 361);
            this.employee_password.Margin = new System.Windows.Forms.Padding(4);
            this.employee_password.Name = "employee_password";
            this.employee_password.Size = new System.Drawing.Size(274, 24);
            this.employee_password.TabIndex = 61;
            // 
            // Grant_Admin_Access_Label
            // 
            this.Grant_Admin_Access_Label.AutoSize = true;
            this.Grant_Admin_Access_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Grant_Admin_Access_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Grant_Admin_Access_Label.Location = new System.Drawing.Point(748, 88);
            this.Grant_Admin_Access_Label.Name = "Grant_Admin_Access_Label";
            this.Grant_Admin_Access_Label.Size = new System.Drawing.Size(166, 18);
            this.Grant_Admin_Access_Label.TabIndex = 62;
            this.Grant_Admin_Access_Label.Text = "Grant Admin Access:";
            // 
            // Grant_Admin_Acess_txtArea
            // 
            this.Grant_Admin_Acess_txtArea.BackColor = System.Drawing.SystemColors.Info;
            this.Grant_Admin_Acess_txtArea.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Grant_Admin_Acess_txtArea.Location = new System.Drawing.Point(921, 86);
            this.Grant_Admin_Acess_txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.Grant_Admin_Acess_txtArea.Name = "Grant_Admin_Acess_txtArea";
            this.Grant_Admin_Acess_txtArea.Size = new System.Drawing.Size(97, 24);
            this.Grant_Admin_Acess_txtArea.TabIndex = 63;
            // 
            // Grant_Admin_Access_Button
            // 
            this.Grant_Admin_Access_Button.BackColor = System.Drawing.SystemColors.Info;
            this.Grant_Admin_Access_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Grant_Admin_Access_Button.Location = new System.Drawing.Point(1026, 86);
            this.Grant_Admin_Access_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Grant_Admin_Access_Button.Name = "Grant_Admin_Access_Button";
            this.Grant_Admin_Access_Button.Size = new System.Drawing.Size(94, 26);
            this.Grant_Admin_Access_Button.TabIndex = 64;
            this.Grant_Admin_Access_Button.Text = "ID";
            this.Grant_Admin_Access_Button.UseVisualStyleBackColor = false;
            this.Grant_Admin_Access_Button.Click += new System.EventHandler(this.Grant_Admin_Access_Button_Click);
            // 
            // Remove_Admin_Access_Button
            // 
            this.Remove_Admin_Access_Button.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_Admin_Access_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Admin_Access_Button.Location = new System.Drawing.Point(1026, 114);
            this.Remove_Admin_Access_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Admin_Access_Button.Name = "Remove_Admin_Access_Button";
            this.Remove_Admin_Access_Button.Size = new System.Drawing.Size(94, 26);
            this.Remove_Admin_Access_Button.TabIndex = 67;
            this.Remove_Admin_Access_Button.Text = "ID";
            this.Remove_Admin_Access_Button.UseVisualStyleBackColor = false;
            this.Remove_Admin_Access_Button.Click += new System.EventHandler(this.Remove_Admin_Access_Button_Click);
            // 
            // Remove_Admin_Access_txtArea
            // 
            this.Remove_Admin_Access_txtArea.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_Admin_Access_txtArea.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Admin_Access_txtArea.Location = new System.Drawing.Point(921, 115);
            this.Remove_Admin_Access_txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Admin_Access_txtArea.Name = "Remove_Admin_Access_txtArea";
            this.Remove_Admin_Access_txtArea.Size = new System.Drawing.Size(97, 24);
            this.Remove_Admin_Access_txtArea.TabIndex = 66;
            // 
            // Remove_Admin_Access_Label
            // 
            this.Remove_Admin_Access_Label.AutoSize = true;
            this.Remove_Admin_Access_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Remove_Admin_Access_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Admin_Access_Label.Location = new System.Drawing.Point(728, 115);
            this.Remove_Admin_Access_Label.Name = "Remove_Admin_Access_Label";
            this.Remove_Admin_Access_Label.Size = new System.Drawing.Size(186, 18);
            this.Remove_Admin_Access_Label.TabIndex = 65;
            this.Remove_Admin_Access_Label.Text = "Remove Admin Access:";
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.SystemColors.Info;
            this.adminbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminbutton.Location = new System.Drawing.Point(932, 148);
            this.adminbutton.Margin = new System.Windows.Forms.Padding(4);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(161, 26);
            this.adminbutton.TabIndex = 68;
            this.adminbutton.Text = "List All Admins";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // ShortAttendanceNotice
            // 
            this.ShortAttendanceNotice.BackColor = System.Drawing.SystemColors.Info;
            this.ShortAttendanceNotice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShortAttendanceNotice.Location = new System.Drawing.Point(911, 182);
            this.ShortAttendanceNotice.Margin = new System.Windows.Forms.Padding(4);
            this.ShortAttendanceNotice.Name = "ShortAttendanceNotice";
            this.ShortAttendanceNotice.Size = new System.Drawing.Size(200, 26);
            this.ShortAttendanceNotice.TabIndex = 69;
            this.ShortAttendanceNotice.Text = "Short Attendance Notice";
            this.ShortAttendanceNotice.UseVisualStyleBackColor = false;
            this.ShortAttendanceNotice.Click += new System.EventHandler(this.ShortAttendanceNotice_Click);
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.SystemColors.Info;
            this.updateEmployee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateEmployee.Location = new System.Drawing.Point(199, 766);
            this.updateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(173, 34);
            this.updateEmployee.TabIndex = 71;
            this.updateEmployee.Text = "UPDATE";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(12, 775);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Update Record";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(40, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 27);
            this.label7.TabIndex = 73;
            this.label7.Text = "Add / Update Employee Record";
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.SystemColors.Info;
            this.Previous.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Previous.Location = new System.Drawing.Point(722, 766);
            this.Previous.Margin = new System.Windows.Forms.Padding(4);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(241, 34);
            this.Previous.TabIndex = 74;
            this.Previous.Text = "BACK";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // HireDate
            // 
            this.HireDate.Location = new System.Drawing.Point(124, 582);
            this.HireDate.Name = "HireDate";
            this.HireDate.Size = new System.Drawing.Size(274, 24);
            this.HireDate.TabIndex = 75;
            // 
            // Department_combo_box
            // 
            this.Department_combo_box.BackColor = System.Drawing.SystemColors.Info;
            this.Department_combo_box.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Department_combo_box.FormattingEnabled = true;
            this.Department_combo_box.Location = new System.Drawing.Point(126, 612);
            this.Department_combo_box.Name = "Department_combo_box";
            this.Department_combo_box.Size = new System.Drawing.Size(174, 26);
            this.Department_combo_box.TabIndex = 76;
            // 
            // Position_combo_box
            // 
            this.Position_combo_box.BackColor = System.Drawing.SystemColors.Info;
            this.Position_combo_box.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Position_combo_box.FormattingEnabled = true;
            this.Position_combo_box.Location = new System.Drawing.Point(126, 648);
            this.Position_combo_box.Name = "Position_combo_box";
            this.Position_combo_box.Size = new System.Drawing.Size(174, 26);
            this.Position_combo_box.TabIndex = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1475, 859);
            this.Controls.Add(this.Position_combo_box);
            this.Controls.Add(this.Department_combo_box);
            this.Controls.Add(this.HireDate);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.ShortAttendanceNotice);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.Remove_Admin_Access_Button);
            this.Controls.Add(this.Remove_Admin_Access_txtArea);
            this.Controls.Add(this.Remove_Admin_Access_Label);
            this.Controls.Add(this.Grant_Admin_Access_Button);
            this.Controls.Add(this.Grant_Admin_Acess_txtArea);
            this.Controls.Add(this.Grant_Admin_Access_Label);
            this.Controls.Add(this.employee_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.gendertextarea);
            this.Controls.Add(this.GENDER_LABEL);
            this.Controls.Add(this.Admin_Panel_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.query);
            this.Controls.Add(this.AGE_LABEL);
            this.Controls.Add(this.agetextarea);
            this.Controls.Add(this.Sortpostion);
            this.Controls.Add(this.list_BY_Position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADD_EMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addsalary);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.List_All);
            this.Controls.Add(this.Add_Employee_PhoneNO);
            this.Controls.Add(this.Add_Employee_Email);
            this.Controls.Add(this.Add_Employee_LastName);
            this.Controls.Add(this.Add_Employee_FirstName);
            this.Controls.Add(this.Add_Employee_ID);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.positionid);
            this.Controls.Add(this.departmentid);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.Employee_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Remove_By_id);
            this.Controls.Add(this.Remove_Employee_Text_Area);
            this.Controls.Add(this.Remove_Employee);
            this.Controls.Add(this.List_By_Department);
            this.Controls.Add(this.List_Type_combo_box);
            this.Controls.Add(this.list_by);
            this.Controls.Add(this.Search_By_Name);
            this.Controls.Add(this.Search_By_ID);
            this.Controls.Add(this.Search_Employee_Text_Area);
            this.Controls.Add(this.Search_Employee_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Search_Employee_label;
        private System.Windows.Forms.TextBox Search_Employee_Text_Area;
        private System.Windows.Forms.Button Search_By_ID;
        private System.Windows.Forms.Button Search_By_Name;
        private System.Windows.Forms.Label list_by;
        private System.Windows.Forms.ComboBox List_Type_combo_box;
        private System.Windows.Forms.Button List_By_Department;
        private System.Windows.Forms.Label Remove_Employee;
        private System.Windows.Forms.TextBox Remove_Employee_Text_Area;
        private System.Windows.Forms.Button Remove_By_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Employee_id;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phoneno;
        private System.Windows.Forms.Label departmentid;
        private System.Windows.Forms.Label positionid;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox Add_Employee_ID;
        private System.Windows.Forms.TextBox Add_Employee_FirstName;
        private System.Windows.Forms.TextBox Add_Employee_LastName;
        private System.Windows.Forms.TextBox Add_Employee_Email;
        private System.Windows.Forms.TextBox Add_Employee_PhoneNO;
        private System.Windows.Forms.Button List_All;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_EMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_BY_Position;
        private System.Windows.Forms.Button Sortpostion;
        private System.Windows.Forms.TextBox agetextarea;
        private System.Windows.Forms.Label AGE_LABEL;
        private System.Windows.Forms.RichTextBox query;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Admin_Panel_Label;
        private System.Windows.Forms.Label GENDER_LABEL;
        private System.Windows.Forms.TextBox gendertextarea;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox employee_password;
        private System.Windows.Forms.Label Grant_Admin_Access_Label;
        private System.Windows.Forms.TextBox Grant_Admin_Acess_txtArea;
        private System.Windows.Forms.Button Grant_Admin_Access_Button;
        private System.Windows.Forms.Button Remove_Admin_Access_Button;
        private System.Windows.Forms.TextBox Remove_Admin_Access_txtArea;
        private System.Windows.Forms.Label Remove_Admin_Access_Label;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button ShortAttendanceNotice;
        private System.Windows.Forms.Button updateEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.DateTimePicker HireDate;
        private System.Windows.Forms.ComboBox Department_combo_box;
        private System.Windows.Forms.ComboBox Position_combo_box;
    }
}

