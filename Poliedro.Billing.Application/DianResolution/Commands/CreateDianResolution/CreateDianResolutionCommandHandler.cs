using AutoMapper;
using MediatR;
using Poliedro.Billing.Domain.Resolution.DomainService;
using Poliedro.Billing.Domain.Resolution.Entities;

namespace Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution
{
    public class CreateDianResolutionCommandHandler(
        IDianResolutionDomainService dianResolutionDomainService,
        IMapper mapper) : IRequestHandler<CreateDianResolutionCommand, bool>
    {
        public async Task<bool> Handle(CreateDianResolutionCommand request, CancellationToken cancellationToken)
        {
            var dianResolutionEntity = mapper.Map<DianResolutionEntity>(request);
            return await dianResolutionDomainService.Create(dianResolutionEntity, cancellationToken);
        }
    }
}
