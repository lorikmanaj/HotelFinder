using System;
using System.Collections.Generic;

namespace HotelFinder.Models
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public int CreditCardNumber { get; set; }
        public int Value { get; set; }
        public string Currency { get; set; }
        public DateTime PaymentDate { get; set; }
        public int RoomsBookedId { get; set; }

        public virtual RoomsBooked RoomsBooked { get; set; }
        public virtual Users User { get; set; }
    }
}
