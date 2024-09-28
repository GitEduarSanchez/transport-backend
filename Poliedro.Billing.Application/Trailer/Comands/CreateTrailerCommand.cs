using MediatR;

namespace Poliedro.Billing.Application.Trailer.Commands.CreateServerCommand;

public record CreateTrailerCommand(int idTrailer, String Descripcion, String serial) : IRequest<bool>;