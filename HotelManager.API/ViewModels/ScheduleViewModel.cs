using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.API.ViewModels
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }

        public int? Monday { get; set; }
        public int? Tuesday { get; set; }
        public int? Wednesday { get; set; }
        public int? Thursday { get; set; }
        public int? Friday { get; set; }
        public int? Saturday { get; set; }
        public int? Sunday { get; set; }
    }
}
