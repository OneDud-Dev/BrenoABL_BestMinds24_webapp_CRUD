using NSPS.Domain.CustomExceptions.ProductCreationExceptions;
using NSPS.Domain.Primitives;
using System.Xml.Linq;


namespace NSPS.Domain.ValueObjects
{
    public sealed class ProductName : AValueObject
    {
        public string ProdName { get; init; }
        private int minText = 2;
        private int maxText = 50;

        private ProductName(string prodName) => ProdName = prodName;

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return ProdName;
        }


        public ProductName Creater(string? prodName)
        {
            if (prodName is null)
            {
                throw new Product_NameCreationException
                        ("Product Name Can Not Be Null");
            }
            if (prodName.Length < minText)
            {
                throw new Product_NameCreationException
                        ($"Product Name must be longer than {minText} Characteres");
            }
            if (prodName.Length > maxText)
            {
                throw new Product_NameCreationException
                        ($"Product Name Can Not Be Longer Than {maxText} Characteres");
            }


            return new ProductName(prodName);
        }
    }
}
