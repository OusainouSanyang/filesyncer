using Api.Contracts;
using Api.Entities;
using AutoMapper;

namespace Api.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateUser, UserEntity>() .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
               
            CreateMap<UserEntity, UserDto>();

            CreateMap<LoginUser, UserEntity>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<UserDto, CreateUser>().ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        }
    }
}