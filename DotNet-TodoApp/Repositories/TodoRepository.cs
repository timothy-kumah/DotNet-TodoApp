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

        public void DeleteTodo(Guid id)
        {
            var itemToRemove = _context.Todo.SingleOrDefault(x => x.TodoId == id); 

            if (itemToRemove != null)
            {
                _context.Todo.Remove(itemToRemove);
                _context.SaveChanges();
            }
        }

        public void EditTodo(Guid id, TodoDto dto)
        {
            var todoItemToUpdate = _context.Todo.FirstOrDefault(item => item.TodoId == id);

            if (todoItemToUpdate != null)
            {
                todoItemToUpdate.IsCompleted = dto.IsCompleted;
                todoItemToUpdate.Description = dto.Description;
                todoItemToUpdate.Title = dto.Title;

                _context.SaveChanges();
            }
        }

        public Todo GetTodo(Guid id)
        {
            return _context.Todo.Where(t => t.TodoId == id).FirstOrDefault();
        }

        public IEnumerable<Todo> GetTodos()
        {
             return _context.Todo.OrderBy(t => t.Id).ToList();
        }
    }
}
