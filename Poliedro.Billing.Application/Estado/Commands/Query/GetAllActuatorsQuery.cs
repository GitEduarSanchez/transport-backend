using MediatR;
using Poliedro.Billing.Application.Estado.Dto;

namespace Poliedro.Billing.Application.Estado.Query;

public record GetAllActuatorsQuery: IRequest<IEnumerable<EstadoDto>>;

