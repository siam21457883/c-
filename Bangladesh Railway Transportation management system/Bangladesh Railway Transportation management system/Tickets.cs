using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class Tickets : Form
    {
       
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        
        string usname = homepage.u;
        public Tickets()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from userdetails where username='" + usname + "'", con);
            usernametxt.Text = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("select email from userdetails where username='" + usname + "'", con);
            emailtxtbox.Text = cmd1.ExecuteScalar().ToString();
            con.Close();
        }

        private void book_Click(object sender, EventArgs e)
        {
                     if (string.IsNullOrEmpty(trainnocombobox.Text.Trim()))
                     {
                         errorProvider1.SetError(trainnocombobox, " please fullfill the information");
                         return;
                     }
                     else
                     {
                         errorProvider1.SetError(trainnocombobox, string.Empty);
                     }

                     if (string.IsNullOrEmpty(traindestinationcomboBox.Text.Trim()))
                     {
                         errorProvider2.SetError(traindestinationcomboBox, " please fullfill the information");
                         return;
                     }
                     else
                     {
                         errorProvider2.SetError(traindestinationcomboBox, string.Empty);
                     }

                     if (string.IsNullOrEmpty(usernametxt.Text.Trim()))
                     {
                         errorProvider3.SetError(usernametxt, " please fullfill the information");
                         return;
                     }
                     else
                     {
                         errorProvider3.SetError(usernametxt, string.Empty);
                     }

                     if (string.IsNullOrEmpty(emailtxtbox.Text.Trim()))
                     {
                         errorProvider4.SetError(emailtxtbox, " please fullfill the information");
                         return;
                     }
                     else
                     {
                         errorProvider4.SetError(emailtxtbox, string.Empty);
                     }

                     
            int trainNo;
            if (!int.TryParse(trainnocombobox.Text, out trainNo))
            {
                MessageBox.Show("Invalid Train No. Please enter a valid number.");
                return;
            }

            string trainDestination = traindestinationcomboBox.Text;
            string username = usernametxt.Text;
            string email = emailtxtbox.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                
                string insertQuery = "INSERT INTO bookinglist (username, email, TrainNo, TrainDestination, Date, Time, TicketPrice) " +
                                     "SELECT @Username, @Email, @TrainNo, TrainDestination, Date, Time, TicketPrice " +
                                     "FROM Schedule " +
                                     "WHERE TrainNo = @TrainNo AND TrainDestination = @TrainDestination ";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                    cmd.Parameters.AddWithValue("@TrainDestination", trainDestination);

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Booking successful!");
                        }
                        else
                        {
                            MessageBox.Show("Booking failed. Please check your inputs.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred:" +ex.Message);
                    }
                }
            }

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Clear()
        {

        }

        private void traindestinationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            
        }

       void BindData()
        {
               con.Open();
               SqlCommand cmd = new SqlCommand("SELECT username, email, TrainNo, Date, Time, TicketPrice FROM bookinglist", con);
               SqlDataAdapter sd = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();
               sd.Fill(dt);

               dataGridView1.DataSource = dt;
               con.Close();
            
        }
        
        private void back_Click(object sender, EventArgs e)
        {
            Form user = new User();
            user.Show();
            this.Hide();
        }


        private void time_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void usernametxtbox(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tickets_Load_1(object sender, EventArgs e)
        {

        }

        private void trainnocombobox_SelectedIndexChanged(object sender, EventArgs e)
        {    

        }

        private void traindestinationcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Datetext_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TimetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Tickets_Load_2(object sender, EventArgs e)
        {
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trainnocombobox.Text.Trim()))
            {
                errorProvider1.SetError(trainnocombobox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(trainnocombobox, string.Empty);
            }

            if (string.IsNullOrEmpty(traindestinationcomboBox.Text.Trim()))
            {
                errorProvider2.SetError(traindestinationcomboBox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(traindestinationcomboBox, string.Empty);
            }

            if (string.IsNullOrEmpty(usernametxt.Text.Trim()))
            {
                errorProvider3.SetError(usernametxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider3.SetError(usernametxt, string.Empty);
            }

            if (string.IsNullOrEmpty(emailtxtbox.Text.Trim()))
            {
                errorProvider4.SetError(emailtxtbox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider4.SetError(emailtxtbox, string.Empty);
            }


            int trainNo;
            if (!int.TryParse(trainnocombobox.Text, out trainNo))
            {
                MessageBox.Show("Invalid Train No. Please enter a valid number.");
                return;
            }

            string trainDestination = traindestinationcomboBox.Text;
            string username = usernametxt.Text;
            string email = emailtxtbox.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();


                string deleteQuery = "DELETE FROM [dbo].[bookinglist]     WHERE [TrainNo]='" + trainnocombobox.Text+ "' and [username]='"+usernametxt.Text+"'";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                    cmd.Parameters.AddWithValue("@TrainDestination", trainDestination);

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Booking Cancel successful!");
                        }
                        else
                        {
                            MessageBox.Show("Booking Cancel failed. Please check your inputs.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred:" + ex.Message);
                    }
                }
            }

        }
    }
}
