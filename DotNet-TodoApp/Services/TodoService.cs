﻿using DotNet_TodoApp.Dtos;
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

        public async Task AddTodo(TodoDto dto)
        {
            var todo = new Todo
            {
                Title = dto.Title,
                CreatedAt = dto.CreatedAt,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted,
            };
            await _todoRepository.AddTodo(todo);
        }

        public IEnumerable<Todo> Getodos()
        {
            return  _todoRepository.GetTodos();
        }
    }
}
