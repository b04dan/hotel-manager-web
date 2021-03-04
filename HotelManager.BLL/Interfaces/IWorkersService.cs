using HotelManager.BLL.DTO;
using System.Collections.Generic;

namespace HotelManager.BLL.Interfaces
{
    public interface IWorkersService
    {
        IEnumerable<WorkerDTO> GetAll();
        WorkerDTO GetById(int id);
    }
}
