using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TodoList.Entities;
using TodoList.Models;
using TodoList.Services.Abstruct;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        private List<SelectListItem> GetOptions()
        {
            return new List<SelectListItem>
                {
                    new SelectListItem{Text = "Daily", Value="0"},
                    new SelectListItem{Text = "Weekly", Value="1"},
                    new SelectListItem{Text = "Monthly", Value="2"},
                };
        }

        public IActionResult Index(int id = 0)
        {
            var model = new TodoListViewModel
            {
                Todos = id == 0 ? _todoService.GetAll() : _todoService.GetCompleted()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new TodoEditViewModel
            {
                Todo = new Todo(),
                Periods = this.GetOptions()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TodoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Todo.CreatedAt = DateTime.Now;
                model.Todo.UpdatedAt = DateTime.Now;
                _todoService.Add(model.Todo);
                TempData["success"] = "Todo item is successfully added!";

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("Error", "Some error(s) accured while attempting to save changes");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = new TodoEditViewModel
            {
                Todo = _todoService.GetById(id),
                Periods = this.GetOptions()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(TodoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Todo.UpdatedAt = DateTime.Now;
                _todoService.Update(model.Todo);
                TempData["success"] = "Todo item is successfully updated!";

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("Error", "Some error(s) accured while attempting to save changes");
                return View(model);
            }
        }

        public IActionResult Complete(int id)
        {
            if (_todoService.Complete(id))
            {
                TempData["success"] = "Task completed!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Some error(s) accured while task complete";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            if (_todoService.Delete(id))
            {
                TempData["success"] = "Task is successfully deleted!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Some error(s) accured while task delete";
                return RedirectToAction("Index");
            }
        }
    }
}
