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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

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

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.parentSignUpForm.Show();
           
            
        }

        private void staffSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.staffSignUpForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signForm.Show();
        }
    }
}
