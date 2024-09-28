using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;

namespace Poliedro.Billing.Application.ViajeOrigen.Handle;

public class ViajeOrigenHandle(IViajeOrigenRepository _viajeOrigenRepository) : IRequestHandler<CreateViajeOrigenCommand, bool>
{
    public async Task<bool> Handle(CreateViajeOrigenCommand request, CancellationToken cancellationToken)
    {
        ViajeOrigenEntity viajeOrigen = new() { idControlViajeOrigen = request.idControlViajeOrigen };
        return await _viajeOrigenRepository.SaveAsync(viajeOrigen);
    }
}
