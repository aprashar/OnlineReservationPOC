using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservationPOC.Resources
{
    interface ILinkable
    {
        Link Self { get; set; }
        IEnumerable<Link> Links { get; set; }
    }
}
