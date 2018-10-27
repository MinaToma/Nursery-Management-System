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
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
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
        public string cString = "Data Source=ADEL;Initial Catalog=Nursery;Integrated Security=True";
        string Gender;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string Query = "insert into Nursery.dbo.Child (Name, Gender, DOB, RoomID) values (' " + this.childName.Text + " ' , '" + Gender + " ' , ' " + this.DOBpicker.Value + " ' , ' " + this.roomNumber.Text + " ' );   ";
            SqlConnection connectionDataBase = new SqlConnection(cString);
            SqlCommand commandDataBase = new SqlCommand(Query, connectionDataBase);
            SqlDataReader myReader;
            try
            {
                connectionDataBase.Open();
                myReader = commandDataBase.ExecuteReader();
                MessageBox.Show("Information saved successfully ! ");
                while (myReader.Read())
                {

                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }
    }
}