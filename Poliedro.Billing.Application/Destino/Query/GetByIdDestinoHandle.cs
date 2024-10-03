using MediatR;
using Poliedro.Billing.Application.Destino.Dto;
using Poliedro.Billing.Domain.Destino.Ports;

namespace Poliedro.Billing.Application.Destino.Query;

public class GetByIdDestinoHandle(IDestinoRepository destinoRepository) : IRequestHandler<GetByIdDestinoQuery, DestinoDto>
{
    public async Task<DestinoDto> Handle(GetByIdDestinoQuery request, CancellationToken cancellationToken)
    {
        var getByIdDestino = await destinoRepository.GetById(request.Id);
        return new DestinoDto(Id: getByIdDestino.Id, Descripcion: getByIdDestino.descripcion);
    }
}
