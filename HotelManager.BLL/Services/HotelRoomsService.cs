using System.Collections.Generic;
using HotelManager.BLL.Interfaces;
using HotelManager.BLL.DTO;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using HotelManager.DAL.Interfaces;
using HotelManager.DAL.Entities;

namespace HotelManager.BLL.Services
{
    public class HotelRoomsService : IHotelRoomsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HotelRoomsService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public IEnumerable<HotelRoomDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(_unitOfWork.HotelRoomRepository.GetAll());
        }

        public HotelRoomDTO GetById(int id)
        {
            return _mapper.Map<HotelRoom, HotelRoomDTO>(_unitOfWork.HotelRoomRepository.GetById(id));
        }
    }
}
