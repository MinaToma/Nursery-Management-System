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
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            if (mSQLQuery.checkForUsername(username.Text) == true)
            {
                MessageBox.Show("Username already exists", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Staff staff = new Staff(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, -1, 1, "Staff");
                mSQLQuery.insertStaffData(staff, "Staff");

                mSQLQuery.insertUser(username.Text, password.Text, "Staff", staff.id);
                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.signForm.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signUpForm.Show();
        }
    }
}