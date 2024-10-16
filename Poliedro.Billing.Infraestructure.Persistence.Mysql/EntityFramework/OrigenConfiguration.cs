using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Origen.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class OrigenConfiguration
{
    public OrigenConfiguration(EntityTypeBuilder<OrigenEntity> builder)
    {
        builder.ToTable("origen");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idorigen");
        builder.Property(x => x.descripcion).HasColumnName("descripcion");
    }
}
