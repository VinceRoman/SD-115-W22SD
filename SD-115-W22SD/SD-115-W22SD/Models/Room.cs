﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReview
{
    class Room
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        public bool Occupied { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Room()
        {
            Reservations = new List<Reservation>();
        }

        public Room(string number, int capacity)
        {
            Number = number;
            Capacity = capacity;
            Occupied = false;
            Reservations = new List<Reservation>();
        }

    }
}
