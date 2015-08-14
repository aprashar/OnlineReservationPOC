using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace OnlineReservationPOC.Resources
{
    [DataContract]
    public class Resource : ILinkable
    {
        [DataMember]
        public IEnumerable<Link> Links
        {
            get;
            set;
            
        }
        [DataMember]
        public Link Self
        {
            get;
            set;
           
        }
    }
}