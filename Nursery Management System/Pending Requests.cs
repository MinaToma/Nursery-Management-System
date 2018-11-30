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
    public partial class adminPendingRequests : Form
    {
        public adminPendingRequests()
        {
            InitializeComponent();
            DataTable pennding = new DataTable();
            SQLQuery MyQuery = new SQLQuery();

            // staff pennding list veiw load
            pennding = MyQuery.getPendingStaff();
            foreach(DataRow row in pennding.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                for (int i = 2; i <= 4; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                staffListView.Items.Add(item);
            }
            staffListView.View = View.Details;
            staffListView.FullRowSelect = true;

            // parents pennding list veiw  laod
            pennding = MyQuery.getPendingParent();
            foreach (DataRow row in pennding.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                for (int i = 2; i <= 4; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                parentsListView.Items.Add(item);
            }
            parentsListView.View = View.Details;
            parentsListView.FullRowSelect = true;

            // Child Pending listview laod




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

        private void backButtonChild_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

        private void backButtonStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

        private void backButtonParents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

    }
}
