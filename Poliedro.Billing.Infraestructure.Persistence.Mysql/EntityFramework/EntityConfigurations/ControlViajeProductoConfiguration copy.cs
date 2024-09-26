using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ControlViajeProductoConfiguration
{
    public ControlViajeProductoConfiguration(EntityTypeBuilder<ControlViajeProductoEntity> builder)
    {
        builder.ToTable("ControlViajeProducto");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idControlViajeProducto");
        builder.Property(x => x.idControlViaje).HasColumnName("idControlViaje");
        builder.Property(x => x.idProducto ).HasColumnName("idProducto");
    }
}
