using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Child : People
    {
        public int parentId { get; set; }
        public int roomId { get; set; }
        public string gender { get; set; }
        public DOB dateOfBirt { get; set; }

        public Child()
        {
            dateOfBirt = new DOB();
        }
        public Child(int _id, String _name) : base(_id , _name)
        {
            dateOfBirt = new DOB();
        }
    }
}
