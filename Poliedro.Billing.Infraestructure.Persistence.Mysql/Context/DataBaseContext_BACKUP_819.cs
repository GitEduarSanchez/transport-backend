using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using Poliedro.Billing.Domain.Concepto.Entities;
=======
using Microsoft.EntityFrameworkCore.Metadata.Builders;
>>>>>>> origin/feature/ControllerConductor
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
  
    public DbSet<ConductorEntity> Conductor { get; set; }
<<<<<<< HEAD
    public DbSet<ConceptoEntity> Concepto { get; set; }

=======
 public DbSet<VehiculoEntity> Vehiculo { get; set; }
>>>>>>> origin/feature/ControllerConductor
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
<<<<<<< HEAD
        new ConceptoConfiguration(modelBuilder.Entity<ConceptoEntity>());
=======
         new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
>>>>>>> origin/feature/ControllerConductor
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