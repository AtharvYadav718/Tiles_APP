namespace Tiles_APP
{
    partial class Frm_Quotation
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
            this.dgv_Quotation = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Quotation_List = new System.Windows.Forms.Button();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Quotation_Custmer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_Customer_Name = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Quotation_No = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_No = new System.Windows.Forms.Label();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_All_Rate = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotation)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Quotation
            // 
            this.dgv_Quotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quotation.Location = new System.Drawing.Point(12, 263);
            this.dgv_Quotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Quotation.Name = "dgv_Quotation";
            this.dgv_Quotation.RowHeadersWidth = 51;
            this.dgv_Quotation.RowTemplate.Height = 24;
            this.dgv_Quotation.Size = new System.Drawing.Size(1251, 288);
            this.dgv_Quotation.TabIndex = 22;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(412, 640);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 52);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Quotation_List
            // 
            this.btn_Quotation_List.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Quotation_List.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quotation_List.Location = new System.Drawing.Point(655, 640);
            this.btn_Quotation_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quotation_List.Name = "btn_Quotation_List";
            this.btn_Quotation_List.Size = new System.Drawing.Size(293, 52);
            this.btn_Quotation_List.TabIndex = 28;
            this.btn_Quotation_List.Text = "Quotation List";
            this.btn_Quotation_List.UseVisualStyleBackColor = false;
            this.btn_Quotation_List.Click += new System.EventHandler(this.btn_Quotation_List_Click);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(994, 37);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(279, 34);
            this.tb_Mobile_No.TabIndex = 37;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(871, 46);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(122, 25);
            this.lbl_Mobile_No.TabIndex = 42;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // tb_Quotation_Custmer_Name
            // 
            this.tb_Quotation_Custmer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quotation_Custmer_Name.Location = new System.Drawing.Point(534, 33);
            this.tb_Quotation_Custmer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quotation_Custmer_Name.Name = "tb_Quotation_Custmer_Name";
            this.tb_Quotation_Custmer_Name.Size = new System.Drawing.Size(331, 39);
            this.tb_Quotation_Custmer_Name.TabIndex = 36;
            // 
            // lbl_Quotation_Customer_Name
            // 
            this.lbl_Quotation_Customer_Name.AutoSize = true;
            this.lbl_Quotation_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quotation_Customer_Name.Location = new System.Drawing.Point(289, 40);
            this.lbl_Quotation_Customer_Name.Name = "lbl_Quotation_Customer_Name";
            this.lbl_Quotation_Customer_Name.Size = new System.Drawing.Size(231, 25);
            this.lbl_Quotation_Customer_Name.TabIndex = 41;
            this.lbl_Quotation_Customer_Name.Text = "Quotation Cust.Name";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1112, 0);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(149, 31);
            this.dtp_Date.TabIndex = 40;
            // 
            // tb_Quotation_No
            // 
            this.tb_Quotation_No.Enabled = false;
            this.tb_Quotation_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quotation_No.Location = new System.Drawing.Point(179, 37);
            this.tb_Quotation_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quotation_No.Name = "tb_Quotation_No";
            this.tb_Quotation_No.Size = new System.Drawing.Size(104, 34);
            this.tb_Quotation_No.TabIndex = 39;
            // 
            // lbl_Quotation_No
            // 
            this.lbl_Quotation_No.AutoSize = true;
            this.lbl_Quotation_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quotation_No.Location = new System.Drawing.Point(8, 40);
            this.lbl_Quotation_No.Name = "lbl_Quotation_No";
            this.lbl_Quotation_No.Size = new System.Drawing.Size(154, 25);
            this.lbl_Quotation_No.TabIndex = 38;
            this.lbl_Quotation_No.Text = "Quotation No ";
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.Transparent;
            this.gb_Product_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Sales_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Sales_Price);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.tb_Unit);
            this.gb_Product_Details.Controls.Add(this.lbl_Unit);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.btn_All_Rate);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.cmb_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.Cmb_Category_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Details.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(7, 95);
            this.gb_Product_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Size = new System.Drawing.Size(1276, 144);
            this.gb_Product_Details.TabIndex = 43;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(189, 84);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(273, 34);
            this.cmb_Product_Name.TabIndex = 25;
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(1116, 84);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(157, 34);
            this.tb_Sales_Price.TabIndex = 8;
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(981, 87);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(126, 25);
            this.lbl_Sales_Price.TabIndex = 24;
            this.lbl_Sales_Price.Text = "Sales Price ";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(813, 81);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(157, 34);
            this.tb_Quantity.TabIndex = 7;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(703, 87);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(106, 25);
            this.lbl_Quantity.TabIndex = 22;
            this.lbl_Quantity.Text = "Quantity ";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit.Location = new System.Drawing.Point(553, 81);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(144, 34);
            this.tb_Unit.TabIndex = 6;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(477, 84);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(61, 25);
            this.lbl_Unit.TabIndex = 20;
            this.lbl_Unit.Text = "Unit ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1171, 18);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 46);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_All_Rate
            // 
            this.btn_All_Rate.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_All_Rate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All_Rate.Location = new System.Drawing.Point(1037, 18);
            this.btn_All_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_All_Rate.Name = "btn_All_Rate";
            this.btn_All_Rate.Size = new System.Drawing.Size(127, 46);
            this.btn_All_Rate.TabIndex = 18;
            this.btn_All_Rate.Text = "All Rate";
            this.btn_All_Rate.UseVisualStyleBackColor = false;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(8, 84);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(159, 25);
            this.lbl_Product_Name.TabIndex = 14;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(695, 22);
            this.cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(305, 34);
            this.cmb_Subcategory_Name.TabIndex = 4;
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(477, 28);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(203, 25);
            this.lbl_Subcategory_Name.TabIndex = 12;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(189, 26);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(273, 34);
            this.Cmb_Category_Name.TabIndex = 4;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(5, 30);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(170, 25);
            this.lbl_Category_Name.TabIndex = 10;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(156, 566);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(183, 39);
            this.tb_Total.TabIndex = 49;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(49, 569);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(81, 32);
            this.lbl_Total.TabIndex = 48;
            this.lbl_Total.Text = "Total ";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(454, 571);
            this.tb_GST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(164, 39);
            this.tb_GST.TabIndex = 44;
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(356, 571);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(76, 32);
            this.lbl_GST.TabIndex = 47;
            this.lbl_GST.Text = "GST ";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(852, 570);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(305, 39);
            this.tb_Total_Amount.TabIndex = 45;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(641, 575);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(183, 32);
            this.lbl_Total_Amount.TabIndex = 46;
            this.lbl_Total_Amount.Text = "Total Amount ";
            // 
            // Frm_Quotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.tb_GST);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.tb_Quotation_Custmer_Name);
            this.Controls.Add(this.lbl_Quotation_Customer_Name);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Quotation_No);
            this.Controls.Add(this.lbl_Quotation_No);
            this.Controls.Add(this.btn_Quotation_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgv_Quotation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Quotation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotation)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Quotation;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Quotation_List;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Quotation_Custmer_Name;
        private System.Windows.Forms.Label lbl_Quotation_Customer_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Quotation_No;
        private System.Windows.Forms.Label lbl_Quotation_No;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_All_Rate;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
    }
}