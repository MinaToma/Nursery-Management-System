using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Nursery_Management_System
{
    class SQL

    {
        private string Query { set; get; }
        private SqlConnection connectionDataBase { set; get; }
        private SqlCommand commandDataBase { set; get; }
        private SqlDataReader myReader { set; get; }

        public SQL()
        {
            connectionDataBase = new SqlConnection(@"Server=DESKTOP-2OGA27F; DataBase=Nursery; Integrated Security=true;");
        }

        private int convert(string name)
        {
            int x = Int32.Parse(name);
            return x;
        }
        public void saveChildData(string parentID , string name, string gender, DateTime DOB, string roomID, string picLocation)
        {
            try
            {
                byte[] img = null;

                FileStream imageLocation = new FileStream(picLocation, FileMode.Open, FileAccess.Read);
                BinaryReader imageToBinaryCode = new BinaryReader(imageLocation);
                img = imageToBinaryCode.ReadBytes((int)imageLocation.Length);

                Query = "insert into Child (childName , parentID , DOB , gender , roomID , image) values (' " + name + " ' , '" + parentID + " '  , ' " + DOB + " ' , '" + gender + " '  ,  ' " + convert(roomID) + " ' ,@img ); ";
                commandDataBase = new SqlCommand(Query, connectionDataBase);
                commandDataBase.Parameters.Add(new SqlParameter("@img", img));
    
                connectionDataBase.Open();
                commandDataBase.ExecuteReader();
                
                MessageBox.Show("Information saved successfully !");
            }
            catch
            {
                MessageBox.Show("Data Not Saved", "Error"  , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            finally
            {
                connectionDataBase.Close();
            }
        }
        public void laodChildData(ref PictureBox Pic , ref TextBox name, ref TextBox room, int ParentID, int numOfChild)
        {
            try
            {
                Query = "Select * from Child where ParentID='" + ParentID + "'   ";
                commandDataBase = new SqlCommand(Query, connectionDataBase);
                connectionDataBase.Open();

                myReader = commandDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    if (numOfChild == 0)
                    {
                        // load img from db
                        byte[] img = (byte[])(myReader["Image"]);
                        if (img == null)
                            Pic.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            Pic.Image = Image.FromStream(ms);
                            Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    name.Text = myReader["Name"].ToString();
                    room.Text = myReader["RoomID"].ToString();

                    numOfChild--;
                }
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                connectionDataBase.Close();

            }


        }

    }
}
