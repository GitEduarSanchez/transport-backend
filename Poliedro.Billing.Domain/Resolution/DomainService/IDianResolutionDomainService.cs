using Poliedro.Billing.Domain.Resolution.Entities;

namespace Poliedro.Billing.Domain.Resolution.DomainService;

public interface  IDianResolutionDomainService
{
    Task<bool> Create(DianResolutionEntity dianResolutionEntity, CancellationToken cancelationToken);
    Task<DianResolutionEntity> Update(DianResolutionEntity dianResolutionEntity, CancellationToken cancelationToken);
    Task<bool> Delete(DianResolutionEntity dianResolutionEntity, CancellationToken cancelationToken);
    Task<IEnumerable<DianResolutionEntity>> GetAll(CancellationToken cancellationToken);
    Task<DianResolutionEntity> GetById(int id, CancellationToken cancellationToken);
}
