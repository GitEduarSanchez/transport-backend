using MediatR;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.DeleteClientBillingElectronic;

public record DeleteClientBillingElectronicCommand : IRequest<bool>
{
    public int Id { get; init; }
}
