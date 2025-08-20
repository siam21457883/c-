using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangladesh_Railway_Transportation_management_system
{
    internal class register
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public DataTable Select()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");

            DataTable dt = new DataTable();

            string query = "Select * from userdetails";
          
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.Fill(dt);

            return dt;
        }

        public bool Insert(register r)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {

                string query = "Insert into userdetails (username,password,email,phone,dob,gender,address)values(@Username,@Password,@Email,@Phone,@DOB,@Gender,@Address)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username",r.User);
                cmd.Parameters.AddWithValue("@password", r.Password);
                cmd.Parameters.AddWithValue("@email", r.Email);
                cmd.Parameters.AddWithValue("@phone", r.Phone);
                cmd.Parameters.AddWithValue("@dob", r.DOB);
                cmd.Parameters.AddWithValue("@gender", r.Gender);
                cmd.Parameters.AddWithValue("@address", r.Address);

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


        public bool Delete(register m)
        {

            bool isSuccess = false;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {

                string query = "Delete from userdetails where username=@username";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", m.User);

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
