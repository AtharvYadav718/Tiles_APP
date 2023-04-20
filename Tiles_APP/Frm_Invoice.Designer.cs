namespace Tiles_APP
{
    partial class Frm_Invoice_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.Cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_All_Rate = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.Cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.dtp_Invoice_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Invoice_No = new System.Windows.Forms.TextBox();
            this.lbl_Invoice_No = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.dgv_Invoice_Details = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.tb_Balance_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Balance_Amount = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Paying_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.gb_Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.Transparent;
            this.gb_Product_Details.Controls.Add(this.tb_Sales_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Sales_Price);
            this.gb_Product_Details.Controls.Add(this.Cmb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Total);
            this.gb_Product_Details.Controls.Add(this.lbl_Total);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.tb_Unit);
            this.gb_Product_Details.Controls.Add(this.lbl_Unit);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.btn_All_Rate);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.Cmb_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.Cmb_Category_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Details.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(12, 61);
            this.gb_Product_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Size = new System.Drawing.Size(1261, 134);
            this.gb_Product_Details.TabIndex = 28;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Enabled = false;
            this.tb_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(974, 85);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(94, 34);
            this.tb_Sales_Price.TabIndex = 53;
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(841, 91);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(125, 26);
            this.lbl_Sales_Price.TabIndex = 54;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // Cmb_Product_Name
            // 
            this.Cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Product_Name.FormattingEnabled = true;
            this.Cmb_Product_Name.Location = new System.Drawing.Point(176, 85);
            this.Cmb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Product_Name.Name = "Cmb_Product_Name";
            this.Cmb_Product_Name.Size = new System.Drawing.Size(260, 34);
            this.Cmb_Product_Name.TabIndex = 5;
            this.Cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Product_Name_SelectedIndexChanged);
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(1142, 85);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(113, 34);
            this.tb_Total.TabIndex = 9;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(1074, 91);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(64, 26);
            this.lbl_Total.TabIndex = 24;
            this.lbl_Total.Text = "Total";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(554, 88);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(98, 34);
            this.tb_Quantity.TabIndex = 6;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Quantity.Leave += new System.EventHandler(this.tb_Quantity_Leave);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(442, 91);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(110, 26);
            this.lbl_Quantity.TabIndex = 22;
            this.lbl_Quantity.Text = "Quantity ";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Enabled = false;
            this.tb_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit.Location = new System.Drawing.Point(725, 88);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(110, 34);
            this.tb_Unit.TabIndex = 7;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(658, 94);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(63, 26);
            this.lbl_Unit.TabIndex = 20;
            this.lbl_Unit.Text = "Unit ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1148, 26);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 46);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_All_Rate
            // 
            this.btn_All_Rate.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_All_Rate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All_Rate.Location = new System.Drawing.Point(1009, 26);
            this.btn_All_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_All_Rate.Name = "btn_All_Rate";
            this.btn_All_Rate.Size = new System.Drawing.Size(127, 46);
            this.btn_All_Rate.TabIndex = 18;
            this.btn_All_Rate.Text = "All Rate";
            this.btn_All_Rate.UseVisualStyleBackColor = false;
            this.btn_All_Rate.Click += new System.EventHandler(this.btn_All_Rate_Click);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(8, 88);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(160, 26);
            this.lbl_Product_Name.TabIndex = 14;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // Cmb_Subcategory_Name
            // 
            this.Cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Subcategory_Name.FormattingEnabled = true;
            this.Cmb_Subcategory_Name.Location = new System.Drawing.Point(675, 32);
            this.Cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Subcategory_Name.Name = "Cmb_Subcategory_Name";
            this.Cmb_Subcategory_Name.Size = new System.Drawing.Size(299, 34);
            this.Cmb_Subcategory_Name.TabIndex = 4;
            this.Cmb_Subcategory_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_Name_SelectedIndexChanged);
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(460, 36);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(205, 26);
            this.lbl_Subcategory_Name.TabIndex = 12;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(181, 34);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(273, 34);
            this.Cmb_Category_Name.TabIndex = 3;
            this.Cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(5, 36);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(172, 26);
            this.lbl_Category_Name.TabIndex = 10;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Enabled = false;
            this.tb_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(715, 11);
            this.tb_Customer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(304, 39);
            this.tb_Customer_Name.TabIndex = 3;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(527, 18);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(183, 26);
            this.lbl_Customer_Name.TabIndex = 26;
            this.lbl_Customer_Name.Text = " Customer Name";
            // 
            // dtp_Invoice_Date
            // 
            this.dtp_Invoice_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Invoice_Date.Location = new System.Drawing.Point(1102, 15);
            this.dtp_Invoice_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Invoice_Date.Name = "dtp_Invoice_Date";
            this.dtp_Invoice_Date.Size = new System.Drawing.Size(171, 34);
            this.dtp_Invoice_Date.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1030, 18);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(66, 26);
            this.lbl_Date.TabIndex = 24;
            this.lbl_Date.Text = "Date ";
            // 
            // tb_Invoice_No
            // 
            this.tb_Invoice_No.Enabled = false;
            this.tb_Invoice_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Invoice_No.Location = new System.Drawing.Point(136, 14);
            this.tb_Invoice_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Invoice_No.Name = "tb_Invoice_No";
            this.tb_Invoice_No.Size = new System.Drawing.Size(105, 34);
            this.tb_Invoice_No.TabIndex = 23;
            // 
            // lbl_Invoice_No
            // 
            this.lbl_Invoice_No.AutoSize = true;
            this.lbl_Invoice_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invoice_No.Location = new System.Drawing.Point(5, 18);
            this.lbl_Invoice_No.Name = "lbl_Invoice_No";
            this.lbl_Invoice_No.Size = new System.Drawing.Size(127, 26);
            this.lbl_Invoice_No.TabIndex = 22;
            this.lbl_Invoice_No.Text = "Invoice No ";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(412, 15);
            this.tb_Customer_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(109, 34);
            this.tb_Customer_ID.TabIndex = 1;
            this.tb_Customer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Customer_ID.Leave += new System.EventHandler(this.tb_Customer_ID_Leave);
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(257, 18);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(150, 26);
            this.lbl_Customer_ID.TabIndex = 29;
            this.lbl_Customer_ID.Text = "Customer ID ";
            // 
            // dgv_Invoice_Details
            // 
            this.dgv_Invoice_Details.AllowUserToAddRows = false;
            this.dgv_Invoice_Details.AllowUserToDeleteRows = false;
            this.dgv_Invoice_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoice_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoice_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoice_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Category_Name,
            this.Subcategory_Name,
            this.Product_Name,
            this.Quantity,
            this.Unit,
            this.Sales_Rate,
            this.Total});
            this.dgv_Invoice_Details.Location = new System.Drawing.Point(12, 199);
            this.dgv_Invoice_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Invoice_Details.Name = "dgv_Invoice_Details";
            this.dgv_Invoice_Details.ReadOnly = true;
            this.dgv_Invoice_Details.RowHeadersWidth = 51;
            this.dgv_Invoice_Details.RowTemplate.Height = 24;
            this.dgv_Invoice_Details.Size = new System.Drawing.Size(1261, 298);
            this.dgv_Invoice_Details.TabIndex = 31;
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr No";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "Category";
            this.Category_Name.MinimumWidth = 6;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // Subcategory_Name
            // 
            this.Subcategory_Name.HeaderText = "Subcategory";
            this.Subcategory_Name.MinimumWidth = 6;
            this.Subcategory_Name.Name = "Subcategory_Name";
            this.Subcategory_Name.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product ";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Sales_Rate
            // 
            this.Sales_Rate.HeaderText = "Sales Rate";
            this.Sales_Rate.MinimumWidth = 6;
            this.Sales_Rate.Name = "Sales_Rate";
            this.Sales_Rate.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(591, 637);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 55);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Cmb_Payment_Mode
            // 
            this.Cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Payment_Mode.FormattingEnabled = true;
            this.Cmb_Payment_Mode.Items.AddRange(new object[] {
            "Cash",
            "Online",
            "Card"});
            this.Cmb_Payment_Mode.Location = new System.Drawing.Point(1016, 583);
            this.Cmb_Payment_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Payment_Mode.Name = "Cmb_Payment_Mode";
            this.Cmb_Payment_Mode.Size = new System.Drawing.Size(223, 34);
            this.Cmb_Payment_Mode.TabIndex = 11;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(833, 589);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(173, 26);
            this.lbl_Payment_Mode.TabIndex = 49;
            this.lbl_Payment_Mode.Text = "Payment Mode ";
            // 
            // tb_Balance_Amount
            // 
            this.tb_Balance_Amount.Enabled = false;
            this.tb_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Balance_Amount.Location = new System.Drawing.Point(591, 583);
            this.tb_Balance_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Balance_Amount.Name = "tb_Balance_Amount";
            this.tb_Balance_Amount.Size = new System.Drawing.Size(225, 34);
            this.tb_Balance_Amount.TabIndex = 14;
            this.tb_Balance_Amount.Text = "0";
            // 
            // lbl_Balance_Amount
            // 
            this.lbl_Balance_Amount.AutoSize = true;
            this.lbl_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance_Amount.Location = new System.Drawing.Point(393, 583);
            this.lbl_Balance_Amount.Name = "lbl_Balance_Amount";
            this.lbl_Balance_Amount.Size = new System.Drawing.Size(187, 26);
            this.lbl_Balance_Amount.TabIndex = 47;
            this.lbl_Balance_Amount.Text = "Balance Amount ";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(1016, 514);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(223, 34);
            this.tb_Total_Amount.TabIndex = 12;
            this.tb_Total_Amount.Text = "0";
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(851, 518);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(157, 26);
            this.lbl_Total_Amount.TabIndex = 39;
            this.lbl_Total_Amount.Text = "Total Amount ";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(591, 514);
            this.tb_GST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(225, 34);
            this.tb_GST.TabIndex = 9;
            this.tb_GST.Text = "0";
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(509, 522);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(64, 26);
            this.lbl_GST.TabIndex = 40;
            this.lbl_GST.Text = "GST ";
            // 
            // tb_Paying_Amount
            // 
            this.tb_Paying_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paying_Amount.Location = new System.Drawing.Point(205, 580);
            this.tb_Paying_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Paying_Amount.Name = "tb_Paying_Amount";
            this.tb_Paying_Amount.Size = new System.Drawing.Size(181, 34);
            this.tb_Paying_Amount.TabIndex = 10;
            this.tb_Paying_Amount.Text = "0";
            this.tb_Paying_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Paying_Amount.Leave += new System.EventHandler(this.Paid_Amount);
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(27, 583);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(152, 26);
            this.lbl_Paid_Amount.TabIndex = 41;
            this.lbl_Paid_Amount.Text = "Paid Amount ";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(205, 514);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(181, 34);
            this.tb_Discount.TabIndex = 8;
            this.tb_Discount.Text = "0";
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(85, 518);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(108, 26);
            this.lbl_Discount.TabIndex = 42;
            this.lbl_Discount.Text = "Discount ";
            // 
            // Frm_Invoice_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Cmb_Payment_Mode);
            this.Controls.Add(this.lbl_Payment_Mode);
            this.Controls.Add(this.tb_Balance_Amount);
            this.Controls.Add(this.lbl_Balance_Amount);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.tb_GST);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.tb_Paying_Amount);
            this.Controls.Add(this.lbl_Paid_Amount);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.dgv_Invoice_Details);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Customer_ID);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.dtp_Invoice_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.tb_Invoice_No);
            this.Controls.Add(this.lbl_Invoice_No);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Invoice_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Frm_Invoice_Details_Load);
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_All_Rate;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox Cmb_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.DateTimePicker dtp_Invoice_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Invoice_No;
        private System.Windows.Forms.Label lbl_Invoice_No;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.DataGridView dgv_Invoice_Details;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox Cmb_Payment_Mode;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.TextBox tb_Balance_Amount;
        private System.Windows.Forms.Label lbl_Balance_Amount;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Paying_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.ComboBox Cmb_Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.Label lbl_Sales_Price;
    }
}