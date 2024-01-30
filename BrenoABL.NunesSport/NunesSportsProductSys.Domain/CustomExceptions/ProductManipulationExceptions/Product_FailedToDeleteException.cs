namespace NSPS.Domain.CustomExceptions.ProductManipulationExceptions;


internal sealed class Product_FailedToDeleteException : ADomainException
{
    public Product_FailedToDeleteException(string message) : base(message)
    {
    }
}
