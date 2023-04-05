namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Customer_Invoice
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
            this.crv_Customer_Invoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Customer_Invoice
            // 
            this.crv_Customer_Invoice.ActiveViewIndex = -1;
            this.crv_Customer_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Invoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Invoice.DisplayStatusBar = false;
            this.crv_Customer_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Customer_Invoice.Location = new System.Drawing.Point(0, 0);
            this.crv_Customer_Invoice.Name = "crv_Customer_Invoice";
            this.crv_Customer_Invoice.Size = new System.Drawing.Size(1182, 1055);
            this.crv_Customer_Invoice.TabIndex = 0;
            this.crv_Customer_Invoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Customer_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.crv_Customer_Invoice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Customer_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Customer_Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Invoice;
    }
}