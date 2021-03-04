using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.API.ViewModels
{
    public class WorkerViewModel
    {
        public int Id { get; set; } // Id
        public string Surname { get; set; } // фамилия
        public string Name { get; set; } // имя
        public string Patronymic { get; set; } // отчество
        public string PassportNumber { get; set; } // номер паспорта
        public string Email { get; set; } // электоронная почта
        public string PhoneNumber { get; set; } // номер телефона

        public int WeeklyScheduleId { get; set; }
        public int WorkDaysCount { get; set; }

        public bool Working { get; set; } // статус
        public double WorkdaySalary { get; set; } // зарплата за рабочий день
    }
}
