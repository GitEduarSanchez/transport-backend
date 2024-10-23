using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class TrailerConfiguration
{
    public TrailerConfiguration(EntityTypeBuilder<TrailerEntity> builder)
    {
        builder.ToTable("Trailer");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idconductor");
        builder.Property(x => x.Name).HasColumnName("nombre");
    }
}
