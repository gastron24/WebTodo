namespace Todo.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; } = 0;
        public bool IsCompleted { get; set; }

        public Task(string name,string description,int status,bool isComplete)
        {
            Name = name;
            Description = description;
            Status = status;
            IsCompleted = isComplete;
            Id++;
        }
    }
}
