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
            Program.signForm.Close();   
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
