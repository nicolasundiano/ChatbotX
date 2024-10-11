namespace Application.Common.ApplicationResults;

public readonly record struct Result<TValue> : IResult<TValue>
{
    private readonly TValue? _value = default;
    private readonly List<Error>? _errors = null;
    
    public TValue Value => _value!;
    public List<Error> Errors => IsError ? _errors! : new List<Error> { };
    public bool IsError { get; }


    private Result(TValue value)
    {
        _value = value;
        IsError = false;
    }
    
    private Result(Error error)
    {
        _errors = new List<Error> { error };
        IsError = true;
    }
    
    private Result(List<Error> errors)
    {
        _errors = errors;
        IsError = true;
    }
    
    public static implicit operator Result<TValue>(TValue value)
    {
        return new Result<TValue>(value);
    }
    
    public static implicit operator Result<TValue>(Error error)
    {
        return new Result<TValue>(error);
    }
    
    public static implicit operator Result<TValue>(List<Error> errors)
    {
        return new Result<TValue>(errors);
    }
}