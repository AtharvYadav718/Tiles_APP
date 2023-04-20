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
    public partial class Frm_Invoice_Details : Form
    {
        public Frm_Invoice_Details()
        {
            InitializeComponent();
        }

        int C_Stock = 0, p_Cnt = 1;

        private void Frm_Invoice_Details_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();
            tb_Invoice_No.Text = Convert.ToString(Tiles_App_Sherard_Content.Auto_Incr("Invoice_Bill_Details", "Invoice_ID", 601));
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
            Tiles_App_Sherard_Content.Con_Close();
        }

        private void Cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Subcategory_Name.Items.Clear();

            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Tiles_App_Sherard_Content.Con;
            Cmd.CommandText = "Select Distinct(Subcategory_Name) from Subcategory_Details where Category_Name = '" + Cmb_Category_Name.Text + "' ";

            SqlDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                Cmb_Subcategory_Name.Items.Add(dr["Subcategory_Name"].ToString());
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
            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Category_Name ='" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + Cmb_Subcategory_Name.Text + "' ";
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

            SqlCommand Cmd = new SqlCommand("Select  Sales_Rate, Stock_Quantity, Stock_Unit From Product_Details where Category_Name = '" + Cmb_Category_Name.Text + "' And Subcategory_Name = '" + Cmb_Subcategory_Name.Text + "' And Product_Name = '" + Cmb_Product_Name.Text + "' ", Tiles_App_Sherard_Content.Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
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

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {

            if (tb_Quantity.Text == "" || tb_Quantity.Text == "0")
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Quantity.Text = "0";
                tb_Quantity.Focus();
            }
            else if (Convert.ToInt32(tb_Quantity.Text) > C_Stock)
            {
                MessageBox.Show("No Enough Stock");
                tb_Quantity.Focus();
            }
            else
            {
                btn_Add.Enabled = true;

                tb_Total.Text = Convert.ToString(Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Sales_Price.Text));
            }
        }

        private void Paid_Amount(object sender, EventArgs e)
        {

            if (tb_Total_Amount.Text != "" && tb_Total_Amount.Text != "0")
            {
                double Paid_Amt = Convert.ToDouble(tb_Total_Amount.Text) - (Convert.ToDouble(tb_Paying_Amount.Text));
                tb_Balance_Amount.Text = Convert.ToString(Paid_Amt);
                btn_Save.Enabled = true;
            }
        }


        private void tb_Customer_ID_Leave(object sender, EventArgs e)
        {
            Tiles_App_Sherard_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Customer_Name From Customer_Details where Customer_ID = '" + tb_Customer_ID.Text + "' ");
            Cmd.Connection = Tiles_App_Sherard_Content.Con;

            SqlDataReader obj = Cmd.ExecuteReader();
            if (obj.Read())
            {
                tb_Customer_Name.Text = (obj["Customer_Name"].ToString());
            }

            obj.Dispose();
            Cmd.Dispose();


            Tiles_App_Sherard_Content.Con_Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Cmb_Category_Name.Text != "" && Cmb_Subcategory_Name.Text != "" && Cmb_Product_Name.Text != "" && tb_Quantity.Text != "" && tb_Unit.Text != "" && tb_Sales_Price.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

                for (int i = 0; i <= dgv_Invoice_Details.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgv_Invoice_Details.Rows[i].Cells[3].Value) == Cmb_Product_Name.Text && Convert.ToString(dgv_Invoice_Details.Rows[i].Cells[2].Value) == Cmb_Subcategory_Name.Text && Convert.ToString(dgv_Invoice_Details.Rows[i].Cells[1].Value) == Cmb_Category_Name.Text)
                    {
                        flag = 0;

                        Qty += Convert.ToInt32(dgv_Invoice_Details.Rows[i].Cells[4].Value);

                        if (C_Stock >= Qty)
                        {
                            double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Sales_Price.Text);

                            dgv_Invoice_Details.Rows[i].Cells[4].Value = Qty;
                            dgv_Invoice_Details.Rows[i].Cells[7].Value = Tot_Price;
                        }
                        else
                        {
                            MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = 1;
                        }
                    }
                }

                if (flag == -1)
                {
                    if (C_Stock >= Qty)
                    {
                        dgv_Invoice_Details.Rows.Add(p_Cnt, Cmb_Category_Name.Text, Cmb_Subcategory_Name.Text, Cmb_Product_Name.Text, tb_Quantity.Text, tb_Unit.Text, tb_Sales_Price.Text, tb_Total.Text);

                        p_Cnt++;
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }

                if (flag < 1)
                {
                    double Bill = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Total.Text);

                    tb_Total_Amount.Text = Convert.ToString(Bill);
                }

                Cmb_Category_Name.SelectedIndex = -1;
                Cmb_Subcategory_Name.SelectedIndex = -1;
                Cmb_Product_Name.SelectedIndex = -1;

                tb_Total.Clear();
                tb_Quantity.Clear();
                tb_Unit.Clear();
                tb_Sales_Price.Clear();

                tb_Quantity.Enabled = false;

                btn_Add.Enabled = false;

            }
        }
     
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Invoice_No.Text != "" && tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && tb_Total_Amount.Text != "" && tb_Paying_Amount.Text != "" && tb_Balance_Amount.Text != "")
            {
                int invoiceId = Convert.ToInt32(tb_Invoice_No.Text);

                Tiles_App_Sherard_Content.Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Invoice_Bill_Details Values (@I_ID,@Date,@Cust_ID,@Cust_Name,@Disc,@GST,@Total_Bill,@Paid_Bill,@Balance_Amount)", Tiles_App_Sherard_Content.Con);

                cmd.Parameters.Add("@I_ID", SqlDbType.Int).Value = tb_Invoice_No.Text;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Invoice_Date.Value.Date;
                cmd.Parameters.Add("@Cust_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                cmd.Parameters.Add("@Cust_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                cmd.Parameters.Add("@Disc", SqlDbType.Float).Value = tb_Discount.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = tb_Total_Amount.Text;
                cmd.Parameters.Add("@Paid_Bill", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd.Parameters.Add("@Balance_Amount", SqlDbType.Money).Value = tb_Balance_Amount.Text;


                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i <= dgv_Invoice_Details.Rows.Count - 1; i++)
                {
                     int CStock = 0;

                    SqlCommand cmd1 = new SqlCommand("Insert Into Invoice_Details Values (@I_ID,@Cat,@SubCat,@Product_Name,@Quantity,@Unit,@sale_Price,@Total)", Tiles_App_Sherard_Content.Con);

                    cmd1.Parameters.Add("@I_ID", SqlDbType.Int).Value = tb_Invoice_No.Text;
                    cmd1.Parameters.Add("@Cat", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat", SqlDbType.NVarChar).Value = dgv_Invoice_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Quantity", SqlDbType.Int).Value = dgv_Invoice_Details.Rows[i].Cells[4].Value;
                    cmd1.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = dgv_Invoice_Details.Rows[i].Cells[5].Value;
                    cmd1.Parameters.Add("@sale_Price", SqlDbType.Money).Value = dgv_Invoice_Details.Rows[i].Cells[6].Value;
                    cmd1.Parameters.Add("@Total", SqlDbType.Money).Value = dgv_Invoice_Details.Rows[i].Cells[7].Value;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                    cmd1.CommandText = "Select Stock_Quantity from Product_Details where Category_Name = @Cat1 And Subcategory_Name = @SubCat1 And Product_Name = @Product_Name1";
                    cmd1.Connection = Tiles_App_Sherard_Content.Con;

                    cmd1.Parameters.Add("@Cat1", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat1", SqlDbType.NVarChar).Value = dgv_Invoice_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name1", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[3].Value;

                    SqlDataReader Dr = cmd1.ExecuteReader();

                    if (Dr.Read())
                    {
                        CStock = Convert.ToInt32((Dr["Stock_Quantity"].ToString())) - Convert.ToInt32(dgv_Invoice_Details.Rows[i].Cells[4].Value);
                    }

                    cmd1.Dispose();
                    Dr.Close();

                    cmd1.CommandText = "Update Product_Details Set Stock_Quantity = @Qty WHERE Category_Name = @Cat2 And Subcategory_Name = @SubCat2 And Product_Name = @Product_Name2 ";
                    cmd1.Connection = Tiles_App_Sherard_Content.Con;

                    cmd1.Parameters.Add("@Cat2", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@SubCat2", SqlDbType.NVarChar).Value = dgv_Invoice_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Product_Name2", SqlDbType.VarChar).Value = dgv_Invoice_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Qty", SqlDbType.Int).Value = CStock;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                }

                SqlCommand cmd2 = new SqlCommand("Insert Into Invoice_Recieve values (@I_ID,@C_Name,@Date,@Paying_Amount,@Payment_Mode)", Tiles_App_Sherard_Content.Con);

                cmd2.Parameters.Add("@I_ID", SqlDbType.Int).Value = tb_Invoice_No.Text;
                cmd2.Parameters.Add("@C_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                cmd2.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Invoice_Date.Value;
                cmd2.Parameters.Add("@Paying_Amount", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd2.Parameters.Add("@Payment_Mode", SqlDbType.VarChar).Value = Cmb_Payment_Mode.Text;

                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                MessageBox.Show("Invoice Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                if (invoiceId > 0)
                {
                    Reports.Report_Forms.Frm_Customer_Invoice frm = new Reports.Report_Forms.Frm_Customer_Invoice();
                    frm.showREport(invoiceId);
                    frm.Show();

                }

            }
            else
            {
                MessageBox.Show("Fill Product & Invoice Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Tiles_App_Sherard_Content obj = new Tiles_App_Sherard_Content();
            obj.Only_Numeric(sender,e);
        }

        private void btn_All_Rate_Click(object sender, EventArgs e)
        {
            Frm_Product_List Obj = new Frm_Product_List();
            Obj.Show();
            this.Hide();
        }

        void Clear_Control()
        {
            tb_Customer_ID.Clear();
            tb_Customer_Name.Clear();
            dtp_Invoice_Date.Text = "";
            tb_Discount.Clear();
            tb_GST.Clear();
            tb_Total_Amount.Clear();
            tb_Paying_Amount.Clear();
            tb_Balance_Amount.Clear();
            Cmb_Payment_Mode.SelectedIndex = -1;
            dgv_Invoice_Details.Rows.Clear();
        }
    }
}
