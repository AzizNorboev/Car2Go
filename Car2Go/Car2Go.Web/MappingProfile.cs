using AutoMapper;
using Car2Go.Data.Models;
using Car2Go.Web.ViewModels.Users;

namespace Car2Go.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, ApplicationUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
