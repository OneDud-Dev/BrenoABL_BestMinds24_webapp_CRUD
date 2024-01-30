namespace NSPS.Domain.CustomExceptions.ProductManipulationExceptions;


internal sealed class Product_FailedToEditCodeException : ADomainException
{
    public Product_FailedToEditCodeException(string message) : base(message)
    {
    }
}
