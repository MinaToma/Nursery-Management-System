using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public string Query;
        public SqlConnection connectionDataBase = new SqlConnection(@"Server=DESKTOP-QSKFJLO; DataBase=Nursery; Integrated Security=true;");
        public SqlCommand commandDataBase;
        public SqlDataReader myReader;

        public SqlCommandBuilder cmdb;
        public SqlDataAdapter Da;
        public DataSet ds = new DataSet();
        public DataTable Dt = new DataTable();
        public CurrencyManager cm;

        public int convert(string name)
        {
            int x = Int32.Parse(name);
            return x;
        }
        public void saveChilddata(string Name, string Gender, DateTime dob, string romenumber, string PicLocation)
        {

            try
            {
                byte[] img = null;

                FileStream fs = new FileStream(PicLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                Query = "insert into Child (Name, Gender, DOB ,  RoomID,ParentID , Image) values (' " + Name + " ' , '" + Gender + " ' , ' " + dob + " ' , ' " + convert(romenumber) + " ', '" + 1 + " ',@img );   ";
                commandDataBase = new SqlCommand(Query, connectionDataBase);
                commandDataBase.Parameters.Add(new SqlParameter("@img", img));
                connectionDataBase.Open();
                commandDataBase.ExecuteReader();


                MessageBox.Show("Information saved successfully ! ");

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
            finally
            {
                connectionDataBase.Close();
            }
        }
        public void laodChildData(ref PictureBox Pic, ref TextBox name, ref TextBox room, int ParentID, int numOfChild)
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
