using NSPS.Domain.ValueObjects;
using System;


namespace NSPS.Domain.Entities;

public sealed class Admin
{
    private UserName     adminName     { get; set; }
    private UserPassword adminPassword { get; set; }

    public Admin(Guid id, UserName adminName, UserPassword adminPassword)
    {
        this.adminName = adminName;
        this.adminPassword = adminPassword;
    }


    public Admin CreateAdmin(Guid id,
                            UserName adminName,
                            UserPassword adminPassword)
    {
        //could add logic here
        return new Admin(id, adminName, adminPassword);
    }
}
