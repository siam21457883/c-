using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bangladesh_Railway_Transportation_management_system
{
    internal class adminreg
    {  
        public int UserName {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DataTable select() {
 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");

            DataTable dt = new DataTable();

            string query = "Select * from admindetails";           

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(adminreg a)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {
                string query = "Insert into admindetails (username,password,email)values(@UserName,@Password,@Email)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", a.UserName);
                cmd.Parameters.AddWithValue("@password", a.Password);
                cmd.Parameters.AddWithValue("@email", a.Email);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred:" + e.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
