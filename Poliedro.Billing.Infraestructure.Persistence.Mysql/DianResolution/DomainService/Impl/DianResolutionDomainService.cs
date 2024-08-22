using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Resolution.DomainService;
using Poliedro.Billing.Domain.Resolution.Entities;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.DianResolution.DomainService.Impl;

public class DianResolutionDomainService(DataBaseContext context) : IDianResolutionDomainService
{
    public async Task<bool> Create(DianResolutionEntity dianResolutionEntity, CancellationToken cancellationToken)
    {
        await context.DianResolution.AddAsync(dianResolutionEntity, cancellationToken);
        return await context.SaveChangesAsync(cancellationToken) > 0;
    }

    public async Task<DianResolutionEntity> Update(DianResolutionEntity dianResolutionEntity, CancellationToken cancellationToken)
    {
        var existingEntity = await context.DianResolution.FindAsync(dianResolutionEntity.ResolutionId, cancellationToken);

        if (existingEntity != null)
        {
            context.Entry(existingEntity).CurrentValues.SetValues(dianResolutionEntity);

            await context.SaveChangesAsync(cancellationToken);
            return dianResolutionEntity;
        }

        return null;
    }

    public async Task<bool> Delete(DianResolutionEntity dianResolutionEntity, CancellationToken cancellationToken)
    {
        var trackedEntity = context.DianResolution.Local.FirstOrDefault(e => e.ResolutionId == dianResolutionEntity.ResolutionId);

        if (trackedEntity != null)
        {
            context.DianResolution.Remove(trackedEntity);
        }
        else
        {
            context.DianResolution.Attach(dianResolutionEntity);
            context.DianResolution.Remove(dianResolutionEntity);
        }

        await context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<IEnumerable<DianResolutionEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await context.DianResolution
            .Include(c => c.clientsBillingElectronic)
            .ToListAsync(cancellationToken);
    }

    public async Task<DianResolutionEntity> GetById(int id, CancellationToken cancellationToken)
    {
        var dianResolution = await context.DianResolution
            .FindAsync(id, cancellationToken);
        if (dianResolution != null)
        {
            return dianResolution;
        }
        return null;
    }
}
