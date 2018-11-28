using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nursery_Management_System
{
    public partial class childForm : Form
    {
        string Gender, PicLocation;
        PictureBox PicBox = new PictureBox();
        public childForm()
        {
            InitializeComponent();
            PicBox.Image = childImageButton.BackgroundImage;
            SQL Q = new SQL();

           // last two number the id of parent and the number of his childeren 
           //Q.laodChildData(ref PicBox, ref childName, ref roomNumber, 1, 0);
           // childImageButton.BackgroundImage = PicBox.Image;
        }

        public void enableEditing(string state)
        {
            this.editButton.Visible = false;
            this.childProfilePanel.Enabled = true;
            this.importImageButton.Visible = true;
            this.saveButton.Visible = true;

            switch(state)
            {
                case "parentSignUp":
                {
                    this.Text = "Nusery Management System - Child Sign Up";                    
                    this.roomNumber.Enabled = false;
                }
                break;

                default:
                {

                }
                break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.signForm.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void childName_TextChanged(object sender, EventArgs e)
        {

        }

        private void childImageButton_Click(object sender, EventArgs e)
        {

        }

        private void note_Click(object sender, EventArgs e)
        {

        }

        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void childProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            Gender = "Female";
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            Gender = "Male";
        }

        //string Gender;
        public string cString = "Data Source=MARIAMS-LAPTOP;Initial Catalog = Nursery; Integrated Security = True";

        private void saveButton_Click(object sender, EventArgs e)
        {
       
        }

        private void childName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void childImageButton_Click_1(object sender, EventArgs e)
        {

        }

        private void importImageButton_Click(object sender, EventArgs e)
        {
            ImageRead img = new ImageRead();
            PicLocation = img.PICc(ref PicBox);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            enableEditing("adminEdit");
        }
    }
}