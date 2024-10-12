using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.ViajeOrigen.Adapter;

public class ViajeOrigenRepository(DataBaseContext _context) : IViajeOrigenRepository
{
    public async Task<IEnumerable<ViajeOrigenEntity>> GetAllAsync()
    {
        return await _context.ViajeOrigen.ToListAsync();
    }

    public async Task<ViajeOrigenEntity> GetById(int Id)
    {
        return await _context.ViajeOrigen.FirstAsync(x => x.IdControlViajeOrigen== Id);
    }

    public async Task<bool> SaveAsync(ViajeOrigenEntity viajeorigen)
    {
        await _context.ViajeOrigen.AddAsync(viajeorigen);
        return  await _context.SaveChangesAsync() > 0;
    }
}
