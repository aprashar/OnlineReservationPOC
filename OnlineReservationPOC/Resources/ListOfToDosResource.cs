using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnlineReservationPOC.Resources
{
    [DataContract]
    public class ListOfToDosResource :Resource
    {
        [DataMember]
        public IEnumerable<ToDoResource> ToDos { get; set; }
    }
}