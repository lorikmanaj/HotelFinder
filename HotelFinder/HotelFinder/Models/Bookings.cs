using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class Bookings
    {
        public Bookings()
        {
            RoomsBooked = new HashSet<RoomsBooked>();
        }

        public int BookingId { get; set; }
        public int HotelId { get; set; }
        public int UserId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; }

        public virtual Hotels Hotel { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<RoomsBooked> RoomsBooked { get; set; }
    }
}
