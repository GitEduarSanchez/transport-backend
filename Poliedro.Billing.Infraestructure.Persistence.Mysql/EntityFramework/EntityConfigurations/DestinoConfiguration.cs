using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Destino.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class DestinoConfiguration
{
    public DestinoConfiguration(EntityTypeBuilder<DestinoEntity> builder)
    {
        builder.ToTable("Destino");
        builder.HasKey(x => x.IdDestino);
        builder.Property(x => x.IdDestino).HasColumnName("idDestino");
        builder.Property(x => x.Descripcion).HasColumnName("Descripcion");
    }
}
