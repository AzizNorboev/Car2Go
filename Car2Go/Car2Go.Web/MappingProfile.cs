using AutoMapper;
using Car2Go.Data.Models;
using Car2Go.Web.ViewModels.Users;
using System.Security.Claims;

namespace Car2Go.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, ApplicationUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));

            CreateMap<ExternalLoginModel, ApplicationUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
