namespace Tiles_APP
{
    partial class Frm_Delete_User
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
            this.gb_ClothType_Details = new System.Windows.Forms.GroupBox();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.lbl_UserRole = new System.Windows.Forms.Label();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.gb_ClothType_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ClothType_Details
            // 
            this.gb_ClothType_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_ClothType_Details.Controls.Add(this.tb_Admin_Password);
            this.gb_ClothType_Details.Controls.Add(this.lbl_Admin_Password);
            this.gb_ClothType_Details.Controls.Add(this.lbl_Username);
            this.gb_ClothType_Details.Controls.Add(this.cmb_Username);
            this.gb_ClothType_Details.Controls.Add(this.cmb_UserRole);
            this.gb_ClothType_Details.Controls.Add(this.lbl_UserRole);
            this.gb_ClothType_Details.Font = new System.Drawing.Font("Lucida Bright", 7F);
            this.gb_ClothType_Details.ForeColor = System.Drawing.Color.Black;
            this.gb_ClothType_Details.Location = new System.Drawing.Point(70, 82);
            this.gb_ClothType_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ClothType_Details.Name = "gb_ClothType_Details";
            this.gb_ClothType_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ClothType_Details.Size = new System.Drawing.Size(1146, 486);
            this.gb_ClothType_Details.TabIndex = 20;
            this.gb_ClothType_Details.TabStop = false;
            this.gb_ClothType_Details.Text = "Delete User";
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.tb_Admin_Password.Location = new System.Drawing.Point(612, 322);
            this.tb_Admin_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Admin_Password.MaxLength = 40;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.Size = new System.Drawing.Size(402, 38);
            this.tb_Admin_Password.TabIndex = 3;
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(264, 323);
            this.lbl_Admin_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Admin_Password.Name = "lbl_Admin_Password";
            this.lbl_Admin_Password.Size = new System.Drawing.Size(247, 36);
            this.lbl_Admin_Password.TabIndex = 22;
            this.lbl_Admin_Password.Text = "Admin Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Username.Location = new System.Drawing.Point(264, 212);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(156, 36);
            this.lbl_Username.TabIndex = 21;
            this.lbl_Username.Text = "Username";
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(611, 214);
            this.cmb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Username.MaxLength = 20;
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(403, 37);
            this.cmb_Username.TabIndex = 1;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserRole.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_UserRole.Location = new System.Drawing.Point(611, 108);
            this.cmb_UserRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_UserRole.MaxLength = 20;
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(403, 37);
            this.cmb_UserRole.TabIndex = 1;
            this.cmb_UserRole.SelectedIndexChanged += new System.EventHandler(this.cmb_UserRole_SelectedIndexChanged);
            // 
            // lbl_UserRole
            // 
            this.lbl_UserRole.AutoSize = true;
            this.lbl_UserRole.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserRole.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_UserRole.Location = new System.Drawing.Point(264, 109);
            this.lbl_UserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserRole.Name = "lbl_UserRole";
            this.lbl_UserRole.Size = new System.Drawing.Size(147, 36);
            this.lbl_UserRole.TabIndex = 20;
            this.lbl_UserRole.Text = "User Role";
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Delete_User.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Delete_User.Location = new System.Drawing.Point(499, 606);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(281, 58);
            this.btn_Delete_User.TabIndex = 19;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // Frm_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.gb_ClothType_Details);
            this.Controls.Add(this.btn_Delete_User);
            this.Name = "Frm_Delete_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            this.gb_ClothType_Details.ResumeLayout(false);
            this.gb_ClothType_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ClothType_Details;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ComboBox cmb_Username;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.Label lbl_UserRole;
        private System.Windows.Forms.Button btn_Delete_User;
    }
}