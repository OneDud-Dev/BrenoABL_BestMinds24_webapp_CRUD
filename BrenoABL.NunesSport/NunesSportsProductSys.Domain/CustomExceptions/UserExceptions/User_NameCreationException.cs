using NSPS.Domain.CustomExceptions;

namespace NSPS.Domain.CustomExceptions.UserExceptions;


internal class User_NameCreationException : ADomainException
{
    public User_NameCreationException(string message) : base(message)
    {
    }
}
