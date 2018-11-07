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

        /****************  USER AUTHENTICATION  ****************/

        public void serachForUser(string name , string password)
        {

        }

        /****************  INSERTING DATA INTO DATABASE  ****************/

        //child data insertion
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

        //parent data insertion
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

        //staff data insertion
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

        //room data insertion
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

        /****************  RETRIEVING CHILD DATA FROM DATABASE  ****************/

        private LinkedList<Child> getChild(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);

            LinkedList<Child> child = new LinkedList<Child>();
            foreach (DataRow dr in dt.Rows)
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

        //uses specific query to select all children from database
        public LinkedList<Child> getAllChildren()
        {
            string query = "select * from Child";
            return getChild(query);
        }

        //uses specific query to select child by ID from database
        public LinkedList<Child> getChildByID(int id)
        {
            string query = "select * from Child where childID = " + Convert.ToString(id);
            return getChild(query);
        }

        //uses specific query to select child by parent's ID from database
        public LinkedList<Child> getChildByParentID(int id)
        {
            string query = "select * from Child where parentID = " + Convert.ToString(id);   
            return getChild(query);
        }

        //uses specific query to select child by room's ID from database
        public LinkedList<Child> getChildByRoomID(int id)
        {
            string query = "select * from Child where roomID = " + Convert.ToString(id);
            return getChild(query);
        }

        //uses specific query to select pending child by parent's ID from database
        public LinkedList<Child> getPendingChildByParentID(int id)
        {
            string query = "select * from Child where parentID = " + Convert.ToString(id) + " and childIsPending = 1";
            return getChild(query);
        }

        /****************  RETRIEVING PARENT DATA FROM DATABASE  ****************/

        private LinkedList<Parent> getParent(string query)
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

        //uses specific query to select all parents from database
        public LinkedList<Parent> getAllParent()
        {
            string query = "select * from Parent";
            return getParent(query);
        }

        //uses specific query to select parent by ID from database
        public LinkedList<Parent> getParentByID(int id)
        {
            string query = "select * from Parent where parentID = " + Convert.ToString(id);
            return getParent(query);
        }

        //uses specific query to select pending parents from database
        public LinkedList<Parent> getPendingParent()
        {
            string query = "select * from Parent where parentIsPending = 1";
            return getParent(query);
        }

        /****************  RETRIEVING STAFF DATA FROM DATABASE  ****************/

        private LinkedList<Staff> getStaff(string query)
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

        //uses specific query to select all staff members from database
        public LinkedList<Staff> getAllStaff()
        {
            string query = "select * from Staff";
            return getStaff(query);
        }

        //uses specific query to select staff member type from database (admin, staff)
        public LinkedList<Staff> getStaffByType(string type)
        {
            string query = "select * from Staff where staffType = " + type;
            return getStaff(query);
        }

        //uses specific query to select staff member by ID from database
        public LinkedList<Staff> getStaffByID(int id)
        {
            string query = "select * from Staff where staffID = " + Convert.ToString(id);
            return getStaff(query);
        }

        //uses specific query to select staff member by room ID from database
        public LinkedList<Staff> getStaffByRoomID(int id)
        {
            LinkedList<Room> room = new LinkedList<Room>();
            room = getRoomByID(id);

            if (room.Count() == 0)
                return new LinkedList<Staff>(); 

            string query = "select * from Staff where staffID = " + Convert.ToString(room.ElementAt(0).staffID);
            return getStaff(query);
        }

        //uses specific query to select pending staff member requests from database
        public LinkedList<Staff> getPendingStaff()
        {
            string query = "";
            return getStaff(query);
        }

        /****************  RETRIEVING ROOM DATA FROM DATABASE  ****************/

        private LinkedList<Room> getRoom(string query)
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

        //uses specific query to select all rooms from database
        public LinkedList<Room> getAllRooms()
        {
            string query = "select * from Room";
            return getRoom(query);
        }

        //uses specific query to select room by ID from database
        public LinkedList<Room> getRoomByID(int id)
        {
            string query = "select * from Room where roomID = " + Convert.ToString(id);
            return getRoom(query);
        }

        //uses specific query to select room by staff member's ID from database
        public LinkedList<Room> getRoomByStaffID(int id)
        {
            string query = "select * from Room where roomStaffID = " + Convert.ToString(id);
            return getRoom(query);
        }

        /****************  UPDATING ROOM DATA FROM DATABASE  ****************/

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




        private void deleteUser(string query)
        {
            SQL mSql = new SQL();
            mSql.deleteQuery(query);
        }

        public void deleteChildData(LinkedList<int> childIDs)
        {
            string query = "delete from Child where childID in(" + string.Join(",", childIDs) + ")";
            deleteUser(query);
        }

        public void deleteParentData(LinkedList<int> parentIDs)
        {
            string query = "delete from Parent where parentID in(" + string.Join(",", parentIDs) + ")";
            deleteUser(query);
        }

        public void deleteStaffData(LinkedList<int> staffIDs)
        {
            string query = "delete from Staff where staffID in(" + string.Join(",", staffIDs) + ")";
            deleteUser(query);
        }

        public void deleteRoomData(LinkedList<int> roomIDs)
        {
            string query = "delete from Room where roomID in(" + string.Join(",", roomIDs) + ")";
            deleteUser(query);
        }      

     }
}
