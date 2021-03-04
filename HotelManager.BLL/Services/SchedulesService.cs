using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using HotelManager.BLL.Interfaces;
using HotelManager.BLL.DTO;
using HotelManager.DAL.Interfaces;
using HotelManager.DAL.Entities;

namespace HotelManager.BLL.Services
{
    public class SchedulesService : ISchedulesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SchedulesService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public IEnumerable<WeeklyScheduleDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<WeeklySchedule>, IEnumerable<WeeklyScheduleDTO>>(_unitOfWork.ScheduleRepository.GetAll());
        }

        public WeeklyScheduleDTO GetById(int id)
        {
            return _mapper.Map<WeeklySchedule, WeeklyScheduleDTO>(_unitOfWork.ScheduleRepository.GetById(id));
        }
    }
}
