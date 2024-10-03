using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Vehiculo.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class VehiculoConfiguration
{ 
    public VehiculoConfiguration(EntityTypeBuilder<VehiculoEntity> builder)
    {
        builder.ToTable("vehiculo");
        builder.HasKey(x => x.idvehiculo);
        builder.Property(x => x.idvehiculo).HasColumnName("idvehiculo");
        builder.Property(x => x.placa).HasColumnName("placa");
        builder.Property(x => x.idmarca).HasColumnName("idmarca");
     
    }

}
