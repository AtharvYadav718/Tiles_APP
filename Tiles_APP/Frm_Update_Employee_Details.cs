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
    public partial class Frm_Update_Employee_Details : Form
    {
        public Frm_Update_Employee_Details()
        {
            InitializeComponent();
        }

        private void Frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();
            SqlCommand Cmd = new SqlCommand("Select * from Employee_Details where  Employee_ID= '" + tb_Employee_ID.Text + "' ", Tiles_App_Sherard_Content.Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Employee_Name.Text = Dr.GetString(Dr.GetOrdinal("Employee_Name"));
                cmb_Gender.Text = Dr.GetString(Dr.GetOrdinal("Gender"));
                dtp_DOB.Text = (Dr["DOB"].ToString());
                tb_Aadhar_Number.Text = (Dr["Aadhar_Number"].ToString());
                tb_Mobile_Number.Text = (Dr["Mobile_Number"].ToString());
                tb_Alternative_Mob_No.Text = (Dr["Alternative_Mob_No"].ToString());
                dtp_Joining_Date.Text = (Dr["Joining_Date"].ToString());
                tb_Experience.Text = Dr.GetString(Dr.GetOrdinal("Experience"));
                cmb_Post.Text = Dr.GetString(Dr.GetOrdinal("Post"));
                tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("Email_ID"));
                tb_Qualification.Text = Dr.GetString(Dr.GetOrdinal("Qualifications"));
                tb_PAN_Number.Text = (Dr["PAN_Number"].ToString());
                tb_Salary.Text = (Dr["Salary"].ToString());

            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Employee Id");
                tb_Employee_ID.Clear();
            }
            Tiles_App_Sherard_Content.Con_Close();

            tb_Employee_ID.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();
            if (tb_Mobile_Number.Text != "" && tb_Alternative_Mob_No.Text != "" && tb_Salary.Text != "" && tb_Experience.Text != "" && tb_Qualification.Text != "" && cmb_Post.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Tiles_App_Sherard_Content.Con;
                Cmd.CommandText = "Update Employee_Details Set Mobile_Number = @Mob_No, Alternative_Mob_No = @Alt_Mob_No, Experience = @Experience, Qualifications = @Qualification , Salary = @Salary Where Employee_ID= '" + tb_Employee_ID.Text + " ' ";

                Cmd.Parameters.Add("@Mob_No", SqlDbType.NVarChar).Value = tb_Mobile_Number.Text;
                Cmd.Parameters.Add("@Alt_Mob_No", SqlDbType.NVarChar).Value = tb_Alternative_Mob_No.Text;
                Cmd.Parameters.Add("@Experience", SqlDbType.NVarChar).Value = tb_Experience.Text;
                Cmd.Parameters.Add("@Post", SqlDbType.NVarChar).Value = cmb_Post.Text;
                Cmd.Parameters.Add("@Qualification", SqlDbType.NVarChar).Value = tb_Qualification.Text;
                Cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = tb_Salary.Text;


                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

            }
            else
            {
                MessageBox.Show("First Fill All Fields");
            }

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        void Clear_Controls()
        {
            tb_Employee_ID.Clear();
            tb_Employee_Name.Clear();
            cmb_Gender.SelectedIndex = -1;
            dtp_DOB.Text = "";
            tb_Aadhar_Number.Clear();
            tb_Mobile_Number.Clear();
            tb_Alternative_Mob_No.Clear();
            dtp_Joining_Date.Text = "";
            tb_Experience.Clear();
            cmb_Post.SelectedIndex = -1;
            tb_Email_ID.Clear();
            tb_Qualification.Clear();
            tb_PAN_Number.Clear();
            tb_Salary.Clear();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }
    }
}
