namespace Tiles_APP
{
    partial class Frm_Add_New_Supplier
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Alternative_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_Alt_Mob_No = new System.Windows.Forms.Label();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.dtp_Tie_Up_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Tie_Up_Date = new System.Windows.Forms.Label();
            this.tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Supplier_ID = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_ID = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(572, 596);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 62);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Alternative_Mob_No
            // 
            this.tb_Alternative_Mob_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternative_Mob_No.Location = new System.Drawing.Point(900, 162);
            this.tb_Alternative_Mob_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Alternative_Mob_No.MaxLength = 10;
            this.tb_Alternative_Mob_No.Name = "tb_Alternative_Mob_No";
            this.tb_Alternative_Mob_No.Size = new System.Drawing.Size(355, 39);
            this.tb_Alternative_Mob_No.TabIndex = 6;
            this.tb_Alternative_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Alt_Mob_No
            // 
            this.lbl_Alt_Mob_No.AutoSize = true;
            this.lbl_Alt_Mob_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Alt_Mob_No.Location = new System.Drawing.Point(690, 167);
            this.lbl_Alt_Mob_No.Name = "lbl_Alt_Mob_No";
            this.lbl_Alt_Mob_No.Size = new System.Drawing.Size(185, 34);
            this.lbl_Alt_Mob_No.TabIndex = 48;
            this.lbl_Alt_Mob_No.Text = "Alt.Mob.No ";
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(900, 357);
            this.tb_PAN_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PAN_No.MaxLength = 11;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(355, 39);
            this.tb_PAN_No.TabIndex = 8;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_PAN_No.Location = new System.Drawing.Point(737, 362);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(137, 34);
            this.lbl_PAN_No.TabIndex = 47;
            this.lbl_PAN_No.Text = "PAN No ";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(900, 257);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(355, 39);
            this.tb_Address.TabIndex = 7;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Address.Location = new System.Drawing.Point(739, 257);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(127, 34);
            this.lbl_Address.TabIndex = 46;
            this.lbl_Address.Text = "Address ";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(900, 67);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(355, 39);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Mobile_No.Location = new System.Drawing.Point(707, 77);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(163, 34);
            this.lbl_Mobile_No.TabIndex = 49;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(277, 461);
            this.tb_Email_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(368, 39);
            this.tb_Email_ID.TabIndex = 4;
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Email_ID.Location = new System.Drawing.Point(92, 467);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(159, 34);
            this.lbl_Email_ID.TabIndex = 44;
            this.lbl_Email_ID.Text = "E-Mail ID ";
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(277, 368);
            this.tb_Aadhar_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(368, 39);
            this.tb_Aadhar_No.TabIndex = 3;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(84, 374);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(168, 34);
            this.lbl_Aadhar_No.TabIndex = 42;
            this.lbl_Aadhar_No.Text = "Aadhar No ";
            // 
            // dtp_Tie_Up_Date
            // 
            this.dtp_Tie_Up_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Tie_Up_Date.Location = new System.Drawing.Point(277, 262);
            this.dtp_Tie_Up_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Tie_Up_Date.Name = "dtp_Tie_Up_Date";
            this.dtp_Tie_Up_Date.Size = new System.Drawing.Size(368, 39);
            this.dtp_Tie_Up_Date.TabIndex = 2;
            // 
            // lbl_Tie_Up_Date
            // 
            this.lbl_Tie_Up_Date.AutoSize = true;
            this.lbl_Tie_Up_Date.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Tie_Up_Date.Location = new System.Drawing.Point(62, 271);
            this.lbl_Tie_Up_Date.Name = "lbl_Tie_Up_Date";
            this.lbl_Tie_Up_Date.Size = new System.Drawing.Size(192, 34);
            this.lbl_Tie_Up_Date.TabIndex = 40;
            this.lbl_Tie_Up_Date.Text = " Tie Up Date ";
            // 
            // tb_Supplier_Name
            // 
            this.tb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Name.Location = new System.Drawing.Point(280, 163);
            this.tb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Supplier_Name.Name = "tb_Supplier_Name";
            this.tb_Supplier_Name.Size = new System.Drawing.Size(368, 39);
            this.tb_Supplier_Name.TabIndex = 1;
            this.tb_Supplier_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(38, 168);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(216, 34);
            this.lbl_Supplier_Name.TabIndex = 38;
            this.lbl_Supplier_Name.Text = "Supplier Name ";
            // 
            // tb_Supplier_ID
            // 
            this.tb_Supplier_ID.Enabled = false;
            this.tb_Supplier_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_ID.Location = new System.Drawing.Point(277, 73);
            this.tb_Supplier_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Supplier_ID.Name = "tb_Supplier_ID";
            this.tb_Supplier_ID.Size = new System.Drawing.Size(368, 39);
            this.tb_Supplier_ID.TabIndex = 37;
            this.tb_Supplier_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Supplier_ID
            // 
            this.lbl_Supplier_ID.AutoSize = true;
            this.lbl_Supplier_ID.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Supplier_ID.Location = new System.Drawing.Point(74, 78);
            this.lbl_Supplier_ID.Name = "lbl_Supplier_ID";
            this.lbl_Supplier_ID.Size = new System.Drawing.Size(175, 34);
            this.lbl_Supplier_ID.TabIndex = 36;
            this.lbl_Supplier_ID.Text = "Supplier ID ";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Note.Location = new System.Drawing.Point(782, 461);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(87, 34);
            this.lbl_Note.TabIndex = 55;
            this.lbl_Note.Text = "Note ";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(900, 440);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(355, 115);
            this.tb_Note.TabIndex = 9;
            // 
            // Frm_Add_New_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Note);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Alternative_Mob_No);
            this.Controls.Add(this.lbl_Alt_Mob_No);
            this.Controls.Add(this.tb_PAN_No);
            this.Controls.Add(this.lbl_PAN_No);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.tb_Email_ID);
            this.Controls.Add(this.lbl_Email_ID);
            this.Controls.Add(this.tb_Aadhar_No);
            this.Controls.Add(this.lbl_Aadhar_No);
            this.Controls.Add(this.dtp_Tie_Up_Date);
            this.Controls.Add(this.lbl_Tie_Up_Date);
            this.Controls.Add(this.tb_Supplier_Name);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.Controls.Add(this.tb_Supplier_ID);
            this.Controls.Add(this.lbl_Supplier_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Add_New_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Supplier";
            this.Load += new System.EventHandler(this.Frm_Add_New_Supplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Alternative_Mob_No;
        private System.Windows.Forms.Label lbl_Alt_Mob_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.DateTimePicker dtp_Tie_Up_Date;
        private System.Windows.Forms.Label lbl_Tie_Up_Date;
        private System.Windows.Forms.TextBox tb_Supplier_Name;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Supplier_ID;
        private System.Windows.Forms.Label lbl_Supplier_ID;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
    }
}