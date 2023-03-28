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
    public partial class Frm_Customer_Information : Form
    {
        public Frm_Customer_Information()
        {
            InitializeComponent();

        }
        private void Frm_Customer_Information_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Focus();
            tb_Customer_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Customer_Details", "Customer_ID", 101));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if (tb_Customer_ID.Text != "" && tb_Custmer_Name.Text != "" && tb_Aadhar_No.Text != "" && tb_PAN_No.Text != "" && tb_Mobile_No.Text != "" && tb_Alternative_Mob_No.Text != "" )
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText = "Insert into Customer_Details(Customer_ID,Customer_Name,Aadhar_No,PAN_No,Date,Mobile_No,Alt_Mob_No,Address)Values(@CD,@CN,@AN,@PN,@DATE,@MOB,@AMOB,@ADDRESS)";
               
                cmd.Parameters.Add("CD",SqlDbType.Int).Value= tb_Customer_ID.Text;
                cmd.Parameters.Add("CN", SqlDbType.VarChar).Value= tb_Custmer_Name.Text;
                cmd.Parameters.Add("AN",SqlDbType.Decimal).Value= tb_Aadhar_No.Text;
                cmd.Parameters.Add("PN", SqlDbType.NVarChar).Value= tb_PAN_No.Text;
                cmd.Parameters.Add("DATE",SqlDbType.Date).Value= dtp_Date.Value.Date;
                cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value= tb_Mobile_No.Text;
                cmd.Parameters.Add("AMOB", SqlDbType.Decimal).Value= tb_Alternative_Mob_No.Text;
                cmd.Parameters.Add("ADDRESS", SqlDbType.NVarChar).Value= tb_Address.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully","Welcome" , MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Field Are Compulsary", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        
        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Customer_Details", "Customer_ID", 101));
            tb_Custmer_Name.Clear();
            tb_Aadhar_No.Clear();
            tb_PAN_No.Clear();
            dtp_Date.Text = "";
            tb_Mobile_No.Clear();
            tb_Alternative_Mob_No.Clear();
            tb_Address.Clear();
        }

    }
}