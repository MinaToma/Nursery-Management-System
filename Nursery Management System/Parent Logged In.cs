using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{
    public partial class parentLoggedIn : Form
    {
        public parentLoggedIn()
        {
            InitializeComponent();
        }

        private void Parent_Logged_In_Load(object sender, EventArgs e)
        {

        }

        private void parentProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.parentProfileForm.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signForm.Show();
        }
    }
}
