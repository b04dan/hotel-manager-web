namespace HotelManager.DAL.Entities
{
    public class Worker : Person
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } // отель

        public WeeklySchedule WeeklySchedule { get; set; } // график уборки. День недели - этаж

        public bool Working { get; set; } // true, если работник находится на работе, false - если уволен
        public double WorkdaySalary { get; set; } // зарплата за рабочий день
    }
}
