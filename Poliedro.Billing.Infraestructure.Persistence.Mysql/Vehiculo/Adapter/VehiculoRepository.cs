using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Vehiculo.Adapter;

public class VehiculoRepository(DataBaseContext context) : IVehiculoRepository
{
    public async Task<bool> SaveAsync(VehiculoEntity Vehiculo)
    {
        await context.Vehiculo.AllAsync(Vehiculo);
        return  await context.SaveChangesAsync() > 0;
    }
}

