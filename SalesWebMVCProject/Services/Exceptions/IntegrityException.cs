namespace SalesWebMVCProject.Services.Exceptions;

public class IntegrityException : Exception
{
    public IntegrityException(string message) : base(message) { }
}
