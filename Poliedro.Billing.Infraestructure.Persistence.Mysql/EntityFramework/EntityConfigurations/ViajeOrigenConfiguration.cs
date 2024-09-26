using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ViajeOrigenConfiguration
{
    public ViajeOrigenConfiguration(EntityTypeBuilder<ViajeOrigenEntity> builder)
    {
        builder.ToTable("ViajeOrigen");
        builder.HasKey(x => x.IdControlViajeOrigen);
        builder.Property(x => x.IdControlViajeOrigen).HasColumnName("idconductor");
        builder.Property(x => x.IdControlViaje).HasColumnName("IdControlViaje");
        builder.Property(x => x.IdOrigen).HasColumnName("IdOrigen");
        builder.Property(x => x.IdCiudad).HasColumnName("IdCiudad");
    }
}
