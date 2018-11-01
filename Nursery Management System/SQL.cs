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
        private SqlConnection mConnection;
        public SqlCommand mCommand;
        public SqlDataReader mReader;
        private SqlDataAdapter mAdapter;

        public SQL()
        {
            mConnection = new SqlConnection(@"Server=DESKTOP-2OGA27F; DataBase=Nursery; Integrated Security=true;");
        }

        public DataTable retrieveQuery(string query)
        {
            DataTable mDataTable = new DataTable();
            try
            {
                mCommand = new SqlCommand(query, mConnection);
                mConnection.Open();
                mAdapter = new SqlDataAdapter(mCommand);
                mAdapter.Fill(mDataTable);
            }
            catch
            {
                MessageBox.Show("There was an error while connecting to data base , please check your connection and try again", "Sql Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mConnection.Close();
                mAdapter.Dispose();
            }

            return mDataTable ;
        }
        
        public void insertQuery(SqlCommand command)
        {
            mCommand = command;
            mCommand.Connection = mConnection;
            try
            {
                mConnection.Open();
                mCommand.ExecuteNonQuery();
            }
            catch
            {
                
                MessageBox.Show("There was an error while connecting to data base , please check your connection and try again", "Sql Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mConnection.Close();
            }
            return;
        }
    }
}
