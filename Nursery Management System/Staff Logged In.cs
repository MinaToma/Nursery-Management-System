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
    public partial class staffLoggedIn : Form
    {
        public staffLoggedIn()
        {
            InitializeComponent();
        }

        private void staffProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.staffSignUpForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.signForm.Close();
        }
    }
}
