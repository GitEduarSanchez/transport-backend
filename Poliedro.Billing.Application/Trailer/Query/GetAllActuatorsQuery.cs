using MediatR;
using Poliedro.Billing.Application.Trailer.Dto;

namespace Poliedro.Billing.Application.Trailer.Query;

public record GetAllTrailerQuery: IRequest<IEnumerable<TrailerDto>>;

