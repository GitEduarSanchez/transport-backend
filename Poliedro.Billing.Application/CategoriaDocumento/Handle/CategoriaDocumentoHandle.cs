using System;
using MediatR;
using Poliedro.Billing.Application.CategoriaDocumento.Commands;
using Poliedro.Billing.Domain.CategoriaDocumento.Entities;
using Poliedro.Billing.Domain.CategoriaDocumento.Ports;

namespace Poliedro.Billing.Application.CategoriaDocumento.Handle;

// TODO): Crear ICategoriaDocumentoRepository y CategoriaDocumentoEntity

public class CategoriaDocumentoHandle(ICategoriaDocumentoRepository _categoriaDocumentoRepository) : IRequestHandler<CreateCategoriaDocumentoCommand, bool>
{
    public async Task<bool> Handle(CreateCategoriaDocumentoCommand request, CancellationToken cancellationToken)
    {
        CategoriaDocumentoEntity categoriaDocumento = new () { Descripcion = request.Descripcion };
        return await _categoriaDocumentoRepository.SaveAsync(categoriaDocumento);
    }
}
