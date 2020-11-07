using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.DataAccess.Abstruct;
using TodoList.Entities;
using TodoList.Services.Abstruct;

namespace TodoList.Services.Concrete
{
    public class TodoManager : ITodoService
    {
        private ITodoDal _todoDal;
        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public void Add(Todo entity)
        {
            _todoDal.Add(entity);
        }

        public bool Complete(int id)
        {
            var entity = _todoDal.Get(td => td.Id == id);
            if(entity != null)
            {
                entity.IsCompleted = true;
                _todoDal.Update(entity);
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var entity = _todoDal.Get(td => td.Id == id);
            if (entity != null)
            {
                _todoDal.Delete(entity);
                return true;
            }

            return false;
        }

        public List<Todo> GetAll()
        {
            return _todoDal.List();
        }

        public Todo GetById(int id)
        {
            return _todoDal.Get(td => td.Id == id);
        }

        public List<Todo> GetCompleted()
        {
            return _todoDal.List(td => td.IsCompleted == true);
        }

        public void Update(Todo entity)
        {
            _todoDal.Update(entity);
        }
    }
}
