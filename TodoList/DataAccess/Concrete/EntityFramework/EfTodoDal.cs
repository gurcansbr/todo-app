using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TodoList.DataAccess.Abstruct;
using TodoList.DataAccess.Concrete.EntityFramework.Contexts;
using TodoList.Entities;

namespace TodoList.DataAccess.Concrete.EntityFramework
{
    public class EfTodoDal : EfEntityRepositoryBase<Todo, TodoContext>, ITodoDal
    {
        
    }
}
