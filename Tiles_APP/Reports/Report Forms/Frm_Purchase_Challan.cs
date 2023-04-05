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
    public partial class Frm_Purchase_Challan : Form
    {
        public Frm_Purchase_Challan()
        {
            InitializeComponent();
        }


        public void showREport(int PurchaseID)
        {
            ReportDocument reportDocument = new ReportDocument();
            ParameterField parameterField = new ParameterField();
            ParameterFields parameterFields = new ParameterFields();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterField.Name = "PurchaseID";
            parameterDiscreteValue.Value = PurchaseID;
            parameterField.CurrentValues.Add(parameterDiscreteValue);
            parameterFields.Add(parameterField);

            crv_Purchase_Challan.ParameterFieldInfo = parameterFields;
            reportDocument.Load(@"D:\SGM_VS_19\Tiles_APP\Tiles_APP\Reports\CrystalReports\CR_Purchase_Challan.rpt");
            crv_Purchase_Challan.ReportSource = reportDocument;
            reportDocument.SetDatabaseLogon("Shop", "Shop", "Atharv", "Tiles_App_DB");

            //BillDetailsInvoiceID
            //D:\SGM_VS_19\Tiles_APP\Tiles_APP\Reports\CrystalReports\CR_Purchase_Challan.rpt
        }
    }
}
