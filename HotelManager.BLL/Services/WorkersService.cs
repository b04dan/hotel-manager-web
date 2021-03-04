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
    public class WorkersService : IWorkersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkersService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public IEnumerable<WorkerDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Worker>, IEnumerable<WorkerDTO>>(_unitOfWork.WorkerRepository.GetAll(
                includeProperties: w => w.WeeklySchedule)
                );
        }

        public WorkerDTO GetById(int id)
        {
            return _mapper.Map<Worker, WorkerDTO>(_unitOfWork.WorkerRepository.GetById(id));
        }
    }
}
