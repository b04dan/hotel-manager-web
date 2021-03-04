using HotelManager.BLL.DTO;
using System.Collections.Generic;

namespace HotelManager.BLL.Interfaces
{
    public interface IResidencesService
    {
        IEnumerable<ResidenceDTO> GetAll();
        ResidenceDTO GetById(int id);
    }
}
