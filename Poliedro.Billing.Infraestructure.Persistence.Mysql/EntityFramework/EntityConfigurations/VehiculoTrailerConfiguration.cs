using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.VehiculoTrailer.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class VehiculoTrailerConfiguration
{
    public VehiculoTrailerConfiguration(EntityTypeBuilder<VehiculoTrailerEntity> builder)
    {
        builder.ToTable("conductor");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("idconductor");
        builder.Property(x => x.Name).HasColumnName("nombre");
    }
}
