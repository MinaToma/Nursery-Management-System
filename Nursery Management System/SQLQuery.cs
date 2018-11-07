using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nursery_Management_System
{
    class SQLQuery
    {
        public SQLQuery() { }

        public void insertChildData(Child child)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertChildData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@childName", child.firstName);
            mCommand.Parameters.AddWithValue("@parentID", child.parentID);
            mCommand.Parameters.AddWithValue("@DOB", child.DOB);
            mCommand.Parameters.AddWithValue("@gender", child.gender);
            mCommand.Parameters.AddWithValue("@picture", child.image);
            mCommand.Parameters.AddWithValue("@roomID", child.roomID);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertParentData(Parent parent)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertParentData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@parentID", parent.id);
            mCommand.Parameters.AddWithValue("@parentFirstName", parent.firstName);
            mCommand.Parameters.AddWithValue("@parentLastName", parent.lastName);
            mCommand.Parameters.AddWithValue("@parentAddress", parent.address);
            mCommand.Parameters.AddWithValue("@parentPhoneNumber", parent.phoneNumber);
            mCommand.Parameters.AddWithValue("@parentCreditCard", parent.creditCard);
            mCommand.Parameters.AddWithValue("@parentEmail", parent.email);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertStaffData(Staff staff, string department)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertStaffData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@staffID", staff.id);
            mCommand.Parameters.AddWithValue("@staffFirstName", staff.firstName);
            mCommand.Parameters.AddWithValue("@staffLasttName", staff.lastName);
            mCommand.Parameters.AddWithValue("@staffPhoneNumber", staff.phoneNumber);
            mCommand.Parameters.AddWithValue("@staffEmail", staff.email);
            mCommand.Parameters.AddWithValue("@staffSalary", staff.salary);
            mCommand.Parameters.AddWithValue("@staffType", department);

            mSQL.insertQuery(mCommand);

            return;
        }
    
        public void insertRoomData(Room room)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertRoomData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@roomNumber", room.number);
            if (room.staffID == -1)
                mCommand.Parameters.AddWithValue("@roomStaffID", DBNull.Value);
            else
                mCommand.Parameters.AddWithValue("@roomStaffID", room.staffID);
            mSQL.insertQuery(mCommand);

            return;
        }

        public LinkedList<Child> getChild(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);

            LinkedList<Child> child = new LinkedList<Child>();
            foreach(DataRow dr in dt.Rows)
            {
                Child currentChild = new Child();

                currentChild.id = Convert.ToInt32(dr["childID"].ToString());
                currentChild.firstName = dr["childName"].ToString();
                currentChild.parentID = Convert.ToInt32(dr["parentID"].ToString());
                currentChild.DOB = Convert.ToDateTime(dr["DOB"].ToString());
                currentChild.gender = dr["gender"].ToString();
                currentChild.roomID = Convert.ToInt32(dr["roomID"].ToString());
                currentChild.image = dr["picture"].ToString();
                currentChild.pending = Convert.ToInt32(dr["childIsPending"].ToString());   

                child.AddLast(currentChild);
            }
            
            return child;
        }

        public LinkedList<Parent> getParent(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);

            LinkedList<Parent> parent = new LinkedList<Parent>();
            foreach (DataRow dr in dt.Rows)
            {
                Parent currentParent = new Parent();

                currentParent.id = Convert.ToInt32(dr["parentID"].ToString());
                currentParent.firstName = dr["parentFirstName"].ToString();
                currentParent.lastName = dr["parentLastName"].ToString();
                currentParent.address = dr["parentAddress"].ToString();
                currentParent.phoneNumber = dr["parentPhoneNumber"].ToString();
                currentParent.creditCard = dr["parentCreditCard"].ToString();
                currentParent.email = dr["parentEmail"].ToString();
                currentParent.pending = Convert.ToInt32(dr["parentIsPending"].ToString());

                parent.AddLast(currentParent);
            }
            
            return parent;
        }

        public LinkedList<Staff> getStaff(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);

            LinkedList<Staff> staff = new LinkedList<Staff>();
            foreach (DataRow dr in dt.Rows)
            {
                Staff currentStaff = new Staff();

                currentStaff.id = Convert.ToInt32(dr["staffID"].ToString());
                currentStaff.firstName = dr["staffFirstName"].ToString();
                currentStaff.lastName = dr["staffLastName"].ToString();
                currentStaff.phoneNumber = dr["staffPhoneNumber"].ToString();
                currentStaff.email = dr["staffEmail"].ToString();
                currentStaff.salary = Convert.ToDouble(dr["staffSalary"].ToString());
                currentStaff.type = dr["staffType"].ToString();
                currentStaff.pending = Convert.ToInt32(dr["staffIsPending"].ToString());

                staff.AddLast(currentStaff);
            }
            
            return staff;
        }
     
        public LinkedList<Room> getRoom(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);

            LinkedList<Room> room = new LinkedList<Room>();
            foreach (DataRow dr in dt.Rows)
            {
                Room currentRoom = new Room();

                currentRoom.id = Convert.ToInt32(dr["roomID"].ToString());
                currentRoom.number = Convert.ToInt32(dr["roomNumber"].ToString()); 
                currentRoom.staffID = Convert.ToInt32(dr["roomStaffID"].ToString());

                room.AddLast(currentRoom);
            }
            return room;
        }

        public void updateChildData(Child child)
        {

        }

        public void updateParentData(Parent parent)
        {

        }

        public void updateStaffData(Staff staff)
        {
            
        }
        public void updateRoomData(Room room)
        {

        }

        public void deleteChildData(string query)
        {

        }

        public void deleteParentData(string query)
        {

        }

        public void deleteStaffData(string query)
        {

        }

        public void deleteRoomData(string query)
        {

        }
    }
}
