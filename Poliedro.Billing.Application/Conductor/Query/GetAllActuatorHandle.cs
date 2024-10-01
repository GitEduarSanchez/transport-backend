using MediatR;
using Poliedro.Billing.Application.Conductor.Dto;
using Poliedro.Billing.Domain.Conductor.Ports;

namespace Poliedro.Billing.Application.Conductor.Query;

public class GetAllActuatorHandle(IConductorRepository _conductorRepository) : IRequestHandler<GetAllActuatorsQuery, IEnumerable<ConductorDto>>
{
    public async Task<IEnumerable<ConductorDto>> Handle(GetAllActuatorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _conductorRepository.GetAllAsync();
        return entities.Select(conductor => new ConductorDto
        (
            Id: conductor.Id,
            Name: conductor.Name
        ));
    }
}
