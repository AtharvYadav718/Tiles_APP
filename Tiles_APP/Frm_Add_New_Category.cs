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
    public partial class Frm_Add_New_Category : Form
    {
        public Frm_Add_New_Category()
        {
            InitializeComponent();
        }

        private void Frm_Add_New_Category_Load(object sender, EventArgs e)
        {
            tb_Category_ID.Focus();
            tb_Category_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Category_Details", "Category_ID", 1));

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if (tb_Category_ID.Text != "" && tb_Category_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "insert into Category_Details (Category_ID,Category_Name)Values(@CI,@CN)";

                cmd.Parameters.Add("CI", SqlDbType.Int).Value = tb_Category_ID.Text;
                cmd.Parameters.Add("CN", SqlDbType.VarChar).Value = tb_Category_Name.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            Tiles_App_Sherard_Content.Con_Close();
        }
        private void btn_Add_New_Subcategory_Click(object sender, EventArgs e)
        {

        }

        private void tb_Category_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }

        private void tb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Text(sender, e);
        }
      
        void Clear_Controls()
        {
            tb_Category_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Category_Details", "Category_ID", 1));
            tb_Category_Name.Clear();
        }

     
    }
}
