using MediatR;
using Poliedro.Billing.Application.ClientBillingElectronic.Dtos;

namespace Poliedro.Billing.Application.ClientBillingElectronic.Queries.GetAllClientBillingElectronic;

public record GetAllClientBillingElectronicQuery: IRequest<IEnumerable<ClientBillingElectronicDto>>
{
}
