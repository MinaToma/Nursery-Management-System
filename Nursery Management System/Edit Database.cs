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
    public partial class editDatabase : Form
    {
        public editDatabase()
        {
            InitializeComponent();

            SQLQuery mSQLQuery = new SQLQuery();

            
        }

        private void editDatabase_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void childrenTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //private void editDatabaseControl_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        //{
        //    Font f;
        //    Brush backBrush;
        //    Brush foreBrush;

        //    if (e.Index == this.editDatabaseControl.SelectedIndex)
        //    {
        //        f = new Font(e.Font, FontStyle.Italic | FontStyle.Bold);
        //        backBrush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Blue, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
        //        foreBrush = Brushes.PowderBlue;
        //    }
        //    else
        //    {
        //        f = e.Font;
        //        backBrush = new SolidBrush(e.BackColor);
        //        foreBrush = new SolidBrush(e.ForeColor);
        //    }

        //    string tabName = this.editDatabaseControl.TabPages[e.Index].Text;
        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;
        //    e.Graphics.FillRectangle(backBrush, e.Bounds);
        //    Rectangle r = e.Bounds;
        //    r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
        //    e.Graphics.DrawString(tabName, f, foreBrush, r, sf);

        //    sf.Dispose();
        //    if (e.Index == this.editDatabaseControl.SelectedIndex)
        //    {
        //        f.Dispose();
        //        backBrush.Dispose();
        //    }
        //    else
        //    {
        //        backBrush.Dispose();
        //        foreBrush.Dispose();
        //    }
        //}
    }
}
