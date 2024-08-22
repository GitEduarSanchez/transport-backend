using MediatR;
using Poliedro.Billing.Domain.ClientBillintElectronic.Enums;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Commands.CreateClientBillingElectronic
{
    public record CreateClientBillingElectronicCommand : IRequest<bool>
    {
        public string Name { get; set; } = string.Empty;
        public int ResolutionId { get; set; } = default!;
        public int ServerId { get; set; } = default!;
        public ProviderType ProviderId { get; set; } = default!;
        public bool Active { get; set; } = default!;
    }
}
