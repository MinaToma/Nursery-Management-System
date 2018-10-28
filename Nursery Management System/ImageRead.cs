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
    class ImageRead
    {
        public string PICc(ref PictureBox Pic)
        {
            string picloc = "";
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picloc = dlg.FileName.ToString();
            }
            return picloc;

        }
    }
}
