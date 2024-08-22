using MediatR;
using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Domain.Resolution.Enums;

namespace Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution
{
    public record UpdateDianResolutionCommand(
    int id,
    string ResolutionNumber,
    string Prefix,
    int InitialRange,
    int FinalRange,
    DateTime ResolutionDate = default,
    string Description = "",
    string? ResolutionFile = "",
    bool Active = false,
    DateTime CreationDate = default,
    int VigencyMonth = 0,
    DateTime ExpirationDate = default,
    ResolutionType ResolutionType = default,
    int ClientBillingElectronicId = default
) : IRequest<DianResolutionDto>;
}
