namespace Tiles_APP
{
    partial class Frm_Product_List
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
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.pnl_Peoduct_List = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.Category_Name = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.pnl_Peoduct_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.AllowUserToAddRows = false;
            this.dgv_Product_List.AllowUserToDeleteRows = false;
            this.dgv_Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(12, 177);
            this.dgv_Product_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.ReadOnly = true;
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(1255, 503);
            this.dgv_Product_List.TabIndex = 23;
            // 
            // pnl_Peoduct_List
            // 
            this.pnl_Peoduct_List.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_Peoduct_List.Controls.Add(this.btn_Refresh);
            this.pnl_Peoduct_List.Controls.Add(this.lbl_Product_Name);
            this.pnl_Peoduct_List.Controls.Add(this.lbl_Subcategory_Name);
            this.pnl_Peoduct_List.Controls.Add(this.Category_Name);
            this.pnl_Peoduct_List.Controls.Add(this.cmb_Product_Name);
            this.pnl_Peoduct_List.Controls.Add(this.cmb_Subcategory_Name);
            this.pnl_Peoduct_List.Controls.Add(this.Cmb_Category_Name);
            this.pnl_Peoduct_List.Location = new System.Drawing.Point(12, 22);
            this.pnl_Peoduct_List.Name = "pnl_Peoduct_List";
            this.pnl_Peoduct_List.Size = new System.Drawing.Size(1255, 131);
            this.pnl_Peoduct_List.TabIndex = 31;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(946, 67);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 56);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(27, 83);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(160, 26);
            this.lbl_Product_Name.TabIndex = 33;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(592, 26);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(205, 26);
            this.lbl_Subcategory_Name.TabIndex = 32;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // Category_Name
            // 
            this.Category_Name.AutoSize = true;
            this.Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.Location = new System.Drawing.Point(27, 25);
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(172, 26);
            this.Category_Name.TabIndex = 31;
            this.Category_Name.Text = "Category Name";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(212, 80);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(348, 34);
            this.cmb_Product_Name.TabIndex = 3;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(827, 22);
            this.cmb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(374, 34);
            this.cmb_Subcategory_Name.TabIndex = 2;
            this.cmb_Subcategory_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_Name_SelectedIndexChanged);
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(212, 17);
            this.Cmb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(348, 34);
            this.Cmb_Category_Name.TabIndex = 1;
            this.Cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Category_Name_SelectedIndexChanged);
            // 
            // Frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.pnl_Peoduct_List);
            this.Controls.Add(this.dgv_Product_List);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.Frm_Product_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.pnl_Peoduct_List.ResumeLayout(false);
            this.pnl_Peoduct_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_Peoduct_List;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.Label Category_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
    }
}