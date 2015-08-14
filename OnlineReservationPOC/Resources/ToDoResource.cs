using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnlineReservationPOC.Resources
{
    [DataContract]
    public class ToDoResource:Resource
    {
        public ToDoResource(int id)
        {
            this.Id = id;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ActivityName { get; set; }
        [DataMember]
        public string ActivityDesc { get; set; }
    }
}