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
    public partial class Frm_Dead_Stock : Form
    {
        public Frm_Dead_Stock()
        {
            InitializeComponent();
        }

        int C_Stock = 0, p_Cnt = 1;

        private void Frm_Dead_Stock_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            tb_Dead_No.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Dead_Stock_Details", "Dead_No", 801));

        }
        void Bind_ComboBox()
        {
            Cmb_Category_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Category_Name) from Category_Details ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Category_Name.Items.Add(dr["Category_Name"].ToString());
            }

            dr.Close();
            Cmd.Dispose();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Subcategory_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Subcategory_Name) from Subcategory_Details where Category_Name = '" + Cmb_Category_Name.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Subcategory_Name.Items.Add(dr["Subcategory_Name"].ToString());
            }

            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void cmb_Subcategory_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_Product_Name.Items.Clear();
            Tiles_App_Sherard_Content.Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Category_Name ='" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "' ";
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Product_Name.Items.Add(dr["Product_Name"].ToString());
            }
            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }      

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            C_Stock = 0;

            SqlCommand Cmd = new SqlCommand("Select  Purchase_Rate, Stock_Quantity, Stock_Unit From Product_Details where Category_Name = '" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ", Tiles_App_Sherard_Content.Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Purchase_Price.Text = (obj["Purchase_Rate"].ToString());
                tb_Unit.Text = (obj["Stock_Unit"].ToString());

                C_Stock = Convert.ToInt32(obj["Stock_Quantity"]);
            }

            if (tb_Unit.Text == "Box")
            {
                C_Stock *= 12;
            }

            tb_Quantity.Enabled = true;

            obj.Dispose();
            Cmd.Dispose();

            Tiles_App_Sherard_Content.Con_Close();
        }
        
        private void tb_Quantity_Leave(object sender, EventArgs e)
        {

            if (tb_Quantity.Text == "" || tb_Quantity.Text == "0")
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Quantity.Text = "0";
                tb_Quantity.Focus();
            }
            else if (Convert.ToInt32(tb_Quantity.Text) > C_Stock)
            {
                MessageBox.Show("No Enough Stock");
                tb_Quantity.Focus();
            }
            else
            {
                tb_Total_Amount.Text = Convert.ToString(Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Purchase_Price.Text));
            }
        }
     
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();
            if (tb_Dead_No.Text != "" && Cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && cmb_Product_Name.Text != "" &&  dtp_Date.Text != "" && tb_Purchase_Price.Text != "" &&  tb_Quantity.Text != "" && tb_Unit.Text != "")
            {
                int CStock = 0;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "Insert into Dead_Stock_Details(Dead_No,Dead_Date,Category_Name,Subcategory_Name,Product_Name,Quantity,Unit,Purchase_Price,Total_Amount) Values(@DN,@DD,@CN,@SN,@PN,@QUANTITY,@UNIT,@PP,@TA)";

                cmd.Parameters.Add("DN", SqlDbType.Int).Value = tb_Dead_No.Text;
                cmd.Parameters.Add("DD", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.Parameters.Add("CN", SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("SN", SqlDbType.NVarChar).Value = cmb_Subcategory_Name.Text;
                cmd.Parameters.Add("PN", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                cmd.Parameters.Add("QUANTITY", SqlDbType.Int).Value = tb_Quantity.Text;
                cmd.Parameters.Add("Unit", SqlDbType.VarChar).Value = tb_Unit.Text;
                cmd.Parameters.Add("PP", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                cmd.Parameters.Add("TA", SqlDbType.Money).Value = tb_Total_Amount.Text;

                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select Stock_Quantity from Product_Details where Category_Name = @Cat1 And Subcategory_Name = @SubCat1 And Product_Name = @Product_Name1";
                cmd.Connection = Tiles_App_Sherard_Content.Con;

                cmd.Parameters.Add("@Cat1", SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("@SubCat1", SqlDbType.NVarChar).Value = cmb_Subcategory_Name.Text;
                cmd.Parameters.Add("@Product_Name1", SqlDbType.VarChar).Value = cmb_Product_Name.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    CStock = Convert.ToInt32((Dr["Stock_Quantity"].ToString())) - Convert.ToInt32(tb_Quantity.Text);
                }

                cmd.Dispose();
                Dr.Close();

                cmd.CommandText = "Update Product_Details Set Stock_Quantity = @Qty WHERE Category_Name = @Cat2 And Subcategory_Name = @SubCat2 And Product_Name = @Product_Name2 ";
                cmd.Connection = Tiles_App_Sherard_Content.Con;

                cmd.Parameters.Add("@Cat2", SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("@SubCat2", SqlDbType.NVarChar).Value = cmb_Subcategory_Name.Text;
                cmd.Parameters.Add("@Product_Name2", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = CStock;

                cmd.ExecuteNonQuery();
                cmd.Dispose();



                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            Tiles_App_Sherard_Content.Con_Close();

        }

        void Clear_Control()
        {
            tb_Dead_No.Clear();
            dtp_Date.Text = "";
            Cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Quantity.Clear();
            tb_Unit.Clear();
            tb_Purchase_Price.Clear();
            tb_Total_Amount.Clear();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }
    }
}
