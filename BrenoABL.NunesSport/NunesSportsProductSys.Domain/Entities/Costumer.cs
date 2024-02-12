using NSPS.Domain.ValueObjects;



namespace NSPS.Domain.Entities;

public sealed class Costumer
{
    public UserName     CostumerName     { get; set; }
    public UserPassword CostumerPassword { get; set; }
 
    public Costumer(Guid id, UserName costumerName, UserPassword costumerPassword)
    {
        CostumerName =     costumerName;
        CostumerPassword = costumerPassword;
    }


    public Costumer CreateCostumer(Guid id,
                                   UserName adminName,
                                   UserPassword adminPassword) 
    {
        
        return new Costumer(id, adminName, adminPassword);
    }
}

