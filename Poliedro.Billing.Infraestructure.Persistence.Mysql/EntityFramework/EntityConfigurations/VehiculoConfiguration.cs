using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class VehiculoConfiguration
{
    public VehiculoConfiguration(EntityTypeBuilder<VehiculoEntity> builder)
    {
        builder.ToTable("Vehiculo");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idvehiculo");
        builder.Property(x => x.placa).HasColumnName("placa");
         builder.Property(x => x.idmarca).HasColumnName("idmarca");
          builder.Property(x => x.idtipovehiculo).HasColumnName("idtipovehiculo");
    }
}
