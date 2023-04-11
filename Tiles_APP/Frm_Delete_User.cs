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
    public partial class Frm_Delete_User : Form
    {
        public Frm_Delete_User()
        {
            InitializeComponent();
        }

        private void cmb_UserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_Username.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct (Username) from Login_Details where User_Role = '" + cmb_UserRole.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Username.Items.Add(dr["Username"].ToString());
            }
            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            if (tb_Admin_Password.Text != "" && cmb_Username.Text != "" && cmb_UserRole.Text != "")
            {
                Tiles_App_Sherard_Content.Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select Count(*) from Login_Details where User_Role = 'Admin' And Password = '" + tb_Admin_Password.Text + "' ";
                Cmd.Connection = Tiles_App_Sherard_Content.Con;

                int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cmd.Dispose();

                if (Cnt > 0)
                {
                    Cmd.CommandText = "Delete From Login_Details where User_Role = '" + cmb_UserRole.Text + "' And Username = '" + cmb_Username.Text + "' ";
                    Cmd.Connection = Tiles_App_Sherard_Content.Con;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmb_Username.SelectedIndex = -1;
                    cmb_UserRole.SelectedIndex = -1;
                    tb_Admin_Password.Clear();

                    Tiles_App_Sherard_Content.Con_Close();
                }
                else
                {
                    MessageBox.Show("Admin Password Incorrect!", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select or Enter All Details Correctly", "Incomplte Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
