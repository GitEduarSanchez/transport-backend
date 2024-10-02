using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Estado.Entities;
using Poliedro.Billing.Domain.Estado.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Estado.Adapter;

public class EstadoRepository(DataBaseContext _context) : IEstadoRepository
{
    public async Task<IEnumerable<EstadoEntity>> GetAllAsync()
    {
        return await _context.Estado.ToListAsync();
    }

    public async Task<bool> SaveAsync(EstadoEntity estado)
    {
        await _context.Estado.AddAsync(estado);
        return  await _context.SaveChangesAsync() > 0;
    }
}
