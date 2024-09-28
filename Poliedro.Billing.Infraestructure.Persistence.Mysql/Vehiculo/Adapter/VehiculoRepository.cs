
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class VehiculoRepository(DataBaseContext context) : IVehiculoRepository
{
    public async Task<bool> SaveAsync(VehiculoEntity vehiculo)
    {
         await context.Vehiculo.AddAsync(vehiculo);
        return  await context.SaveChangesAsync() > 0;
    }
}
