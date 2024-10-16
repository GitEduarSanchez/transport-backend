using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Origen.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class OrigenConfiguration
{
    public OrigenConfiguration(EntityTypeBuilder<OrigenEntity> builder)
    {
        builder.ToTable("origen");
        builder.HasKey(x => x.IdOrigen);
        builder.Property(x => x.IdOrigen).HasColumnName("idorigen");
        builder.Property(x => x.descripcion).HasColumnName("descripcion");
    }
}
