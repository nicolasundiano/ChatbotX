namespace Application.Common.ApplicationResults;

public class Error
{
    public string Code { get; }
    
    public string Description { get; }
    
    public ErrorType Type { get; }
    
    public static Error Failure(
        string code = "General.Failure",
        string description = "A failure has occurred.") =>
            new(code, description, ErrorType.Failure);
    
    public static Error Unexpected(
        string code = "General.Unexpected",
        string description = "An unexpected error has occurred.") =>
            new(code, description, ErrorType.Unexpected);
    
    public static Error Validation(
        string code = "General.Validation",
        string description = "A validation error has occurred.") =>
            new(code, description, ErrorType.Validation);
    
    public static Error Conflict(
        string code = "General.Conflict",
        string description = "A conflict error has occurred.") =>
            new(code, description, ErrorType.Conflict);
    
    public static Error NotFound(
        string code = "General.NotFound",
        string description = "A 'Not Found' error has occurred.") =>
            new(code, description, ErrorType.NotFound);
    
    public static Error Unauthorized(
        string code = "General.Unauthorized",
        string description = "An 'Unauthorized' error has occurred.") =>
            new(code, description, ErrorType.Unauthorized);
    
    public static Error Forbidden(
        string code = "General.Forbidden",
        string description = "A 'Forbidden' error has occurred.") =>
        new(code, description, ErrorType.Forbidden);
    
    private Error(string code, string description, ErrorType type)
    {
        Code = code;
        Description = description;
        Type = type;
    }
}