using MediatR;
using Poliedro.Billing.Application.Server.Dtos;

namespace Poliedro.Billing.Application.Server.Queries.GellAllServer
{
    public record GellAllServerQuery: IRequest<IEnumerable<ServerDto>>
    {
    }
}
