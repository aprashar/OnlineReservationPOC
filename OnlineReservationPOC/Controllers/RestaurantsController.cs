using OnlineReservationPOC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace OnlineReservationPOC.Controllers
{
    public class RestaurantsController :ApiController
    {
        //api/Restaurants
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //api/Restaurants/{Id}
        public HttpResponseMessage Get(int RestaurantId)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //api/Restaurants
        [HttpPost]
        public HttpResponseMessage Get([FromBody] Restaurant selectedRestaurant)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}