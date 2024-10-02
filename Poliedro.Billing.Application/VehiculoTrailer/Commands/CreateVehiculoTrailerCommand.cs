using MediatR;

namespace Poliedro.Billing.Application.VehiculoTrailer.Commands.CreateServerCommand;

public record CreateVehiculoTrailerCommand(string Name) : IRequest<bool>;