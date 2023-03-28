using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiles_APP
{
    class Tiles_App_Sherard_Content
    {
        
        public static SqlConnection Con = new SqlConnection(@"Data Source=ATHARV;Initial Catalog=Tiles_APP_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }

        public static int Auto_Incr(string Table_Name, string ID_Field_Name, int Start_Point)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "Select Count (*) From " + Table_Name + "";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                cmd.Dispose();

                cmd.Connection = Con;
                cmd.CommandText = "Select Max(" + ID_Field_Name + ") From " + Table_Name + "";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar()) ;

                Cnt += 1;
            }
            else
            {
                Cnt = Start_Point;
            }
            Con_Close();
            return Cnt;
        }
        public void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }
        public void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }      
        public static void Bind_Grid(DataGridView DGV, string Query)
        {
            Con_Open();

            DGV.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            DGV.DataSource = dt;

            Con_Close();
        }

    }
}