using Todofy.SharedKernel;

namespace Todofy.Domain.Todos;

public static class TodoItemErrors
{
    public static Error AlreadyCompleted(string todoItemId) =>
        Error.Problem("TodoItems.AlreadyCompleted",
            $"The to-do item with Id={todoItemId} is already completed.");

    public static Error NotFound(string todoItemId) =>
        Error.NotFound("TodoItems.NotFound",
            $"The to-do item with Id = {todoItemId} was not found.");
}
