using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Tests
{
    public interface ITodoService
    {
        public Guid AddTodo(TodoDto dto);
        void DeleteTodo(Guid id);
        void EditTodo(Guid id,TodoDto dto);
        Todo GetodoById(Guid id);
        public IEnumerable<Todo> Getodos();
    }
}