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
    public partial class adminLoggedIn : Form
    {
        public adminLoggedIn()
        {
            InitializeComponent();
        }

        private void editDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            SQLQuery mSQLQuery = new SQLQuery();
            Program.editDataBaseForm.staffTable.DataSource = mSQLQuery.getAllStaff();
            Program.editDataBaseForm.parentsTable.DataSource = mSQLQuery.getAllParent();
            Program.editDataBaseForm.childrenTable.DataSource = mSQLQuery.getAllChildren();
            Program.editDataBaseForm.roomsTable.DataSource = mSQLQuery.getAllRooms();

            Program.editDataBaseForm.Show();
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

        private void adminLoggedIn_Load(object sender, EventArgs e)
        {

        }
    }
}
