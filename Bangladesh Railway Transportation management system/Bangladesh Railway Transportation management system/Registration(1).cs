using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RLSELRE\SQLEXPRESS;Initial Catalog=bangladeshRailwayManagementDB;Integrated Security=True;Encrypt=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        register r = new register();
        private void register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernamebox2.Text.Trim()))
            {
                errorProvider1.SetError(usernamebox2, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider1.SetError(usernamebox2, string.Empty);
            }

            if (string.IsNullOrEmpty(passwordbox.Text.Trim()))
            {
                errorProvider2.SetError(passwordbox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider2.SetError(passwordbox, string.Empty);
            }

            if (string.IsNullOrEmpty(emailbox.Text.Trim()))
            {
                errorProvider3.SetError(emailbox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider3.SetError(emailbox, string.Empty);
            }

            if (string.IsNullOrEmpty(pbox.Text.Trim()))
            {
                errorProvider4.SetError(pbox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider4.SetError(pbox, string.Empty);
            }

            if (string.IsNullOrEmpty(dateTimePicker1.Text.Trim()))
            {
                errorProvider5.SetError(dateTimePicker1, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(dateTimePicker1, string.Empty);
            }

            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                errorProvider5.SetError(comboBox1, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(comboBox1, string.Empty);
            }

            if (string.IsNullOrEmpty(addressbox.Text.Trim()))
            {
                errorProvider5.SetError(addressbox, " please fullfill the information");
                return;
            }
            else
            {
                errorProvider5.SetError(addressbox, string.Empty);
            }


            r.User = usernamebox2.Text;
            r.Password = passwordbox.Text;
            r.Email = emailbox.Text;
            r.Phone = pbox.Text;
            r.DOB = dateTimePicker1.Text;
            r.Gender = comboBox1.Text;
            r.Address = addressbox.Text;

            bool success = r.Insert(r);

            if (success == true)
            {
                MessageBox.Show("Successfully data Inserted!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 
            }
            else
            {
                MessageBox.Show("Data Insertion failed!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dt = r.Select();
        }

        private void usernamebox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form Registrationtype = new RegistrationType();
            Registrationtype.Show();
            this.Hide();
        }
    }



    
}
