using OnlineReservationPOC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Controllers
{
    public class RestaurantReservationController
    {
        private Restaurant restaurant;

        public RestaurantReservationController(Restaurant selectedRestaurant)
        {
            this.restaurant = selectedRestaurant;
        }
    }
}