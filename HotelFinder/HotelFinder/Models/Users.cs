using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class Users
    {
        public Users()
        {
            Bookings = new HashSet<Bookings>();
            Payments = new HashSet<Payments>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
