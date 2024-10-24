﻿using MediatR;
using Poliedro.Billing.Application.Concepto.Dto;

namespace Poliedro.Billing.Application.Concepto.Query;

public record GetAllConceptoQuery: IRequest<IEnumerable<ConceptoDto>>;

