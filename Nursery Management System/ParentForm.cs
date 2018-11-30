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

        LinkedList<Child> childOfParent = new LinkedList<Child>();


        public parentForm(string state)
        {
            InitializeComponent();
            if(state=="admin")
            {
                acceptButton.Visible = true;
                declineButton.Visible = true;
                signUpButton.Visible = false;
            }
            else
            {
                acceptButton.Visible = false;
                declineButton.Visible = false;
                signUpButton.Visible = true;
            }
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
            if (Program.globalType != "")
                Program.parentLoggedInForm.Show();
            else
                Program.signUpForm.Show();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            string headProblemOfData = "", promblemInData = "";

            if (vaild.vaildDataForParent(username.Text, email.Text, ID.Text, phoneNumber.Text, creditCard.Text, ref headProblemOfData, ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Program.childSignUpForm.Show() ;
                Program.childSignUpForm.enableEditing("parentSignUp");
            }
        }
        public void ChildOfParent(string childName , DateTime dT , string gender , string picLocation)
        {
            
            Int64 id = Int64.Parse(ID.Text);
            Child child = new Child(childName, firstName.Text , id , 44, gender, dT, picLocation, 1);
            childOfParent.AddLast(child);

        }
        private void parentProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            int numberOfChildren = childOfParent.Count;
            string headProblemOfData="", promblemInData="";
            if(vaild.vaildDataForParent(username.Text,email.Text,ID.Text,phoneNumber.Text,creditCard.Text,numberOfChildren,ref headProblemOfData,ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Parent parent = new Parent(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, address.Text, creditCard.Text, 1);
                mSQLQuery.insertParentData(parent);

                Program.globalParent = parent;

                mSQLQuery.insertUser(username.Text, password.Text, "Parent", parent.id);
                foreach(Child i in childOfParent)
                {
                    mSQLQuery.insertChildData(i);
                }

                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }

        private void declineButton_Click(object sender, EventArgs e)
        {

        }
    }
}
