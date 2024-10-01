using Poliedro.Billing.Domain.Descargue.Entities;

namespace Poliedro.Billing.Domain.Descargue.Ports;

public interface IDescargueRepository
{
    Task<bool> SaveAsync(DescargueEntity descargue);
    Task<bool> SaveAsync(object descargue);
}
