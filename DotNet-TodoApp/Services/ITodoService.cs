using DotNet_TodoApp.Dtos;

namespace DotNet_TodoApp.Tests
{
    public interface ITodoService
    {
        public Task AddTodo(TodoDto dto);
    }
}