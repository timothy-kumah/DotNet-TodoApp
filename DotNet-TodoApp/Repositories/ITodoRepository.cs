using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Repositories
{
    public interface ITodoRepository
    {
        Task AddTodo(Todo todo);
        IEnumerable<Todo> GetTodos();
    }
}
