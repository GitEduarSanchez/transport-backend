using AutoMapper;
using MediatR;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;
using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.UpdateClientBillingElectronic
{
    public class UpdateClientBillingElectronicCommandHandler(IClientBillingElectronicDomainService clientBillingElectronicDomainService,
        IMapper mapper) : IRequestHandler<UpdateClientBillingElectronicCommand, bool>
    {
        public async Task<bool> Handle(UpdateClientBillingElectronicCommand request, CancellationToken cancellationToken)
        {
            var clientBillingElectronicEntity = mapper.Map<ClientBillingElectronicEntity>(request);
            return await clientBillingElectronicDomainService.Update(clientBillingElectronicEntity);
        }
    }
}
