using Microsoft.EntityFrameworkCore;
using NSPS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSProductSys.Infra.Data;

internal class NunesShopDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ProductSystemDB.db");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> products { get; set; }
    public DbSet<Admin>   admins   { get; set; }
}