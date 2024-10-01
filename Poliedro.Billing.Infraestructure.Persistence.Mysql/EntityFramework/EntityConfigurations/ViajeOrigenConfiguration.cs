using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ViajeOrigenConfiguration
{
    public ViajeOrigenConfiguration(EntityTypeBuilder<ViajeOrigenEntity> builder)
    {
        builder.ToTable("conductor");
        builder.HasKey(x => x.idControlViajeOrigen);
        builder.Property(x => x.idControlViajeOrigen).HasColumnName("idconductor");
        builder.Property(x => x.idControlViaje).HasColumnName("idControlViaje");
        builder.Property(x => x.idOrigen).HasColumnName("idOrigen");
        builder.Property(x => x.idCiudad).HasColumnName("idCiudad");

    }
}
