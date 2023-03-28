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
    public partial class Frm_Invoice_List : Form
    {
        public Frm_Invoice_List()
        {
            InitializeComponent();
        }

        private void Frm_Invoice_List_Load(object sender, EventArgs e)
        {

            tb_Invoice_ID.Focus();
            Tiles_App_Sherard_Content.Bind_Grid(dgv_Invoice_List, "Select * From Invoice_Bill_Details");
        }

        private void tb_Invoice_ID_Leave(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Customer_Name From Invoice_Bill_Details where Invoice_ID = '" + tb_Invoice_ID.Text + "' ");
            Cmd.Connection = Tiles_App_Sherard_Content.Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Custmer_Name.Text = (obj["Customer_Name"].ToString());
            }

            obj.Dispose();
            Cmd.Dispose();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void dgv_Invoice_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int Row = e.RowIndex;

            Shared_Class.Invoice_No = Convert.ToInt32(dgv_Invoice_List.Rows[Row].Cells[0].Value);

            Frm_Invoice_Pending_Bill Obj = new Frm_Invoice_Pending_Bill();
            Obj.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Invoice_ID.Clear();
            tb_Custmer_Name.Clear();

            Tiles_App_Sherard_Content.Bind_Grid(dgv_Invoice_List, "Select * From Invoice_Bill_Details");
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }
    }
}
