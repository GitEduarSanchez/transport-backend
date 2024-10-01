using MediatR;
using Poliedro.Billing.Application.ControlViaje.Dto;
using Poliedro.Billing.Domain.ControlViaje.Ports;

namespace Poliedro.Billing.Application.ControlViaje.Query;

public class GetAllActuatorHandle(IControlViajeRepository _controlviajeRepository) : IRequestHandler<GetAllActuatorsQuery, IEnumerable<ControlViajeDto>>
{
    public async Task<IEnumerable<ControlViajeDto>> Handle(GetAllActuatorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _controlviajeRepository.GetAllAsync();
        return entities.Select(controlviaje => new ControlViajeDto
        (
            fecha: controlviaje.fecha, 
            guia: controlviaje.guia,
            idVehiculoTrailer: controlviaje.idVehiculoTrailer
        ));
    }
}
