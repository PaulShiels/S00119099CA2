﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trip_booking.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public int legs { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int minimumGuests { get; set; }

        public ICollection<Trip> trips { get; set; }

        //public Trip()
        //{
        //}

        //public Trip(int ID, int legs, string name, DateTime startDate, DateTime endDate, int minimumGuests)
        //{
        //    this.ID = ID;
        //    this.legs = legs;
        //    this.name = name;
        //    //this.startDate = startDate;
        //    //this.endDate = endDate;
        //    this.minimumGuests = minimumGuests;
        //}
    }
}