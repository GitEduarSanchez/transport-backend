using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IDestinoRepository
{
    Task<bool> SaveAsync(DestinoEntity conductor);
}
