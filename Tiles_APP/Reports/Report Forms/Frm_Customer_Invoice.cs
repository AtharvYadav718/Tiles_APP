using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_APP.Reports.Report_Forms
{
    public partial class Frm_Customer_Invoice : Form
    {
        public Frm_Customer_Invoice()
        {
            InitializeComponent();
        }

        public void showREport(int InvoideId)
        {
            ReportDocument reportDocument = new ReportDocument();
            ParameterField parameterField = new ParameterField();
            ParameterFields parameterFields = new ParameterFields();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterField.Name = "InvoiceId";
            parameterDiscreteValue.Value = InvoideId;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterFields.Add(parameterField);

            crv_Customer_Invoice.ParameterFieldInfo = parameterFields;
            reportDocument.Load(@"D:\SGM_VS_19\Tiles_APP\Tiles_APP\CR_Customer_Invoice.rpt");
            crv_Customer_Invoice.ReportSource = reportDocument;
            reportDocument.SetDatabaseLogon("Shop", "Shop", "Atharv", "Tiles_App_DB");

            //BillDetailsInvoiceID
            //D:\SGM_VS_19\Tiles_APP\Tiles_APP\CR_Customer_Invoice.rpt
        }

        private void Frm_Customer_Invoice_Load(object sender, EventArgs e)
        {

        }
    }
}
