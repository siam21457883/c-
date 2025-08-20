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


namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class TicketDetails : Form
    {
        public TicketDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        private void backbtn_Click(object sender, EventArgs e)
        {
            Form Admin = new Admin();
            Admin.Show();
            this.Hide();
            
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select *from bookinglist", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void TicketDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TicketDetails_Load_1(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
