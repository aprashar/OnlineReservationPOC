using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationPOC.Resources
{
    interface ILinkable
    {
        public Link Self { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}
