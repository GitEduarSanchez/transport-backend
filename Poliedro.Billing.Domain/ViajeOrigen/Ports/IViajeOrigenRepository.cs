using Poliedro.Billing.Domain.ViajeOrigen.Entities;

namespace Poliedro.Billing.Domain.ViajeOrigen.Ports;

public interface IViajeOrigenRepository
{
    Task<bool> SaveAsync(ViajeOrigenEntity viajeorigen);
}
