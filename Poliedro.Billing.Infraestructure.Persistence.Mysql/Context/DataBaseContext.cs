using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Estado.Entities;
using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
  
    public DbSet<ConductorEntity> Conductor { get; set; }
    public DbSet<EstadoEntity> Estado { get; set; }
    public DbSet<DescargueEntity> Descargue { get; set; }
    
    public DbSet<ControlViajeProductoEntity> ControlViajeProducto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
 feature/ControllerControlViajeProducto
        new ControlViajeProductoConfiguration(modelBuilder.Entity<ControlViajeProductoEntity>());

        new DescargueConfiguration(modelBuilder.Entity<DescargueEntity>());
 releasecandidate/v1.0.0
         new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
         new EstadoConfiguration(modelBuilder.Entity<EstadoEntity>());
    }
}