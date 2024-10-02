using Poliedro.Billing.Domain.VehiculoTrailer.Entities;

namespace Poliedro.Billing.Domain.VehiculoTrailer.Ports;

public interface IVehiculoTrailerRepository
{
    Task<bool> SaveAsync(VehiculoTrailerEntity vehiculotrailer);
}
