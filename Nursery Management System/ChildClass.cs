using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class ChildClass : People
    {
        public int parentId { get; set; }
        public int roomId { get; set; }
        public string gender { get; set; }
        public DOB dateOfBirt { get; set; }

        public ChildClass()
        {
            dateOfBirt = new DOB();
        }
        public ChildClass(int _id, String _name) : base(_id, _name)
        {
            dateOfBirt = new DOB();
        }
    }
}
