using AutoMapper;
using Data.Model;
using LogicAPI.ViewModel;

namespace LogicAPI.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dst => dst.UserName, opt => opt.MapFrom(x => x.UserName)).ReverseMap();
        }
    }
}
