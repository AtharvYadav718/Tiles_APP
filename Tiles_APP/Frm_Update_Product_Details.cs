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
    public partial class Frm_Update_Product_Details : Form
    {
        public Frm_Update_Product_Details()
        {
            InitializeComponent();
        }

        private void Frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Category_Name ,Subcategory_Name,Product_Name,Purchase_Rate,Sales_Rate From Product_Details where Product_ID = " + tb_Product_ID.Text + " ", Tiles_App_Sherard_Content.Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Category_Name.Text = obj.GetString(obj.GetOrdinal("Category_Name"));
                tb_Subcategory_Name.Text = obj.GetString(obj.GetOrdinal("Subcategory_Name"));
                tb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                tb_Purchase_Rate.Text = (obj["Purchase_Rate"].ToString());
                tb_Sales_Rate.Text = (obj["Sales_Rate"].ToString());
                tb_Product_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Product ID!!!");
                tb_Product_ID.Clear();
                tb_Product_ID.Focus();
            }
            obj.Dispose();
            Tiles_App_Sherard_Content.Con_Close();
          //  tb_Product_ID.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if (tb_Purchase_Rate.Text != "" && tb_Sales_Rate.Text != "" && tb_Product_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Tiles_App_Sherard_Content.Con;
                Cmd.CommandText = "Update Product_Details Set  Product_Name = @Product_Name , Purchase_Rate= @Purchase_Rate, Sales_Rate = @Sales_Rate where Product_ID = '" + tb_Product_ID.Text + "' ";
                Cmd.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("@Purchase_Rate", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                Cmd.Parameters.Add("@Sales_Rate", SqlDbType.Money).Value = tb_Sales_Rate.Text;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Product Details Updated Successfully");


            }
            else
            {
                MessageBox.Show("First Fill All Fields");
            }

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
            tb_Product_ID.Enabled = true;
            tb_Product_ID.Focus();
        }
        void Clear_Control()
        {
            tb_Product_ID.Clear();
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();
            tb_Product_Name.Clear();
            tb_Category_Name.Clear();
            tb_Subcategory_Name.Clear();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }
    }
}
