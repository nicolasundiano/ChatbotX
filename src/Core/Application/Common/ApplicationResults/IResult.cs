namespace Application.Common.ApplicationResults;

public interface IResult<out TValue> : IResult
{
    TValue Value { get; }
}

public interface IResult
{
    List<Error>? Errors { get; }
    
    bool IsError { get; }
}