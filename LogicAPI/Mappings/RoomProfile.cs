using AutoMapper;
using Data.Model;
using LogicAPI.ViewModel;

namespace LogicAPI.Mappings
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomViewModel>()
                .ForMember(x => x.Admin, opt => opt.MapFrom(x => x.Admin.UserName))
                .ReverseMap();
        }
    }
}
