namespace Todofy.SharedKernel;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
