using NSPS.Domain.CustomExceptions.ProductCreationExceptions;



namespace NSPS.Domain.ValueObjects;

public record ProductCost
{
    public double ProdCost { get; private set; }
    private const double minCost = 0;
    private const double maxCost = 999999;


    private       ProductCost(double cost) => ProdCost = cost;
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
