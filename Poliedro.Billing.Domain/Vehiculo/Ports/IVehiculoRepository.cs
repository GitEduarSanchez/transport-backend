using Poliedro.Billing.Domain.Vehiculo.Entities;

namespace Poliedro.Billing.Domain.Vehiculo.Ports;

public interface IVehiculoRepository
{
    Task<bool> SaveAsync(VehiculoEntity Vehiculo);
    Task<bool> SaveAsync(object vehiculo);
}
