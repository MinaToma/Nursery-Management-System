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
            editDatabaseControl.DrawItem += mina;
        }

        private void editDatabase_Load(object sender, EventArgs e)
        {

        }

        private void mina(object sender, DrawItemEventArgs e)
        {
            MessageBox.Show("haha");
            //get tabpage
            TabPage tabPages = editDatabaseControl.TabPages[e.Index];
            Graphics graphics = e.Graphics;
            Brush textBrush = new SolidBrush(Color.Green); //fore color brush
            Rectangle tabBounds = editDatabaseControl.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                graphics.FillRectangle(Brushes.SkyBlue, e.Bounds); //fill background color
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font tabFont = new Font("Book Antiqua", 12, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Near;
            // draw text
            graphics.DrawString(tabPages.Text, tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
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
