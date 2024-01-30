namespace NSPS.Domain.CustomExceptions.UserExceptions;


internal class User_PasswordisCreationException : ADomainException
{
    public User_PasswordisCreationException(string message) : base(message)
    {
    }
}
