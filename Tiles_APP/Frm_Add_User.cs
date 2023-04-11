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
    public partial class Frm_Add_User : Form
    {
        public Frm_Add_User()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "" && cmb_UserRole.Text != "")
            {
                if (tb_Password.Text == tb_Confirm_Password.Text)
                {
                    int id = Tiles_App_Sherard_Content.Auto_Incr("Login_details","User_ID",1);
                    SqlCommand cmd = new SqlCommand("Insert Into Login_Details Values (@User_ID , @User_Role, @Username, @Password ) ", Tiles_App_Sherard_Content.Con);

                    cmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@User_Role", SqlDbType.NVarChar).Value = cmb_UserRole.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tb_Confirm_Password.Text;

                    Tiles_App_Sherard_Content.Con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   Tiles_App_Sherard_Content.Con_Close();

                    cmb_UserRole.SelectedIndex = -1;
                    tb_Username.Clear();
                    tb_Password.Clear();
                    tb_Confirm_Password.Clear();
                }
                else
                {
                    MessageBox.Show("Password Didn't Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select All Options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            Frm_Delete_User Obj = new Frm_Delete_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            Frm_Menu_Form.pnl_ChildForm.Controls.Clear();
            Frm_Menu_Form.pnl_ChildForm.Controls.Add(Obj);

            Obj.Show();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            Frm_Update_User_Password Obj = new Frm_Update_User_Password() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            Frm_Menu_Form.pnl_ChildForm.Controls.Clear();
            Frm_Menu_Form.pnl_ChildForm.Controls.Add(Obj);

            Obj.Show();
        }
    }
}
