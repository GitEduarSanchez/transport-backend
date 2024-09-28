using MediatR;

namespace Poliedro.Billing.Application.ciudad.Commands.CreateServerCommand;

public record CreateciudadCommand(int Idciudad, string Descripcion, int Iddepartamento) : IRequest<bool>;