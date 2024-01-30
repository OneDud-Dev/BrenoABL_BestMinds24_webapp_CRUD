using NSPS.Domain.Primitives;
using NSPS.Domain.ValueObjects;
using System;


namespace NSPS.Domain.Entities;

public sealed class Product : AnEntity
{

    public Product(
        Guid id,
        ProductName? prodName,
        ProductCost? cost,
        ProductDescription? description,
        ProductCode? code)
                            : base(id)
    {

    }

    public ProductName? PName { get; private set; }
    public ProductCost? Cost { get; private set; }
    public ProductDescription? Desciption { get; private set; }
    public ProductCode? Code { get; private set; }

    public static Product Create(
        Guid id,
        ProductName name,
        ProductCost cost,
        ProductDescription description,
        ProductCode code)
    {
        var newProduct = new Product(id, name, cost, description, code);

        return newProduct;
    }

}
