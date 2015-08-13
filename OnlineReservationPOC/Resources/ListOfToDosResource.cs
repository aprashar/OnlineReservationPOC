using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Resources
{
    public class ListOfToDosResource
    {
        IEnumerable<ToDoResource> ToDos { get; set; }
    }
}