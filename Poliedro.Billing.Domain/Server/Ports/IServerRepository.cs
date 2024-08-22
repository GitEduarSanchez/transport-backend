using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Domain.Server.Ports;

public interface IServerRepository
{
    Task SaveAsync(ServerEntity server);
}
