using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangladesh_Railway_Transportation_management_system
{
    internal class userticketbook
    {
        public string username { get; set; }
        public int trainno { get; set; }
        public string traindestination { get; set; }
        public string email {get;set;}


       public DataTable select()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");

            DataTable dt = new DataTable();

            string query = "Select * Schedule INNER JOIN bookinglist ON Schedule.TrainNo=bookinglist.TrainNo]";
         

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);

            return dt;
        }

        public bool Insert(userticketbook u)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {

                string query = "Insert into bookinglist (username,email,TrainNo,TrainDestination)values(@username,@email,@trainno,@traindestination)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@TrainNo", u.trainno);
                cmd.Parameters.AddWithValue("@TrainDestination", u.traindestination);
                cmd.Parameters.AddWithValue("@email", u.email);
 

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

            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }



    }


}
