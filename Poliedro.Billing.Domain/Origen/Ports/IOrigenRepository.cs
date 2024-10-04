﻿using Poliedro.Billing.Domain.Origen.Entities;

namespace Poliedro.Billing.Domain.Origen.Ports;

public interface IOrigenRepository
{
    Task<bool> SaveAsync(OrigenEntity origen);
}
