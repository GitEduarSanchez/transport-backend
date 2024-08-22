using Poliedro.Billing.Domain.Server.DomainService;
using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Domain.Server.DomainService
{
    public interface IServerDomainService
    {
        Task<IEnumerable<ServerEntity>> GetAll();
    }
}
