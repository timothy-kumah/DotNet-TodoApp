using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Tests;

namespace DotNet_TodoApp.Services
{
    public class TodoService : ITodoService
    {
        public TodoService() { }

        public Task AddTodo(TodoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
