using MediatR;

namespace Poliedro.Billing.Application.CategoriaDocumento.Commands;

public record class CreateCategoriaDocumentoCommand(string Descripcion) : IRequest<bool>;