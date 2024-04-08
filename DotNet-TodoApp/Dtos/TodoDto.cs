namespace DotNet_TodoApp.Dtos
{
    public class TodoDto
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
