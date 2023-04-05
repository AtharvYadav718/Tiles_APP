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
    public partial class Frm_Add_New_Product : Form
    {
        public Frm_Add_New_Product()
        {
            InitializeComponent();
        }

        private void Frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            tb_Product_ID.Focus();
            tb_Product_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Product_Details", "Product_ID", 201));
        }

        void Bind_ComboBox()
        {
            Cmb_Category_Name.Items.Clear();
            Tiles_App_Sherard_Content.Con_Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Tiles_App_Sherard_Content.Con;
            cmd.CommandText = "Select Distinct(Category_Name) from Category_Details";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Category_Name.Items.Add(dr["Category_Name"].ToString());
            }

            dr.Close();
            cmd.Dispose();


            cmd.Connection = Tiles_App_Sherard_Content.Con;
            cmd.CommandText = "Select Distinct(Supplier_Name) from Supplier_Details ";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Supplier_Name.Items.Add(dr["Supplier_Name"].ToString());
            }
            dr.Close();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Subcategory_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct (Subcategory_Name) from Subcategory_Details where Category_Name = '" + Cmb_Category_Name.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Subcategory_Name.Items.Add(dr["Subcategory_Name"].ToString());
            }
            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();
            if (tb_Product_ID.Text != "" && Cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && tb_Product_Name.Text != "" && Cmb_Supplier_Name.Text != "" && dtp_Date.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sales_Rate.Text != "" && tb_Stock_Quantity.Text != "" && Cmb_Stock_Unit.Text !="")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "Insert into Product_Details(Product_ID, Category_Name,Subcategory_Name,Product_Name,Supplier_Name,Date,Purchase_Rate,Sales_Rate,Stock_Quantity,Stock_Unit) Values(@PI,@CN,@SN,@PN,@SNM,@DATE,@PR,@SR,@SQ,@SU)";

                cmd.Parameters.Add("PI", SqlDbType.Int).Value = tb_Product_ID.Text;
                cmd.Parameters.Add("CN", SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("SN", SqlDbType.NVarChar).Value = cmb_Subcategory_Name.Text;
                cmd.Parameters.Add("PN", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("SNM", SqlDbType.VarChar).Value = Cmb_Supplier_Name.Text;
                cmd.Parameters.Add("DATE", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("PR", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                cmd.Parameters.Add("SR", SqlDbType.Money).Value = tb_Sales_Rate.Text;
                cmd.Parameters.Add("SQ", SqlDbType.Int).Value = tb_Stock_Quantity.Text;
                cmd.Parameters.Add("SU", SqlDbType.NVarChar).Value = Cmb_Stock_Unit.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            Tiles_App_Sherard_Content.Con_Close();
        }
 
        private void btn_Update_Product_Details_Click(object sender, EventArgs e)
        {

        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }

        void Clear_Controls()
        {
            tb_Product_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Product_Details", "Product_ID", 201));

            Cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            tb_Product_Name.Clear();
            Cmb_Supplier_Name.SelectedIndex = -1;
            dtp_Date.Text = "";
            tb_Purchase_Rate.Clear();
            tb_Sales_Rate.Clear();  
            tb_Stock_Quantity.Clear();
            Cmb_Stock_Unit.SelectedIndex = -1;
          
        }      
    }
}
