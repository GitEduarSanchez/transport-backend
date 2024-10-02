using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Conductor.Entities;
using Poliedro.Billing.Domain.Conductor.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Conductor.Adapter;

public class VehiculoRepository(DataBaseContext _context) : IVehiculoRepository
{
    public async Task<IEnumerable<VehiculoEntity>> GetAllAsync()
    {
        return await _context.Vehiculo.ToListAsync();
    }

    public async Task<bool> SaveAsync(VehiculoEntity Vehiculo)
    {
        await _context.Vehiculo.AddAsync(Vehiculo);
        return  await _context.SaveChangesAsync() > 0;
    }
}
