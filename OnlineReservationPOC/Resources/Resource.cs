using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Resources
{
    public class Resource : ILinkable
    {
        public IEnumerable<Link> Links
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Link Self
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}