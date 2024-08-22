using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Poliedro.Billing.Application.ClientBillingElectronic.AutoMappers;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.CreateClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.UpdateClientBillingElectronic;
using Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution;
using Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution;
using Poliedro.Billing.Application.Resolution.AutoMappers;
using Poliedro.Billing.Application.Server.AutoMappers;
using Poliedro.Billing.Application.Server.Commands.CreateServerCommand;
using Poliedro.Billing.Application.Server.Validator;
using System.Reflection;

namespace Poliedro.Billing.Application;

public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        #region Mappers
        var mapper = new MapperConfiguration(config =>
        {
            config.AddProfile(new ClientBillingElectronicMapper()); 
            config.AddProfile(new ServerMapper()); 
            config.AddProfile(new DianResolutionMapper());
        });
        services.AddSingleton(mapper.CreateMapper());
        #endregion

        #region Validators
        services.AddScoped<IValidator<CreateClientBillingElectronicCommand>, CreateClientBillingElectronicCommandValidator>();
        services.AddScoped<IValidator<UpdateClientBillingElectronicCommand>, UpdateClientBillingElectronicCommandValidator>();
        services.AddScoped<IValidator<CreateServerCommand>, ServerCommandValidator>();
        services.AddScoped<IValidator<CreateDianResolutionCommand>, CreateDianResolutionCommandValidator>();
        services.AddScoped<IValidator<UpdateDianResolutionCommand>, UpdateDianResolutionCommandValidator>();
        services.AddScoped<IValidator<DeleteDianResolutionCommand>, DeleteDianResolutionCommandValidator>();
        #endregion


        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}