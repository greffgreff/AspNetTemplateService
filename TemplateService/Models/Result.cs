namespace TemplateService.Models;

public class Result<T> where T : class
{
    public T? Data { get; }
    public Error? Error { get; }
    public bool IsSuccess { get; }

    protected Result(T? data, Error? error)
    {
        Data = data;
        Error = error;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(data, null);
    }
}

public class Result : Result<object>
{
    protected Result(object? data, Error? error) : base(data, error)
    {
    }

    public static Result Success()
    {
        return new Result(null, null);
    }

    public static Result Failure(Error error)
    {
        return new Result(default, error);
    }
}
