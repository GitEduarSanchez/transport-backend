using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poliedro.Billing.Domain.Resolution.Entities;
using Poliedro.Billing.Domain.Resolution.Enums;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations
{
    public class DianResolutionConfiguration
    {
        public DianResolutionConfiguration(EntityTypeBuilder<DianResolutionEntity> builder)
        {
            builder.ToTable("dian_resolution");
            builder.HasKey(x => x.ResolutionId);
            builder.Property(x => x.ResolutionId).HasColumnName("resolutionid");
            builder.Property(x => x.ResolutionNumber).HasColumnName("resolution_number");
            builder.Property(x => x.Prefix).HasColumnName("prefix");
            builder.Property(x => x.InitialRange).HasColumnName("initial_range");
            builder.Property(x => x.FinalRange).HasColumnName("final_range");
            builder.Property(x => x.ResolutionDate).HasColumnName("resolution_date");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.ResolutionFile).HasColumnName("resolution_file");
            builder.Property(x => x.Active).HasColumnName("active");
            builder.Property(x => x.CreationDate).HasColumnName("creation_date");
            builder.Property(x => x.VigencyMonth).HasColumnName("vigency_month");
            builder.Property(x => x.ExpirationDate).HasColumnName("expiration_date");
            builder.Property(x => x.ResolutionType).HasConversion(ConvertResolutionType()).HasColumnName("resolution_type");
            builder.Property(x => x.ClientBillingElectronicId).HasColumnName("client_billing_electronic_id");

            builder.HasMany(x => x.clientsBillingElectronic)
                .WithOne(x => x.DianResolution)
                .HasForeignKey(x => x.ResolutionId);
        }

        private ValueConverter ConvertResolutionType()
        {
            return new ValueConverter<ResolutionType, string>(
            v => v.ToString(),
            v => (ResolutionType)Enum.Parse(typeof(ResolutionType), v));
        }
    }
}
