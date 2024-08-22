using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Server.DomainService;
using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Server.DomainService.Impl;

public class ServerDomainService(DataBaseContext context) : IServerDomainService
{
    public async Task<IEnumerable<ServerEntity>> GetAll()
    {
        return await context.Server            
            .Include(c => c.clientsBillingElectronic)            
            .ToListAsync();
    }
}
