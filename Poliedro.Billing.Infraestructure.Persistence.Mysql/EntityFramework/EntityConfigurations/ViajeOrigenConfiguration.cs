using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ViajeOrigenConfiguration
{
    public ViajeOrigenConfiguration(EntityTypeBuilder<ViajeOrigenEntity> builder)
    {
        builder.ToTable("controlviaje_origen");
        builder.HasKey(x => x.IdControlViajeOrigen);
        builder.Property(x => x.IdControlViajeOrigen).HasColumnName("idcontrolviaje_origen");
        builder.Property(x => x.IdControlViaje).HasColumnName("idcontrolViaje");
        builder.Property(x => x.IdOrigen).HasColumnName("idorigen");
        builder.Property(x => x.IdCiudad).HasColumnName("idcuidad");
    }
}
