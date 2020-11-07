using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Services.Abstruct
{
    public interface ITodoService
    {
        List<Todo> GetAll();
        List<Todo> GetCompleted();
        Todo GetById(int id);
        void Update(Todo entity);
        void Add(Todo entity);
        bool Delete(int id);
        bool Complete(int id);
    }
}
