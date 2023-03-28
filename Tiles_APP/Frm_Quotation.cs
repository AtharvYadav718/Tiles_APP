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
    public partial class Frm_Quotation : Form
    {
        public Frm_Quotation()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if(tb_Quotation_No.Text !="" && dtp_Date.Text !="" && tb_Quotation_Custmer_Name.Text !="" && Cmb_Category_Name.Text !="" && cmb_Subcategory_Name.Text !="" && cmb_Product_Name.Text !="" && tb_Unit.Text !="" && tb_Quantity.Text !="" && tb_Sales_Price.Text !="" && tb_GST.Text !="" && tb_Total_Amount.Text !="")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "Insert into Quotation_Details(Quotation_No,Date,Quotation_Cust_Name,Category_Name,Subcategory_Name,Product_Name,Unit,Quantity,Sales_Price,GST,Total_Amount)values(@QN,@DATE,@QCN,@CN,@SN,@PN,@UNIT,@QUN,@SP,@GST,@TM)";

                cmd.Parameters.Add("QN",SqlDbType.Int).Value = tb_Quotation_No.Text;
                cmd.Parameters.Add("DATE", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("QCN", SqlDbType.VarChar).Value = tb_Quotation_Custmer_Name.Text;
                cmd.Parameters.Add("CN",SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("SN",SqlDbType.NVarChar).Value = cmb_Subcategory_Name.Text;
                cmd.Parameters.Add("PN", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                cmd.Parameters.Add("UNIT", SqlDbType.Int).Value = tb_Unit.Text;
                cmd.Parameters.Add("QUN",SqlDbType.Int).Value = tb_Quantity.Text;
                cmd.Parameters.Add("SP",SqlDbType.Money).Value = tb_Sales_Price.Text;
                cmd.Parameters.Add("GST", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("TM",SqlDbType.Money).Value = tb_Total_Amount.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Succesfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill All Field Are Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Quotation_List_Click(object sender, EventArgs e)
        {
            Frm_Quotation_List obj = new Frm_Quotation_List();
            this.Hide();
            obj.Show();
        }
    }
}
