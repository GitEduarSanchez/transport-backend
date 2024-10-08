using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.ViajeOrigen.Entities;
using Poliedro.Billing.Domain.ViajeOrigen.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.ViajeOrigen.Adapter;

public class ViajeOrigenRepository(DataBaseContext _context) : IViajeOrigenRepository
{
    public async Task<bool> SaveAsync(ViajeOrigenEntity ViajeOrigen)
    {
        await _context.ViajeOrigen.AddAsync(ViajeOrigen);
        return  await _context.SaveChangesAsync() > 0;
    }
// yo
      public async Task<IEnumerable<ViajeOrigenEntity>> GetAllAsync()
    {
        return await _context.ViajeOrigen.ToListAsync();
    }
}
