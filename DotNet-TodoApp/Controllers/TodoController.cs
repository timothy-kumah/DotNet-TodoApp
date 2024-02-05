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

namespace DotNet_TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        public TodoController()
        {
           
        }


        // POST: api/Todo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> AddTodo(TodoDto dto)
        {
            return Ok("Todo Created");
        }

    }
}
