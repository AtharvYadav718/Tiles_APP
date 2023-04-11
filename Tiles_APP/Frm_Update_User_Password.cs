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
    public partial class Frm_Update_User_Password : Form
    {
        public Frm_Update_User_Password()
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

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            if (cmb_Username.Text != "" && cmb_UserRole.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "")
            {
                if (tb_Password.Text == tb_Confirm_Password.Text)
                {
                    Tiles_App_Sherard_Content.Con_Open();

                    SqlCommand Cmd = new SqlCommand("Update Login_Details Set Password =  '" + tb_Password.Text + "' where User_Role = '" + cmb_UserRole.Text + "' And Username = '" + cmb_Username.Text + "' ", Tiles_App_Sherard_Content.Con);

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Password Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmb_Username.SelectedIndex = -1;
                    cmb_UserRole.SelectedIndex = -1;
                    tb_Password.Clear();
                    tb_Confirm_Password.Clear();

                    Tiles_App_Sherard_Content.Con_Close();
                }
                else
                {
                    MessageBox.Show("Password & Confirm Password Didn't Matched", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select or Enter All Details Correctly", "Incomplte Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
