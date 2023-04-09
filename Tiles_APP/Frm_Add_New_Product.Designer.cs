namespace Tiles_APP
{
    partial class Frm_Add_New_Product
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
            this.tb_Sales_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Rate = new System.Windows.Forms.Label();
            this.tb_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Rate = new System.Windows.Forms.Label();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.Cmb_Stock_Unit = new System.Windows.Forms.ComboBox();
            this.Cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            this.btn_Update_Product_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(411, 588);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 71);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Sales_Rate
            // 
            this.tb_Sales_Rate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Rate.Location = new System.Drawing.Point(905, 260);
            this.tb_Sales_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Rate.Name = "tb_Sales_Rate";
            this.tb_Sales_Rate.Size = new System.Drawing.Size(321, 39);
            this.tb_Sales_Rate.TabIndex = 8;
            this.tb_Sales_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Sales_Rate
            // 
            this.lbl_Sales_Rate.AutoSize = true;
            this.lbl_Sales_Rate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Rate.Location = new System.Drawing.Point(740, 264);
            this.lbl_Sales_Rate.Name = "lbl_Sales_Rate";
            this.lbl_Sales_Rate.Size = new System.Drawing.Size(154, 35);
            this.lbl_Sales_Rate.TabIndex = 69;
            this.lbl_Sales_Rate.Text = "Sales Rate ";
            // 
            // tb_Stock_Quantity
            // 
            this.tb_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Quantity.Location = new System.Drawing.Point(905, 361);
            this.tb_Stock_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Stock_Quantity.Name = "tb_Stock_Quantity";
            this.tb_Stock_Quantity.Size = new System.Drawing.Size(144, 39);
            this.tb_Stock_Quantity.TabIndex = 9;
            this.tb_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Stock_Quantity
            // 
            this.lbl_Stock_Quantity.AutoSize = true;
            this.lbl_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Quantity.Location = new System.Drawing.Point(684, 365);
            this.lbl_Stock_Quantity.Name = "lbl_Stock_Quantity";
            this.lbl_Stock_Quantity.Size = new System.Drawing.Size(212, 35);
            this.lbl_Stock_Quantity.TabIndex = 67;
            this.lbl_Stock_Quantity.Text = "Stock Quantity ";
            // 
            // tb_Purchase_Rate
            // 
            this.tb_Purchase_Rate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Rate.Location = new System.Drawing.Point(905, 157);
            this.tb_Purchase_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_Rate.Name = "tb_Purchase_Rate";
            this.tb_Purchase_Rate.Size = new System.Drawing.Size(321, 39);
            this.tb_Purchase_Rate.TabIndex = 7;
            this.tb_Purchase_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Purchase_Rate
            // 
            this.lbl_Purchase_Rate.AutoSize = true;
            this.lbl_Purchase_Rate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Rate.Location = new System.Drawing.Point(691, 157);
            this.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate";
            this.lbl_Purchase_Rate.Size = new System.Drawing.Size(204, 35);
            this.lbl_Purchase_Rate.TabIndex = 70;
            this.lbl_Purchase_Rate.Text = "Purchase Rate ";
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(63, 472);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(211, 35);
            this.lbl_Supplier_Name.TabIndex = 65;
            this.lbl_Supplier_Name.Text = "Supplier Name ";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(291, 368);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(368, 39);
            this.tb_Product_Name.TabIndex = 4;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(66, 368);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(205, 35);
            this.lbl_Product_Name.TabIndex = 63;
            this.lbl_Product_Name.Text = "Product Name ";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(905, 60);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date.MaxDate = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            this.dtp_Date.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(321, 39);
            this.dtp_Date.TabIndex = 6;
            this.dtp_Date.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(811, 60);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(82, 35);
            this.lbl_Date.TabIndex = 61;
            this.lbl_Date.Text = "Date ";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(55, 160);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Category_Name.TabIndex = 59;
            this.lbl_Category_Name.Text = "Category Name ";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(291, 60);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(368, 39);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(108, 59);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(166, 35);
            this.lbl_Product_ID.TabIndex = 57;
            this.lbl_Product_ID.Text = "Product ID ";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(13, 263);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(260, 35);
            this.lbl_Subcategory_Name.TabIndex = 59;
            this.lbl_Subcategory_Name.Text = "Subcategory Name ";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(291, 264);
            this.cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(368, 39);
            this.cmb_Subcategory_Name.TabIndex = 3;
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(291, 161);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(368, 39);
            this.Cmb_Category_Name.TabIndex = 2;
            this.Cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Category_Name_SelectedIndexChanged);
            // 
            // Cmb_Stock_Unit
            // 
            this.Cmb_Stock_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Stock_Unit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Stock_Unit.FormattingEnabled = true;
            this.Cmb_Stock_Unit.Items.AddRange(new object[] {
            "Unit",
            "Box"});
            this.Cmb_Stock_Unit.Location = new System.Drawing.Point(1072, 361);
            this.Cmb_Stock_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Stock_Unit.Name = "Cmb_Stock_Unit";
            this.Cmb_Stock_Unit.Size = new System.Drawing.Size(154, 39);
            this.Cmb_Stock_Unit.TabIndex = 10;
            // 
            // Cmb_Supplier_Name
            // 
            this.Cmb_Supplier_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Supplier_Name.FormattingEnabled = true;
            this.Cmb_Supplier_Name.Location = new System.Drawing.Point(291, 468);
            this.Cmb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Supplier_Name.Name = "Cmb_Supplier_Name";
            this.Cmb_Supplier_Name.Size = new System.Drawing.Size(368, 39);
            this.Cmb_Supplier_Name.TabIndex = 5;
            // 
            // btn_Update_Product_Details
            // 
            this.btn_Update_Product_Details.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Update_Product_Details.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product_Details.Location = new System.Drawing.Point(690, 588);
            this.btn_Update_Product_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update_Product_Details.Name = "btn_Update_Product_Details";
            this.btn_Update_Product_Details.Size = new System.Drawing.Size(462, 71);
            this.btn_Update_Product_Details.TabIndex = 71;
            this.btn_Update_Product_Details.Text = "Update Product Details";
            this.btn_Update_Product_Details.UseVisualStyleBackColor = false;
            this.btn_Update_Product_Details.Click += new System.EventHandler(this.btn_Update_Product_Details_Click);
            // 
            // Frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update_Product_Details);
            this.Controls.Add(this.Cmb_Supplier_Name);
            this.Controls.Add(this.Cmb_Stock_Unit);
            this.Controls.Add(this.cmb_Subcategory_Name);
            this.Controls.Add(this.Cmb_Category_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Sales_Rate);
            this.Controls.Add(this.lbl_Sales_Rate);
            this.Controls.Add(this.tb_Stock_Quantity);
            this.Controls.Add(this.lbl_Stock_Quantity);
            this.Controls.Add(this.tb_Purchase_Rate);
            this.Controls.Add(this.lbl_Purchase_Rate);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Subcategory_Name);
            this.Controls.Add(this.lbl_Category_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Product_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.Frm_Add_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Sales_Rate;
        private System.Windows.Forms.Label lbl_Sales_Rate;
        private System.Windows.Forms.TextBox tb_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Purchase_Rate;
        private System.Windows.Forms.Label lbl_Purchase_Rate;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.ComboBox Cmb_Stock_Unit;
        private System.Windows.Forms.ComboBox Cmb_Supplier_Name;
        private System.Windows.Forms.Button btn_Update_Product_Details;
    }
}