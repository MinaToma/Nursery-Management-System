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
    public partial class parentForm : Form
    {
        public parentForm()
        {
            InitializeComponent();
        }

        private void parentForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.signForm.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(Program.globalType != "")
                Program.parentLoggedInForm.Show();
            else
                Program.signUpForm.Show();
        }
    }
}
