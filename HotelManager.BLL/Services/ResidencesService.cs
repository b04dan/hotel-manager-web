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
    public class ResidencesService : IResidencesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ResidencesService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public IEnumerable<ResidenceDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Residence>, IEnumerable<ResidenceDTO>>(
                _unitOfWork.ResidenceRepository.GetAll(includeProperties: r => r.Client)
                );
        }

        public ResidenceDTO GetById(int id)
        {
            return _mapper.Map<Residence, ResidenceDTO>(_unitOfWork.ResidenceRepository.GetById(id));
        }
    }
}
