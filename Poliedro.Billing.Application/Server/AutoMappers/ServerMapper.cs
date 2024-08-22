using AutoMapper;
using Poliedro.Billing.Application.Server.Commands.CreateServerCommand;
using Poliedro.Billing.Application.Server.Dtos;
using Poliedro.Billing.Domain.Server.Entities;

namespace Poliedro.Billing.Application.Server.AutoMappers;

public class ServerMapper : Profile
{
    public ServerMapper()
    {
        CreateMap<ServerEntity, ServerDto>().ReverseMap();
        CreateMap<ServerEntity, CreateServerCommand>().ReverseMap()
            .ForMember(dest => dest.DatabaseName, opt => opt.MapFrom(src => src.DatabaseName))
            .ForMember(dest => dest.DbUsername, opt => opt.MapFrom(src => src.DbUsername))
            .ForMember(dest => dest.DbPassword, opt => opt.MapFrom(src => src.DbPassword));
    }
}
