namespace NSPS.Domain.CustomExceptions.ProductCreationExceptions
{
    internal class Product_IdCreationException : ADomainException
    {
        public Product_IdCreationException(string message) : base(message)
        {
        }
    }
}
