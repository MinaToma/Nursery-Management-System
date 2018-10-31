using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class ChildClass : Human
    {
        public int parentID { get; set; }
        public int roomID { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string image { get; set; }

        public ChildClass() {}
        public ChildClass(int _id , String _firstName , string _lastName , int _parentID , int _roomID , string _gender , DateTime _DOB , string _image) : 
            base(_id , _firstName , _lastName)
        {
            parentID = _parentID;
            roomID = _roomID;
            gender = _gender;
            DOB = _DOB;
            image = _image;
        }
    }
}
