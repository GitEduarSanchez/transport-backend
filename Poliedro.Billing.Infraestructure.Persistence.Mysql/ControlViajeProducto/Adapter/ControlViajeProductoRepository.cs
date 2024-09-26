using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class ControlViajeProductopository(DataBaseContext context) : IControlViajeProductoRepository
{
    public async Task<bool> SaveAsync(ControlViajeProductoEntity controlViajeProducto )
    {
        await context.ControlViajeProducto.AddAsync(controlViajeProducto);
        return  await context.SaveChangesAsync() > 0;
    }
}
