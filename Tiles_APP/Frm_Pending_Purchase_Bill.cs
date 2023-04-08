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

namespace Tiles_APP
{
    public partial class Frm_Purchase_Pending_Bill : Form
    {
        public Frm_Purchase_Pending_Bill()
        {
            InitializeComponent();
        }

        private void Frm_Purchase_Pending_Bill_Load(object sender, EventArgs e)
        {
            tb_Purchase_ID.Text = Convert.ToString(Shared_Class.Purchase_ID);

            Tiles_App_Sherard_Content.Con_Open();

            tb_Paying_Amount.Text = "0";

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Tiles_App_Sherard_Content.Con;

            Cmd.CommandText = "Select Supplier_Name ,Total_Amount,Paid_Amount,Balance_Amount from Purchase_Bill_Details where  Purchase_ID = '" + Convert.ToString(Shared_Class.Purchase_ID) + "' ";
            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                tb_Supplier_Name.Text = dr.GetString(dr.GetOrdinal("Supplier_Name"));
                tb_Total_Amount.Text = (dr["Total_Amount"].ToString());
                tb_Paid_Amount.Text = (dr["Paid_Amount"].ToString());
                tb_Balance_Amount.Text = (dr["Balance_Amount"].ToString());
            }
            dr.Close();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            double Paid = Convert.ToDouble(tb_Paid_Amount.Text) + Convert.ToDouble(tb_Paying_Amount.Text);
            double Balance = Convert.ToDouble(tb_Balance_Amount.Text) - Convert.ToDouble(tb_Paying_Amount.Text);

            int Purchase_Id = Convert.ToInt32(tb_Purchase_ID.Text);

            Tiles_App_Sherard_Content.Con_Open();

            if (tb_Paying_Amount.Text != "" && cmb_Payment_Mode.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Tiles_App_Sherard_Content.Con;
                Cmd.CommandText = "Update Purchase_Bill_Details Set  Paid_Amount = '" + Convert.ToString(Paid) + "' , Balance_Amount= '" + Convert.ToString(Balance) + "' where Purchase_ID = '" + Convert.ToString(Shared_Class.Purchase_ID) + "' ";
                Cmd.Parameters.Add("@Paid", SqlDbType.Money).Value = tb_Paid_Amount.Text;
                Cmd.Parameters.Add("@Balance", SqlDbType.Money).Value = tb_Balance_Amount.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                SqlCommand cmd1 = new SqlCommand("Insert Into Purchase_Pending values (@P_ID,@Date,@S_Name,@Paying_Amount,@Payment_Mode)", Tiles_App_Sherard_Content.Con);

                cmd1.Parameters.Add("@P_ID", SqlDbType.Int).Value = tb_Purchase_ID.Text;
                cmd1.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Purchase_Date.Text;
                cmd1.Parameters.Add("@S_Name", SqlDbType.VarChar).Value = tb_Supplier_Name.Text;
                cmd1.Parameters.Add("@Paying_Amount", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd1.Parameters.Add("@Payment_Mode", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();

                MessageBox.Show(" Payment Paid Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    Reports.Report_Forms.Frm_Purchase_Pending_Report frm = new Reports.Report_Forms.Frm_Purchase_Pending_Report();
                    frm.showREport(Purchase_Id);
                    frm.Show();

                }
                Clear_Controls();

                this.Close();
            }
            else
            {
                MessageBox.Show("First Fill All Fields");
            }

            Tiles_App_Sherard_Content.Con_Close();
            /// Update Purchase_Bill_Details
            /// Set Paid_Amount = Paid, Balance_Amount = Balance 

            /// Insert Data Into Purchase Payment

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }

        void Clear_Controls()
        {
            tb_Supplier_Name.Clear();
            tb_Total_Amount.Clear();
            tb_Paid_Amount.Clear();
            tb_Balance_Amount.Clear();
            tb_Paid_Amount.Clear();
            tb_Paying_Amount.Text = "0";
        }     
    }
}
