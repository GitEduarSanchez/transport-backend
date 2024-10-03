using MediatR;
using Poliedro.Billing.Application.Estado.Dto;
using Poliedro.Billing.Domain.Estado.Ports;

namespace Poliedro.Billing.Application.Estado.Query;

public class GetByIdEstadoHandle(IEstadoRepository estadoRepository) : IRequestHandler<GetByIdEstadoQuery, EstadoDto>
{
    public async Task<EstadoDto> Handle(GetByIdEstadoQuery request, CancellationToken cancellationToken)
    {
        var getByIdEstado = await estadoRepository.GetById(request.Id);
        return new EstadoDto(Id: getByIdEstado.Id, Descripcion: getByIdEstado.Descripcion);
    }
}
