namespace NSPS.Domain.CustomExceptions.ProductManipulationExceptions;


internal sealed class Product_FailedToEditNameException : ADomainException
{
    public Product_FailedToEditNameException(string message) : base(message)
    {
    }
}
