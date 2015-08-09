using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Domain
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int TotalNumberOfTables { get; set; }
    }
}