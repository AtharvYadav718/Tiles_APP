namespace Tiles_APP
{
    partial class Frm_Update_Employee_Details
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.gb_Employee_Information = new System.Windows.Forms.GroupBox();
            this.tb_Alternative_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_Number = new System.Windows.Forms.TextBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_Number = new System.Windows.Forms.Label();
            this.lbl_Alt_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.lbl_Employeee_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.tb_PAN_Number = new System.Windows.Forms.TextBox();
            this.lbl_PAN_Number = new System.Windows.Forms.Label();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.gb_Personal_Information = new System.Windows.Forms.GroupBox();
            this.cmb_Post = new System.Windows.Forms.ComboBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.tb_Experience = new System.Windows.Forms.TextBox();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Employee_Information.SuspendLayout();
            this.gb_Personal_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(477, 629);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(157, 63);
            this.btn_Refresh.TabIndex = 100;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(428, 33);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 49);
            this.btn_Search.TabIndex = 95;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.Enabled = false;
            this.cmb_Gender.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.IntegralHeight = false;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_Gender.Location = new System.Drawing.Point(269, 180);
            this.cmb_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(375, 39);
            this.cmb_Gender.TabIndex = 2;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(264, 254);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(380, 39);
            this.dtp_DOB.TabIndex = 3;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(138, 253);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(97, 32);
            this.lbl_DOB.TabIndex = 63;
            this.lbl_DOB.Text = "D.O.B ";
            // 
            // gb_Employee_Information
            // 
            this.gb_Employee_Information.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gb_Employee_Information.Controls.Add(this.btn_Search);
            this.gb_Employee_Information.Controls.Add(this.cmb_Gender);
            this.gb_Employee_Information.Controls.Add(this.dtp_DOB);
            this.gb_Employee_Information.Controls.Add(this.lbl_DOB);
            this.gb_Employee_Information.Controls.Add(this.tb_Alternative_Mob_No);
            this.gb_Employee_Information.Controls.Add(this.tb_Mobile_Number);
            this.gb_Employee_Information.Controls.Add(this.tb_Aadhar_Number);
            this.gb_Employee_Information.Controls.Add(this.tb_Employee_Name);
            this.gb_Employee_Information.Controls.Add(this.lbl_Aadhar_Number);
            this.gb_Employee_Information.Controls.Add(this.lbl_Alt_Mob_No);
            this.gb_Employee_Information.Controls.Add(this.lbl_Mobile_Number);
            this.gb_Employee_Information.Controls.Add(this.lbl_Employeee_Name);
            this.gb_Employee_Information.Controls.Add(this.lbl_Gender);
            this.gb_Employee_Information.Controls.Add(this.tb_Employee_ID);
            this.gb_Employee_Information.Controls.Add(this.lbl_Employee_ID);
            this.gb_Employee_Information.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_Information.Location = new System.Drawing.Point(2, 11);
            this.gb_Employee_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Employee_Information.Name = "gb_Employee_Information";
            this.gb_Employee_Information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Employee_Information.Size = new System.Drawing.Size(664, 599);
            this.gb_Employee_Information.TabIndex = 97;
            this.gb_Employee_Information.TabStop = false;
            this.gb_Employee_Information.Text = "Employee Information ";
            // 
            // tb_Alternative_Mob_No
            // 
            this.tb_Alternative_Mob_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternative_Mob_No.Location = new System.Drawing.Point(264, 510);
            this.tb_Alternative_Mob_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Alternative_Mob_No.Name = "tb_Alternative_Mob_No";
            this.tb_Alternative_Mob_No.Size = new System.Drawing.Size(380, 39);
            this.tb_Alternative_Mob_No.TabIndex = 6;
            this.tb_Alternative_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(264, 427);
            this.tb_Mobile_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(380, 39);
            this.tb_Mobile_Number.TabIndex = 5;
            this.tb_Mobile_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Aadhar_Number
            // 
            this.tb_Aadhar_Number.Enabled = false;
            this.tb_Aadhar_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_Number.Location = new System.Drawing.Point(264, 339);
            this.tb_Aadhar_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Aadhar_Number.Name = "tb_Aadhar_Number";
            this.tb_Aadhar_Number.Size = new System.Drawing.Size(380, 39);
            this.tb_Aadhar_Number.TabIndex = 4;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Enabled = false;
            this.tb_Employee_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(269, 108);
            this.tb_Employee_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(375, 39);
            this.tb_Employee_Name.TabIndex = 1;
            // 
            // lbl_Aadhar_Number
            // 
            this.lbl_Aadhar_Number.AutoSize = true;
            this.lbl_Aadhar_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Number.Location = new System.Drawing.Point(17, 338);
            this.lbl_Aadhar_Number.Name = "lbl_Aadhar_Number";
            this.lbl_Aadhar_Number.Size = new System.Drawing.Size(216, 32);
            this.lbl_Aadhar_Number.TabIndex = 59;
            this.lbl_Aadhar_Number.Text = "Aadhar Number ";
            // 
            // lbl_Alt_Mob_No
            // 
            this.lbl_Alt_Mob_No.AutoSize = true;
            this.lbl_Alt_Mob_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alt_Mob_No.Location = new System.Drawing.Point(42, 514);
            this.lbl_Alt_Mob_No.Name = "lbl_Alt_Mob_No";
            this.lbl_Alt_Mob_No.Size = new System.Drawing.Size(176, 32);
            this.lbl_Alt_Mob_No.TabIndex = 59;
            this.lbl_Alt_Mob_No.Text = "Alt. Mob. No ";
            // 
            // lbl_Mobile_Number
            // 
            this.lbl_Mobile_Number.AutoSize = true;
            this.lbl_Mobile_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Number.Location = new System.Drawing.Point(19, 427);
            this.lbl_Mobile_Number.Name = "lbl_Mobile_Number";
            this.lbl_Mobile_Number.Size = new System.Drawing.Size(209, 32);
            this.lbl_Mobile_Number.TabIndex = 59;
            this.lbl_Mobile_Number.Text = "Mobile Number ";
            // 
            // lbl_Employeee_Name
            // 
            this.lbl_Employeee_Name.AutoSize = true;
            this.lbl_Employeee_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employeee_Name.Location = new System.Drawing.Point(24, 112);
            this.lbl_Employeee_Name.Name = "lbl_Employeee_Name";
            this.lbl_Employeee_Name.Size = new System.Drawing.Size(213, 32);
            this.lbl_Employeee_Name.TabIndex = 59;
            this.lbl_Employeee_Name.Text = "Employee Name ";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(132, 177);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(110, 32);
            this.lbl_Gender.TabIndex = 59;
            this.lbl_Gender.Text = "Gender ";
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(268, 35);
            this.tb_Employee_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(120, 39);
            this.tb_Employee_ID.TabIndex = 60;
            this.tb_Employee_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.Location = new System.Drawing.Point(64, 37);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(175, 32);
            this.lbl_Employee_ID.TabIndex = 59;
            this.lbl_Employee_ID.Text = "Employee ID ";
            // 
            // tb_PAN_Number
            // 
            this.tb_PAN_Number.Enabled = false;
            this.tb_PAN_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_Number.Location = new System.Drawing.Point(241, 423);
            this.tb_PAN_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PAN_Number.Name = "tb_PAN_Number";
            this.tb_PAN_Number.Size = new System.Drawing.Size(345, 39);
            this.tb_PAN_Number.TabIndex = 12;
            // 
            // lbl_PAN_Number
            // 
            this.lbl_PAN_Number.AutoSize = true;
            this.lbl_PAN_Number.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_Number.Location = new System.Drawing.Point(25, 428);
            this.lbl_PAN_Number.Name = "lbl_PAN_Number";
            this.lbl_PAN_Number.Size = new System.Drawing.Size(181, 32);
            this.lbl_PAN_Number.TabIndex = 67;
            this.lbl_PAN_Number.Text = "PAN Number ";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.CalendarFont = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Enabled = false;
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(241, 31);
            this.dtp_Joining_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(345, 39);
            this.dtp_Joining_Date.TabIndex = 7;
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.Location = new System.Drawing.Point(36, 33);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(173, 32);
            this.lbl_Joining_Date.TabIndex = 65;
            this.lbl_Joining_Date.Text = "Joining Date ";
            // 
            // gb_Personal_Information
            // 
            this.gb_Personal_Information.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gb_Personal_Information.Controls.Add(this.cmb_Post);
            this.gb_Personal_Information.Controls.Add(this.tb_Salary);
            this.gb_Personal_Information.Controls.Add(this.lbl_Salary);
            this.gb_Personal_Information.Controls.Add(this.tb_PAN_Number);
            this.gb_Personal_Information.Controls.Add(this.lbl_PAN_Number);
            this.gb_Personal_Information.Controls.Add(this.tb_Qualification);
            this.gb_Personal_Information.Controls.Add(this.lbl_Qualification);
            this.gb_Personal_Information.Controls.Add(this.tb_Email_ID);
            this.gb_Personal_Information.Controls.Add(this.lbl_Email_ID);
            this.gb_Personal_Information.Controls.Add(this.lbl_Post);
            this.gb_Personal_Information.Controls.Add(this.tb_Experience);
            this.gb_Personal_Information.Controls.Add(this.lbl_Experience);
            this.gb_Personal_Information.Controls.Add(this.dtp_Joining_Date);
            this.gb_Personal_Information.Controls.Add(this.lbl_Joining_Date);
            this.gb_Personal_Information.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Information.Location = new System.Drawing.Point(672, 11);
            this.gb_Personal_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Personal_Information.Name = "gb_Personal_Information";
            this.gb_Personal_Information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Personal_Information.Size = new System.Drawing.Size(611, 599);
            this.gb_Personal_Information.TabIndex = 98;
            this.gb_Personal_Information.TabStop = false;
            this.gb_Personal_Information.Text = "Personal Information ";
            // 
            // cmb_Post
            // 
            this.cmb_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Post.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Post.FormattingEnabled = true;
            this.cmb_Post.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Worker"});
            this.cmb_Post.Location = new System.Drawing.Point(241, 185);
            this.cmb_Post.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Post.Name = "cmb_Post";
            this.cmb_Post.Size = new System.Drawing.Size(345, 39);
            this.cmb_Post.TabIndex = 9;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(241, 510);
            this.tb_Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(345, 39);
            this.tb_Salary.TabIndex = 13;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(117, 514);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(99, 32);
            this.lbl_Salary.TabIndex = 67;
            this.lbl_Salary.Text = "Salary ";
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(241, 339);
            this.tb_Qualification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(345, 39);
            this.tb_Qualification.TabIndex = 11;
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.Location = new System.Drawing.Point(33, 348);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(179, 32);
            this.lbl_Qualification.TabIndex = 67;
            this.lbl_Qualification.Text = "Qualification ";
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(241, 261);
            this.tb_Email_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(345, 39);
            this.tb_Email_ID.TabIndex = 10;
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.Location = new System.Drawing.Point(67, 264);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(142, 32);
            this.lbl_Email_ID.TabIndex = 67;
            this.lbl_Email_ID.Text = "E-Mail ID ";
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Post.Location = new System.Drawing.Point(143, 184);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(73, 32);
            this.lbl_Post.TabIndex = 67;
            this.lbl_Post.Text = "Post ";
            // 
            // tb_Experience
            // 
            this.tb_Experience.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Experience.Location = new System.Drawing.Point(241, 110);
            this.tb_Experience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Experience.Name = "tb_Experience";
            this.tb_Experience.Size = new System.Drawing.Size(345, 39);
            this.tb_Experience.TabIndex = 8;
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Experience.Location = new System.Drawing.Point(60, 114);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(154, 32);
            this.lbl_Experience.TabIndex = 67;
            this.lbl_Experience.Text = "Experience ";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(693, 629);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(157, 63);
            this.btn_Update.TabIndex = 99;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Frm_Update_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Employee_Information);
            this.Controls.Add(this.gb_Personal_Information);
            this.Controls.Add(this.btn_Update);
            this.Name = "Frm_Update_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee Details";
            this.Load += new System.EventHandler(this.Frm_Update_Employee_Details_Load);
            this.gb_Employee_Information.ResumeLayout(false);
            this.gb_Employee_Information.PerformLayout();
            this.gb_Personal_Information.ResumeLayout(false);
            this.gb_Personal_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.GroupBox gb_Employee_Information;
        private System.Windows.Forms.TextBox tb_Alternative_Mob_No;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Aadhar_Number;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Label lbl_Aadhar_Number;
        private System.Windows.Forms.Label lbl_Alt_Mob_No;
        private System.Windows.Forms.Label lbl_Mobile_Number;
        private System.Windows.Forms.Label lbl_Employeee_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.TextBox tb_PAN_Number;
        private System.Windows.Forms.Label lbl_PAN_Number;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.GroupBox gb_Personal_Information;
        private System.Windows.Forms.ComboBox cmb_Post;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.TextBox tb_Experience;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Button btn_Update;
    }
}