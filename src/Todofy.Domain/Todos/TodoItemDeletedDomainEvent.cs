using Todofy.SharedKernel;

namespace Todofy.Domain.Todos;

public record TodoItemDeletedDomainEvent(string TodoItemId) : IDomainEvent;
