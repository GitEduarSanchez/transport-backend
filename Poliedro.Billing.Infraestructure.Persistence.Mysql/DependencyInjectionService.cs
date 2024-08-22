using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;
using Poliedro.Billing.Domain.Ports;
using Poliedro.Billing.Domain.Resolution.DomainService;
using Poliedro.Billing.Domain.Server.DomainService;
using Poliedro.Billing.Domain.Server.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.ClientBillintElectronic.DomainService.Impl;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.DianResolution.DomainService.Impl;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Server.Adapters;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Server.DomainService.Impl;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql;

public static class DependencyInjectionService
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MysqlConnection");
        services.AddDbContext<DataBaseContext>(
            options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)
        ));
        services.AddScoped<IClientBillingElectronicDomainService, ClientBillingElectronicDomainService>();
        services.AddScoped<IServerDomainService, ServerDomainService>();
        services.AddScoped<IServerRepository, ServerRepository>();
        services.AddScoped<IDianResolutionDomainService, DianResolutionDomainService>();
        services.AddTransient<IMessageProvider, MessageProvider>();

        return services;
    }
}
