using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ConductorConfiguration
{
    public ConductorConfiguration(EntityTypeBuilder<ConductorEntity> builder)
    {
        builder.ToTable("conductor");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idconductor");
        builder.Property(x => x.Name).HasColumnName("nombre");
    }
}
