using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.ClientBillingElectronic.Dtos;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetClientBillingElectronicById
{
    public class GetClientBillingElectronicByIdQueryHandler(
        IClientBillingElectronicDomainService clientBillingElectronicDomainService,
        IMapper mapper) 
        : IRequestHandler<GetClientBillingElectronicByIdQuery, ClientBillingElectronicDto>
    {
        public async Task<ClientBillingElectronicDto> Handle(GetClientBillingElectronicByIdQuery request, CancellationToken cancellationToken)
        {
            var clientBillintElectronicEntity = await clientBillingElectronicDomainService.GetById(request.Id);
            return mapper.Map<ClientBillingElectronicDto>(clientBillintElectronicEntity);
        }
    }
}
