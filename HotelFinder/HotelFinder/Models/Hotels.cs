using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class Hotels
    {
        public Hotels()
        {
            Bookings = new HashSet<Bookings>();
            Rooms = new HashSet<Rooms>();
        }

        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Rating { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
