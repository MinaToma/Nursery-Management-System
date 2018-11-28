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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSqlQuery = new SQLQuery();
            
            if(mSqlQuery.serachForUser(username.Text , password.Text) == false)
            {
                MessageBox.Show("Username doesn't exist", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hello, " + username.Text + "!" , "Logged In Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                if (Program.globalType == "Staff")
                {
                    //open staff form
                    Program.staffLoggedInForm.Show();
                }
                else if(Program.globalType == "Admin")
                {
                    //open admin form
                    Program.adminLoggedInForm.Show();
                }
                else if(Program.globalType == "Parent")
                {
                    //open parent form
                    Program.parentLoggedInForm.Show();
                }
            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {
                
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signForm.Show();
        }
    }
}
