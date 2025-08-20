using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class homepage : Form
    {
        public static string u;
        public homepage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KPFVTBL\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registerclick(object sender, EventArgs e)
        {
            Form Registrationtype = new RegistrationType();
            Registrationtype.Show();
            this.Hide();
           
        }

        private void exitclick(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to exit?", "closing window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void loginclick(object sender, EventArgs e)
        {
                u = usernamebox1.Text;
                string username = u;
                string password = passbox.Text;

                string query = @"SELECT [username], [password], 'Admin' AS [UserType] FROM [BangladeshRailwayManagement].[dbo].[admindetails] WHERE [username] = '" + username + "' AND [password] = '" + password + @"'
                     UNION ALL
                     SELECT [username], [password], 'User' AS [UserType] FROM [BangladeshRailwayManagement].[dbo].[userdetails] WHERE [username] = '" + username + "' AND [password] = '" + password + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string userType = dt.Rows[0]["UserType"].ToString();

                    if (userType == "Admin")
                    {
                    Form Admin = new Admin();
                    Admin.Show();
                    this.Hide();
                }
                    else if (userType == "User")
                    {
                    Form User = new User();
                    User.Show();
                    this.Hide();
                    }

                    MessageBox.Show("Login Successful!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Inputs!","Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void passwordbox(object sender, EventArgs e)
        {

        }

        private void usernamebox(object sender, EventArgs e)
        {

        }

        private void usernamebox1_TextChanged(object sender, EventArgs e)
        {
            usernamebox1.Focus();
        }

        private void usernamebox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void passbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
