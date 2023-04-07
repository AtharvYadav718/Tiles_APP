
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Invoice_Bill_D
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
            this.dtp_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_End_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.crv_Invoice_Bill_D = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dtp_Start_Date
            // 
            this.dtp_Start_Date.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start_Date.Location = new System.Drawing.Point(232, 17);
            this.dtp_Start_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Start_Date.Name = "dtp_Start_Date";
            this.dtp_Start_Date.Size = new System.Drawing.Size(283, 39);
            this.dtp_Start_Date.TabIndex = 28;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(129, 17);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(86, 36);
            this.lbl_Date.TabIndex = 29;
            this.lbl_Date.Text = "Date ";
            // 
            // dtp_End_Date
            // 
            this.dtp_End_Date.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End_Date.Location = new System.Drawing.Point(556, 17);
            this.dtp_End_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_End_Date.Name = "dtp_End_Date";
            this.dtp_End_Date.Size = new System.Drawing.Size(283, 39);
            this.dtp_End_Date.TabIndex = 28;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(886, 10);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 49);
            this.btn_Search.TabIndex = 96;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // crv_Invoice_Bill_D
            // 
            this.crv_Invoice_Bill_D.ActiveViewIndex = -1;
            this.crv_Invoice_Bill_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Invoice_Bill_D.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Invoice_Bill_D.DisplayStatusBar = false;
            this.crv_Invoice_Bill_D.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Invoice_Bill_D.Location = new System.Drawing.Point(0, 64);
            this.crv_Invoice_Bill_D.Name = "crv_Invoice_Bill_D";
            this.crv_Invoice_Bill_D.Size = new System.Drawing.Size(1285, 639);
            this.crv_Invoice_Bill_D.TabIndex = 97;
            this.crv_Invoice_Bill_D.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Invoice_Bill_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.crv_Invoice_Bill_D);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_End_Date);
            this.Controls.Add(this.dtp_Start_Date);
            this.Controls.Add(this.lbl_Date);
            this.Name = "Frm_Invoice_Bill_D";
            this.Text = "Cutomer Invoice Datewise";
            this.Load += new System.EventHandler(this.Frm_Invoice_Bill_D_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_Start_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_End_Date;
        private System.Windows.Forms.Button btn_Search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Invoice_Bill_D;
    }
}