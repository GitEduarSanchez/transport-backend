using AutoMapper;
using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Domain.Resolution.DomainService;

namespace Poliedro.Billing.Application.DianResolution.Queries.GetSingleDianResolution
{
    public class GetSingleDianResolutionQueryHandler(
        IDianResolutionDomainService dianResolutionDomainService,
        IMapper mapper) : IRequestHandler<GetSingleDianResolutionQuery, DianResolutionDto>
    {
        public async Task<DianResolutionDto>
            Handle(GetSingleDianResolutionQuery request, CancellationToken cancellationToken)
        {
            var dianResolutionEntity = await dianResolutionDomainService.GetById(request.Id, cancellationToken);

            return mapper.Map<DianResolutionDto>(dianResolutionEntity);
        }
    }
}
