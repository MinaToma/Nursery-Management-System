using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
            
            SQL mSql = new SQL();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            Program.signForm.Hide();
            Program.signInForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }
    }
}
