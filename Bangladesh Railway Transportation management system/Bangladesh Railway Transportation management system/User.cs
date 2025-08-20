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
    public partial class User : Form
    {
        string uname = homepage.u;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KPFVTBL\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        public User()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from userdetails where username='"+uname+"'",con);
            label3.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to logout?", "closing window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form Form1 = new homepage();
                Form1.Show();
                this.Hide();
            }
        }

        private void ticketsbutton_Click(object sender, EventArgs e)
        {
            Form Tickets = new Tickets();
            Tickets.Show();
            this.Hide();
        }

        private void Schedulebutton(object sender, EventArgs e)
        {
            Form Schedule = new Schedule();
            Schedule.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
