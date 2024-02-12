using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSPS.Domain.Entities;

public class Product 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public double Code       { get; private set; }
    public string Name       { get; private set; } = string.Empty;
    public string Description{ get; private set; } = string.Empty;
    public double Cost       { get; private set; }


    public Product(double code,        string name,
                   string description, double cost)
    {
        Code = code;
        Name = name;
        Description = description;
        Cost = cost;
    }

    public static Product Create(double code,        string name,
                                 string description, double cost)
    {
        return new Product(code, name, description, cost);
    }
}
