
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Purchase_Pending_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Purchase_Pending_Report));
            this.crv_purchase_Pending = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_purchase_Pending
            // 
            this.crv_purchase_Pending.ActiveViewIndex = -1;
            this.crv_purchase_Pending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_purchase_Pending.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_purchase_Pending.DisplayStatusBar = false;
            this.crv_purchase_Pending.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_purchase_Pending.Location = new System.Drawing.Point(0, 2);
            this.crv_purchase_Pending.Name = "crv_purchase_Pending";
            this.crv_purchase_Pending.Size = new System.Drawing.Size(1128, 756);
            this.crv_purchase_Pending.TabIndex = 0;
            this.crv_purchase_Pending.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Purchase_Pending_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 758);
            this.Controls.Add(this.crv_purchase_Pending);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Purchase_Pending_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Pending Challan";
            this.Load += new System.EventHandler(this.Frm_Purchase_Pending_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_purchase_Pending;
    }
}