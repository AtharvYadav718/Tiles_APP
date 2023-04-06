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
    public partial class Frm_Suppiler_Entry : Form
    {
        public Frm_Suppiler_Entry()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=ATHARV;Initial Catalog=Tiles_APP_DB;Integrated Security=True; User ID = Shop , Password = Shop ");


        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }
        void Bind_ComboBox()
        {
            Cmb_Supplier_Name.Items.Clear();

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            SqlDataReader dr;
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Supplier_Name) from Supplier_Details ";

            dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Supplier_Name.Items.Add(dr["Supplier_Name"].ToString());
            }
            dr.Close();

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Supplier_Name;
            Supplier_Name = Cmb_Supplier_Name.Text;
            Con_Open();
            SqlCommand cmd;
            SqlDataAdapter dr;
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select  Purchase_ID,Purchase_Date,Supplier_Name,Discount,GST,Paid_Amount,Balance_Amount,Total_Amount from Purchase_Bill_Details where  Supplier_Name ='" + Cmb_Supplier_Name.Text + "'", Con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            Reports.CrystalReports.CR_Supplier_Entry cr = new Reports.CrystalReports.CR_Supplier_Entry();

            cr.Database.Tables["Purchase_Bill_Details"].SetDataSource(dt);
            this.crv_Supplier_Entry.ReportSource = cr;
            cr.SetDatabaseLogon("Shop", "Shop", "Atharv", "Tiles_App_DB");
            Con_Close();
        }

        private void Frm_Suppiler_Entry_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
        }
    }
}
