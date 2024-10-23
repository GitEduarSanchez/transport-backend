﻿using MediatR;
using Poliedro.Billing.Application.Origen.Commands.CreateServerCommand;
using Poliedro.Billing.Domain.Origen.Entities;
using Poliedro.Billing.Domain.Origen.Ports;

namespace Poliedro.Billing.Application.Origen.Handle;

public class OrigenHandle(IOrigenRepository _origenRepository) : IRequestHandler<CreateOrigenCommand, bool>
{
    public async Task<bool> Handle(CreateOrigenCommand request, CancellationToken cancellationToken)
    {
        OrigenEntity origen = new() { descripcion = request.descripcion };
        return await _origenRepository.SaveAsync(origen);
    }
}
