using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Destino.Entities;
using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
  
    public DbSet<ConductorEntity> Conductor { get; set; }
    public DbSet<DescargueEntity> Descargue { get; set; }
    public DbSet<VehiculoEntity> Vehiculo { get; set; }

    public DbSet<DestinoEntity> Destino { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
        new DescargueConfiguration(modelBuilder.Entity<DescargueEntity>());
        new DestinoConfiguration(modelBuilder.Entity<DestinoEntity>());
        
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