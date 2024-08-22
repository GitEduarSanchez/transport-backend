using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

public class ServerConfiguration
{
    public ServerConfiguration(EntityTypeBuilder<ServerEntity> builder)
    {
        builder.ToTable("server");
        builder.HasKey(x => x.ServerId);
        builder.Property(x => x.ServerId).HasColumnName("serverid");
        builder.Property(x => x.Ip).HasColumnName("ip");
        builder.Property(x => x.DatabaseName).HasColumnName("database_name");
        builder.Property(x => x.DbUsername).HasColumnName("db_username");
        builder.Property(x => x.DbPassword).HasColumnName("db_password");
        builder.Property(x => x.CreationDate).HasColumnName("creation_date");

        builder.HasMany(x => x.clientsBillingElectronic)
            .WithOne(x => x.Server)
            .HasForeignKey(x => x.ServerId);
    }
}
