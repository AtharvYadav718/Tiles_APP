
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Suppiler_Entry
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
            this.crv_Supplier_Entry = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Supplier_Entry
            // 
            this.crv_Supplier_Entry.ActiveViewIndex = -1;
            this.crv_Supplier_Entry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Supplier_Entry.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Supplier_Entry.DisplayStatusBar = false;
            this.crv_Supplier_Entry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Supplier_Entry.Location = new System.Drawing.Point(0, 85);
            this.crv_Supplier_Entry.Name = "crv_Supplier_Entry";
            this.crv_Supplier_Entry.Size = new System.Drawing.Size(1285, 618);
            this.crv_Supplier_Entry.TabIndex = 0;
            this.crv_Supplier_Entry.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Cmb_Supplier_Name
            // 
            this.Cmb_Supplier_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Supplier_Name.FormattingEnabled = true;
            this.Cmb_Supplier_Name.Location = new System.Drawing.Point(329, 24);
            this.Cmb_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Supplier_Name.Name = "Cmb_Supplier_Name";
            this.Cmb_Supplier_Name.Size = new System.Drawing.Size(389, 34);
            this.Cmb_Supplier_Name.TabIndex = 97;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(736, 16);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 49);
            this.btn_Search.TabIndex = 96;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(98, 23);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(211, 35);
            this.lbl_Supplier_Name.TabIndex = 40;
            this.lbl_Supplier_Name.Text = "Supplier Name ";
            // 
            // Frm_Suppiler_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Cmb_Supplier_Name);
            this.Controls.Add(this.crv_Supplier_Entry);
            this.Controls.Add(this.lbl_Supplier_Name);
            this.MinimizeBox = false;
            this.Name = "Frm_Suppiler_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Suppiler Entry";
            this.Load += new System.EventHandler(this.Frm_Suppiler_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Supplier_Entry;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox Cmb_Supplier_Name;
    }
}