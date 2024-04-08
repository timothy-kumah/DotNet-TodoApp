using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Repositories
{
    public interface ITodoRepository
    {
        Task AddTodo(Todo todo);
        void DeleteTodo(Guid id);
        void EditTodo(Guid id, TodoDto dto);
        Todo GetTodo(Guid id);
        IEnumerable<Todo> GetTodos();
    }
}
