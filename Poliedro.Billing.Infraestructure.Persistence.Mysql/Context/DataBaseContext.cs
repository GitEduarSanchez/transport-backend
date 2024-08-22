using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Server.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.EntityFramework.EntityConfigurations;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Context
{
    public class DataBaseContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ServerEntity> Server { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private static void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new ServerConfiguration(modelBuilder.Entity<ServerEntity>());
        }
    }
}
