using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Domain.Descargue.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Descargue.Adapter;

public class DescargueRepository(DataBaseContext context) : IDescargueRepository
{
    public Task<IEnumerable<object>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAsync(DescargueEntity descargue)
    {
        await context.Descargue.AddAsync(descargue);
        return  await context.SaveChangesAsync() > 0;
    }

    public Task<bool> SaveAsync(object descargue)
    {
        throw new NotImplementedException();
    }
}