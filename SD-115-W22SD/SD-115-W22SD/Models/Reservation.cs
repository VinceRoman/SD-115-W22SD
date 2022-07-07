using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReview
{
    class Reservation
    {
        public DateTime Date { get; set; }
        public int Occupants { get; set; }
        public bool IsCurrent { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }


        // CONSTRUCTORS
        public Reservation() { }
        public Reservation(int occupants, Client client, Room room)
        {
            Date = DateTime.Now;
            Occupants = occupants;
            IsCurrent = true;
            Client = client;
            Room = room;
        }
    }
}
