using Poliedro.Billing.Domain.Origen.Entities;

namespace Poliedro.Billing.Domain.Origen.Ports;

public interface IOrigenRepository
{
    Task<IEnumerable<object>> GetAllAsync();
    Task<bool> SaveAsync(OrigenEntity origen);
}
