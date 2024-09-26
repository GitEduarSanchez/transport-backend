using MediatR;

namespace Poliedro.Billing.Application.ControlViaje.Commands.CreateServerCommand;

public record CreateControlViajeCommand(int idControlViaje, DateTime fecha, string guia, int idVehiculoTrailer) : IRequest<bool>;