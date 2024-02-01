using NSPS.Domain.Primitives;
using NSPS.Domain.ValueObjects;
using System;


namespace NSPS.Domain.Entities;

public sealed class Costumer : AnEntity
{
    public UserName     CostumerName     { get; set; }
    public UserPassword CostumerPassword { get; set; }
 
    public Costumer(Guid id, UserName costumerName, UserPassword costumerPassword) : base(id)
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

