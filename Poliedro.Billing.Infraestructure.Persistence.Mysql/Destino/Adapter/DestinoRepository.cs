using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class DestinoRepository(DataBaseContext context) : IDestinoRepository
{
    public async Task<bool> SaveAsync(DestinoEntity conductor)
    {
        await context.Conductor.AddAsync(Destino);
        return  await context.SaveChangesAsync() > 0;
    }
}
