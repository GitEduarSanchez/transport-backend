using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Trailer.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class TrailerConfiguration
{
    public TrailerConfiguration(EntityTypeBuilder<TrailerEntity> builder)
    {
        builder.ToTable("trailer");
        builder.HasKey(x => x.idtrailer);
        builder.Property(x => x.idtrailer).HasColumnName("idtrailer");
        builder.Property(x => x.descripcion).HasColumnName("descripcion");
        builder.Property(x => x.serial).HasColumnName("serial");

    }
}
