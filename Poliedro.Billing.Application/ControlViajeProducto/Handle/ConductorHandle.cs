using MediatR;
using Poliedro.Billing.Application.ControlViajeProducto.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.ControlViajeProducto.Entities;
using Poliedro.Billing.Domain.ControlViajeProducto.Ports;

namespace Poliedro.Billing.Application.Conductor.Handle;

public class ControlViajeProductoHandle(IControlViajeProductoRepository _ControlViajeProductoRepository) : IRequestHandler<CreateControlViajeProductoCommand, bool>
{
    public async Task<bool> Handle(CreateControlViajeProductoCommand request, CancellationToken cancellationToken)
    {
        ControlViajeProductoEntity conductor = new() { idControlViaje = request.idControlViaje, idProducto = request.idProducto };
        return await _ControlViajeProductoRepository.SaveAsync(conductor);
    }
}
