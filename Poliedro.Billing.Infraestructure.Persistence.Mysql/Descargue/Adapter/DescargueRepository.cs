using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Domain.Descargue.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Descargue.Adapter;


public class ControlViajeRepository(DataBaseContext _context) : IDescargueRepository
{
    public async Task<IEnumerable<DescargueEntity>> GetAllAsync()
    {
        return await _context.Descargue.ToListAsync();
    }

    public async Task<bool> SaveAsync(DescargueEntity controlViaje)
    {
        await _context.Descargue.AddAsync(Descargue);
        return  await _context.SaveChangesAsync() > 0;
    }

    public Task<bool> SaveAsync(object descargue)
    {
        throw new NotImplementedException();
    }
}
