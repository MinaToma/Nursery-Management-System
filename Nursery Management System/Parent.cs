using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Parent : People
    {
        public long phoneNumber { get; set;}
        public String creditCard { get; set; }
        public Address address { get; set; }

        public Parent()
        {
            address = new Address();
        }
        public Parent(int _id , String _name) : base(_id , _name)
        {
            address = new Address();
        }
    }
}
