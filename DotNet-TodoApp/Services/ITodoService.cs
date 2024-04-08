using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Tests
{
    public interface ITodoService
    {
        public Task AddTodo(TodoDto dto);
        public IEnumerable<Todo> Getodos();
    }
}