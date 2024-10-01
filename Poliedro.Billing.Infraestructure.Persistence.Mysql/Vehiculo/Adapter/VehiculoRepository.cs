﻿using Poliedro.Billing.Domain.Vehiculo.Entities;
using Poliedro.Billing.Domain.Vehiculo.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Vehiculo.Adapter;

public class VehiculoRepository(DataBaseContext _context) : IVehiculoRepository
{
    public async Task<bool> SaveAsync(VehiculoEntity Vehiculo)
    {
        await _context.Vehiculo.AddAsync(Vehiculo);
        return  await _context.SaveChangesAsync() > 0;
    }
}
