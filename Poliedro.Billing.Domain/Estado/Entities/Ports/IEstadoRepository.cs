using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IEstadoRepository
{
    Task<bool> SaveAsync(EstadoEntity estado);
}
