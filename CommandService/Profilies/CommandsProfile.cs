using AutoMapper;
using CommandService.Dtos;
using CommandService.Models;

namespace CommandService.Profilies
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
            CreateMap<PlatformPublishedDto, Platform>()
                .ForMember(dest => dest.ExternalId, options => options.MapFrom(src => src.Id));
        }
    }
}
