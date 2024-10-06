using Microsoft.EntityFrameworkCore;
using Poliedro.Billing.Domain.CategoriaDocumento.Entities;
using Poliedro.Billing.Domain.CategoriaDocumento.Ports;
using Poliedro.Billing.Infraestructure.Persistence.Mysql.Context;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.CategoriaDocumento.Adapter;

public class CategoriaDocumentoRepository(DataBaseContext _context) : ICategoriaDocumentoRepository
{
    public async Task<IEnumerable<CategoriaDocumentoEntity>> GetAllAsync()
    {
        return await _context.CategoriaDocumento.ToListAsync();
    }

    public async Task<bool> SaveAsync(CategoriaDocumentoEntity categoriaDocumento)
    {
        await _context.CategoriaDocumento.AddAsync(categoriaDocumento);
        return await _context.SaveChangesAsync() > 0;
    }
}
