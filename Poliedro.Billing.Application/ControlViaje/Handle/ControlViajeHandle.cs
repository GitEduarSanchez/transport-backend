﻿using MediatR;
using Poliedro.Billing.Application.ControlViaje.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.ControlViaje.Entities;
using Poliedro.Billing.Domain.ControlViaje.Ports;

namespace Poliedro.Billing.Application.Conductor.Handle;

public class ControlViajeHandle(IControlViajeRepository _controlviajeRepository) : IRequestHandler<CreateControlViajeCommand, bool>
{
    public async Task<bool> Handle(CreateControlViajeCommand request, CancellationToken cancellationToken)
    {
        ControlViajeEntity controlviaje = new() { idControlViaje = request.idControlViaje, fecha = request.fecha, guia = request.guia, idVehiculoTrailer = request.idVehiculoTrailer};
        return await _controlviajeRepository.SaveAsync(controlviaje);
    }
}