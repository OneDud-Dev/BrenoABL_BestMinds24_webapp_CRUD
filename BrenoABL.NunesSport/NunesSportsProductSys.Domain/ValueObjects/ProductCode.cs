using NSPS.Domain.CustomExceptions.ProductCreationExceptions;
using NSPS.Domain.Primitives;


namespace NSPS.Domain.ValueObjects
{
    public sealed class ProductCode : AValueObject
    {
        public int ProdCode { get; init; }
        private const int maxCode = 9999999;
        private const int minCode = 0;


        private ProductCode(int code) => ProdCode = code;
        public static ProductCode Create(int? code)
        {
            if (code is null)
            {
                throw new Product_CodeCreationException
                        ("Product Code Can Not Be Null");
            }
            if (code < minCode)
            {
                throw new Product_CodeCreationException
                        ($"Product Code Can Not Be Less Than {minCode}");
            }
            if (code > maxCode)
            {
                throw new Product_CodeCreationException
                        ($"Product Code Can Not Be Higher Than {maxCode}");
            }

            return new ProductCode((int)code);
        }


        public override IEnumerable<object> GetAtomicValues()
        {
            yield return ProdCode;
        }

    }
}
