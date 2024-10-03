using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Destino.Entities;
using Poliedro.Billing.Domain.Destino.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Destino.Adapter;

public class DestinoRepository(DataBaseContext _context) : IDestinoRepository
{
    public async Task<IEnumerable<DestinoEntity>> GetAllAsync()
    {
        return await _context.Destino.ToListAsync();
    }

    
    public async Task<DestinoEntity> GetById(int Id)
    {
        return await _context.Destino.FirstAsync(x => x.Id == Id);
    }

    public async Task<bool> SaveAsync(DestinoEntity Destino)
    {
        await _context.Destino.AddAsync(Destino);
        return  await _context.SaveChangesAsync() > 0;
    }
}
