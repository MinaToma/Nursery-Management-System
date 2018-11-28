using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{ 
    class connectionString
    {
        public string serverName { set; get;}
       
        public connectionString()
        {
            try
            {
                StreamReader sr = new StreamReader(@"E:\IS Project\Nursery-Management-System\Nursery Management System\ServerName\serverName.txt");
                serverName = "Server=" + sr.ReadLine().ToString() + "; DataBase=Nursery; Integrated Security=true;";
            }
            catch
            {
                MessageBox.Show("Error server isn't found" , "Error in Conenction" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
