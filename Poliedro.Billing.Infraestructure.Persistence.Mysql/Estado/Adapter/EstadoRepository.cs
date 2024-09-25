using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Estado.Adapter;

public class EstadoRepository(DataBaseContext context) : IEstadoRepository
{
    public async Task<bool> SaveAsync(EstadoEntity estado)
    {
        await context.Estado.AddAsync(estado);
        return  await context.SaveChangesAsync() > 0;
    }
}
