﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Concepto.Entities;
using Poliedro.Billing.Domain.Ciudad.Entities;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;
using Poliedro.Billing.Domain.View_Ciudad.Entities;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Origen.Entities;
using Poliedro.Billing.Domain.ControlViaje.Entities;
using Poliedro.Billing.Domain.Estado.Entities;
using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<ConductorEntity> Conductor { get; set; }
    public DbSet<OrigenEntity> Origen { get; set; }
    public DbSet<ConceptoEntity> Concepto { get; set; }
 public DbSet<VehiculoEntity> Vehiculo { get; set; }
    public DbSet<ControlViajeEntity> ControlViaje { get; set; }
    public DbSet<EstadoEntity> Estado { get; set; }
    public DbSet<CiudadEntity> Ciudad { get; set; }
    public DbSet<DescargueEntity> Descargue { get; set; }

    
    public DbSet<View_CiudadEntity> View_Ciudad { get; set; }
    public DbSet<VehiculoEntity> Vehiculo { get; set; }

    public DbSet<ControlViajeProductoEntity> ControlViajeProducto { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private static void EntityConfiguration(ModelBuilder modelBuilder)
    {
        new ConductorConfiguration(modelBuilder.Entity<ConductorEntity>());
         new OrigenConfiguration(modelBuilder.Entity<OrigenEntity>());
        new ConceptoConfiguration(modelBuilder.Entity<ConceptoEntity>());
         new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
    }
}

internal class VehiculoConfiguration
{
    private EntityTypeBuilder<VehiculoEntity> entityTypeBuilder;

    public VehiculoConfiguration(EntityTypeBuilder<VehiculoEntity> entityTypeBuilder)
        new ControlViajeConfiguration(modelBuilder.Entity<ControlViajeEntity>());
        new CiudadConfiguration(modelBuilder.Entity<CiudadEntity>());
        new View_CiudadConfiguration(modelBuilder.Entity<View_CiudadEntity>());
 feature/ControllerControlViajeProducto
        new ControlViajeProductoConfiguration(modelBuilder.Entity<ControlViajeProductoEntity>());

        new DescargueConfiguration(modelBuilder.Entity<DescargueEntity>());
 releasecandidate/v1.0.0
        new VehiculoConfiguration(modelBuilder.Entity<VehiculoEntity>());
         new EstadoConfiguration(modelBuilder.Entity<EstadoEntity>());
    {
        this.entityTypeBuilder = entityTypeBuilder;
    }
internal class VehiculoConfiguration