using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MathTraining.Web.Repositories.Demo;
using MathTraining.Web.Models.Demo;

namespace MathTraining.Web.Controllers.Demo
{
    [Produces("application/json")]
    [Route("api/Todoes")]
    public class TodoesController : Controller
    {
        private readonly ITodoRepository _todoItems;

        public TodoesController(ITodoRepository todoItems)
        {
            _todoItems = todoItems;
        }

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.GetAll();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = _todoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _todoItems.Add(item);
            return CreatedAtRoute("GetTodo", new { id = item.Key }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] TodoItem item)
        {
            if (item == null || item.Key != id)
            {
                return BadRequest();
            }

            var todo = _todoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _todoItems.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var todo = _todoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _todoItems.Remove(id);
            return new NoContentResult();
        }
    }
}