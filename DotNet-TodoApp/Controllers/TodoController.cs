using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNet_TodoApp.Data;
using DotNet_TodoApp.Models;
using DotNet_TodoApp.Dtos;
using DotNet_TodoApp.Tests;

namespace DotNet_TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService _todoService)
        {
           todoService = _todoService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo(TodoDto dto)
        {
            if (dto != null)
            {
                await todoService.AddTodo(dto);
                return Ok("Todo added successfully");
            }

            return BadRequest("Form is null");
            
        }

        [HttpGet]
        public IEnumerable<Todo> GetTodos()
        {
            return todoService.Getodos();
        }



    }
}
