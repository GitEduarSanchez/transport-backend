using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class DescargueConfiguration
{
    public DescargueConfiguration(EntityTypeBuilder<DescargueEntity> builder)
    {
        builder.ToTable("descargue");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("iddescargue");
        builder.Property(x => x.descriocion).HasColumnName("descriocion");
    }
}
