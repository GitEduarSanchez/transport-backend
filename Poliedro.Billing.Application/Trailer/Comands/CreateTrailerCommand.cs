using MediatR;

namespace Poliedro.Billing.Application.Trailer.Commands.CreateServerCommand;

public record CreateTrailerCommand( String Descripcion, String serial) : IRequest<bool>;