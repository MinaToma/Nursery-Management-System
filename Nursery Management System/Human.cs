using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Human
    {
        public int id {get;set;}
        public String name { get; set; }

        protected Human() {}
        protected Human(int _id , String _name)
        {
            id = _id;
            name = _name;
        }
        
        public String className()
        {
            return GetType().ToString();
        }
    }
}
