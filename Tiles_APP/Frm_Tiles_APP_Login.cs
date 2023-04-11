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
        private void Frm_Tiles_APP_Login_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            Cmb_User_Role.SelectedIndex = 0;
            Cmb_User_Role.Focus();
        }

        void Bind_ComboBox()
        {
            Cmb_User_Role.Items.Clear();
            Tiles_App_Sherard_Content.Con_Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Tiles_App_Sherard_Content.Con;
            cmd.CommandText = "Select Distinct(User_Role) from Login_Details";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_User_Role.Items.Add(dr["User_Role"].ToString());
            }

            dr.Close();
            cmd.Dispose();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Username.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct (Username) from Login_Details where User_Role = '" + Cmb_User_Role.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Username.Items.Add(dr["Username"].ToString());
            }
            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

           Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection =Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Count(*) From Login_Details where User_Role=@URole And Username= @Uname And Password= @Pwd";

           
            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = cmb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("URole", SqlDbType.VarChar).Value = Cmb_User_Role.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("WELCOME To Samarath Tiles APP", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Cmb_User_Role.SelectedIndex == 0)
                {
                    Tiles_App_Sherard_Content.UserRole = 1;
                }
                else if (Cmb_User_Role.SelectedIndex == 1)
                {
                    Tiles_App_Sherard_Content.UserRole = 2;
                }
                else if (Cmb_User_Role.SelectedIndex == 2)
                {
                    Tiles_App_Sherard_Content.UserRole = 3;
                }
                else if (Cmb_User_Role.SelectedIndex == 3)
                {
                    Tiles_App_Sherard_Content.UserRole = 4;
                }

                Tiles_App_Sherard_Content.LoggedInUName = cmb_Username.Text;
                Frm_Menu_Form Obj = new Frm_Menu_Form();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Credentials!!!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cmb_User_Role.SelectedIndex = 0;
            cmb_Username.SelectedIndex = -1;
            tb_Password.Text = "";
            Cmb_User_Role.Focus();

            Tiles_App_Sherard_Content.Con_Close();
 
        }


      
    }
}
