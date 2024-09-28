using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Trailer.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class TrailerConfiguration
{
    public TrailerConfiguration(EntityTypeBuilder<TrailerEntity> builder)
    {
        builder.ToTable("Trailer");
        builder.HasKey(x => x.idTrailer);
        builder.Property(x => x.Descripcion).HasColumnName("Descripcion");
        builder.Property(x => x.serial).HasColumnName("serial");
    }
}
