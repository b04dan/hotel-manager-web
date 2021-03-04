using HotelManager.BLL.DTO.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.BLL.Interfaces
{
    public interface IStatisticsService
    {
        IEnumerable<CheckInOutStatistics> CheckInOut(DateTime from, DateTime to);
        IEnumerable<NumberStatistics> Numbers();
        IEnumerable<NumberStatistics> Occupancy();
    }
}
