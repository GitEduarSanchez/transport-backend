using MediatR;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Poliedro.Billing.Application.Destino.Dto;
using Poliedro.Billing.Domain.Destino.Ports;

namespace Poliedro.Billing.Application.Destino.Query;
public class GetAllActuatorHandle(IDestinoRepository _DestinoRepository) : IRequestHandler<GetAllActuatorsQuery, IEnumerable<DestinoDto>>
{
    public async Task<IEnumerable<IDestinoRepository>> Handle(GetAllActuatorsQuery request, CancellationToken cancellationToken)
    {
        var Entities = await _DestinoRepository.GetAllAsync();
        return (IEnumerable<IDestinoRepository>)Entities.Select(Destino => new DestinoDto
        (
          Id: Destino.idDestino,
          Descripcion: Destino.Descripcion
        ));
    }

}

