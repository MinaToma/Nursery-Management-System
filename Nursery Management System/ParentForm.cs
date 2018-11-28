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

        private void addChildButton_Click(object sender, EventArgs e)
        {
            Program.childSignUpForm.Show();
            Program.childSignUpForm.enableEditing("parentSignUp");
        }

        private void parentProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            if (mSQLQuery.checkForUsername(firstName.Text) == true)
            {
                MessageBox.Show("Username already exists", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Parent parent = new Parent(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, address.Text, creditCard.Text, 1);
                mSQLQuery.insertParentData(parent);

                mSQLQuery.insertUser(username.Text, password.Text, "Parent", parent.id);
                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
