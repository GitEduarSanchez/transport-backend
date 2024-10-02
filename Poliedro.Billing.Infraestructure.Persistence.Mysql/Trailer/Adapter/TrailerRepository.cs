using Poliedro.Billing.Domain.Trailer.Entities;
using Poliedro.Billing.Domain.Trailer.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Trailer.Adapter;

public class TrailerRepository(DataBaseContext context) : ITrailerRepository
{
    public async Task<bool> SaveAsync(TrailerEntity Trailer)
    {
        await context.Trailer.AddAsync(Trailer);
        return  await context.SaveChangesAsync() > 0;
    }
}
