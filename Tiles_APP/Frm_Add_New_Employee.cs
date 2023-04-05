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
    public partial class Frm_Add_New_Employee : Form
    {
        public Frm_Add_New_Employee()
        {
            InitializeComponent();
        }
        private void Frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
            tb_Employee_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Employee_Details", "Employee_ID", 401));
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && Cmb_Gender.Text != "" && dtp_DOB.Text != "" && tb_Aadhar_Number.Text != "" && tb_Mobile_Number.Text != "" && tb_Alternative_Mob_No.Text !="" && dtp_Joining_Date.Text !="" && tb_Experience.Text !="" && Cmb_Post.Text !="" && tb_Email_ID.Text !="" && tb_Qualification.Text !="" && tb_PAN_Number.Text !="" && tb_Salary.Text !="")
            {

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Tiles_App_Sherard_Content.Con;
                Cmd.CommandText = "Insert into Employee_Details(Employee_ID,Employee_Name,Gender,DOB,Aadhar_Number,Mobile_Number,Alternative_Mob_No,Joining_Date,Experience,Post,Email_ID,Qualifications,PAN_Number,Salary)Values(@EI,@EN,@GENDER,@DOB,@AN,@MN,@AMN,@JD,@EXPERIENCE,@POST,@EMAIL_ID,@QUALIFICATION,@PN,@SALARY)";

                Cmd.Parameters.Add("EI",SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("EN", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("GENDER", SqlDbType.VarChar).Value = Cmb_Gender.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("AN", SqlDbType.Decimal).Value = tb_Aadhar_Number.Text;
                Cmd.Parameters.Add("MN", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                Cmd.Parameters.Add("AMN", SqlDbType.Decimal).Value = tb_Alternative_Mob_No.Text;
                Cmd.Parameters.Add("JD", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;
                Cmd.Parameters.Add("EXPERIENCE", SqlDbType.NVarChar).Value = tb_Experience.Text;
                Cmd.Parameters.Add("POST", SqlDbType.VarChar).Value = Cmb_Post.Text;
                Cmd.Parameters.Add("EMAIL_ID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("QUALIFICATION", SqlDbType.NVarChar).Value = tb_Qualification.Text;
                Cmd.Parameters.Add("PN", SqlDbType.NVarChar).Value = tb_PAN_Number.Text;
                Cmd.Parameters.Add("SALARY", SqlDbType.Money).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Text(sender, e);
        }

        private void btn_Update_Employee_Information_Click(object sender, EventArgs e)
        {

        }
        void Clear_Controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Employee_Details", "Employee_ID", 401));
            tb_Employee_Name.Clear();
            Cmb_Gender.SelectedIndex = -1;
            dtp_DOB.Text = "";
            tb_Aadhar_Number.Clear();
            tb_Mobile_Number.Clear();
            tb_Alternative_Mob_No.Clear();
            dtp_Joining_Date.Text = "";
            tb_Experience.Clear();
            Cmb_Post.SelectedIndex = -1;
            tb_Email_ID.Clear();
            tb_Qualification.Clear();
            tb_PAN_Number.Clear();
            tb_Salary.Clear();
        }

    }
}
