using System.Collections.Generic;
using System.Linq;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Services
{
    public interface ITodoService
    {
        Todo GetTodoByUserId(string userid);
    }

    public class TodoService : ITodoService
    {
        private Dictionary<int, Todo> todos = new Dictionary<int, Todo>();

        public Todo GetTodoByUserId(string userid)
        {
            return todos.FirstOrDefault(kvp => kvp.Value.Userid.Equals(userid)).Value;
        }
    }
}