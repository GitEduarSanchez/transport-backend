using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poliedro.Billing.Domain.Ciudad.Ports;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Domain.Estado.Ports;
 feature/ControllerControlViajeProducto
using Poliedro.Billing.Domain.ControlViajeProducto.Ports;

using Poliedro.Billing.Domain.Descargue.Ports;
releasecandidate/v1.0.0
using Poliedro.Billing.Domain.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Ciudad.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.ControlViajeProducto.Adapter;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Estado.Adapter;
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
        services.AddTransient<IEstadoRepository, EstadoRepository>();
        services.AddTransient<ICiudadRepository, CiudadRepository>();
        services.AddTransient<IView_CiudadRepository, View_CiudadRepository>();
 feature/ControllerControlViajeProducto
        services.AddTransient<IControlViajeProductoRepository, ControlViajeProductoRepository>();


        services.AddTransient<IDescargueRepository, DescargueRepository>();
 releasecandidate/v1.0.0
        return services;
    }
}
