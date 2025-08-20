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

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KPFVTBL\SQLEXPRESS;Initial Catalog=BangladeshRailwayManagement;Integrated Security=True;Encrypt=False");
        private void adminnametxt(object sender, EventArgs e)
        {

        }

        private void adminpwtxt(object sender, EventArgs e)
        {

        }

        private void adminemailtxt(object sender, EventArgs e)
        {
        }

        string otp = "1234";

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adminnmtxt.Text.Trim()))
            {
                errorProvider1.SetError(adminnmtxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(adminnmtxt, string.Empty);
            }

            if (string.IsNullOrEmpty(adpwtxt.Text.Trim()))
            {
                errorProvider2.SetError(adpwtxt, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(adpwtxt, string.Empty);
            }

            if (string.IsNullOrEmpty(adminemail.Text.Trim()))
            {
                errorProvider2.SetError(adminemail, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(adminemail, string.Empty);
            }
            if (string.IsNullOrEmpty(OTPbox.Text.Trim()))
            {
                errorProvider2.SetError(OTPbox, " please enter the OTP");
                return;
            }
            else
            {
                errorProvider2.SetError(OTPbox, string.Empty);
            }


            if (OTPbox.Text == otp)
            {

                string query = "insert into admindetails values( '" + adminnmtxt.Text + "','" + adpwtxt.Text + "','" + adminemail.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form Form1 = new homepage();
                        Form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                    MessageBox.Show("Wrong otp ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form Registrationtype = new RegistrationType();
            Registrationtype.Show();
            this.Hide();
        }

        private void OTPbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
