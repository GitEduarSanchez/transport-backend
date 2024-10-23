using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Ciudad.Entities;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;
using Poliedro.Billing.Domain.View_Ciudad.Entities;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Destino.Entities;
using Poliedro.Billing.Domain.ControlViaje.Entities;
using Poliedro.Billing.Domain.Estado.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<ConductorEntity> Conductor { get; set; }
    public DbSet<ControlViajeEntity> ControlViaje { get; set; }
    public DbSet<EstadoEntity> Estado { get; set; }
    public DbSet<CiudadEntity> Ciudad { get; set; }

    
    public DbSet<View_CiudadEntity> View_Ciudad { get; set; }
    public DbSet<VehiculoEntity> Vehiculo { get; set; }

    public DbSet<DestinoEntity> Destino { get; set; }
    public DbSet<ControlViajeProductoEntity> ControlViajeProducto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
        new ControlViajeConfiguration(modelBuilder.Entity<ControlViajeEntity>());
        new CiudadConfiguration(modelBuilder.Entity<CiudadEntity>());
        new View_CiudadConfiguration(modelBuilder.Entity<View_CiudadEntity>());
 feature/ControllerControlViajeProducto
        new ControlViajeProductoConfiguration(modelBuilder.Entity<ControlViajeProductoEntity>());

        new DestinoConfiguration(modelBuilder.Entity<DestinoEntity>());
 releasecandidate/v1.0.0
        
        new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
         new EstadoConfiguration(modelBuilder.Entity<EstadoEntity>());
    }
internal class VehiculoConfiguration