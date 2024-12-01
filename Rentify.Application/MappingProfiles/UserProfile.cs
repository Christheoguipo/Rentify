using AutoMapper;
using Rentify.Application.DTOs;
using Rentify.Domain.Entities;

namespace Rentify.Application.MappingProfiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
