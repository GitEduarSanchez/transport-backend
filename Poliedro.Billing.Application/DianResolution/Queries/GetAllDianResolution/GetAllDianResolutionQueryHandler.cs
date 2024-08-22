using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Domain.Resolution.DomainService;

namespace Poliedro.Billing.Application.DianResolution.Queries.GetAllDianResolution;

public class GetAllDianResolutionQueryHandler(
    IDianResolutionDomainService dianResolutionDomainService,
    IMapper mapper) : IRequestHandler<GetAllDianResolutionQuery, IEnumerable<DianResolutionDto>>
{
    public async Task<IEnumerable<DianResolutionDto>>
        Handle(GetAllDianResolutionQuery request, CancellationToken cancellationToken)
    {
        var dianResolutionEntities = await dianResolutionDomainService.GetAll(cancellationToken);
        return mapper.Map<IEnumerable<DianResolutionDto>>(dianResolutionEntities);
    }
}
