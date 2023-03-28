namespace Tiles_APP
{
    partial class Frm_Purchase_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Purchase_ID = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_ID = new System.Windows.Forms.Label();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.Cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Unit = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.dgv_Purchase_Details = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paying_Amount = new System.Windows.Forms.Label();
            this.tb_Paying_Amount = new System.Windows.Forms.TextBox();
            this.tb_Balance_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Balance_Amount = new System.Windows.Forms.Label();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_Purchase_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            this.gb_Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(359, 24);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(166, 25);
            this.lbl_Supplier_Name.TabIndex = 25;
            this.lbl_Supplier_Name.Text = "Supplier Name ";
            // 
            // tb_Purchase_ID
            // 
            this.tb_Purchase_ID.Enabled = false;
            this.tb_Purchase_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_ID.Location = new System.Drawing.Point(175, 20);
            this.tb_Purchase_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_ID.Name = "tb_Purchase_ID";
            this.tb_Purchase_ID.Size = new System.Drawing.Size(157, 34);
            this.tb_Purchase_ID.TabIndex = 22;
            // 
            // lbl_Purchase_ID
            // 
            this.lbl_Purchase_ID.AutoSize = true;
            this.lbl_Purchase_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_ID.Location = new System.Drawing.Point(7, 24);
            this.lbl_Purchase_ID.Name = "lbl_Purchase_ID";
            this.lbl_Purchase_ID.Size = new System.Drawing.Size(144, 25);
            this.lbl_Purchase_ID.TabIndex = 21;
            this.lbl_Purchase_ID.Text = "Purchase ID ";
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.Transparent;
            this.gb_Product_Details.Controls.Add(this.tb_Total);
            this.gb_Product_Details.Controls.Add(this.lbl_Total);
            this.gb_Product_Details.Controls.Add(this.Cmb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Sales_Price);
            this.gb_Product_Details.Controls.Add(this.label1);
            this.gb_Product_Details.Controls.Add(this.tb_Purchase_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.tb_Unit);
            this.gb_Product_Details.Controls.Add(this.lbl_Purchase_Unit);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.cmb_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Product_Details.Controls.Add(this.Cmb_Category_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Product_Details.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(0, 74);
            this.gb_Product_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Product_Details.Size = new System.Drawing.Size(1280, 180);
            this.gb_Product_Details.TabIndex = 29;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(927, 131);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(260, 34);
            this.tb_Total.TabIndex = 10;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(828, 134);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(68, 25);
            this.lbl_Total.TabIndex = 33;
            this.lbl_Total.Text = "Total ";
            // 
            // Cmb_Product_Name
            // 
            this.Cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Product_Name.FormattingEnabled = true;
            this.Cmb_Product_Name.Location = new System.Drawing.Point(202, 78);
            this.Cmb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Product_Name.Name = "Cmb_Product_Name";
            this.Cmb_Product_Name.Size = new System.Drawing.Size(346, 34);
            this.Cmb_Product_Name.TabIndex = 5;
            this.Cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Product_Name_SelectedIndexChanged);
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Enabled = false;
            this.tb_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(592, 130);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(211, 34);
            this.tb_Sales_Price.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sales Price ";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Enabled = false;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(213, 130);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(221, 34);
            this.tb_Purchase_Price.TabIndex = 8;
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(27, 134);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(170, 25);
            this.lbl_Purchase_Price.TabIndex = 24;
            this.lbl_Purchase_Price.Text = "Purchase Price ";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Enabled = false;
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(671, 75);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(181, 34);
            this.tb_Quantity.TabIndex = 6;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Quantity.Leave += new System.EventHandler(this.tb_Quantity_Leave);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(559, 84);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(106, 25);
            this.lbl_Quantity.TabIndex = 22;
            this.lbl_Quantity.Text = "Quantity ";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Enabled = false;
            this.tb_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit.Location = new System.Drawing.Point(1051, 75);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(201, 34);
            this.tb_Unit.TabIndex = 7;
            // 
            // lbl_Purchase_Unit
            // 
            this.lbl_Purchase_Unit.AutoSize = true;
            this.lbl_Purchase_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Unit.Location = new System.Drawing.Point(874, 78);
            this.lbl_Purchase_Unit.Name = "lbl_Purchase_Unit";
            this.lbl_Purchase_Unit.Size = new System.Drawing.Size(161, 25);
            this.lbl_Purchase_Unit.TabIndex = 20;
            this.lbl_Purchase_Unit.Text = "Purchase Unit ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1125, 19);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(148, 46);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(31, 81);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(165, 25);
            this.lbl_Product_Name.TabIndex = 14;
            this.lbl_Product_Name.Text = "Product Name ";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(793, 25);
            this.cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(316, 34);
            this.cmb_Subcategory_Name.TabIndex = 4;
            this.cmb_Subcategory_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_Name_SelectedIndexChanged);
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(566, 30);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(209, 25);
            this.lbl_Subcategory_Name.TabIndex = 12;
            this.lbl_Subcategory_Name.Text = "Subcategory Name ";
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(215, 25);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(333, 34);
            this.Cmb_Category_Name.TabIndex = 3;
            this.Cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(33, 30);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(176, 25);
            this.lbl_Category_Name.TabIndex = 10;
            this.lbl_Category_Name.Text = "Category Name ";
            // 
            // dgv_Purchase_Details
            // 
            this.dgv_Purchase_Details.AllowUserToAddRows = false;
            this.dgv_Purchase_Details.AllowUserToDeleteRows = false;
            this.dgv_Purchase_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Purchase_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Category,
            this.Subcategory_Name,
            this.Product_Name,
            this.Quantity,
            this.Purchase_Unit,
            this.Purchase_Price,
            this.Sales_Price,
            this.Total});
            this.dgv_Purchase_Details.Location = new System.Drawing.Point(12, 258);
            this.dgv_Purchase_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Purchase_Details.Name = "dgv_Purchase_Details";
            this.dgv_Purchase_Details.ReadOnly = true;
            this.dgv_Purchase_Details.RowHeadersWidth = 51;
            this.dgv_Purchase_Details.RowTemplate.Height = 24;
            this.dgv_Purchase_Details.Size = new System.Drawing.Size(1261, 249);
            this.dgv_Purchase_Details.TabIndex = 30;
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr No";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
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
            this.Product_Name.HeaderText = "Product";
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
            // Purchase_Unit
            // 
            this.Purchase_Unit.HeaderText = "Purchase Unit";
            this.Purchase_Unit.MinimumWidth = 6;
            this.Purchase_Unit.Name = "Purchase_Unit";
            this.Purchase_Unit.ReadOnly = true;
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.HeaderText = "Purchase Price";
            this.Purchase_Price.MinimumWidth = 6;
            this.Purchase_Price.Name = "Purchase_Price";
            this.Purchase_Price.ReadOnly = true;
            // 
            // Sales_Price
            // 
            this.Sales_Price.HeaderText = "Sales Price";
            this.Sales_Price.MinimumWidth = 6;
            this.Sales_Price.Name = "Sales_Price";
            this.Sales_Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(212, 529);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(181, 34);
            this.tb_Discount.TabIndex = 12;
            this.tb_Discount.Text = "0";
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(92, 532);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(106, 25);
            this.lbl_Discount.TabIndex = 31;
            this.lbl_Discount.Text = "Discount ";
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(515, 538);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(64, 25);
            this.lbl_GST.TabIndex = 31;
            this.lbl_GST.Text = "GST ";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(597, 529);
            this.tb_GST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(225, 34);
            this.tb_GST.TabIndex = 13;
            this.tb_GST.Text = "0";
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(857, 532);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(154, 25);
            this.lbl_Total_Amount.TabIndex = 31;
            this.lbl_Total_Amount.Text = "Total Amount ";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(1021, 529);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(223, 34);
            this.tb_Total_Amount.TabIndex = 32;
            this.tb_Total_Amount.Text = "0";
            // 
            // lbl_Paying_Amount
            // 
            this.lbl_Paying_Amount.AutoSize = true;
            this.lbl_Paying_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paying_Amount.Location = new System.Drawing.Point(49, 585);
            this.lbl_Paying_Amount.Name = "lbl_Paying_Amount";
            this.lbl_Paying_Amount.Size = new System.Drawing.Size(172, 25);
            this.lbl_Paying_Amount.TabIndex = 31;
            this.lbl_Paying_Amount.Text = "Paying Amount ";
            // 
            // tb_Paying_Amount
            // 
            this.tb_Paying_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paying_Amount.Location = new System.Drawing.Point(220, 582);
            this.tb_Paying_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Paying_Amount.Name = "tb_Paying_Amount";
            this.tb_Paying_Amount.Size = new System.Drawing.Size(181, 34);
            this.tb_Paying_Amount.TabIndex = 14;
            this.tb_Paying_Amount.Text = "0";
            this.tb_Paying_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Paying_Amount.Leave += new System.EventHandler(this.tb_Paid_Amount_Leave);
            // 
            // tb_Balance_Amount
            // 
            this.tb_Balance_Amount.Enabled = false;
            this.tb_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Balance_Amount.Location = new System.Drawing.Point(597, 585);
            this.tb_Balance_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Balance_Amount.Name = "tb_Balance_Amount";
            this.tb_Balance_Amount.Size = new System.Drawing.Size(225, 34);
            this.tb_Balance_Amount.TabIndex = 34;
            this.tb_Balance_Amount.Text = "0";
            // 
            // lbl_Balance_Amount
            // 
            this.lbl_Balance_Amount.AutoSize = true;
            this.lbl_Balance_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance_Amount.Location = new System.Drawing.Point(407, 588);
            this.lbl_Balance_Amount.Name = "lbl_Balance_Amount";
            this.lbl_Balance_Amount.Size = new System.Drawing.Size(184, 25);
            this.lbl_Balance_Amount.TabIndex = 33;
            this.lbl_Balance_Amount.Text = "Balance Amount ";
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "Cash ",
            "Online",
            "Card"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(1021, 585);
            this.cmb_Payment_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(223, 34);
            this.cmb_Payment_Mode.TabIndex = 15;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(839, 591);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(172, 25);
            this.lbl_Payment_Mode.TabIndex = 35;
            this.lbl_Payment_Mode.Text = "Payment Mode ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(531, 644);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 58);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_Purchase_Date
            // 
            this.dtp_Purchase_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Purchase_Date.Location = new System.Drawing.Point(1021, 20);
            this.dtp_Purchase_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Purchase_Date.Name = "dtp_Purchase_Date";
            this.dtp_Purchase_Date.Size = new System.Drawing.Size(244, 34);
            this.dtp_Purchase_Date.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(945, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(66, 25);
            this.lbl_Date.TabIndex = 40;
            this.lbl_Date.Text = "Date ";
            // 
            // Cmb_Supplier_Name
            // 
            this.Cmb_Supplier_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Supplier_Name.FormattingEnabled = true;
            this.Cmb_Supplier_Name.Location = new System.Drawing.Point(531, 20);
            this.Cmb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Supplier_Name.Name = "Cmb_Supplier_Name";
            this.Cmb_Supplier_Name.Size = new System.Drawing.Size(389, 34);
            this.Cmb_Supplier_Name.TabIndex = 1;
            // 
            // Frm_Purchase_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.Cmb_Supplier_Name);
            this.Controls.Add(this.dtp_Purchase_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Payment_Mode);
            this.Controls.Add(this.lbl_Payment_Mode);
            this.Controls.Add(this.tb_Balance_Amount);
            this.Controls.Add(this.lbl_Balance_Amount);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.tb_GST);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.tb_Paying_Amount);
            this.Controls.Add(this.lbl_Paying_Amount);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.dgv_Purchase_Details);
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.Controls.Add(this.tb_Purchase_ID);
            this.Controls.Add(this.lbl_Purchase_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Purchase_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Bill";
            this.Load += new System.EventHandler(this.Frm_Purchase_Bill_Load);
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Purchase_ID;
        private System.Windows.Forms.Label lbl_Purchase_ID;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Label lbl_Purchase_Unit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.DataGridView dgv_Purchase_Details;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Paying_Amount;
        private System.Windows.Forms.TextBox tb_Paying_Amount;
        private System.Windows.Forms.TextBox tb_Balance_Amount;
        private System.Windows.Forms.Label lbl_Balance_Amount;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox Cmb_Product_Name;
        private System.Windows.Forms.DateTimePicker dtp_Purchase_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox Cmb_Supplier_Name;
    }
}