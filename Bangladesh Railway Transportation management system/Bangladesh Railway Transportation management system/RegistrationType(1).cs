using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangladesh_Railway_Transportation_management_system
{
    public partial class RegistrationType : Form
    {
        public RegistrationType()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            Form Registration = new Registration();
            Registration.Show();
            this.Hide();    
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            Form AdminRegistation = new AdminRegistration();
            AdminRegistation.Show();
            this.Hide();

        }

        private void backbtnclick(object sender, EventArgs e)
        {
            Form Form1 = new homepage();
            Form1.Show();
            this.Hide();
        }
    }
}
