﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineReservationPOC.Domain
{
    public class ListOfToDos
    {
        public IEnumerable<ToDo> ToDos { get; set; }
    }
}