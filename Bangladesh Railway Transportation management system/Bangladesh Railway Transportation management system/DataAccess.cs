using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bangladesh_Railway_Transportation_management_system
{
    internal class DataAccess
    {
        public int TrainNo{ get; set; }
        public string TrainDestination {  get; set; }
        public string Date {  get; set; }
        public string Time {  get; set; }
        public int TicketPrice {  get; set; }

        public DataTable select () {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            DataTable dt = new DataTable();

            string query = "select *from Schedule ";

            SqlDataAdapter sda = new SqlDataAdapter(query,con);

            sda.Fill(dt);

            return dt;

        }
        public bool Insert(DataAccess s)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {
                string query = "Insert into Schedule (TrainNo,TrainDestination,Date,Time,TicketPrice)values(@TrainNo,@TrainDestination,@Date,@Time,@TicketPrice)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TrainNo", s.TrainNo);
                cmd.Parameters.AddWithValue("@TrainDestination", s.TrainDestination);
                cmd.Parameters.AddWithValue("@Date", s.Date);
                cmd.Parameters.AddWithValue("@Time", s.Time);
                cmd.Parameters.AddWithValue("@TicketPrice", s.TicketPrice);

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
                MessageBox.Show("An error occurred:" +e.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        public bool Update(DataAccess s)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {

                string query = "Update Schedule set  TrainDestination=@TrainDestination, Date=@Date, Time=@Time, TicketPrice=@TicketPrice where TrainNo=@TrainNo";
  
                SqlCommand cmd = new SqlCommand(query, con);

                
                cmd.Parameters.AddWithValue("@TrainDestination", s.TrainDestination);
                cmd.Parameters.AddWithValue("@Date", s.Date);
                cmd.Parameters.AddWithValue("@Time", s.Time);
                cmd.Parameters.AddWithValue("@TicketPrice", s.TicketPrice);
                cmd.Parameters.AddWithValue("@TrainNo", s.TrainNo);

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
                MessageBox.Show("An error occurred:" +e.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


        public bool Delete(DataAccess s)
        {

            bool isSuccess = false;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
            try
            {

                string query = "Delete from Schedule where TrainNo=@TrainNo";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@TrainNo", s.TrainNo);

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
