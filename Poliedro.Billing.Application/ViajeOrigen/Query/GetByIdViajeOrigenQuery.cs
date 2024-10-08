using MediatR;
using Poliedro.Billing.Application.ViajeOrigen.Dto;

namespace Poliedro.Billing.Application.ViajeOrigen.Query;

public record GetByIdViajeOrigenQuery(int IdControlViaje): IRequest<ViajeOrigenDto>;

