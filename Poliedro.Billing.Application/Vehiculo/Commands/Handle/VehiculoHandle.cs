using MediatR;
using Poliedro.Billing.Application.Vehiculo.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Vehiculo.Entities;
using Poliedro.Billing.Domain.Vehiculo.Ports;

namespace Poliedro.Billing.Application.Vehiculo.Handle;

public class VehiculoHandle(IVehiculoRepository _VehiculoRepository) : IRequestHandler<CreateVehiculoCommand, bool>
{
    public async Task<bool> Handle(CreateVehiculoCommand request, CancellationToken cancellationToken)
    {
        VehiculoEntity Vehiculo = new() { placa = request.placa, idmarca=request.idmarca,idtipovehiculo=request.idtipovehiculo };
        return await _VehiculoRepository.SaveAsync(Vehiculo);
    }
}
