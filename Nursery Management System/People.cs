using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class People
    {
        private int id;
        private String name;

        protected People() {}
        public People(int _id , String _name)
        {
            id = _id;
            name = _name;
        }

        public int getId()
        {
            return id;
        }

        public String className()
        {
            return GetType().ToString();
        }

        public String getName()
        {
            return name;
        }
    }
}
