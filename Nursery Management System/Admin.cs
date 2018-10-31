using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Admin : Staff
    {
        public Admin() { }
        public Admin(int _id, String _firstName , string _lastName , string _phoneNumber , string email , double _salary) :
            base(_id , _firstName , _lastName , _phoneNumber , email , _salary)
        {

        }


    }
}
