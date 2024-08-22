using MediatR;
using Poliedro.Billing.Application.ClientBillingElectronic.Dtos;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetClientBillingElectronicById
{
    public record GetClientBillingElectronicByIdQuery : IRequest<ClientBillingElectronicDto>
    {
        public int Id { get; init; }
    }
}
