using NSPS.Domain.CustomExceptions.ProductCreationExceptions;



namespace NSPS.Domain.ValueObjects;

public record ProductName 
{
    public string ProdName { get; private set; } = string.Empty;
    private const int minText = 2;
    private const int maxText = 50;


    private       ProductName(string prodName) => ProdName = prodName;
    public static ProductName Create(string prodName)
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
