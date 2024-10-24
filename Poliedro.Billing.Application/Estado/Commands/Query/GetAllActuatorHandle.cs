using MediatR;
using Poliedro.Billing.Application.Estado.Dto;
using Poliedro.Billing.Domain.Estado.Ports;

namespace Poliedro.Billing.Application.Estado.Query;

public class GetAllActuatorHandle(IEstadoRepository _estadoRepository) : IRequestHandler<GetAllActuatorsQuery, IEnumerable<EstadoDto>>
{
    public async Task<IEnumerable<EstadoDto>> Handle(GetAllActuatorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _estadoRepository.GetAllAsync();
        return entities.Select(estado => new EstadoDto
        (
            Id: estado.Id,
            Descripcion: estado.Descripcion
        ));
    }
}
