using AutoMapper;
using MediatR;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;
using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.CreateClientBillingElectronic
{
    public class CreateClientBillingElectronicCommandHandler(
        IClientBillingElectronicDomainService clientBillingElectronicDomainService,
        IMapper mapper) : IRequestHandler<CreateClientBillingElectronicCommand, bool>
    {
        public async Task<bool> Handle(CreateClientBillingElectronicCommand request, CancellationToken cancellationToken)
        {
            var clientBillingElectronicEntity = mapper.Map<ClientBillingElectronicEntity>(request);
            return await clientBillingElectronicDomainService.Create(clientBillingElectronicEntity);
        }
    }
}
