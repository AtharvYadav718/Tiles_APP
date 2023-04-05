
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Customer_Entry
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
            this.crv_Customer_Entry = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tb_Custmer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Customer_Entry
            // 
            this.crv_Customer_Entry.ActiveViewIndex = -1;
            this.crv_Customer_Entry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Entry.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Entry.DisplayStatusBar = false;
            this.crv_Customer_Entry.Location = new System.Drawing.Point(0, 100);
            this.crv_Customer_Entry.Name = "crv_Customer_Entry";
            this.crv_Customer_Entry.Size = new System.Drawing.Size(1182, 661);
            this.crv_Customer_Entry.TabIndex = 0;
            this.crv_Customer_Entry.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tb_Custmer_Name
            // 
            this.tb_Custmer_Name.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Custmer_Name.Location = new System.Drawing.Point(557, 22);
            this.tb_Custmer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Custmer_Name.Name = "tb_Custmer_Name";
            this.tb_Custmer_Name.Size = new System.Drawing.Size(359, 39);
            this.tb_Custmer_Name.TabIndex = 26;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(276, 22);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(242, 36);
            this.lbl_Customer_Name.TabIndex = 27;
            this.lbl_Customer_Name.Text = "Customer Name ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(992, 22);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 54);
            this.btn_Search.TabIndex = 101;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Customer_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 761);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Custmer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.crv_Customer_Entry);
            this.Name = "Frm_Customer_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoice Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Entry;
        private System.Windows.Forms.TextBox tb_Custmer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Button btn_Search;
    }
}