using HotelManager.BLL.DTO;
using System.Collections.Generic;

namespace HotelManager.BLL.Interfaces
{
    public interface IHotelRoomsService
    {
        // void Add(HotelRoomDTO client);
        IEnumerable<HotelRoomDTO> GetAll();
        HotelRoomDTO GetById(int id);
        // void Remove(int id);
    }
}
