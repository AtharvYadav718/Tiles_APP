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
    public partial class Frm_Purchase_Bill : Form
    {
        public Frm_Purchase_Bill()
        {
            InitializeComponent();
        }

        int C_Stock = 0, p_Cnt = 1;
        private void Frm_Purchase_Bill_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            tb_Purchase_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Purchase_Bill_Details", "Purchase_ID", 501));
        }

        void Bind_ComboBox()
        {
            Cmb_Category_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Category_Name) from Category_Details ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Category_Name.Items.Add(dr["Category_Name"].ToString());
            }

            dr.Close();
            Cmd.Dispose();
            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Supplier_Name) from Supplier_Details ";

            dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Supplier_Name.Items.Add(dr["Supplier_Name"].ToString());
            }
            dr.Close();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_Subcategory_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Subcategory_Name) from Subcategory_Details where Category_Name = '" + Cmb_Category_Name.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Subcategory_Name.Items.Add(dr["Subcategory_Name"].ToString());
            }

            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void cmb_Subcategory_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Product_Name.Items.Clear();
            Tiles_App_Sherard_Content.Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Category_Name ='" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "' ";
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_Product_Name.Items.Add(dr["Product_Name"].ToString());
            }
            dr.Close();
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            C_Stock = 0;

            SqlCommand Cmd = new SqlCommand("Select Purchase_Rate, Sales_Rate, Stock_Quantity, Stock_Unit From Product_Details where Category_Name = '" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + cmb_Subcategory_Name.Text + "' And Product_Name = '" + Cmb_Product_Name.Text + "' ", Tiles_App_Sherard_Content.Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Purchase_Price.Text = (obj["Purchase_Rate"].ToString());
                tb_Sales_Price.Text = (obj["Sales_Rate"].ToString());
                tb_Unit.Text = (obj["Stock_Unit"].ToString());

                C_Stock = Convert.ToInt32(obj["Stock_Quantity"]);
            }

            if (tb_Unit.Text == "Box")
            {
                C_Stock *= 12;
            }

            tb_Quantity.Enabled = true;

            obj.Dispose();
            Cmd.Dispose();

            Tiles_App_Sherard_Content.Con_Close();
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "")
            {
                btn_Add.Enabled = true;
                tb_Total.Text = Convert.ToString(Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Purchase_Price.Text));
            }
        }

        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "")
            {
                double Disc = Convert.ToDouble(tb_Total_Amount.Text) * (Convert.ToDouble(tb_Discount.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Total_Amount.Text) - Disc;

                tb_Total_Amount.Text = Convert.ToString(Tot_Bill);

                btn_Save.Enabled = true;
            }
        }

        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if (tb_GST.Text != "")
            {
                double GST = Convert.ToDouble(tb_Total_Amount.Text) * (Convert.ToDouble(tb_GST.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Total_Amount.Text) + GST;

                tb_Total_Amount.Text = Convert.ToString(Tot_Bill);

                btn_Save.Enabled = true;
            }
        }

        private void tb_Paid_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Total_Amount.Text != "" && tb_Total_Amount.Text != "0")
            {
                double Paid_Amt = Convert.ToDouble(tb_Total_Amount.Text) - (Convert.ToDouble(tb_Paying_Amount.Text));
                tb_Balance_Amount.Text = Convert.ToString(Paid_Amt);
                btn_Save.Enabled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && Cmb_Product_Name.Text != "" && tb_Quantity.Text != "" && tb_Unit.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[3].Value) == Cmb_Product_Name.Text && Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[2].Value) == cmb_Subcategory_Name.Text && Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[1].Value) == Cmb_Category_Name.Text)
                    {
                        flag = 0;

                        Qty += Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[4].Value);

                        double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Sales_Price.Text);

                        dgv_Purchase_Details.Rows[i].Cells[4].Value = Qty;
                        dgv_Purchase_Details.Rows[i].Cells[8].Value = Tot_Price;
                    }
                }

                if (flag == -1)
                {
                    dgv_Purchase_Details.Rows.Add(p_Cnt, Cmb_Category_Name.Text, cmb_Subcategory_Name.Text, Cmb_Product_Name.Text, tb_Quantity.Text, tb_Unit.Text, tb_Purchase_Price.Text, tb_Sales_Price.Text, tb_Total.Text);

                    p_Cnt++;
                }

                double Bill = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Total.Text);
                tb_Total_Amount.Text = Convert.ToString(Bill);

                Cmb_Category_Name.SelectedIndex = -1;
                cmb_Subcategory_Name.SelectedIndex = -1;
                Cmb_Product_Name.SelectedIndex = -1;

                tb_Total.Clear();
                tb_Quantity.Clear();
                tb_Unit.Clear();
                tb_Purchase_Price.Clear();
                tb_Sales_Price.Clear();

                tb_Quantity.Enabled = false;

                btn_Add.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Purchase_ID.Text != "" && Cmb_Supplier_Name.Text != "" && tb_Total_Amount.Text != "" && tb_Paying_Amount.Text != "" && tb_Balance_Amount.Text != "")
            {
                int Purchase_Id = Convert.ToInt32(tb_Purchase_ID.Text);

                Tiles_App_Sherard_Content.Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Purchase_Bill_Details Values (@P_ID,@S_Name,@Disc,@GST,@Total_Bill,@Paid_Bill,@Balance_Amount,@Purchase_Date)", Tiles_App_Sherard_Content.Con);

                cmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = tb_Purchase_ID.Text;
                cmd.Parameters.Add("@S_Name", SqlDbType.VarChar).Value = Cmb_Supplier_Name.Text;
                cmd.Parameters.Add("@Disc", SqlDbType.Float).Value = tb_Discount.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = tb_Total_Amount.Text;
                cmd.Parameters.Add("@Paid_Bill", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd.Parameters.Add("@Balance_Amount", SqlDbType.Money).Value = tb_Balance_Amount.Text;
                cmd.Parameters.Add("@Purchase_Date", SqlDbType.Date).Value = dtp_Purchase_Date.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    int CStock = 0;

                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = "Insert Into Purchase_Details Values (@P_ID,@Cat,@SubCat,@Product_Name,@Quantity,@Purchase_Unit,@Purchase_Price,@sale_Price,@Total)";
                    cmd1.Connection = Tiles_App_Sherard_Content.Con;

                    cmd1.Parameters.Add("@P_ID", SqlDbType.Int).Value = tb_Purchase_ID.Text;
                    cmd1.Parameters.Add("@Cat", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Quantity", SqlDbType.Int).Value = dgv_Purchase_Details.Rows[i].Cells[4].Value;
                    cmd1.Parameters.Add("@Purchase_Unit", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[5].Value;
                    cmd1.Parameters.Add("@Purchase_Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[6].Value;
                    cmd1.Parameters.Add("@sale_Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[7].Value;
                    cmd1.Parameters.Add("@Total", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[8].Value;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                    cmd1.CommandText = "Select Stock_Quantity from Product_Details where Category_Name = @Cat1 And Subcategory_Name = @SubCat1 And Product_Name = @Product_Name1";
                    cmd1.Connection = Tiles_App_Sherard_Content.Con;

                    cmd1.Parameters.Add("@Cat1", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat1", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name1", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;

                    SqlDataReader Dr = cmd1.ExecuteReader();

                    if (Dr.Read())
                    {
                        CStock = Convert.ToInt32((Dr["Stock_Quantity"].ToString())) + Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[4].Value) ;
                    }

                    cmd1.Dispose();
                    Dr.Close();

                    cmd1.CommandText = "Update Product_Details Set Stock_Quantity = @Qty WHERE Category_Name = @Cat2 And Subcategory_Name = @SubCat2 And Product_Name = @Product_Name2 ";
                    cmd1.Connection = Tiles_App_Sherard_Content.Con;

                    cmd1.Parameters.Add("@Cat2", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat2", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name2", SqlDbType.VarChar).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Qty", SqlDbType.Int).Value = CStock;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }
                /// Insert Data Into Purchase Payment

                SqlCommand cmd2 = new SqlCommand("Insert Into Purchase_Pending values (@P_ID,@Date,@S_Name,@Paying_Amount,@Payment_Mode)", Tiles_App_Sherard_Content.Con);

                cmd2.Parameters.Add("@P_ID", SqlDbType.Int).Value = tb_Purchase_ID.Text;
                cmd2.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Purchase_Date.Text;
                cmd2.Parameters.Add("@S_Name", SqlDbType.VarChar).Value = Cmb_Supplier_Name.Text;
                cmd2.Parameters.Add("@Paying_Amount", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd2.Parameters.Add("@Payment_Mode", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                MessageBox.Show("Purchase Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                if (Purchase_Id > 0)
                {
                    Reports.Report_Forms.Frm_Purchase_Challan frm = new Reports.Report_Forms.Frm_Purchase_Challan();
                    frm.showREport(Purchase_Id);
                    frm.Show();

                }

                /* if (!string.IsNullOrEmpty(tb_Purchase_ID.Text))
                 {
                     Frm_Purchase_Report report = new Frm_Purchase_Report();
                     report.showREport(Convert.ToInt32(tb_Purchase_ID.Text));
                     report.Show();
                 }*/
            }
            else
            {
                MessageBox.Show("Fill Product & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender, e);
        }

        void Clear_Control()
        {
            tb_Purchase_ID.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Purchase_Bill_Details", "Purchase_ID", 501));

            Cmb_Supplier_Name.SelectedIndex = -1;
            dtp_Purchase_Date.Text = "";
            tb_Discount.Clear();
            tb_GST.Clear();
            tb_Total_Amount.Clear();
            tb_Paying_Amount.Clear();
            tb_Balance_Amount.Clear();
            cmb_Payment_Mode.SelectedIndex = -1;
            dgv_Purchase_Details.Rows.Clear();
        }
    }
}
