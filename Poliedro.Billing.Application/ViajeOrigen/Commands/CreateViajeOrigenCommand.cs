using MediatR;

namespace Poliedro.Billing.Application.Conductor.Commands.CreateServerCommand;

public record CreateViajeOrigenCommand(int IdControlViajeOrigen, int IdControlViaje, int IdOrigen, int IdCiudad) : IRequest<bool>;