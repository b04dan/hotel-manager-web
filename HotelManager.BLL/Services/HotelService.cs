using System.Linq;
using AutoMapper;
using HotelManager.BLL.Interfaces;
using HotelManager.BLL.DTO;
using HotelManager.DAL.Interfaces;
using System.Collections.Generic;
using HotelManager.DAL.Entities;

namespace HotelManager.BLL.Services
{
    public class HotelService : IHotelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HotelService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public HotelDTO Get()
        {
            return _mapper.Map<Hotel, HotelDTO>(_unitOfWork.HotelRepository.GetAll().First());
        }

        public void Initialize()
        {
            _unitOfWork.Initialize();
        }
    }
}
