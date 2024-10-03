using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Trailer.Entities;
using Poliedro.Billing.Domain.Trailer.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Trailer.Adapter;

public class TrailerRepository(DataBaseContext _context) : ITrailerRepository
{
    
     public async Task<IEnumerable<TrailerEntity>> GetAllAsync()
    {
        return await _context.Trailer.ToListAsync();
    }
    public async Task<bool> SaveAsync(TrailerEntity Trailer)
    {
        await _context.Trailer.AddAsync(Trailer);
        return  await _context.SaveChangesAsync() > 0;
    }
}
