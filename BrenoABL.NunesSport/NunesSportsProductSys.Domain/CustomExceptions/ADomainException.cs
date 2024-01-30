namespace NSPS.Domain.CustomExceptions;

public abstract class ADomainException : Exception
{
    protected ADomainException(string message)
                              : base(message)
    {

    }
}
