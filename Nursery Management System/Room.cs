﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Room
    {
        public int id { get; set; }
        public int number { get; set;}
        public int staffID { get; set; }

        public Room() { }
        public Room(int _id , int _number , int _staffID)
        {
            id = _id;
            number = _number;
            staffID = _staffID;
        }
    }
}