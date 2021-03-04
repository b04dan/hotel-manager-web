using HotelManager.BLL.DTO;
using System.Collections.Generic;

namespace HotelManager.BLL.Interfaces
{
    public interface IClientsService
    {
        void Add(ClientDTO client);
        IEnumerable<ClientDTO> GetAll();
        ClientDTO GetById(int Id);
        // void Remove(int id);
    }
}
