using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trip_Booking.Controllers
{
    public class Trip
    {
        public int legs { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int minimumGuests { get; set; }

        public Trip()
        {
        }

        public Trip(int legs, string name, DateTime startDate, DateTime endDate, int minimumGuests)
        {
            this.legs = legs;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.minimumGuests = minimumGuests;
        }
    }
}