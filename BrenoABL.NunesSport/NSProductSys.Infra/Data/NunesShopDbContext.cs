using Microsoft.EntityFrameworkCore;
using NSPS.Domain.Entities;


namespace NSProductSys.Infra.Data;

internal class NunesShopDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}NunesShopDB.db");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> TheProducts { get; set; }
    //public DbSet<Admin>   admins   { get; set; }
}