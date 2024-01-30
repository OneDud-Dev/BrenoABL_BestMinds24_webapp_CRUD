namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions;

internal class Product_DescriptionCreationException : ADomainException
{
    public Product_DescriptionCreationException(string message) : base(message)
    {
    }
}
