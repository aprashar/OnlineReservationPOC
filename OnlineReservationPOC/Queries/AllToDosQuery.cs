using OnlineReservationPOC.Domain;
using OnlineReservationPOC.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Queries
{
    public class AllToDosQuery
    {
        private IToDosAdapter adapter;
        private LinkFactory linker;
        private IToDosRepository repo;

        public AllToDosQuery(IToDosRepository toDoRepo, IToDosAdapter toDoAdpapter, LinkFactory linker)
        {
            this.repo = toDoRepo;
            this.adapter = toDoAdpapter;
            this.linker = linker;
        }

        public ListOfToDosResource GetAllToDos()
        {
            var toDos = repo.GetToDos();
            return null;
        }

        public interface IToDosAdapter
        {
        }

        public interface IToDosRepository
        {
            ListOfToDos GetToDos();
           
        }

        public class ToDoRepository : IToDosRepository
        {
            public ListOfToDos GetToDos()
            {

                var toDos = new List<ToDo>();
                toDos.Add(new ToDo() { Id = 1, ActivityName = "Go out for a meal", ActivityDesc = "Reserve a table at a restaurant" });
                toDos.Add(new ToDo() { Id = 2, ActivityName = "Buy Tickets", ActivityDesc = "Buy Tickets to a movie or a game" });
                toDos.Add(new ToDo() { Id = 3, ActivityName = "Buy other Stuff", ActivityDesc = "C'mon let's waste some money" });
                toDos.Add(new ToDo() { Id = 4, ActivityName = "Get help", ActivityDesc = "Things you are too lazy to do" });

                return new ListOfToDos() { ToDos = toDos };

            }
        }
    }
}