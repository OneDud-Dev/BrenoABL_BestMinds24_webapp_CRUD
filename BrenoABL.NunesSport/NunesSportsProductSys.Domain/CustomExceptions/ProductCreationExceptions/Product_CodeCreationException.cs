namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions;

internal class Product_CodeCreationException : ADomainException
{
    public Product_CodeCreationException(string message) : base(message)
    {
    }
}
