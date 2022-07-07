using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReview
{
    class Client
    {
        public string Name { get; set; }
        public int CreditCard { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Client() 
        {
            Reservations = new List<Reservation>();
        }

        public Client(string name, int creditCard)
        {
            Name = name;
            CreditCard = creditCard;
            Reservations = new List<Reservation>();
        }
    }
}
