﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Domain
{
    public class RestaurantReservation : Reservation
    {
        public double ConvenienceCharge { get; set; } 
    }
}