using NSPS.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NSPS.Domain.Entities;

public class VBProduct
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public ProductCode        Code        { get; private set; }
    public ProductName        Name        { get; private set; }
    public ProductDescription Description { get; private set; }
    public ProductCost        Cost        { get; private set; }


    public VBProduct(ProductCode pCode, ProductName pName, ProductDescription pDescription, ProductCost pCost)
    {
        Code = pCode;
        Name = pName;
        Description = pDescription;
        Cost = pCost;
    }

}
