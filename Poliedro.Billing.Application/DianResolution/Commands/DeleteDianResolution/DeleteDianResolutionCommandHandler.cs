using AutoMapper;
using MediatR;
using Poliedro.Billing.Domain.Resolution.DomainService;
using Poliedro.Billing.Domain.Resolution.Entities;

namespace Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution
{
    public class DeleteDianResolutionCommandHandler(
        IDianResolutionDomainService dianResolutionDomainService,
        IMapper mapper) : IRequestHandler<DeleteDianResolutionCommand, bool>
    {
        public async Task<bool> Handle(DeleteDianResolutionCommand request, CancellationToken cancellationToken)
        {
            var dianResolutionEntity = mapper.Map<DianResolutionEntity>(request);
            var response = await dianResolutionDomainService.Delete(dianResolutionEntity, cancellationToken);
            return response;
        }
    }
}
