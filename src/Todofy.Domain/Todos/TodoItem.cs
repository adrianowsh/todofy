using Todofy.SharedKernel;

namespace Todofy.Domain.Todos;

public sealed class TodoItem : Entity
{
    private TodoItem(
        string id,
        string description,
        DateTime? dueDate,
        bool isComplete, DateTime? completedAt, Priority priority)
    {
        Id = id;
        Description = description;
        DueDate = dueDate;
        IsComplete = isComplete;
        CompletedAt = completedAt;
        Priority = priority;
    }

    private TodoItem() { }

    public string Id { get; private set; }
    public string Description { get; private set; }
    public DateTime? DueDate { get; private set; }
    public bool IsComplete { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public Priority Priority { get; private set; }

    public DateTime? CompletedAt { get; private set; }
    public static TodoItem Create(
        string description,
        DateTime? dueDate,
        bool isComplete,
        DateTime? completedAt,
        Priority priority)
    {
        return new TodoItem(
            id: $"tdo_{Guid.CreateVersion7()}",
            description,
            dueDate,
            isComplete,
            completedAt,
            priority);
    }

    public void CompleteItem()
    {
        IsComplete = true;
        CompletedAt = DateTime.UtcNow;
    }

    public void SetDueDate(DateTime? dueDate)
    {
        DueDate = dueDate;
    }
}
