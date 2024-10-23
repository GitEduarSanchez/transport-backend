﻿using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Origen.Entities;
using Poliedro.Billing.Domain.Origen.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Origen.Adapter;

public class OrigenRepository(DataBaseContext _context) : IOrigenRepository
{
       public async Task<IEnumerable<OrigenEntity>> GetAllAsync()
    {
        return await _context.Origen.ToListAsync();
    }

    public async Task<OrigenEntity> GetById(int Id)
    {
        return await _context.Origen.FirstAsync(x => x.Id == Id);
    }

    public async Task<bool> SaveAsync(OrigenEntity origen)
    {
        await _context.Origen.AddAsync(origen);
        return  await _context.SaveChangesAsync() > 0;
    }


}