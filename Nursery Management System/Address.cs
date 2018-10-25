using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Address
    {
        public String streetName { get; set; }
        public int streetNumber { get; set; }
        public String city { get; set; }

        public Address() {}

        Address(String _streetName , int _streetNumber , String _city)
        {
            streetName = _streetName;
            streetNumber = _streetNumber;
            city = _city;
        }
    }
}
