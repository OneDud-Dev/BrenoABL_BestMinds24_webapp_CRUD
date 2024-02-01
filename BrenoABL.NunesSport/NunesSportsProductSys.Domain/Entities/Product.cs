using NSPS.Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSPS.Domain.Entities;

public class Product : AnEntity
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public double Code { get;  set; }

    public string Name { get;  set; }
    
    public double Cost { get;  set; }

    public string Desciption { get;  set; }

 
    public Product(
                    Guid id, string prodName, double code, string description, double cost)
                    : base(id)
    {
        Name = prodName;
        Cost = cost;
        Desciption = description;
        Code = code;
    }


    //public static Product Create(
    //    Guid id,
    //    string name,
    //    double code,
    //    string description,
    //    double cost)
    //{
    //    return new Product(id, name, cost, description, code);
    //}

}
