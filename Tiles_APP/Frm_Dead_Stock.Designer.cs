namespace Tiles_APP
{
    partial class Frm_Dead_Stock
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
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Dead_Date = new System.Windows.Forms.Label();
            this.tb_Dead_No = new System.Windows.Forms.TextBox();
            this.lbl_Dead_No = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(577, 618);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 63);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Enabled = false;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(490, 326);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(358, 39);
            this.tb_Purchase_Price.TabIndex = 7;
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(229, 329);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(215, 34);
            this.lbl_Purchase_Price.TabIndex = 39;
            this.lbl_Purchase_Price.Text = "Purchase Price ";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Enabled = false;
            this.tb_Unit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit.Location = new System.Drawing.Point(703, 244);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(140, 39);
            this.tb_Unit.TabIndex = 6;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(491, 176);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(357, 39);
            this.cmb_Product_Name.TabIndex = 4;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(491, 244);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(143, 39);
            this.tb_Quantity.TabIndex = 5;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Quantity.Leave += new System.EventHandler(this.tb_Quantity_Leave);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Quantity.Location = new System.Drawing.Point(305, 250);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(143, 34);
            this.lbl_Quantity.TabIndex = 22;
            this.lbl_Quantity.Text = "Quantity ";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Product_Name.Location = new System.Drawing.Point(235, 178);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(202, 34);
            this.lbl_Product_Name.TabIndex = 14;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(491, 111);
            this.cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(357, 39);
            this.cmb_Subcategory_Name.TabIndex = 3;
            this.cmb_Subcategory_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_Name_SelectedIndexChanged);
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(184, 114);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(260, 34);
            this.lbl_Subcategory_Name.TabIndex = 12;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(491, 52);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(357, 39);
            this.Cmb_Category_Name.TabIndex = 2;
            this.Cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Category_Name.Location = new System.Drawing.Point(224, 55);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(220, 34);
            this.lbl_Category_Name.TabIndex = 10;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(916, 33);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(285, 34);
            this.dtp_Date.TabIndex = 1;
            // 
            // lbl_Dead_Date
            // 
            this.lbl_Dead_Date.AutoSize = true;
            this.lbl_Dead_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dead_Date.Location = new System.Drawing.Point(785, 36);
            this.lbl_Dead_Date.Name = "lbl_Dead_Date";
            this.lbl_Dead_Date.Size = new System.Drawing.Size(125, 25);
            this.lbl_Dead_Date.TabIndex = 30;
            this.lbl_Dead_Date.Text = "Dead Date ";
            // 
            // tb_Dead_No
            // 
            this.tb_Dead_No.Enabled = false;
            this.tb_Dead_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dead_No.Location = new System.Drawing.Point(227, 39);
            this.tb_Dead_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Dead_No.Name = "tb_Dead_No";
            this.tb_Dead_No.Size = new System.Drawing.Size(157, 34);
            this.tb_Dead_No.TabIndex = 29;
            // 
            // lbl_Dead_No
            // 
            this.lbl_Dead_No.AutoSize = true;
            this.lbl_Dead_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dead_No.Location = new System.Drawing.Point(107, 42);
            this.lbl_Dead_No.Name = "lbl_Dead_No";
            this.lbl_Dead_No.Size = new System.Drawing.Size(106, 25);
            this.lbl_Dead_No.TabIndex = 28;
            this.lbl_Dead_No.Text = "Dead No ";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(491, 399);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(357, 39);
            this.tb_Total_Amount.TabIndex = 10;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Total_Amount.Location = new System.Drawing.Point(244, 399);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(205, 34);
            this.lbl_Total_Amount.TabIndex = 35;
            this.lbl_Total_Amount.Text = "Total Amount ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Cmb_Category_Name);
            this.panel1.Controls.Add(this.tb_Total_Amount);
            this.panel1.Controls.Add(this.tb_Purchase_Price);
            this.panel1.Controls.Add(this.lbl_Total_Amount);
            this.panel1.Controls.Add(this.lbl_Category_Name);
            this.panel1.Controls.Add(this.lbl_Purchase_Price);
            this.panel1.Controls.Add(this.cmb_Subcategory_Name);
            this.panel1.Controls.Add(this.lbl_Subcategory_Name);
            this.panel1.Controls.Add(this.cmb_Product_Name);
            this.panel1.Controls.Add(this.tb_Unit);
            this.panel1.Controls.Add(this.lbl_Product_Name);
            this.panel1.Controls.Add(this.tb_Quantity);
            this.panel1.Controls.Add(this.lbl_Quantity);
            this.panel1.Location = new System.Drawing.Point(87, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 472);
            this.panel1.TabIndex = 40;
            // 
            // Frm_Dead_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Dead_Date);
            this.Controls.Add(this.tb_Dead_No);
            this.Controls.Add(this.lbl_Dead_No);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Dead_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead Stock";
            this.Load += new System.EventHandler(this.Frm_Dead_Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Dead_Date;
        private System.Windows.Forms.TextBox tb_Dead_No;
        private System.Windows.Forms.Label lbl_Dead_No;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Panel panel1;
    }
}