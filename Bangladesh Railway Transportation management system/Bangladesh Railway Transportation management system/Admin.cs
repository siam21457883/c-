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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void schedulemanagebtn_Click(object sender, EventArgs e)
        {
            Form ScheduleManage = new ScheduleManage();
            ScheduleManage.Show();
            this.Hide();
        }

        private void ticketdetailsbtn_Click(object sender, EventArgs e)
        {
            Form TicketDetails = new TicketDetails();
            TicketDetails.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to logout?", "closing window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form Form1 = new homepage();
                Form1.Show();
                this.Hide();
            }
        }

        private void manageuser_Click(object sender, EventArgs e)
        {
            Form ManageUser = new ManageUser();
            ManageUser.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
