using NSPS.Domain.CustomExceptions.ProductCreationExceptions;
using NSPS.Domain.Primitives;


namespace NSPS.Domain.ValueObjects
{
    public sealed class ProductCost : AValueObject
    {

        public double PValue { get; init; }
        private const double minCost = 0;
        private const double maxCost = 999999;


        public ProductCost(double cost) => PValue = cost;

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return PValue;
        }



        public static ProductCost Create(double? cost)
        {
            if (cost is null)
            {
                throw new Product_CostValueCreationException
                        ("Product Cost Can Not Be Null");
            }
            if (cost < minCost)
            {
                throw new Product_CostValueCreationException
                        ($"Product Cost Can Not Be Less Than {minCost}");
            }
            if (cost > maxCost)
            {
                throw new Product_CostValueCreationException
                        ($"Product Cost Can Not Be Higher Than {maxCost}");
            }

            return new ProductCost((double)cost);
        }
    }
}
