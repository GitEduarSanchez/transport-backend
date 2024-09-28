using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IVehiculoRepository
{
    Task<bool> SaveAsync(VehiculoEntity Vehiculo);
}
