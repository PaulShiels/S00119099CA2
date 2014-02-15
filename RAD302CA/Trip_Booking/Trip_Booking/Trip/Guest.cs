using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trip_Booking.Controllers
{
    public class Guest
    {
        public string name { get; set; }

        public Guest()
        {

        }

        public Guest(string name)
        {
            this.name = name;
        }
    }
}