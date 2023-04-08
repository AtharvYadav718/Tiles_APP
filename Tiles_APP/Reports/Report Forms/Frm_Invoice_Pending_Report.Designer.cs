
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Invoice_Pending_Report
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
            this.crv_Invoice_Pending = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Invoice_Pending
            // 
            this.crv_Invoice_Pending.ActiveViewIndex = -1;
            this.crv_Invoice_Pending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Invoice_Pending.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Invoice_Pending.DisplayStatusBar = false;
            this.crv_Invoice_Pending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Invoice_Pending.Location = new System.Drawing.Point(0, 0);
            this.crv_Invoice_Pending.Name = "crv_Invoice_Pending";
            this.crv_Invoice_Pending.Size = new System.Drawing.Size(1063, 725);
            this.crv_Invoice_Pending.TabIndex = 0;
            this.crv_Invoice_Pending.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Invoice_Pending_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 725);
            this.Controls.Add(this.crv_Invoice_Pending);
            this.Name = "Frm_Invoice_Pending_Report";
            this.Text = "Frm_Invoice_Pending_Report";
            this.Load += new System.EventHandler(this.Frm_Invoice_Pending_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Invoice_Pending;
    }
}