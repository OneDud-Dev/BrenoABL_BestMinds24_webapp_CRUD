using NSPS.Domain.Primitives;
using NSPS.Domain.ValueObjects;
using System;


namespace NSPS.Domain.Entities;

public sealed class Admin : AnEntity
{
    public Admin(Guid id, UserName adminName, UserPassword adminPassword) : base(id)
    {
        this.adminName = adminName;
        this.adminPassword = adminPassword;
    }

    private UserName adminName { get; set; }
    private UserPassword adminPassword { get; set; }


    public Admin CreateAdmin(Guid id,
                            UserName adminName,
                            UserPassword adminPassword)
    {
        //could add logic here

        return new Admin(id, adminName, adminPassword);
    }


}
