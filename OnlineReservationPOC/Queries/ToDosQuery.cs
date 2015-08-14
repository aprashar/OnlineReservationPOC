using OnlineReservationPOC.Controllers;
using OnlineReservationPOC.Domain;
using OnlineReservationPOC.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace OnlineReservationPOC.Queries
{
    public class ToDosQuery
    {
        private IToDosAdapter adapter;
        private LinkFactory linker;
        private IToDosRepository repo;

        public ToDosQuery(IToDosRepository toDoRepo, IToDosAdapter toDoAdpapter, LinkFactory linker)
        {
            this.repo = toDoRepo;
            this.adapter = toDoAdpapter;
            this.linker = linker;
        }

        public ListOfToDosResource GetAllToDos()
        {
            var toDosEntity = repo.GetToDos();

            return adapter.MapToResource(toDosEntity, linker);
        }

        public ToDoResource GetToDo( int toDoId)
        {
            var toDoEntity = repo.GetToDo(toDoId);

            return adapter.MapToResource(toDoEntity, linker);
        }

        public interface IToDosAdapter
        {
            ListOfToDosResource MapToResource(ListOfToDos entity, LinkFactory linker);

            ToDoResource MapToResource(ToDo entity, LinkFactory linker);
        }

        public class ToDosAdapter : IToDosAdapter
        {
            public ToDoResource MapToResource(ToDo entity, LinkFactory linker)
            {
                return new ToDoResource(entity.Id) {ActivityDesc = entity.ActivityDesc,
                                                    ActivityName = entity.ActivityName,
                                                    Self = linker.GetResourceLink<ToDosController>(controller => controller.Get(entity.Id), "self", entity.ActivityName, HttpMethod.Get)
                };
            }

            public ListOfToDosResource MapToResource(ListOfToDos entity, LinkFactory linker)
            {
                var toDos = entity.ToDos.Select<ToDo, ToDoResource>(todo => new ToDoResource(todo.Id)
                {
                    ActivityDesc = todo.ActivityDesc,
                    ActivityName = todo.ActivityName,
                    Self = linker.GetResourceLink<ToDosController>(controller => controller.Get(todo.Id), "self", todo.ActivityName, HttpMethod.Get)
                    }
                );

                var resource = new ListOfToDosResource {
                    ToDos = toDos,
                    Self = linker.GetResourceLink<ToDosController>(controller => controller.Get(), "self", "Things to do", HttpMethod.Get)
                };
                      

                return resource;
            }
        }

        public interface IToDosRepository
        {
            ListOfToDos GetToDos();
            ToDo GetToDo(int todDoId);

        }

        public class ToDosRepository : IToDosRepository
        {
            private static List<ToDo> toDos = new List<ToDo>();

            public ToDosRepository()
            {
                toDos.Add(new ToDo() { Id = 1, ActivityName = "Go out for a meal", ActivityDesc = "Reserve a table at a restaurant" });
                toDos.Add(new ToDo() { Id = 2, ActivityName = "Buy Tickets", ActivityDesc = "Buy Tickets to a movie or a game" });
                toDos.Add(new ToDo() { Id = 3, ActivityName = "Buy other Stuff", ActivityDesc = "C'mon let's waste some money" });
                toDos.Add(new ToDo() { Id = 4, ActivityName = "Get help", ActivityDesc = "Things you are too lazy to do" });
            }
            public ListOfToDos GetToDos()
            {

               return new ListOfToDos() { ToDos = toDos };

            }

            public ToDo GetToDo(int todDoId)
            {

                return toDos.Where<ToDo>(toDo => toDo.Id == todDoId).First();

            }
        }
    }
}