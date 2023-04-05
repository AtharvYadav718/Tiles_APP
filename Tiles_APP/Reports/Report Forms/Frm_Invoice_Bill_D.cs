
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_APP.Reports.Report_Forms
{
    public partial class Frm_Invoice_Bill_D : Form
    {
        public Frm_Invoice_Bill_D()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=ATHARV;Initial Catalog=Tiles_APP_DB;Integrated Security=True; User ID = Shop , Password = Shop ");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string date1;
        string date2;

        private void Frm_Invoice_Bill_D_Load(object sender, EventArgs e)
        {
            
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            date1 = dtp_Start_Date.Value.Year + "-" + dtp_Start_Date.Value.Month + "-" + dtp_Start_Date.Value.Day;
            date2 = dtp_End_Date.Value.Year + "-" + dtp_End_Date.Value.Month + "-" + dtp_End_Date.Value.Day;

            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from Invoice_Bill_Details where Date between '" + date1 + "' and '" + date2 + "' ", con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            Reports.CrystalReports.CR_Customer_Invoice_D  cr = new Reports.CrystalReports.CR_Customer_Invoice_D();
     
            cr.Database.Tables["Invoice_Bill_Details"].SetDataSource(dt);
            this.crv_Invoice_Bill_D.ReportSource = cr;
            cr.SetDatabaseLogon("Shop", "Shop", "Atharv", "Tiles_App_DB");
            con.Close();
        }
    }
}
