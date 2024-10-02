using MediatR;
using Poliedro.Billing.Application.VehiculoTrailer.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.VehiculoTrailer.Entities;
using Poliedro.Billing.Domain.VehiculoTrailer.Ports;

namespace Poliedro.Billing.Application.VehiculoTrailer.Handle;

public class VehiculoTrailerHandle(IVehiculoTrailerRepository _vehiculotrailerRepository) : IRequestHandler<CreateVehiculoTrailerCommand, bool>
{
    public async Task<bool> Handle(CreateVehiculoTrailerCommand request, CancellationToken cancellationToken)
    {
        VehiculoTrailerEntity vehiculotrailer = new() { Name = request.Name };
        return await _vehiculotrailerRepository.SaveAsync(vehiculotrailer);
    }
}
