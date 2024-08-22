using AutoMapper;
using Poliedro.Billing.Application.DianResolution.Commands.CreateDianResolution;
using Poliedro.Billing.Application.DianResolution.Commands.DeleteDianResolution;
using Poliedro.Billing.Application.Resolution.Dtos;
using Poliedro.Billing.Domain.Resolution.Entities;

namespace Poliedro.Billing.Application.Resolution.AutoMappers;
public class DianResolutionMapper : Profile
{
    public DianResolutionMapper()
    {
        CreateMap<CreateDianResolutionCommand, DianResolutionEntity>()
        .ForMember(dest => dest.ResolutionId, opt => opt.Ignore());
        CreateMap<UpdateDianResolutionCommand, DianResolutionEntity>();
        CreateMap<DianResolutionEntity, DianResolutionDto>();
        CreateMap<DeleteDianResolutionCommand, DianResolutionEntity>();
    }
}
