using MediatR;

namespace Poliedro.Billing.Application.Vehiculo.Commands.CreateServerCommand;

public record CreateVehiculoCommand(string placa,int idmarca,int idtipovehiculo) : IRequest<bool>;
