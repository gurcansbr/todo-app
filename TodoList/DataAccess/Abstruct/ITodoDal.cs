using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.DataAccess.Abstruct
{
    public interface ITodoDal : IEntityRepository<Todo>
    {

    }
}
