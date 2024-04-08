namespace DotNet_TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public Guid TodoId { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
