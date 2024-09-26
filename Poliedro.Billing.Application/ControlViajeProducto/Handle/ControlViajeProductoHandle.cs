using MediatR;
using Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;

namespace Poliedro.Billing.Application.Conductor.Handle;

public class ControlViajeProductoHandle(IControlViajeProductoRepository _ControlViajeProductoRepository) : IRequestHandler<CreateConTrolViajeProductoCommand, bool>
{
    public async Task<bool> Handle(CreateControlViajeProductoCommand request, CancellationToken cancellationToken)
    {
        ConductorEntity ControlViajeProducto = new() { Name = request.Name };
        return await _ControlViajeProductoRepository.SaveAsync(ControlViajeProducto);
    }
}
