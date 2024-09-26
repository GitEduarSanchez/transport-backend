using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Trailer.Adapter;

public class trailerRepository(DataBaseContext context) : ITrailerRepository
{
    public async Task<bool> SaveAsync(TrailerEntity trailer)
    {
        await context.Conductor.AddAsync(Trailer);
        return  await context.SaveChangesAsync() > 0;
    }
}
