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
        public string Query { set; get; }
        public SqlConnection connectionDataBase { set; get; }
        public SqlCommand commandDataBase { set; get; }
        public SqlDataReader myReader { set; get; }

        public SQL()
        {
            connectionDataBase = new SqlConnection(@"Server=DESKTOP-2OGA27F; DataBase=Nursery; Integrated Security=true;");
        }

        
        public void saveChildData(ChildClass child)
        {
            try
            {
                byte[] img = null;
                
                FileStream imageLocation = new FileStream(child.image , FileMode.Open, FileAccess.Read);
                BinaryReader imageToBinaryCode = new BinaryReader(imageLocation);
                img = imageToBinaryCode.ReadBytes((int)imageLocation.Length);

                Query = "insert into Child (childName , parentID , DOB , gender , roomID , image) values (' " + child.firstName + " ' , '" + child.parentID + " '  , ' " + child.DOB + " ' , '" + child.gender + " '  ,  ' " + child.roomID + " ' ,@img ); ";
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
