using Poliedro.Billing.Domain.ClientBillintElectronic.Enums;
using Poliedro.Billing.Domain.Resolution.Entities;
using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Domain.ClientBillingElectronic.Entities;

public class ClientBillingElectronicEntity
{
    public int ClientBillingElectronicId { get; set; } = default!;
    public string Name { get; set; } = string.Empty;
    public int ResolutionId { get; set; } = default!;
    public int ServerId { get; set; } = default!;
    public ProviderType ProviderId { get; set; } = default!;
    public bool Active { get; set; } = default!;
    public DianResolutionEntity DianResolution { get; set; } = default!;
    public ServerEntity Server { get; set; } = default!;
}
