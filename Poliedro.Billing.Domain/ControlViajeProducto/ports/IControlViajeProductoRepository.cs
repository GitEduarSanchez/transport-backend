﻿using Poliedro.Billing.Domain.Conductor.Entities;

namespace Poliedro.Billing.Domain.Conductor.Ports;

public interface IControlViajeProductoRepository
{
    Task<bool> SaveAsync(ControlViajeProductoEntity controlViajeProducto);
}