using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class DOB
    {
        public String day { get; set; }
        public String month { get; set; }
        public String year { get; set; }

        public DOB() { }

        DOB(String _day , String _month , String _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
    }
}
