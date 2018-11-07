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
            Program.signForm.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSqlQuery = new SQLQuery();
            
            if(mSqlQuery.serachForUser(usernameInput.Text , passwordInput.Text) == false)
            {
                MessageBox.Show("Username doesn't exist", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hello, " + usernameInput.Text + "!" , "Logged In Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (Program.globalType == "Staff")
                {
                    //open staff form
                }
                else if(Program.globalType == "Admin")
                {
                    //open admin form
                }
                else if(Program.globalType == "Parent")
                {
                    //open parent form
                }
            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {
                
        }
    }
}
