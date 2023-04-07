using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_APP
{
    public partial class Frm_Menu_Form : Form
    {
        public Frm_Menu_Form()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnl_Master_Submenu.Visible = false;
            pnl_Purchase_Submenu.Visible = false;
            pnl_Sale_Submenu.Visible = false;
            pnl_Stock_Submenu.Visible = false;
            pnl_Reports_Submenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(pnl_Master_Submenu.Visible == true)
                pnl_Master_Submenu.Visible=false;
            if (pnl_Purchase_Submenu.Visible == true)
                pnl_Purchase_Submenu.Visible = false;
            if(pnl_Sale_Submenu.Visible==true)
                pnl_Sale_Submenu.Visible=false;
            if (pnl_Stock_Submenu.Visible == true)
                pnl_Stock_Submenu.Visible = false;
            if (pnl_Reports_Submenu.Visible == true)
                pnl_Reports_Submenu.Visible = false;
        }

        private void showSubmenu(Panel Submenu)
        {
            if(Submenu.Visible==false)
            {
                hideSubmenu();
                Submenu.Visible=true;
            }
            else
                Submenu.Visible=false;
        }

        private void btn_Master_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Master_Submenu);
        }

        private void btn_Customer_Information_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Customer_Information());
           // hideSubmenu();
            lbl_Head.Text = "Customer Information";
        }

        private void btn_Supplier_Information_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Add_New_Supplier());
          //  hideSubmenu();
            lbl_Head.Text = "Supplier Information";
        }

        private void btn_Product_Information_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Add_New_Product());
          //  hideSubmenu();
            lbl_Head.Text = "Product Information";
        }
       
        private void btn_Employee_Information_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Add_New_Employee());
           // hideSubmenu();
            lbl_Head.Text = "Employee Information";
        }

        private void btn_Category_Details_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Add_New_Category());
            //  hideSubmenu();
            lbl_Head.Text = "Category Details";
        }
       
        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Purchase_Submenu);
        }

        private void btn_Purchase_Bill_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Purchase_Bill());
            hideSubmenu();
            lbl_Head.Text = "Purchase Bill";
        }

        private void btn_Purchase_Bill_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Purchase_Bill_List());
            hideSubmenu();
            lbl_Head.Text = "Purchase Bill List";
        }
        private void btn_Sale_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Sale_Submenu);
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Invoice_Details());
            hideSubmenu();
            lbl_Head.Text = "Invoice";
        }

        private void btn_Invoice_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Invoice_List());
            hideSubmenu();
            lbl_Head.Text = "Invoice List";
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_Stock_Submenu);
        }

        private void btn_Remaining_Stock_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Remaining_Stock());
            hideSubmenu();
            lbl_Head.Text = "Remaining Stock";
        }

        private void btn_Dead_Stock_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Dead_Stock());
            hideSubmenu();
            lbl_Head.Text = "Dead Stock";
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Product_List());
            hideSubmenu();
            lbl_Head.Text = "Product List";
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {

            showSubmenu(pnl_Reports_Submenu);
        }

        private void btn_Customer_Entry_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.Report_Forms.Frm_Customer_Entry());
            hideSubmenu();
            lbl_Head.Text = "Customer Entry";
        }

        private void btn_Supplier_Entry_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.Report_Forms.Frm_Suppiler_Entry());
            hideSubmenu();
            lbl_Head.Text = "Supplier Entry";
        }

        private void btn_Datewise_Report_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.Report_Forms.Frm_Invoice_Bill_D());
            hideSubmenu();
            lbl_Head.Text = "Shop Total Collection";
        }

        private Form activeForm=null;
        private void openChildForm(Form childForm)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            pnl_ChildForm.Controls.Add(childForm);
            pnl_ChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();

        }      
    }
}
