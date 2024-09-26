using Poliedro.Billing.Domain.ViajeOrigen.Entities;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class ViajeOrigenRepository(DataBaseContext context) : IViajeOrigenRepository
{
    public async Task<bool> SaveAsync(ViajeOrigenEntity ViajeOrigen)
    {
        await context.ViajeOrigen.AddAsync(ViajeOrigen);
        return  await context.SaveChangesAsync() > 0;
    }
}
