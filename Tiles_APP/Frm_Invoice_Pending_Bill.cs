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
    public partial class Frm_Invoice_Pending_Bill : Form
    {
        public Frm_Invoice_Pending_Bill()
        {
            InitializeComponent();
        }

        private void Frm_Invoice_Pending_Bill_Load(object sender, EventArgs e)
        {
            tb_Invoice_No.Text = Convert.ToString(Shared_Class.Invoice_No);

            Tiles_App_Sherard_Content.Con_Open();

            tb_Customer_Name.Clear();
            tb_Total_Amount.Clear();
            tb_Paid_Amount.Clear();
            tb_Balance_Amount.Clear();
            tb_Paid_Amount.Clear();
            tb_Paying_Amount.Text = "0";
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Customer_Name ,Total_Bill,Paid_Bill,Balance_Amount from Invoice_Bill_Details where  Invoice_ID = '" + Convert.ToString(Shared_Class.Invoice_No) + "' ";
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_Customer_Name.Text = (dr["Customer_Name"].ToString());
                tb_Total_Amount.Text = (dr["Total_Bill"].ToString());
                tb_Paid_Amount.Text = (dr["Paid_Bill"].ToString());
                tb_Balance_Amount.Text = (dr["Balance_Amount"].ToString());

            }
            dr.Close();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            double Paid = Convert.ToDouble(tb_Paid_Amount.Text) + Convert.ToDouble(tb_Paying_Amount.Text);
            double Balance = Convert.ToDouble(tb_Balance_Amount.Text) - Convert.ToDouble(tb_Paying_Amount.Text);

            int invoiceId = Convert.ToInt32(tb_Invoice_No.Text);
            Tiles_App_Sherard_Content.Con_Open();
            /// Update Purchase_Bill_Details

            if (tb_Paying_Amount.Text != "" && cmb_Payment_Mode.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Tiles_App_Sherard_Content.Con;
                Cmd.CommandText = "Update Invoice_Bill_Details Set  Paid_Bill = '" + Convert.ToString(Paid) + "' , Balance_Amount= '" + Convert.ToString(Balance) + "'  where  Invoice_ID = '" + Convert.ToString(Shared_Class.Invoice_No) + "' ";
                Cmd.Parameters.Add("@Paid", SqlDbType.Money).Value = tb_Paid_Amount.Text;
                Cmd.Parameters.Add("@Balance", SqlDbType.Money).Value = tb_Balance_Amount.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                /// Insert Data Into Purchase Payment

                SqlCommand cmd1 = new SqlCommand("Insert Into Invoice_Recieve values (@I_ID,@C_Name,@Date,@Paying_Amount,@Payment_Mode)", Tiles_App_Sherard_Content.Con);

                cmd1.Parameters.Add("@I_ID", SqlDbType.Int).Value = tb_Invoice_No.Text;
                cmd1.Parameters.Add("@C_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                cmd1.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Invoice_Date.Text;
                cmd1.Parameters.Add("@Paying_Amount", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd1.Parameters.Add("@Payment_Mode", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();

                MessageBox.Show(" Payment Paid Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (invoiceId > 0)
                {
                    Reports.Report_Forms.Frm_Invoice_Pending_Report frm = new Reports.Report_Forms.Frm_Invoice_Pending_Report();
                    frm.showREport(invoiceId);
                    frm.Show();

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("First Fill All Fields");
            }

            Tiles_App_Sherard_Content.Con_Close();

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }
    }
}
