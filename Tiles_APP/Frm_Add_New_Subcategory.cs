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
    public partial class Frm_Add_New_Subcategory : Form
    {
        public Frm_Add_New_Subcategory()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if(Cmb_Category_Name.Text !="" && tb_Subcategory_ID.Text !="" && tb_Subcategory_Name.Text !="")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "Insert into Subcategory_Details(Category_Name,Subcategory_ID,Subcategory_Name)Values(@CN,@SI,@SN)";

                cmd.Parameters.Add("CN",SqlDbType.VarChar).Value = Cmb_Category_Name.Text;
                cmd.Parameters.Add("SI",SqlDbType.Int).Value = tb_Subcategory_ID.Text;
                cmd.Parameters.Add("SN",SqlDbType.VarChar).Value = tb_Subcategory_Name.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Succesfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Field Are Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();

            }
        }

        void Clear_Controls()
        {
            tb_Subcategory_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Subcategory_Details","Subcategory_ID",51));
    
            Cmb_Category_Name.SelectedIndex = -1 ;
            tb_Subcategory_Name.Clear();
        }

        private void Frm_Add_New_Subcategory_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            Clear_Controls();
            tb_Subcategory_ID.Focus();
            tb_Subcategory_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Subcategory_Details", "Subcategory_ID",51));   
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
            Tiles_App_Sherard_Content.Con_Close();
        }
    }
}
