
using Poliedro.Billing.Domain.Vehiculo.Entities;
using Poliedro.Billing.Domain.Vehiculo.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class VehiculoRepository(DataBaseContext context) : IVehiculoRepository
{
    public Task<IEnumerable<object>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAsync(VehiculoEntity Vehiculo)
    {
        await context.Vehiculo.AddAsync(Vehiculo);
        return  await context.SaveChangesAsync() > 0;
    }
}
