using Todofy.SharedKernel;

namespace Todofy.Domain.Todos;

public record TodoItemCreatedDomainEvent(string TodoItemId) : IDomainEvent;
