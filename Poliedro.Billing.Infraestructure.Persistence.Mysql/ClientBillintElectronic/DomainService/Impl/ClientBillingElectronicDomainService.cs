using Poliedro.Billing.Domain.ClientBillingElectronic.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;
using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.ClientBillingElectronic.DomainService;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.ClientBillintElectronic.DomainService.Impl;

public  class ClientBillingElectronicDomainService(DataBaseContext context) : IClientBillingElectronicDomainService
{
    public async Task<bool> Create(ClientBillingElectronicEntity clientBillingElectronicEntity)
    {
        await context.ClientBillingElectronic.AddAsync(clientBillingElectronicEntity);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Update(ClientBillingElectronicEntity clientBillingElectronicEntity)
    {
        context.ClientBillingElectronic.Update(clientBillingElectronicEntity);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<IEnumerable<ClientBillingElectronicEntity>> GetAll()
    {
        return await context.ClientBillingElectronic
            .Include(c => c.DianResolution)
            .Include(c => c.Server)
            .Where(c => c.Active == true)
            .ToListAsync();
    }

    public async Task<ClientBillingElectronicEntity> GetById(int id)
    {
        return await context.ClientBillingElectronic
         .Include(c => c.DianResolution)
         .Include(c => c.Server)
         .FirstAsync(c => c.ClientBillingElectronicId == id);
    }

    public async Task<bool> Delete(int id)
    {
        var entity = await context.ClientBillingElectronic.FirstOrDefaultAsync(x => x.ClientBillingElectronicId == id);
        if (entity == null)
            return false;

        entity.Active = false;
        context.ClientBillingElectronic.Update(entity);
        return await context.SaveChangesAsync() > 0;
    }
}
