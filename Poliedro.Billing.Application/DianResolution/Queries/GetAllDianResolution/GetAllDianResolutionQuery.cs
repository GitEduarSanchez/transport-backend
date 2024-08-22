using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;

namespace Poliedro.Billing.Application.DianResolution.Queries.GetAllDianResolution;

public record GetAllDianResolutionQuery : IRequest<IEnumerable<DianResolutionDto>>;
