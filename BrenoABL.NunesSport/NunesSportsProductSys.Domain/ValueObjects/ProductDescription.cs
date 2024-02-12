using NSPS.Domain.CustomExceptions.ProductCreationExceptions;



namespace NSPS.Domain.ValueObjects;

public record ProductDescription
{
    public string ProdDescription { get; private set; } = string.Empty;
    private const int minText = 10;
    private const int maxText = 600;


    private       ProductDescription(string prodDescription)
    {
        this.prodDescription = prodDescription;
    }
    public static ProductDescription Create(string description)
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
