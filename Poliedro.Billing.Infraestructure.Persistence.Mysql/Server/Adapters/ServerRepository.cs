using Poliedro.Billing.Domain.Server.Entities;
using Poliedro.Billing.Domain.Server.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Server.Adapters;

public class ServerRepository(DataBaseContext context) : IServerRepository
{
    public async Task SaveAsync(ServerEntity server)
    {
        await context.Server.AddAsync(server);
        await context.SaveChangesAsync();
    }
}

