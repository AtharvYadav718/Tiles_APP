﻿namespace Tiles_APP
{
    partial class Frm_Add_New_Category
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
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add_New_Subcategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Enabled = false;
            this.tb_Category_ID.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_ID.Location = new System.Drawing.Point(605, 179);
            this.tb_Category_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(401, 45);
            this.tb_Category_ID.TabIndex = 1;
            this.tb_Category_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_ID_KeyPress);
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Category_ID.Location = new System.Drawing.Point(347, 190);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(187, 34);
            this.lbl_Category_ID.TabIndex = 22;
            this.lbl_Category_ID.Text = "Category ID ";
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(605, 292);
            this.tb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(401, 45);
            this.tb_Category_Name.TabIndex = 2;
            this.tb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_Name_KeyPress);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Category_Name.Location = new System.Drawing.Point(296, 303);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(228, 34);
            this.lbl_Category_Name.TabIndex = 23;
            this.lbl_Category_Name.Text = "Category Name ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Save.Font = new System.Drawing.Font("Calisto MT", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(333, 444);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(175, 68);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add_New_Subcategory
            // 
            this.btn_Add_New_Subcategory.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Add_New_Subcategory.Font = new System.Drawing.Font("Calisto MT", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Add_New_Subcategory.Location = new System.Drawing.Point(566, 444);
            this.btn_Add_New_Subcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_New_Subcategory.Name = "btn_Add_New_Subcategory";
            this.btn_Add_New_Subcategory.Size = new System.Drawing.Size(397, 68);
            this.btn_Add_New_Subcategory.TabIndex = 24;
            this.btn_Add_New_Subcategory.Text = "Add New Subcategory";
            this.btn_Add_New_Subcategory.UseVisualStyleBackColor = false;
            this.btn_Add_New_Subcategory.Click += new System.EventHandler(this.btn_Add_New_Subcategory_Click);
            // 
            // Frm_Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_New_Subcategory);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Category_ID);
            this.Controls.Add(this.lbl_Category_ID);
            this.Controls.Add(this.tb_Category_Name);
            this.Controls.Add(this.lbl_Category_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Add_New_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.Load += new System.EventHandler(this.Frm_Add_New_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add_New_Subcategory;
    }
}