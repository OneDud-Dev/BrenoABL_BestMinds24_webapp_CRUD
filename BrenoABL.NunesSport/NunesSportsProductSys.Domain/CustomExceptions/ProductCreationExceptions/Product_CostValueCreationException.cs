namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions;

internal class Product_CostValueCreationException : ADomainException
{
    public Product_CostValueCreationException(string message) : base(message)
    {
    }
}
