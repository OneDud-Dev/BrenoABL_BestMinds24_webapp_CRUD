using NSPS.Domain.Primitives;
using NSPS.Domain.ValueObjects;
using System;


namespace NSPS.Domain.Entities;

public sealed class Costumer : AnEntity
{
    public Costumer(Guid id, UserName costumerName, UserPassword costumerPassword) : base(id)
    {
        CostumerName = costumerName;
        CostumerPassword = costumerPassword;
    }

    public UserName CostumerName { get; set; }
    public UserPassword CostumerPassword { get; set; }
}

