using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Domain.ControlViaje.Ports;
using Poliedro.Billing.Domain.Descargue.Ports;
using Poliedro.Billing.Domain.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Descargue.Adapter;


namespace Poliedro.Billing.Infraestructure.Persistence.Mysql;

public static class DependencyInjectionService
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION") ?? configuration.GetConnectionString("MysqlConnection");
        services.AddDbContext<DataBaseContext>(
            options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)
        ));

        services.AddTransient<IMessageProvider, MessageProvider>();
        services.AddTransient<IConductorRepository, ConductorRepository>();
        services.AddTransient<IControlViajeRepository, ControlViaje.Adapter.ControlViajeRepository>();
        services.AddTransient<IDescargueRepository, DescargueRepository>();
        return services;
    }
}
