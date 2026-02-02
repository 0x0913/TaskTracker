using TaskTracker.Enums;

namespace TaskTracker.Models;

public class TaskItem
{
    public TaskItem(string description)
    {
        Id = Guid.NewGuid();  
        Description = description;
        CreatedAt = DateTime.Now;
    }

    public Guid Id {get; private set;}
    public string Description {get; private set;} = string.Empty;
    public Status TaskStatus {get; private set;} = Status.todo;
    public DateTime CreatedAt {get; private set;}
    public DateTime UpdatedAt {get; private set;}
}