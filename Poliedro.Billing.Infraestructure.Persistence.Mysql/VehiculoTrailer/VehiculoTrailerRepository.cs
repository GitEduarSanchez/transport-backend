using Poliedro.Billing.Domain.VehiculoTrailer.Entities;
using Poliedro.Billing.Domain.VehiculoTrailer.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.VehiculoTrailer.Adapter;

public class VehiculoTrailerRepository(DataBaseContext context) : IVehiculoTrailerRepository
{
    public async Task<bool> SaveAsync(VehiculoTrailerEntity vehiculotrailer)
    {
        await context.VehiculoTrailer.AddAsync(vehiculotrailer);
        return  await context.SaveChangesAsync() > 0;
    }
}
