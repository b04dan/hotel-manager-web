using System.Collections.Generic;
using HotelManager.BLL.DTO;
using HotelManager.BLL.Interfaces;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using HotelManager.DAL.Interfaces;
using HotelManager.DAL.Entities;

namespace HotelManager.BLL.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientsService(IUnitOfWork unityOfWork, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _mapper = mapper;
        }

        public void Add(ClientDTO client)
        {
            _unitOfWork.ClientRepository.Add(_mapper.Map<ClientDTO, Client>(client));
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Client>, IEnumerable<ClientDTO>>(_unitOfWork.ClientRepository.GetAll());
        }

        public ClientDTO GetById(int clientId)
        {
            return _mapper.Map<Client, ClientDTO>(_unitOfWork.ClientRepository.GetById(clientId));
        }
    }
}
