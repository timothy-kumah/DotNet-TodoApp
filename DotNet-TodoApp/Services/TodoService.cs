using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;
using DotNet_TodoApp.Repositories;
using DotNet_TodoApp.Tests;

namespace DotNet_TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository) {
            _todoRepository = todoRepository;
        }

        public Guid AddTodo(TodoDto dto)
        {
            var todo = new Todo
            {
                Title = dto.Title,
                CreatedAt = dto.CreatedAt,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted,
            };
            _todoRepository.AddTodo(todo);
            return todo.TodoId;
        }

        public void DeleteTodo(Guid id)
        {
            _todoRepository.DeleteTodo(id);
        }

        public void EditTodo(Guid id, TodoDto dto)
        {
            _todoRepository.EditTodo(id,dto);
        }

        public Todo GetodoById(Guid id)
        {
            return _todoRepository.GetTodo(id);
        }

        public IEnumerable<Todo> Getodos()
        {
            return  _todoRepository.GetTodos();
        }
    }
}
