using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Dto;

namespace Poliedro.Billing.Application.ViajeOrigen.Query;

public record GetAllViajeOrigenQuery: IRequest<IEnumerable<ViajeOrigenDto>>;

