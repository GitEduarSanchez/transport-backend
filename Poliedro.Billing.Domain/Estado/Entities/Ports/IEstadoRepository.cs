using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Estado.Entities;

namespace Poliedro.Billing.Domain.Estado.Ports;

public interface IEstadoRepository
{
    Task<bool> SaveAsync(EstadoEntity estado);
}
