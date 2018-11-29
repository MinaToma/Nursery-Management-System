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
            ValidateData vaild = new ValidateData();
            if (mSQLQuery.checkForUsername(username.Text) == true)
            {
                MessageBox.Show("Username already exists", "Wrong Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!vaild.checkMails(email.Text))
            {
                MessageBox.Show("Please Enter correct email", "Invaild email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!vaild.checkNationalID(ID.Text))
            {
                MessageBox.Show("Please Enter correct ID", "Invaild ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!vaild.checkPhoneNum(phoneNumber.Text))
            {
                MessageBox.Show("Please Enter correct Phone Number", "Invaild Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signUpForm.Show();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }

        private void staffProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}