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
    public partial class Frm_Remaining_Stock : Form
    {
        public Frm_Remaining_Stock()
        {
            InitializeComponent();
        }

        private void Frm_Remaining_Stock_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
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

            Tiles_App_Sherard_Content.Bind_Grid(dgv_Remaining_Stock, "Select Stock_Quantity,Stock_Unit From Product_Details where Category_Name = '" + cmb_Subcategory_Name.Text + "'");

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

            Tiles_App_Sherard_Content.Bind_Grid(dgv_Remaining_Stock, "Select Stock_Quantity,Stock_Unit From Product_Details where Category_Name = '" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "'");

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Bind_Grid(dgv_Remaining_Stock, "Select Stock_Quantity,Stock_Unit From Product_Details where Category_Name = '" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ");

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;

            Tiles_App_Sherard_Content.Bind_Grid(dgv_Remaining_Stock, "Select  Stock_Quantity,Stock_Unit From Product_Details");
        }       
    }
}
