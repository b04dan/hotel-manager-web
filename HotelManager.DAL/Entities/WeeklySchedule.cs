using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HotelManager.DAL.Entities
{
    // недельное расписание сотрудника
    public class WeeklySchedule : Entity
    {
        public int? Monday { get; set; }
        public int? Tuesday { get; set; }
        public int? Wednesday { get; set; }
        public int? Thursday { get; set; }
        public int? Friday { get; set; }
        public int? Saturday { get; set; }
        public int? Sunday { get; set; }

        public Worker Worker { get; set; }
        public int WorkerId { get; set; }

        [NotMapped]
        public int WorkDaysCount => new List<int?> { 
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
        }.Count(i => i != null);
    }
}
