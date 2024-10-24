using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.Estado.Entities;
using Poliedro.Billing.Domain.Estado.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Estado.Adapter;

public class EstadoRepository(DataBaseContext _context) : IEstadoRepository
{
    public Task<IEnumerable<EstadoEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EstadoEntity> GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAsync(EstadoEntity estado)
    {
        throw new NotImplementedException();
    }
}
