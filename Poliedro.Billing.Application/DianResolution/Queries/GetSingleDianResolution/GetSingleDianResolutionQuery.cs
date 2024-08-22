using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;

namespace Poliedro.Billing.Application.DianResolution.Queries.GetSingleDianResolution
{
    public record GetSingleDianResolutionQuery(int Id) : IRequest<DianResolutionDto>;
}
