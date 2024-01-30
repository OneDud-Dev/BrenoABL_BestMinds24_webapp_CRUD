namespace NSPS.Domain.CustomExceptions.ProductManipulationExceptions;


internal sealed class Product_FailedToAddAnProductException : ADomainException
{
    public Product_FailedToAddAnProductException(string message) : base(message)
    {
    }
}
