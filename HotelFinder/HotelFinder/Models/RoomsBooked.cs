using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class RoomsBooked
    {
        public RoomsBooked()
        {
            Payments = new HashSet<Payments>();
        }

        public int RoomBookedId { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }

        public virtual Bookings Booking { get; set; }
        public virtual Rooms Room { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
