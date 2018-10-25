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
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            People p = new Parent(3 , "3");
            Console.WriteLine(p.className());

            Program.signForm.Hide();
            signIn signInForm = new signIn();
            signInForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
