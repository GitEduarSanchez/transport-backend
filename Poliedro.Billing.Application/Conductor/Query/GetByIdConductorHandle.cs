using MediatR;
using Poliedro.Billing.Application.Conductor.Dto;
using Poliedro.Billing.Domain.Conductor.Ports;

namespace Poliedro.Billing.Application.Conductor.Query;

public class GetByIdConductorHandle(IConductorRepository conductorRepository) : IRequestHandler<GetByIdConductorQuery, ConductorDto>
{
    public async Task<ConductorDto> Handle(GetByIdConductorQuery request, CancellationToken cancellationToken)
    {
        var getByIdConductor = await conductorRepository.GetById(request.Id);
        return new ConductorDto(Id: getByIdConductor.Id, Name: getByIdConductor.Name);
    }
}
