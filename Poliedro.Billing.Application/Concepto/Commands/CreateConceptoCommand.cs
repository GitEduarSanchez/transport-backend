using MediatR;

namespace Poliedro.Billing.Application.Concepto.Commands.CreateServerCommand;

public record CreateConceptoCommand(int IdConcepto,string descripcion) : IRequest<bool>;