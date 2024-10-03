using Poliedro.Billing.Domain.TipoVehiculo.Entities;
using Poliedro.Billing.Domain.TipoVehiculo.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.TipoVehiculo.Adapter;

public class TipoVehiculoRepository(DataBaseContext context) : ITipoVehiculoRepository
{
    public async Task<bool> SaveAsync(TipoVehiculoEntity TipoVehiculo)
    {
        await context.TipoVehiculo.AddAsync(TipoVehiculo);
        return  await context.SaveChangesAsync() > 0;
    }
}
