using NSPS.Domain.CustomExceptions.ProductCreationExceptions;
using NSPS.Domain.Primitives;

namespace NSPS.Domain.ValueObjects
{
    public sealed class ProductDescription : AValueObject
    {
        public string prodDescription { get; init; }
        private const int minText = 10;
        private const int maxText = 600;

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return prodDescription;
        }

        private ProductDescription(string prodDescription)
        {
            this.prodDescription = prodDescription;
        }



        public ProductDescription Create(string? description)
        {
            if (description is null)
            {
                throw new Product_DescriptionCreationException
                        ("Product Description Can Not Be Null");
            }
            if (description.Length < minText)
            {
                throw new Product_DescriptionCreationException
                        ($"Product Description must be longer than {minText} Characteres");
            }
            if (description.Length > maxText)
            {
                throw new Product_DescriptionCreationException
                        ($"Product description Can Not Be Longer Than {maxText} Characteres");
            }

            return new ProductDescription(description);
        }
    }
}
