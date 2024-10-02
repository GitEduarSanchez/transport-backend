using MediatR;
namespace Poliedro.Billing.Application.ViajeOrigen.Commands.CreateServerCommand;

public record CreateViajeOrigenCommand( int IdControlViaje, int IdOrigen, int IdCiudad) : IRequest<bool>;