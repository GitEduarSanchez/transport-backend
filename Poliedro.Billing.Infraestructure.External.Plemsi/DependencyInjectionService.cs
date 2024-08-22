using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Poliedro.Billing.Infraestructure.External.Plemsi
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternalPlemsi(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
