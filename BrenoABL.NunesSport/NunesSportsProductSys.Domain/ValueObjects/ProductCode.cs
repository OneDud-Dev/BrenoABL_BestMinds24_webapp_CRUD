using NSPS.Domain.CustomExceptions.ProductCreationExceptions;



namespace NSPS.Domain.ValueObjects;

public record ProductCode
{
    public double ProdCode { get; private set; }
    private const double minCode = 0;
    private const double maxCode = 9999999;


    private       ProductCode(double code) => ProdCode = code;
    public static ProductCode Create(double code)
    {
        //if (code is null)
        //{
        //    throw new Product_CodeCreationException
        //            ("Product Code Can Not Be Null");
        //}
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

}
