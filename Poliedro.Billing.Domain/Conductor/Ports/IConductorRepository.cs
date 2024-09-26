using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IConductorRepository
{
    Task<bool> SaveAsync(ConductorEntity conductor);
    Task<IEnumerable<ConductorEntity>> GetAllAsync();
}
