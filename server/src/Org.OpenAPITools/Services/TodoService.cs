using System.Collections.Generic;
using System.Linq;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Services
{
    public interface ITodoService
    {
        Todo GetTodoByUserId(int userid);
        Todo AddTodo(Todo todo);
    }

    public class TodoService : ITodoService
    {
        private Dictionary<int, Todo> todos = new Dictionary<int, Todo>();

        public Todo AddTodo(Todo todo)
        {
            todo.Id = GetNewId();
            todos.Add(todo.Id, todo);
            return todo;
        }

        public Todo GetTodoByUserId(int userid)
        {
            return todos.FirstOrDefault(kvp => kvp.Value.Userid.Equals(userid)).Value;
        }

        private int GetNewId()
        {
            if (todos.Count == 0) return 0;
            return todos.Max(kvp => kvp.Key) + 1;
        }
    }
}