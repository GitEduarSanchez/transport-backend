using MediatR;

namespace Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution
{
    public record DeleteDianResolutionCommand(int ResolutionId) : IRequest<bool>;
}
