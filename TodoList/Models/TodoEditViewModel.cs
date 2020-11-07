using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.Enums;

namespace TodoList.Models
{
    public class TodoEditViewModel
    {
        public Todo Todo { get; set; }
        public List<SelectListItem> Periods { get; set; }
    }
}
