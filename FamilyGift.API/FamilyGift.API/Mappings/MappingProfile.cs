using AutoMapper;
using FamilyGift.API.Models.Dtos.User;
using FamilyGift.API.Models.Entities;

namespace FamilyGift.API.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // User
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
