namespace Tiles_APP
{
    partial class Frm_Invoice_List
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
            this.dgv_Invoice_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Custmer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Invoice_ID = new System.Windows.Forms.TextBox();
            this.lbl_Invoice_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Invoice_List
            // 
            this.dgv_Invoice_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoice_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoice_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoice_List.Location = new System.Drawing.Point(12, 111);
            this.dgv_Invoice_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Invoice_List.Name = "dgv_Invoice_List";
            this.dgv_Invoice_List.RowHeadersWidth = 51;
            this.dgv_Invoice_List.RowTemplate.Height = 24;
            this.dgv_Invoice_List.Size = new System.Drawing.Size(1249, 585);
            this.dgv_Invoice_List.TabIndex = 29;
            this.dgv_Invoice_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Invoice_List_CellDoubleClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1143, 30);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(127, 47);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Custmer_Name
            // 
            this.tb_Custmer_Name.Enabled = false;
            this.tb_Custmer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Custmer_Name.Location = new System.Drawing.Point(703, 34);
            this.tb_Custmer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Custmer_Name.Name = "tb_Custmer_Name";
            this.tb_Custmer_Name.Size = new System.Drawing.Size(415, 39);
            this.tb_Custmer_Name.TabIndex = 27;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(451, 38);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Customer_Name.TabIndex = 26;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // tb_Invoice_ID
            // 
            this.tb_Invoice_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Invoice_ID.Location = new System.Drawing.Point(197, 34);
            this.tb_Invoice_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Invoice_ID.Name = "tb_Invoice_ID";
            this.tb_Invoice_ID.Size = new System.Drawing.Size(215, 39);
            this.tb_Invoice_ID.TabIndex = 1;
            this.tb_Invoice_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Invoice_ID.Leave += new System.EventHandler(this.tb_Invoice_ID_Leave);
            // 
            // lbl_Invoice_ID
            // 
            this.lbl_Invoice_ID.AutoSize = true;
            this.lbl_Invoice_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invoice_ID.Location = new System.Drawing.Point(15, 33);
            this.lbl_Invoice_ID.Name = "lbl_Invoice_ID";
            this.lbl_Invoice_ID.Size = new System.Drawing.Size(156, 35);
            this.lbl_Invoice_ID.TabIndex = 24;
            this.lbl_Invoice_ID.Text = "Invoice ID ";
            // 
            // Frm_Invoice_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Invoice_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_Custmer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.tb_Invoice_ID);
            this.Controls.Add(this.lbl_Invoice_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Invoice_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice List";
            this.Load += new System.EventHandler(this.Frm_Invoice_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Invoice_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Custmer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.TextBox tb_Invoice_ID;
        private System.Windows.Forms.Label lbl_Invoice_ID;
    }
}