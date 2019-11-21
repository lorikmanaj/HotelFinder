using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            RoomsBooked = new HashSet<RoomsBooked>();
        }

        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public int Floor { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public bool Occupied { get; set; }

        public virtual Hotels Hotel { get; set; }
        public virtual ICollection<RoomsBooked> RoomsBooked { get; set; }
    }
}
