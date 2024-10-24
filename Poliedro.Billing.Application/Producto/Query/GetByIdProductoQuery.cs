﻿using MediatR;
using Poliedro.Billing.Application.Producto.Dto;

namespace Poliedro.Billing.Application.Producto.Query;

public record GetByIdProductoQuery(int Id): IRequest<ProductoDto>;

