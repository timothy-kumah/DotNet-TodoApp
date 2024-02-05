using DotNet_TodoApp.Controllers;
using DotNet_TodoApp.Dtos;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using FakeItEasy;

namespace DotNet_TodoApp.Tests
{
    public class TodoControllerTests
    {
        [Fact]
        public  async Task Add_Todo_Returns_StatusCode201()
        {
            //Arrange
            var mockTodoService =A.Fake<ITodoService>();
            var sut = new TodoController(mockTodoService);

            var dto = new TodoDto
            {
                CreatedAt = DateTime.Now,
                Description = "Test",
                IsCompleted = true,
                Title = "Test",
            };

           

            //Act
            var result = (OkObjectResult)await sut.AddTodo(dto);

            //Assert
            A.CallTo(() => mockTodoService.AddTodo(dto)).MustHaveHappenedOnceExactly();
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task Add_NullTodo_Returns_StatusCode400()
        {
            //Arrange
            var mockTodoService = A.Fake<ITodoService>();
            var sut = new TodoController(mockTodoService);

            //Act
            var result = (BadRequestObjectResult)await sut.AddTodo(null);

            //Assert
            A.CallTo(() => mockTodoService.AddTodo(null)).MustNotHaveHappened();
            result.StatusCode.Should().Be(400);

        }
    }
}