using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.API.ViewModels.Statistics
{
    public class CheckInOutDayStatisticsViewModel
    {
        public int Value { get; set; }
        public DateTime Name { get; set; }
    }

    public class CheckInOutStatisticsViewModel
    {
        public string Name { get; set; }
        public IEnumerable<CheckInOutDayStatisticsViewModel> Series { get; set; }
    }
}
