namespace Tiles_APP
{
    partial class Frm_Quotation_List
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
            this.tb_Custmer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Quotation_ID = new System.Windows.Forms.TextBox();
            this.lbl_Quotation_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Quotation_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotation_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Custmer_Name
            // 
            this.tb_Custmer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Custmer_Name.Location = new System.Drawing.Point(684, 37);
            this.tb_Custmer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Custmer_Name.Name = "tb_Custmer_Name";
            this.tb_Custmer_Name.Size = new System.Drawing.Size(409, 39);
            this.tb_Custmer_Name.TabIndex = 16;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(449, 38);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Customer_Name.TabIndex = 15;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // tb_Quotation_ID
            // 
            this.tb_Quotation_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quotation_ID.Location = new System.Drawing.Point(262, 34);
            this.tb_Quotation_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quotation_ID.Name = "tb_Quotation_ID";
            this.tb_Quotation_ID.Size = new System.Drawing.Size(165, 39);
            this.tb_Quotation_ID.TabIndex = 14;
            // 
            // lbl_Quotation_ID
            // 
            this.lbl_Quotation_ID.AutoSize = true;
            this.lbl_Quotation_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quotation_ID.Location = new System.Drawing.Point(54, 37);
            this.lbl_Quotation_ID.Name = "lbl_Quotation_ID";
            this.lbl_Quotation_ID.Size = new System.Drawing.Size(192, 35);
            this.lbl_Quotation_ID.TabIndex = 13;
            this.lbl_Quotation_ID.Text = "Quotation ID ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1118, 25);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(127, 58);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dgv_Quotation_List
            // 
            this.dgv_Quotation_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quotation_List.Location = new System.Drawing.Point(17, 110);
            this.dgv_Quotation_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Quotation_List.Name = "dgv_Quotation_List";
            this.dgv_Quotation_List.RowHeadersWidth = 51;
            this.dgv_Quotation_List.RowTemplate.Height = 24;
            this.dgv_Quotation_List.Size = new System.Drawing.Size(1228, 571);
            this.dgv_Quotation_List.TabIndex = 18;
            // 
            // Frm_Quotation_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.dgv_Quotation_List);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Custmer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.tb_Quotation_ID);
            this.Controls.Add(this.lbl_Quotation_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Quotation_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotation_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Custmer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.TextBox tb_Quotation_ID;
        private System.Windows.Forms.Label lbl_Quotation_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Quotation_List;
    }
}