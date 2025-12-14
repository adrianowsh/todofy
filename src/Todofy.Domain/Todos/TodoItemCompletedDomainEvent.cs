using Todofy.SharedKernel;

namespace Todofy.Domain.Todos;

public record TodoItemCompletedDomainEvent(string TodoItemId) : IDomainEvent;
