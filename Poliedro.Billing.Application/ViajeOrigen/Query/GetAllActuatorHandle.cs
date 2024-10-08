using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Dto;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;

namespace Poliedro.Billing.Application.ViajeOrigen.Query;

public class GetAllViajeOrigenHandle(IViajeOrigenRepository _viajeorigenRepository) : IRequestHandler<GetAllViajeOrigenQuery, IEnumerable<ViajeOrigenDto>>
{
    public async Task<IEnumerable<ViajeOrigenDto>> Handle(GetAllViajeOrigenQuery request, CancellationToken cancellationToken)
    {
        var entities = await _viajeorigenRepository.GetAllAsync();
        return entities.Select(ViajeOrigen => new ViajeOrigenDto
        (
            IdControlViajeOrigen:ViajeOrigen.IdControlViajeOrigen,
            IdCiudad:ViajeOrigen.IdCiudad,
            IdOrigen:ViajeOrigen.IdOrigen,
            IdControlViaje:ViajeOrigen.IdOrigen 
        ));
    }
}
