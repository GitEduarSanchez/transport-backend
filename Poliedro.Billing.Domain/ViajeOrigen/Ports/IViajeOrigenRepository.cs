using Poliedro.Billing.Domain.ViajeOrigen.Entities;

namespace Poliedro.Billing.Domain.ViajeOrigen.Ports;

public interface IViajeOrigenRepository
{
   Task<bool> SaveAsync(ViajeOrigenEntity conductor);
    Task<IEnumerable<ViajeOrigenEntity>> GetAllAsync();
    Task<ViajeOrigenEntity> GetById(int idcontrolviaje_origen);
}
