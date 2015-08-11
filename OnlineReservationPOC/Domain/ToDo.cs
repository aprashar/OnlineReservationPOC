using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Domain
{
    public class ToDo 
    {
        public ToDo(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; }
        public string ActivityName { get; set; }
        public string ActivityDesc { get; set; }

    }
}