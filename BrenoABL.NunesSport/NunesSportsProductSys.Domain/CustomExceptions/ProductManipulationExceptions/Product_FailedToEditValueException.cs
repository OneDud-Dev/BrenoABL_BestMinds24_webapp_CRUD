namespace NSPS.Domain.CustomExceptions.ProductManipulationExceptions;


internal sealed class Product_FailedToEditValueException : ADomainException
{
    public Product_FailedToEditValueException(string message) : base(message)
    {
    }
}
