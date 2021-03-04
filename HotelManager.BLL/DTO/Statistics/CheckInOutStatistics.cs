using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.BLL.DTO.Statistics
{
    public class CheckInOutDayStatistics
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class CheckInOutStatistics
    {
        public string Name { get; set; }
        public IEnumerable<CheckInOutDayStatistics> Series { get; set; }
    }
}
