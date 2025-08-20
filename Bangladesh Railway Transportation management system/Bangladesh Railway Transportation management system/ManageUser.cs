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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KPFVTBL\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        register m =new register();

        private void deletebtn_Click(object sender, EventArgs e)
        {
            m.User = usernamebox.Text;

            bool success = m.Delete(m);

            if (success == true)
            {
                MessageBox.Show("Successfully data Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Data Deletion failed!");
            }

            DataTable dt = m.Select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select *from userdetails", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form Admin = new Admin();
            Admin.Show();
            this.Hide();
        }
    }
}
