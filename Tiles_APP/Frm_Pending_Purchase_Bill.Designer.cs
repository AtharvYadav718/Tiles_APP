namespace Tiles_APP
{
    partial class Frm_Purchase_Pending_Bill
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
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.lbl_Purchase_Pending_Bill = new System.Windows.Forms.Label();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Purchase_ID = new System.Windows.Forms.Label();
            this.tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.tb_Purchase_ID = new System.Windows.Forms.TextBox();
            this.tb_Balance_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Balance_Amount = new System.Windows.Forms.Label();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_Paid_Amount = new System.Windows.Forms.TextBox();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.tb_Paying_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paying = new System.Windows.Forms.Label();
            this.dtp_Purchase_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.pnl_Head.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Head.Controls.Add(this.lbl_Purchase_Pending_Bill);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1285, 126);
            this.pnl_Head.TabIndex = 1;
            // 
            // lbl_Purchase_Pending_Bill
            // 
            this.lbl_Purchase_Pending_Bill.AutoSize = true;
            this.lbl_Purchase_Pending_Bill.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Purchase_Pending_Bill.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Purchase_Pending_Bill.Location = new System.Drawing.Point(261, 25);
            this.lbl_Purchase_Pending_Bill.Name = "lbl_Purchase_Pending_Bill";
            this.lbl_Purchase_Pending_Bill.Size = new System.Drawing.Size(725, 69);
            this.lbl_Purchase_Pending_Bill.TabIndex = 0;
            this.lbl_Purchase_Pending_Bill.Text = " Purchase Pending Bill";
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "CASH",
            "ONLINE",
            "Card"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(945, 535);
            this.cmb_Payment_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(223, 34);
            this.cmb_Payment_Mode.TabIndex = 3;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(727, 537);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(201, 32);
            this.lbl_Payment_Mode.TabIndex = 61;
            this.lbl_Payment_Mode.Text = "Payment Mode ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(586, 631);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 58);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.lbl_Supplier_Name);
            this.panel1.Controls.Add(this.lbl_Purchase_ID);
            this.panel1.Controls.Add(this.tb_Supplier_Name);
            this.panel1.Controls.Add(this.tb_Purchase_ID);
            this.panel1.Controls.Add(this.tb_Balance_Amount);
            this.panel1.Controls.Add(this.lbl_Balance_Amount);
            this.panel1.Controls.Add(this.lbl_Total_Amount);
            this.panel1.Controls.Add(this.tb_Paid_Amount);
            this.panel1.Controls.Add(this.tb_Total_Amount);
            this.panel1.Controls.Add(this.lbl_Paid_Amount);
            this.panel1.Location = new System.Drawing.Point(33, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 312);
            this.panel1.TabIndex = 60;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(462, 67);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(199, 32);
            this.lbl_Supplier_Name.TabIndex = 29;
            this.lbl_Supplier_Name.Text = "Supplier Name ";
            // 
            // lbl_Purchase_ID
            // 
            this.lbl_Purchase_ID.AutoSize = true;
            this.lbl_Purchase_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_ID.Location = new System.Drawing.Point(55, 67);
            this.lbl_Purchase_ID.Name = "lbl_Purchase_ID";
            this.lbl_Purchase_ID.Size = new System.Drawing.Size(168, 32);
            this.lbl_Purchase_ID.TabIndex = 28;
            this.lbl_Purchase_ID.Text = "Purchase ID ";
            // 
            // tb_Supplier_Name
            // 
            this.tb_Supplier_Name.Enabled = false;
            this.tb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Name.Location = new System.Drawing.Point(692, 65);
            this.tb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Supplier_Name.Name = "tb_Supplier_Name";
            this.tb_Supplier_Name.Size = new System.Drawing.Size(373, 34);
            this.tb_Supplier_Name.TabIndex = 26;
            // 
            // tb_Purchase_ID
            // 
            this.tb_Purchase_ID.Enabled = false;
            this.tb_Purchase_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_ID.Location = new System.Drawing.Point(255, 65);
            this.tb_Purchase_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_ID.Name = "tb_Purchase_ID";
            this.tb_Purchase_ID.Size = new System.Drawing.Size(157, 34);
            this.tb_Purchase_ID.TabIndex = 26;
            // 
            // tb_Balance_Amount
            // 
            this.tb_Balance_Amount.Enabled = false;
            this.tb_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Balance_Amount.Location = new System.Drawing.Point(1040, 193);
            this.tb_Balance_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Balance_Amount.Name = "tb_Balance_Amount";
            this.tb_Balance_Amount.Size = new System.Drawing.Size(165, 34);
            this.tb_Balance_Amount.TabIndex = 41;
            this.tb_Balance_Amount.Text = "0";
            // 
            // lbl_Balance_Amount
            // 
            this.lbl_Balance_Amount.AutoSize = true;
            this.lbl_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance_Amount.Location = new System.Drawing.Point(806, 195);
            this.lbl_Balance_Amount.Name = "lbl_Balance_Amount";
            this.lbl_Balance_Amount.Size = new System.Drawing.Size(219, 32);
            this.lbl_Balance_Amount.TabIndex = 43;
            this.lbl_Balance_Amount.Text = "Balance Amount ";
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(19, 191);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(183, 32);
            this.lbl_Total_Amount.TabIndex = 38;
            this.lbl_Total_Amount.Text = "Total Amount ";
            // 
            // tb_Paid_Amount
            // 
            this.tb_Paid_Amount.Enabled = false;
            this.tb_Paid_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_Amount.Location = new System.Drawing.Point(607, 193);
            this.tb_Paid_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Paid_Amount.Name = "tb_Paid_Amount";
            this.tb_Paid_Amount.Size = new System.Drawing.Size(181, 34);
            this.tb_Paid_Amount.TabIndex = 40;
            this.tb_Paid_Amount.Text = "0";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(217, 189);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(174, 34);
            this.tb_Total_Amount.TabIndex = 36;
            this.tb_Total_Amount.Text = "0";
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(413, 191);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(179, 32);
            this.lbl_Paid_Amount.TabIndex = 42;
            this.lbl_Paid_Amount.Text = "Paid Amount ";
            // 
            // tb_Paying_Amount
            // 
            this.tb_Paying_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paying_Amount.Location = new System.Drawing.Point(389, 539);
            this.tb_Paying_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Paying_Amount.Name = "tb_Paying_Amount";
            this.tb_Paying_Amount.Size = new System.Drawing.Size(181, 34);
            this.tb_Paying_Amount.TabIndex = 2;
            this.tb_Paying_Amount.Text = "0";
            this.tb_Paying_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Paying
            // 
            this.lbl_Paying.AutoSize = true;
            this.lbl_Paying.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paying.Location = new System.Drawing.Point(157, 537);
            this.lbl_Paying.Name = "lbl_Paying";
            this.lbl_Paying.Size = new System.Drawing.Size(207, 32);
            this.lbl_Paying.TabIndex = 59;
            this.lbl_Paying.Text = "Paying Amount ";
            // 
            // dtp_Purchase_Date
            // 
            this.dtp_Purchase_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Purchase_Date.Location = new System.Drawing.Point(983, 142);
            this.dtp_Purchase_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Purchase_Date.Name = "dtp_Purchase_Date";
            this.dtp_Purchase_Date.Size = new System.Drawing.Size(255, 34);
            this.dtp_Purchase_Date.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(901, 148);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(60, 25);
            this.lbl_Date.TabIndex = 63;
            this.lbl_Date.Text = "Date";
            // 
            // Frm_Purchase_Pending_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cmb_Payment_Mode);
            this.Controls.Add(this.lbl_Payment_Mode);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Paying_Amount);
            this.Controls.Add(this.lbl_Paying);
            this.Controls.Add(this.dtp_Purchase_Date);
            this.Controls.Add(this.pnl_Head);
            this.Name = "Frm_Purchase_Pending_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Purchase Bill";
            this.Load += new System.EventHandler(this.Frm_Purchase_Pending_Bill_Load);
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Head;
        private System.Windows.Forms.Label lbl_Purchase_Pending_Bill;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Purchase_ID;
        private System.Windows.Forms.TextBox tb_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Purchase_ID;
        private System.Windows.Forms.TextBox tb_Balance_Amount;
        private System.Windows.Forms.Label lbl_Balance_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Paying_Amount;
        private System.Windows.Forms.Label lbl_Paying;
        private System.Windows.Forms.DateTimePicker dtp_Purchase_Date;
        private System.Windows.Forms.Label lbl_Date;
    }
}