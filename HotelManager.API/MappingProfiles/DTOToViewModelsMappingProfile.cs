using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelManager;
using HotelManager.API.ViewModels;
using HotelManager.API.ViewModels.Statistics;
using HotelManager.BLL.DTO;
using HotelManager.BLL.DTO.Statistics;

namespace HotelManager.BLL.MappingProfiles
{
    public class DTOToViewModelsMappingProfile : Profile
    {
        public DTOToViewModelsMappingProfile()
        {
            CreateMap<ResidenceDTO, ResidenceViewModel>()
                .ForMember(r => r.ClientSNP, o => o.MapFrom(r => r.Client));

            CreateMap<WorkerDTO, WorkerViewModel>();
            CreateMap<ClientDTO, ClientViewModel>();

            CreateMap<WeeklyScheduleDTO, ScheduleViewModel>();
            CreateMap<HotelRoomDTO, HotelRoomViewModel>();

            CreateMap<CheckInOutDayStatistics, CheckInOutDayStatisticsViewModel>()
                .ForMember(r => r.Name, o => o.MapFrom(c => c.Date));
            CreateMap<CheckInOutStatistics, CheckInOutStatisticsViewModel>();
            CreateMap<NumberStatistics, NumberStatisticsViewModel>();
        }
    }
}
