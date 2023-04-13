namespace Tiles_APP
{
    partial class Frm_Update_Product_Details
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Purchase_Rate = new System.Windows.Forms.Label();
            this.tb_Sales_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Rate = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.tb_Subcategory_Name = new System.Windows.Forms.TextBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(781, 600);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(157, 71);
            this.btn_Update.TabIndex = 97;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Purchase_Rate
            // 
            this.tb_Purchase_Rate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Rate.Location = new System.Drawing.Point(532, 290);
            this.tb_Purchase_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Purchase_Rate.Name = "tb_Purchase_Rate";
            this.tb_Purchase_Rate.Size = new System.Drawing.Size(418, 39);
            this.tb_Purchase_Rate.TabIndex = 77;
            this.tb_Purchase_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Category_Name.Location = new System.Drawing.Point(233, 70);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(228, 34);
            this.lbl_Category_Name.TabIndex = 84;
            this.lbl_Category_Name.Text = "Category Name ";
            // 
            // lbl_Purchase_Rate
            // 
            this.lbl_Purchase_Rate.AutoSize = true;
            this.lbl_Purchase_Rate.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Purchase_Rate.Location = new System.Drawing.Point(241, 294);
            this.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate";
            this.lbl_Purchase_Rate.Size = new System.Drawing.Size(210, 34);
            this.lbl_Purchase_Rate.TabIndex = 90;
            this.lbl_Purchase_Rate.Text = "Purchase Rate ";
            // 
            // tb_Sales_Rate
            // 
            this.tb_Sales_Rate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Rate.Location = new System.Drawing.Point(532, 367);
            this.tb_Sales_Rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Rate.Name = "tb_Sales_Rate";
            this.tb_Sales_Rate.Size = new System.Drawing.Size(418, 39);
            this.tb_Sales_Rate.TabIndex = 78;
            // 
            // lbl_Sales_Rate
            // 
            this.lbl_Sales_Rate.AutoSize = true;
            this.lbl_Sales_Rate.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Sales_Rate.Location = new System.Drawing.Point(281, 366);
            this.lbl_Sales_Rate.Name = "lbl_Sales_Rate";
            this.lbl_Sales_Rate.Size = new System.Drawing.Size(158, 34);
            this.lbl_Sales_Rate.TabIndex = 89;
            this.lbl_Sales_Rate.Text = "Sales Rate ";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(532, 213);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(418, 39);
            this.tb_Product_Name.TabIndex = 74;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Product_Name.Location = new System.Drawing.Point(241, 217);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(210, 34);
            this.lbl_Product_Name.TabIndex = 86;
            this.lbl_Product_Name.Text = "Product Name ";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(186, 134);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(268, 34);
            this.lbl_Subcategory_Name.TabIndex = 83;
            this.lbl_Subcategory_Name.Text = "Subcategory Name ";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(251, 43);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(212, 39);
            this.tb_Product_ID.TabIndex = 96;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(69, 42);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(176, 35);
            this.lbl_Product_ID.TabIndex = 98;
            this.lbl_Product_ID.Text = "Product ID :";
            // 
            // tb_Subcategory_Name
            // 
            this.tb_Subcategory_Name.Enabled = false;
            this.tb_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subcategory_Name.Location = new System.Drawing.Point(532, 134);
            this.tb_Subcategory_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Subcategory_Name.Name = "tb_Subcategory_Name";
            this.tb_Subcategory_Name.Size = new System.Drawing.Size(418, 39);
            this.tb_Subcategory_Name.TabIndex = 92;
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Enabled = false;
            this.tb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(532, 66);
            this.tb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(418, 39);
            this.tb_Category_Name.TabIndex = 91;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(391, 600);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(157, 71);
            this.btn_Refresh.TabIndex = 101;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(509, 31);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 54);
            this.btn_Search.TabIndex = 100;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.tb_Purchase_Rate);
            this.panel1.Controls.Add(this.lbl_Category_Name);
            this.panel1.Controls.Add(this.lbl_Purchase_Rate);
            this.panel1.Controls.Add(this.tb_Subcategory_Name);
            this.panel1.Controls.Add(this.tb_Sales_Rate);
            this.panel1.Controls.Add(this.lbl_Sales_Rate);
            this.panel1.Controls.Add(this.tb_Category_Name);
            this.panel1.Controls.Add(this.tb_Product_Name);
            this.panel1.Controls.Add(this.lbl_Product_Name);
            this.panel1.Controls.Add(this.lbl_Subcategory_Name);
            this.panel1.Location = new System.Drawing.Point(45, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 439);
            this.panel1.TabIndex = 99;
            // 
            // Frm_Update_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Update_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.Frm_Update_Product_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_Purchase_Rate;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_Purchase_Rate;
        private System.Windows.Forms.TextBox tb_Sales_Rate;
        private System.Windows.Forms.Label lbl_Sales_Rate;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.TextBox tb_Subcategory_Name;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
    }
}