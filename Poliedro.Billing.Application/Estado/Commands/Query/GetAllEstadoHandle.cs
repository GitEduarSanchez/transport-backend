using MediatR;
using Poliedro.Billing.Application.Estado.Dto;
using Poliedro.Billing.Domain.Estado.Ports;

namespace Poliedro.Billing.Application.Estado.Query;

public class GetAllEstadoQueryHandle(IEstadoRepository _estadoRepository) : IRequestHandler<GetAllEstadoQuery, IEnumerable<EstadoDto>>
{
    public async Task<IEnumerable<EstadoDto>> Handle(GetAllEstadoQuery request, CancellationToken cancellationToken)
    {
        var entities = await _estadoRepository.GetAllAsync();
        return entities.Select(estado => new EstadoDto
        (
            Id: estado.Id,
            Descripcion: estado.Descripcion
        ));
    }
}
