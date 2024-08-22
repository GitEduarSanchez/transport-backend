using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Application.Server.Dtos;
using Poliedro.Billing.Domain.ClientBillintElectronic.Enums;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Dtos
{
    public class ClientBillingElectronicDto
    {
        public int ClientBillingElectronicId { get; set; } = default!;
        public string Name { get; set; } = string.Empty;
        public ProviderType ProviderId { get; set; } = default!;
        public bool Active { get; set; } = default!;
        public DianResolutionDto DianResolution { get; set; } = default!;
        public ServerDto Server { get; set; } = default!;
    }
}
