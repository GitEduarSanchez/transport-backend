using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations
{
    public class ClientBillingElectronicConfiguration
    {
        public ClientBillingElectronicConfiguration(EntityTypeBuilder<ClientBillingElectronicEntity> builder)
        {
            builder.ToTable("client_billing_electronic");
            builder.HasKey(x => x.ClientBillingElectronicId);
            builder.Property(x => x.ClientBillingElectronicId).HasColumnName("client_billing_electronic_id");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.ResolutionId).HasColumnName("resolutionid");
            builder.Property(x => x.ServerId).HasColumnName("serverid");
            builder.Property(x => x.ProviderId).HasColumnName("providerid");
            builder.Property(x => x.Active).HasColumnName("active");

            builder.HasOne(x => x.Server)
                .WithMany(x => x.clientsBillingElectronic)
                .HasForeignKey(x => x.ServerId);

            builder.HasOne(x => x.DianResolution)
                .WithMany(x => x.clientsBillingElectronic)
                .HasForeignKey(x => x.ResolutionId);
        }
    }
}