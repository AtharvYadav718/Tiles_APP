namespace Tiles_APP
{
    partial class Frm_Customer_Information
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
            this.tb_Custmer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Alt_Mob_No = new System.Windows.Forms.Label();
            this.tb_Alternative_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Custmer_Name
            // 
            this.tb_Custmer_Name.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Custmer_Name.Location = new System.Drawing.Point(279, 220);
            this.tb_Custmer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Custmer_Name.Name = "tb_Custmer_Name";
            this.tb_Custmer_Name.Size = new System.Drawing.Size(359, 39);
            this.tb_Custmer_Name.TabIndex = 1;
            this.tb_Custmer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Customer_Name.Location = new System.Drawing.Point(34, 223);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(235, 34);
            this.lbl_Customer_Name.TabIndex = 25;
            this.lbl_Customer_Name.Text = "Customer Name ";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(279, 114);
            this.tb_Customer_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(359, 39);
            this.tb_Customer_ID.TabIndex = 1;
            this.tb_Customer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Customer_ID.Location = new System.Drawing.Point(71, 116);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(194, 34);
            this.lbl_Customer_ID.TabIndex = 23;
            this.lbl_Customer_ID.Text = "Customer ID ";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(902, 104);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(337, 39);
            this.dtp_Date.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(719, 107);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(87, 34);
            this.lbl_Date.TabIndex = 27;
            this.lbl_Date.Text = "Date ";
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(279, 334);
            this.tb_Aadhar_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(359, 39);
            this.tb_Aadhar_No.TabIndex = 2;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(94, 341);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(168, 34);
            this.lbl_Aadhar_No.TabIndex = 29;
            this.lbl_Aadhar_No.Text = "Aadhar No ";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(902, 214);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(337, 39);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Mobile_No.Location = new System.Drawing.Point(719, 222);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(163, 34);
            this.lbl_Mobile_No.TabIndex = 33;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Address.Location = new System.Drawing.Point(734, 461);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(127, 34);
            this.lbl_Address.TabIndex = 33;
            this.lbl_Address.Text = "Address ";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(902, 454);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(337, 117);
            this.tb_Address.TabIndex = 7;
            // 
            // lbl_Alt_Mob_No
            // 
            this.lbl_Alt_Mob_No.AutoSize = true;
            this.lbl_Alt_Mob_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Alt_Mob_No.Location = new System.Drawing.Point(700, 334);
            this.lbl_Alt_Mob_No.Name = "lbl_Alt_Mob_No";
            this.lbl_Alt_Mob_No.Size = new System.Drawing.Size(191, 34);
            this.lbl_Alt_Mob_No.TabIndex = 33;
            this.lbl_Alt_Mob_No.Text = "Alt. Mob No ";
            // 
            // tb_Alternative_Mob_No
            // 
            this.tb_Alternative_Mob_No.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternative_Mob_No.Location = new System.Drawing.Point(902, 335);
            this.tb_Alternative_Mob_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Alternative_Mob_No.MaxLength = 10;
            this.tb_Alternative_Mob_No.Name = "tb_Alternative_Mob_No";
            this.tb_Alternative_Mob_No.Size = new System.Drawing.Size(337, 39);
            this.tb_Alternative_Mob_No.TabIndex = 6;
            this.tb_Alternative_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_PAN_No.Location = new System.Drawing.Point(122, 464);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(137, 34);
            this.lbl_PAN_No.TabIndex = 33;
            this.lbl_PAN_No.Text = "PAN No ";
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(279, 457);
            this.tb_PAN_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PAN_No.MaxLength = 11;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(359, 39);
            this.tb_PAN_No.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(600, 602);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 65);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Customer_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Alternative_Mob_No);
            this.Controls.Add(this.lbl_Alt_Mob_No);
            this.Controls.Add(this.tb_PAN_No);
            this.Controls.Add(this.lbl_PAN_No);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.tb_Aadhar_No);
            this.Controls.Add(this.lbl_Aadhar_No);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.tb_Custmer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Customer_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Frm_Customer_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Custmer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Alt_Mob_No;
        private System.Windows.Forms.TextBox tb_Alternative_Mob_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.Button btn_Save;
    }
}