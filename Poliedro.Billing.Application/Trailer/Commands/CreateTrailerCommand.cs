using MediatR;

namespace Poliedro.Billing.Application.Trailer.Commands.CreateServerCommand;

public record CreateTrailerCommand(string descripcion, string serial) : IRequest<bool>;