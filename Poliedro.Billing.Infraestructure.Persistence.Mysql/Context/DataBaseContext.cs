using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Ciudad.Entities;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
  
    public DbSet<ConductorEntity> Conductor { get; set; }
    public DbSet<CiudadEntity> Ciudad { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
        new CiudadConfiguration(modelBuilder.Entity<CiudadEntity>());
    }
}
