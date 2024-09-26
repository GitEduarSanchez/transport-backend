using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ControlViajeProductoConfiguration
{
    public ControlViajeProductoConfiguration(EntityTypeBuilder<ControlViajeProductoEntity> builder)
    {
        builder.ToTable("conductor");
        builder.HasKey(x => x.idControlViajeProducto);
        builder.Property(x => x.idControlViajeProducto).HasColumnName("idControlViajeProducto");
        builder.Property(x => x.idControlViaje).HasColumnName("idControlViaje");
        builder.Property(x => x.idProducto).HasColumnName("idProducto");
    }
}
