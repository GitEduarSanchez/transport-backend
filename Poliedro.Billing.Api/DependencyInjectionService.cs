using Microsoft.OpenApi.Models;

namespace Poliedro.Billing.Api;

public static class DependencyInjectionService
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Poliedro Billing API",
                Description = "Adminitracion de APIs para Billing Electronic"
            });

            var basePath = AppContext.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "Poliedro.Billing.Api.xml");
            options.IncludeXmlComments(xmlPath);
        });
        return services;
    }
}

