namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions;

internal class Product_NameCreationException : ADomainException
{
    public Product_NameCreationException(string message) : base(message)
    {
    }
}
