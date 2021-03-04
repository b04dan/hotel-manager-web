using HotelManager.BLL.DTO;
using System.Collections.Generic;

namespace HotelManager.BLL.Interfaces
{
    public interface ISchedulesService
    {
        IEnumerable<WeeklyScheduleDTO> GetAll();
        WeeklyScheduleDTO GetById(int id);
    }
}
