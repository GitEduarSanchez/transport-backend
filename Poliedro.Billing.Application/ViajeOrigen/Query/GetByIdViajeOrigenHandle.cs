using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Dto;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;

namespace Poliedro.Billing.Application.ViajeOrigen.Query;

public class GetByIdViajeOrigenHandle(IViajeOrigenRepository viajeorigenRepository) : IRequestHandler<GetByIdViajeOrigenQuery, ViajeOrigenDto>
{
    public async Task<ViajeOrigenDto> Handle(GetByIdViajeOrigenQuery request, CancellationToken cancellationToken)
    {
        var getByIdViajeOrigen = await viajeorigenRepository.GetById(request.IdControlViaje);
        return new ViajeOrigenDto(IdControlViajeOrigen: getByIdViajeOrigen.IdControlViajeOrigen, IdCuidad: getByIdViajeOrigen.IdCuidad,IdOrigen:getByIdViajeOrigen.IdOrigen,IdControlViaje:getByIdViajeOrigen.IdControlViaje);
    }
}
