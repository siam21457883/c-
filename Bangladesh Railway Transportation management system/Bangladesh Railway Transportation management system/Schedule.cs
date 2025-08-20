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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPFVTBL\\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        private void backbutton(object sender, EventArgs e)
        {
            Form User = new User();
            User.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showtable(object sender, EventArgs e)
        {
            

        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select *from Schedule", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
