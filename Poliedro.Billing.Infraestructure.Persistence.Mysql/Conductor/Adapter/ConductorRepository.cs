using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class ConductorRepository(DataBaseContext context) : IConductorRepository
{
    public async Task<bool> SaveAsync(ConductorEntity conductor)
    {
        await context.Conductor.AddAsync(conductor);
        return  await context.SaveChangesAsync() > 0;
    }
}
