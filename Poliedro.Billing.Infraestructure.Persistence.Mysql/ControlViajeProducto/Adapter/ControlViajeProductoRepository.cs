using Poliedro.Billing.Domain.ControlViajeProducto.Entities;
using Poliedro.Billing.Domain.ControlViajeProducto.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class ControlViajeProductoRepository(DataBaseContext context) : IControlViajeProductoRepository
{
    public async Task<bool> SaveAsync(ControlViajeProductoEntity controlViajeProducto )
    {
        await context.ControlViajeProducto.AddAsync(controlViajeProducto);
        return  await context.SaveChangesAsync() > 0;
    }
}
