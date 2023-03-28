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
    public partial class Frm_Add_New_Supplier : Form
    {
        public Frm_Add_New_Supplier()
        {
            InitializeComponent();
        }

        private void Frm_Add_New_Supplier_Load(object sender, EventArgs e)
        {
            tb_Supplier_ID.Focus();
            tb_Supplier_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Supplier_Details", "Supplier_ID", 301));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            if( tb_Supplier_ID.Text !="" && tb_Supplier_Name.Text !="" && dtp_Tie_Up_Date.Text !="" && tb_Aadhar_No.Text !="" && tb_Email_ID.Text !="" && tb_Mobile_No.Text !="" && tb_Alternative_Mob_No.Text !="" && tb_Address.Text !="" && tb_PAN_No.Text !="" )
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tiles_App_Sherard_Content.Con;
                cmd.CommandText= "Insert into Supplier_Details(Supplier_ID,Supplier_Name,Aadhar_Number,Email_ID,Tie_Up_Date,Mobile_Number,Alternative_Mob_No,Address,PAN_Number,Note)Values(@SI,@SN,@AN,@EI,@TUD,@MOB,@AMOB,@ADD,@PAN,@NOTE)";

                cmd.Parameters.Add("@SI",SqlDbType.Int).Value = tb_Supplier_ID.Text;
                cmd.Parameters.Add("@SN", SqlDbType.VarChar).Value = tb_Supplier_Name.Text;
                cmd.Parameters.Add("@AN", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                cmd.Parameters.Add("@EI", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                cmd.Parameters.Add("@TUD", SqlDbType.Date).Value = dtp_Tie_Up_Date.Value.Date;
                cmd.Parameters.Add("@MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("@AMOB", SqlDbType.Decimal).Value = tb_Alternative_Mob_No.Text;
                cmd.Parameters.Add("@ADD", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("@PAN", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                cmd.Parameters.Add("@NOTE", SqlDbType.NVarChar).Value = tb_Note.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else 
            {
                MessageBox.Show("Fill All Field Are Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tb_Supplier_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Supplier_Details", "Supplier_ID", 301));
            tb_Supplier_Name.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_ID.Clear();
            dtp_Tie_Up_Date.Text = "";
            tb_Mobile_No.Clear();
            tb_Alternative_Mob_No.Clear();
            tb_Address.Clear();
            tb_PAN_No.Clear();
            tb_Note.Clear();
        }
    }
}
