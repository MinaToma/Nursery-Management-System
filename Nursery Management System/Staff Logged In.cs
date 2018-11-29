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
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Program.signForm.Dispose();
                    break;
                default:
                    break;
            }
        }

        private void staffLoggedIn_Load(object sender, EventArgs e)
        {

        }

        private void roomButton_Click(object sender, EventArgs e)
        {

        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signForm.Show();
        }
    }
}
