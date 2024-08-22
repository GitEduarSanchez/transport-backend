using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.ClientBillingElectronic.Dtos;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetAllClientBillingElectronic;

public class GetAllClientBillingElectronicQueryHandler(
    IClientBillingElectronicDomainService clientBillingElectronicDomainService,
    IMapper mapper) : IRequestHandler<GetAllClientBillingElectronicQuery, IEnumerable<ClientBillingElectronicDto>>
{

    public async Task<IEnumerable<ClientBillingElectronicDto>>
        Handle(GetAllClientBillingElectronicQuery request, CancellationToken cancellationToken)
    {
        var ListClientsBillintElectronicEntity = await clientBillingElectronicDomainService.GetAll();
        return mapper.Map<IEnumerable<ClientBillingElectronicDto>>(ListClientsBillintElectronicEntity);
    }
}