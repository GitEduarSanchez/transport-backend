using MediatR;

namespace Poliedro.Billing.Application.Descargue.Commands.CreateServerCommand;

public record CreateDescargueCommand(int Iddescripcion, string descriocion) : IRequest<bool>;
