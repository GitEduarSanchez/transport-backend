using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Descargue.Entities;
using Poliedro.Billing.Domain.Descargue.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Descargue.Adapter;

public class DescargueRepository(DataBaseContext _context) : IDescargueRepository
{
    public async Task<IEnumerable<DescargueEntity>> GetAllAsync()
    {
        return await _context.Descargue.ToListAsync();
    }

    public async Task<DescargueEntity> GetById(int Id)
    {
        return await _context.Descargue.FirstAsync(x => x.Id == Id);
    }

    public Task GetById(object Id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAsync(DescargueEntity descargue)
    {
        await _context.Descargue.AddAsync(descargue);
        return  await _context.SaveChangesAsync() > 0;
    }
}