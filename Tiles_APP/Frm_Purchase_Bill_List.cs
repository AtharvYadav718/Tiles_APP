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
    public partial class Frm_Purchase_Bill_List : Form
    {
        public Frm_Purchase_Bill_List()
        {
            InitializeComponent();
        }
        private void Frm_Purchase_List_Load(object sender, EventArgs e)
        {
            cmb_Supplier_Name.Focus();
            Bind_ComboBox();
            Tiles_App_Sherard_Content.Bind_Grid(dgv_Purchase_List, "Select * From Purchase_Bill_Details");
        }

        void Bind_ComboBox()
        {
            cmb_Supplier_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Supplier_Name) from Supplier_Details ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Supplier_Name.Items.Add(dr["Supplier_Name"].ToString());
            }
            dr.Close();

            Tiles_App_Sherard_Content.Con_Close();
        }     

        private void cmb_Supplier_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Bind_Grid(dgv_Purchase_List, "Select * From Purchase_Bill_Details where Supplier_Name = '" + cmb_Supplier_Name.Text + "'");

            double Amount = 0;
            for (int i = 0; i <= dgv_Purchase_List.Rows.Count - 1; i++)
            {
                Amount += Convert.ToDouble(dgv_Purchase_List.Rows[i].Cells[6].Value);
            }

            tb_Total_Amount.Text = Amount.ToString();
        }
        private void dgv_Purchase_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;

            Shared_Class.Purchase_ID = Convert.ToInt32(dgv_Purchase_List.Rows[Row].Cells[0].Value);

            Frm_Purchase_Pending_Bill Obj = new Frm_Purchase_Pending_Bill();
            Obj.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Supplier_Name.SelectedIndex = -1;
            Tiles_App_Sherard_Content.Bind_Grid(dgv_Purchase_List, "Select * From Purchase_Bill_Details");
        }      
    }
}
