using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.TipoVehiculo.Entities;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
  
    public DbSet<TipoVehiculoEntity> TipoVehiculo { get; set; }
    public DbSet<ConductorEntity> Conductor { get; set; }
 public DbSet<VehiculoEntity> Vehiculo { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new TipoVehiculoConfiguration(modelBuilder.Entity<TipoVehiculoEntity>());
         new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
    }
}

internal class VehiculoConfiguration
{
    private EntityTypeBuilder<VehiculoEntity> entityTypeBuilder;

    public VehiculoConfiguration(EntityTypeBuilder<VehiculoEntity> entityTypeBuilder)
    {
        this.entityTypeBuilder = entityTypeBuilder;
    }
}