using MediatR;

namespace Poliedro.Billing.Application.Concepto.Commands.CreateServerCommand;

public record CreateConceptoCommand(string descripcion) : IRequest<bool>;