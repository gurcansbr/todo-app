using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Models
{
    public class TodoListViewModel
    {
        public List<Todo> Todos { get; set; }
    }
}
