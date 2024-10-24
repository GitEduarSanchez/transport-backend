﻿using MediatR;
using Poliedro.Billing.Application.Concepto.Dto;

namespace Poliedro.Billing.Application.Concepto.Query;

public record GetByIdConceptoQuery(int IdDescripcion): IRequest<ConceptoDto>;

