using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Resources
{
    public class ToDoResource:Resource
    {
        public int Id { get; }
        public string ActivityName { get; set; }
        public string ActivityDesc { get; set; }
    }
}