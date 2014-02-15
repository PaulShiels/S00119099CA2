using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trip_Booking.Controllers
{
    public class Legs
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Legs()
        {

        }

        public Legs(string startLocation, string endLocation, DateTime startDate, DateTime endDate)
        {
            this.startLocation = startLocation;
            this.endLocation = endLocation;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}