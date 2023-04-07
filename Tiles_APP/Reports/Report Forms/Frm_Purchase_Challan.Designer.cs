
namespace Tiles_APP.Reports.Report_Forms
{
    partial class Frm_Purchase_Challan
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
            this.crv_Purchase_Challan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Purchase_Challan
            // 
            this.crv_Purchase_Challan.ActiveViewIndex = -1;
            this.crv_Purchase_Challan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Purchase_Challan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Purchase_Challan.DisplayStatusBar = false;
            this.crv_Purchase_Challan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Purchase_Challan.Location = new System.Drawing.Point(0, 0);
            this.crv_Purchase_Challan.Name = "crv_Purchase_Challan";
            this.crv_Purchase_Challan.Size = new System.Drawing.Size(1285, 703);
            this.crv_Purchase_Challan.TabIndex = 0;
            this.crv_Purchase_Challan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Purchase_Challan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1285, 703);
            this.Controls.Add(this.crv_Purchase_Challan);
            this.Name = "Frm_Purchase_Challan";
            this.Text = "Purchase Challan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Purchase_Challan;
    }
}