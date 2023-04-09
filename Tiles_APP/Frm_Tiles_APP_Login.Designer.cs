namespace Tiles_APP
{
    partial class Frm_Tiles_APP_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tiles_APP_Login));
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.lbl_Tiles_APP = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.Cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.pnl_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Head.Controls.Add(this.lbl_Tiles_APP);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1282, 126);
            this.pnl_Head.TabIndex = 0;
            // 
            // lbl_Tiles_APP
            // 
            this.lbl_Tiles_APP.AutoSize = true;
            this.lbl_Tiles_APP.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Tiles_APP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Tiles_APP.Location = new System.Drawing.Point(424, 30);
            this.lbl_Tiles_APP.Name = "lbl_Tiles_APP";
            this.lbl_Tiles_APP.Size = new System.Drawing.Size(322, 69);
            this.lbl_Tiles_APP.TabIndex = 0;
            this.lbl_Tiles_APP.Text = "Tiles APP";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.Location = new System.Drawing.Point(714, 222);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(156, 37);
            this.lbl_User_Role.TabIndex = 2;
            this.lbl_User_Role.Text = "User Role";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(712, 348);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(160, 37);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(715, 479);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(151, 37);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // Cmb_User_Role
            // 
            this.Cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_User_Role.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_User_Role.FormattingEnabled = true;
            this.Cmb_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Worker"});
            this.Cmb_User_Role.Location = new System.Drawing.Point(898, 223);
            this.Cmb_User_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_User_Role.Name = "Cmb_User_Role";
            this.Cmb_User_Role.Size = new System.Drawing.Size(305, 39);
            this.Cmb_User_Role.TabIndex = 1;
            this.Cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.Cmb_User_Role_SelectedIndexChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(898, 479);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(305, 39);
            this.tb_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(845, 611);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(184, 64);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Worker"});
            this.cmb_Username.Location = new System.Drawing.Point(898, 351);
            this.cmb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(305, 39);
            this.cmb_Username.TabIndex = 7;
            // 
            // Frm_Tiles_APP_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.cmb_Username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.Cmb_User_Role);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_User_Role);
            this.Controls.Add(this.pnl_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Tiles_APP_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP LOGIN";
            this.Load += new System.EventHandler(this.Frm_Tiles_APP_Login_Load);
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Head;
        private System.Windows.Forms.Label lbl_Tiles_APP;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ComboBox Cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_Username;
    }
}

