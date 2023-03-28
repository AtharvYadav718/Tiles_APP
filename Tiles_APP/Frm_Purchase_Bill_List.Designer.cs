namespace Tiles_APP
{
    partial class Frm_Purchase_Bill_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Purchase_List = new System.Windows.Forms.DataGridView();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(12, 18);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(176, 32);
            this.lbl_Supplier_Name.TabIndex = 21;
            this.lbl_Supplier_Name.Text = "Suplier Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1005, 11);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(131, 50);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Purchase_List
            // 
            this.dgv_Purchase_List.AllowUserToAddRows = false;
            this.dgv_Purchase_List.AllowUserToDeleteRows = false;
            this.dgv_Purchase_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Purchase_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Purchase_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_List.Location = new System.Drawing.Point(18, 102);
            this.dgv_Purchase_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Purchase_List.Name = "dgv_Purchase_List";
            this.dgv_Purchase_List.ReadOnly = true;
            this.dgv_Purchase_List.RowHeadersWidth = 51;
            this.dgv_Purchase_List.RowTemplate.Height = 24;
            this.dgv_Purchase_List.Size = new System.Drawing.Size(1244, 581);
            this.dgv_Purchase_List.TabIndex = 30;
            this.dgv_Purchase_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Purchase_List_CellDoubleClick);
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Enabled = false;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(788, 16);
            this.tb_Total_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(183, 34);
            this.tb_Total_Amount.TabIndex = 2;
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.Location = new System.Drawing.Point(597, 18);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(176, 32);
            this.lbl_Total_Amount.TabIndex = 36;
            this.lbl_Total_Amount.Text = "Total Amount";
            // 
            // cmb_Supplier_Name
            // 
            this.cmb_Supplier_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier_Name.FormattingEnabled = true;
            this.cmb_Supplier_Name.Location = new System.Drawing.Point(196, 16);
            this.cmb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Supplier_Name.Name = "cmb_Supplier_Name";
            this.cmb_Supplier_Name.Size = new System.Drawing.Size(367, 34);
            this.cmb_Supplier_Name.TabIndex = 1;
            this.cmb_Supplier_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_Name_SelectedIndexChanged);
            // 
            // Frm_Purchase_Bill_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.cmb_Supplier_Name);
            this.Controls.Add(this.tb_Total_Amount);
            this.Controls.Add(this.lbl_Total_Amount);
            this.Controls.Add(this.dgv_Purchase_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Purchase_Bill_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase List";
            this.Load += new System.EventHandler(this.Frm_Purchase_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Purchase_List;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.ComboBox cmb_Supplier_Name;
    }
}