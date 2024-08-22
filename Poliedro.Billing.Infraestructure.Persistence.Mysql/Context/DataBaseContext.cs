using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;
using Poliedro.Billing.Domain.Server.Entities;
using Poliedro.Billing.Domain.Resolution.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context
{
    public class DataBaseContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ServerEntity> Server { get; set; }
        public DbSet<DianResolutionEntity> DianResolution { get; set; }
        public DbSet<ClientBillingElectronicEntity> ClientBillingElectronic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private static void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new ServerConfiguration(modelBuilder.Entity<ServerEntity>());
            new DianResolutionConfiguration(modelBuilder.Entity<DianResolutionEntity>());
            new ClientBillingElectronicConfiguration(modelBuilder.Entity<ClientBillingElectronicEntity>());
        }
    }
}
