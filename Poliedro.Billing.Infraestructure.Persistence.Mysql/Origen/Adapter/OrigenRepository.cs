using Poliedro.Billing.Domain.Origen.Entities;
using Poliedro.Billing.Domain.Origen.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Origen.Adapter;

public class OrigenRepository(DataBaseContext context) : IOrigenRepository
{
    public Task<IEnumerable<object>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAsync(OrigenEntity origen)
    {
        await context.Origen.AddAsync(origen);
        return  await context.SaveChangesAsync() > 0;
    }
}
