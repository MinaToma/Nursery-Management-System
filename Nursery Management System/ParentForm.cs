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
            if(Program.globalType != "")
                Program.parentLoggedInForm.Show();
            else
                Program.signUpForm.Show();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            string headProblemOfData = "", promblemInData = "";
            if (vaild.vaildDataForParent(firstName.Text, email.Text, ID.Text, phoneNumber.Text, creditCard.Text,  ref headProblemOfData, ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.childSignUpForm.Show();
                Program.childSignUpForm.enableEditing("parentSignUp");
            }
        }

        private void parentProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            int numberOfChildren = mSQLQuery.childToLinkedList(mSQLQuery.getChildByParentID(Convert.ToInt64(ID.Text))).Count;
            string headProblemOfData="", promblemInData="";
            if(vaild.vaildDataForParent(firstName.Text,email.Text,ID.Text,phoneNumber.Text,creditCard.Text,numberOfChildren,ref headProblemOfData,ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Parent parent = new Parent(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, address.Text, creditCard.Text, 1);
                mSQLQuery.insertParentData(parent);

                Program.globalParent = parent;

                mSQLQuery.insertUser(username.Text, password.Text, "Parent", parent.id);
                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
