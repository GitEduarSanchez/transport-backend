using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateConceptoCommand(int IdConcepto,string Descripcion) : IRequest<bool>;