using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IDescargueRepository
{
    Task<bool> SaveAsync(DescargueEntity conductor);
}
