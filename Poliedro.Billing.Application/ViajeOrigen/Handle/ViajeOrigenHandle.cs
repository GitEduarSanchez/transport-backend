using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;

namespace Poliedro.Billing.Application.ViajeOrigen.Handle;

public class ViajeOrigenHandle(IViajeOrigenRepository _viajeorigenRepository) : IRequestHandler<CreateViajeOrigenCommand, bool>
{
    public async Task<bool> Handle(CreateViajeOrigenCommand request, CancellationToken cancellationToken)
    {
        ViajeOrigenEntity viajeorigen = new() { IdControlViaje = request.IdControlViaje, IdOrigen = request.IdOrigen, IdCiudad = request.IdCiudad};
        return await _viajeorigenRepository.SaveAsync(viajeorigen);
    }
}
