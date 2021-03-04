using HotelManager.BLL.DTO;

namespace HotelManager.BLL.Interfaces
{
    public interface IHotelService
    {
        HotelDTO Get();
        void Initialize();
    }
}
