using DotNet_TodoApp.Controllers;
using DotNet_TodoApp.Dtos;

namespace DotNet_TodoApp.Tests
{
    public class TodoControllerTests
    {
        [Fact]
        public void Add_Todo_Returns_StatusCode201()
        {
            //Arrange
            var sut = new TodoController();
            var dto = new TodoDto
            {
                CreatedAt = DateTime.Now,
                Description = "Test",
                IsCompleted = true,
                Title = "Test",
            };

            //Act
            sut.AddTodo(dto);
            //Assert
        }
    }
}