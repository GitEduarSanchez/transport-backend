﻿using Poliedro.Billing.Domain.Destino.Entities;
using Poliedro.Billing.Domain.Destino.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Destino.Adapter;

public class DestinoRepository(DataBaseContext context) : IDestinoRepository
{
    public Task<IEnumerable<DestinoEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

        return await _context.Destino.FirstAsync(x => x.Id == Id);
        return await _context.Destino.FirstAsync(x => x.iddestino == Id);
    public async Task<bool> SaveAsync(DestinoEntity Destino)
    {
        await context.Destino.AddAsync(Destino);
        return  await context.SaveChangesAsync() > 0;
    }
}