using OnlineReservationPOC.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace OnlineReservationPOC.Controllers
{
    public class ToDosController:ApiController
    {
        //api/ToDos
        public HttpResponseMessage Get()
        {
            var toDos = new ToDosQuery(new ToDosQuery.ToDosRepository(), new ToDosQuery.ToDosAdapter(), new LinkFactory(new HttpUrlProvider(this.Request), this.Configuration.Routes)).GetAllToDos();
            return Request.CreateResponse(HttpStatusCode.OK, toDos);
        }

        //api/ToDos/{Id}
        public HttpResponseMessage Get(int Id)
        {
            HttpResponseMessage response;
            try
            {
                var toDo = new ToDosQuery(new ToDosQuery.ToDosRepository(), new ToDosQuery.ToDosAdapter(), new LinkFactory(new HttpUrlProvider(this.Request), this.Configuration.Routes)).GetToDo(Id);
                
                if (toDo != null)
                    response = Request.CreateResponse(HttpStatusCode.OK, toDo);
                else { response = Request.CreateResponse(HttpStatusCode.NotFound); }
            }
            catch (Exception) { 
                response = Request.CreateResponse(HttpStatusCode.NotFound, "Ops!");
            }
            

            return response;
        }
    }
}