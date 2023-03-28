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
    public partial class Frm_Tiles_APP_Login : Form
    {
        public Frm_Tiles_APP_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

           Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection =Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Count(*) From Login_Details where User_Role=@URole And Username= @Uname And Password= @Pwd";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("URole", SqlDbType.VarChar).Value = Cmb_User_Role.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared_Class.Username = tb_Username.Text;

                Frm_Menu_Form obj = new Frm_Menu_Form();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");
            }
            tb_Username.Clear();
            tb_Password.Clear();

            Cmb_User_Role.Focus();

           Tiles_App_Sherard_Content.Con_Close();
 
        }
        private void Frm_Tiles_APP_Login_Load(object sender, EventArgs e)
        {
            Cmb_User_Role.SelectedIndex = -1;
            Cmb_User_Role.Focus();
        }
    }
}
