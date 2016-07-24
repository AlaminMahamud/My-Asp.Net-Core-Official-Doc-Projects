using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        public IToDoRepository ToDoItems { get; set; }
        public ToDoController(IToDoRepository todoItems)
        {
            ToDoItems = todoItems;
        }
        public IEnumerable<ToDoItem> GetAll()
        {
            return ToDoItems.GetAll();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = ToDoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ToDoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            ToDoItems.Add(item);
            return CreatedAtRoute("GetTodo", new {id= item.Key}, item);
        }
    }
}
