using DotNet_TodoApp.Data;
using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DotNet_TodoAppContext _context;
        public TodoRepository(DotNet_TodoAppContext context)
        {
            _context = context;
        }
        public async Task AddTodo(Todo todo)
        {
            await _context.AddAsync(todo);
            _context.SaveChanges();
        }

        public IEnumerable<Todo> GetTodos()
        {
             return _context.Todo.OrderBy(t => t.Id).ToList();
        }
    }
}
