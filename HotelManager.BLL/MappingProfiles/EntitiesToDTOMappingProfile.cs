using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelManager;
using HotelManager.BLL.DTO;
using HotelManager.DAL.Entities;

namespace HotelManager.BLL.MappingProfiles
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<HotelRoom, HotelRoomDTO>().ReverseMap();
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Worker, WorkerDTO>()
                .ForMember(w => w.WorkDaysCount, o => o.MapFrom(w => w.WeeklySchedule.WorkDaysCount))
                .ForMember(w => w.WeeklyScheduleId, o => o.MapFrom(w => w.WeeklySchedule.Id));
            CreateMap<WeeklySchedule, WeeklyScheduleDTO>().ReverseMap();
            CreateMap<Residence, ResidenceDTO>()
                .ForMember(r => r.Client, o => o.MapFrom(r => $"{r.Client.Surname} {r.Client.Name} {r.Client.Patronymic}"));
            CreateMap<Hotel, HotelDTO>().ReverseMap();
        }
    }
}
