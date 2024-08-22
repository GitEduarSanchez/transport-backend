using AutoMapper;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.CreateClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Commands.UpdateClientBillingElectronic;
using Poliedro.Billing.Application.ClientBillingElectronic.Dtos;
using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

namespace Poliedro.Billing.Application.ClientBillingElectronic.AutoMappers
{
    public class ClientBillingElectronicMapper : Profile
    {
        public ClientBillingElectronicMapper()
        {
            CreateMap<ClientBillingElectronicEntity, ClientBillingElectronicDto>().ReverseMap();
            CreateMap<ClientBillingElectronicEntity, CreateClientBillingElectronicCommand>().ReverseMap();
            CreateMap<ClientBillingElectronicEntity, UpdateClientBillingElectronicCommand>().ReverseMap();
        }
    }
}
