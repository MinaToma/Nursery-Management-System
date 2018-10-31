using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Staff : Human
    {
        public string phoneNumber { get; set; }
        public String email { get; set; }
        public double salary { get; set; }

        public Staff() { }
        public Staff(int _id, String _firstName , string _lastName , string _phoneNumber , string _email , double _salary) : base(_id , _firstName , _lastName)
        {
            phoneNumber = _phoneNumber;
            email = _email;
            salary = _salary;
        }


    }
}
