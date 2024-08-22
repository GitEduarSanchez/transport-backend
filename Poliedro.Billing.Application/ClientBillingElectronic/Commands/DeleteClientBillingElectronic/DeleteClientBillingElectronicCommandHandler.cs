using MediatR;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;
namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.DeleteClientBillingElectronic;

public class DeleteClientBillingElectronicCommandHandler(
    IClientBillingElectronicDomainService clientBillingElectronicDomainService) 
    : IRequestHandler<DeleteClientBillingElectronicCommand, bool>
{
    public Task<bool> Handle(DeleteClientBillingElectronicCommand request, CancellationToken cancellationToken)
    {
        var result = clientBillingElectronicDomainService.Delete(request.Id);
        return result;
    }
}
