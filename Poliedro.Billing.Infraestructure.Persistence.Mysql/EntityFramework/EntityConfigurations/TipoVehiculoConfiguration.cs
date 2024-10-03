using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.TipoVehiculo.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class TipoVehiculoConfiguration
{
    public TipoVehiculoConfiguration(EntityTypeBuilder<TipoVehiculoEntity> builder)
    {
        builder.ToTable("TipoVehiculo");
        builder.HasKey(x => x.idtipovehiculo);
        builder.Property(x => x.idtipovehiculo).HasColumnName("idtipovehiculo");
        builder.Property(x => x.descripcion).HasColumnName("descripcion");
    }
}
