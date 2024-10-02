using Poliedro.Billing.Domain.Vehiculo.Entities;

namespace Poliedro.Billing.Domain.Vehiculo.Ports;

public interface IVehiculoRepository
{
    Task<IEnumerable<object>> GetAllAsync();
    Task<bool> SaveAsync(VehiculoEntity Vehiculo);
}
