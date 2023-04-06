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
    public partial class Frm_Customer_Entry : Form
    {
        public Frm_Customer_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=ATHARV;Initial Catalog=Tiles_APP_DB;Integrated Security=True; User ID = Shop , Password = Shop ");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string Customer_Name;
        

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Customer_Name = tb_Custmer_Name.Text;
            
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select  Customer_ID,Date,Invoice_ID,Customer_Name,Discount,GST,Paid_Bill,Balance_Amount,Total_Bill from Invoice_Bill_Details where  Customer_Name ='" + tb_Custmer_Name.Text  + "'", con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            Reports.CrystalReports.CR_Customer_Entry cr = new Reports.CrystalReports.CR_Customer_Entry();

            cr.Database.Tables["Invoice_Bill_Details"].SetDataSource(dt);
            this.crv_Customer_Entry.ReportSource = cr;
            cr.SetDatabaseLogon("Shop", "Shop", "Atharv", "Tiles_App_DB");
            con.Close();

        }
    }
}
