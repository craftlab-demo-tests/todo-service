using Microsoft.AspNetCore.Mvc;
using Org.OpenAPITools.Services;

namespace Org.OpenAPITools.Controllers
{
    public class TodoController : DefaultApiController
    {
        private ITodoService todoService;

        public TodoController(ITodoService todoService) : base()
        {
            this.todoService = todoService;
        }

        public override IActionResult TodoGet([FromQuery]string userid) {
            var todo = todoService.GetTodoByUserId(userid);
            if (todo == null ){
                return NotFound();
            }
            return Ok(todo);
        }
    }
}