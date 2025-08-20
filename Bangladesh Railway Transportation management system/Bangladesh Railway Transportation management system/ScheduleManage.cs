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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class ScheduleManage : Form
    {
        public ScheduleManage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KPFVTBL\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        private void trainnotxtbox(object sender, EventArgs e)
        {
           
        }

        private void traindestinationtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticketpricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timetxt_TextChanged(object sender, EventArgs e)
        {
        }

        DataAccess d = new DataAccess();

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trainnotxt.Text.Trim()))
            {
                errorProvider1.SetError(trainnotxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(trainnotxt,string.Empty);
            }

            if (string.IsNullOrEmpty(traindestinationtxt.Text.Trim()))
            {
                errorProvider2.SetError(traindestinationtxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(traindestinationtxt, string.Empty);
            }

            if (string.IsNullOrEmpty(ticketpricetxt.Text.Trim()))
            {
                errorProvider3.SetError(ticketpricetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider3.SetError(ticketpricetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(datetxt.Text.Trim()))
            {
                errorProvider4.SetError(datetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider4.SetError(datetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(timetxt.Text.Trim()))
            {
                errorProvider5.SetError(timetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(timetxt, string.Empty);
            }

            d.TrainNo = int.Parse(trainnotxt.Text);
            d.TrainDestination = traindestinationtxt.Text;
            d.Date = datetxt.Text;
            d.Time = timetxt.Text;
            d.TicketPrice = int.Parse(ticketpricetxt.Text);

            bool success = d.Insert(d);

            try {
                if (success == true)
                {
                   
                    Clear();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred:" +ex.Message);
            }

           if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                
                MessageBox.Show("Data Insertion failed!");
            }

            DataTable dt = d.select();
            dataGridView1.DataSource = dt;

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trainnotxt.Text.Trim()))
            {
                errorProvider1.SetError(trainnotxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(trainnotxt, string.Empty);
            }

            if (string.IsNullOrEmpty(traindestinationtxt.Text.Trim()))
            {
                errorProvider2.SetError(traindestinationtxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(traindestinationtxt, string.Empty);
            }

            if (string.IsNullOrEmpty(ticketpricetxt.Text.Trim()))
            {
                errorProvider3.SetError(ticketpricetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider3.SetError(ticketpricetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(datetxt.Text.Trim()))
            {
                errorProvider4.SetError(datetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider4.SetError(datetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(timetxt.Text.Trim()))
            {
                errorProvider5.SetError(timetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(timetxt, string.Empty);
            }



            d.TrainNo = int.Parse(trainnotxt.Text);
            d.TrainDestination = traindestinationtxt.Text;
            d.Date = datetxt.Text;
            d.Time = timetxt.Text;
            d.TicketPrice = int.Parse(ticketpricetxt.Text);

            bool success = d.Update(d);

            if (success == true)
            {
                MessageBox.Show("Successfully data Updated!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Data Update failed!");
            }

            DataTable dt = d.select();
            dataGridView1.DataSource = dt;

        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trainnotxt.Text.Trim()))
            {
                errorProvider1.SetError(trainnotxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(trainnotxt, string.Empty);
            }

            if (string.IsNullOrEmpty(traindestinationtxt.Text.Trim()))
            {
                errorProvider2.SetError(traindestinationtxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(traindestinationtxt, string.Empty);
            }

            if (string.IsNullOrEmpty(ticketpricetxt.Text.Trim()))
            {
                errorProvider3.SetError(ticketpricetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider3.SetError(ticketpricetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(datetxt.Text.Trim()))
            {
                errorProvider4.SetError(datetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider4.SetError(datetxt, string.Empty);
            }

            if (string.IsNullOrEmpty(timetxt.Text.Trim()))
            {
                errorProvider5.SetError(timetxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(timetxt, string.Empty);
            }


            d.TrainNo = int.Parse(trainnotxt.Text);

            bool success = d.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Successfully data Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }

            DataTable dt = d.select();
            dataGridView1.DataSource = dt;

        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            Form Admin = new Admin();
            Admin.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            int row_index = e.RowIndex;

            trainnotxt.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            traindestinationtxt.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            datetxt.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            timetxt.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            ticketpricetxt.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();

        }

        private void trainnotextbox(object sender, EventArgs e)
        {
            trainnotxt.Focus();
        }

        public void Clear()
        {
            trainnotxt.Text = null;
            traindestinationtxt.Text = null;
            datetxt.Text = null;
            timetxt.Text = null;
            ticketpricetxt.Text = null;
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select *from Schedule", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void ScheduleManage_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
