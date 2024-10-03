using MediatR;
using Poliedro.Billing.Application.Conductor.Dto;
using Poliedro.Billing.Application.Trailer.Dto;

namespace Poliedro.Billing.Application.Conductor.Query;

public record GetByIdTrailerQuery(int Id): IRequest<TrailerDto>;

