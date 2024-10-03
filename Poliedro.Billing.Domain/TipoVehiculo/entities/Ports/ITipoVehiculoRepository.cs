using Poliedro.Billing.Domain.TipoVehiculo.Entities;

namespace Poliedro.Billing.Domain.TipoVehiculo.Ports;

public interface ITipoVehiculoRepository
{
    Task<bool> SaveAsync(TipoVehiculoEntity tipoVehiculo);
}
