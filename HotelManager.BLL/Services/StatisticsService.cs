using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelManager.BLL.DTO.Statistics;
using HotelManager.BLL.Interfaces;
using HotelManager.DAL.Interfaces;

namespace HotelManager.BLL.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticsService(IUnitOfWork unityOfWork)
        {
            _unitOfWork = unityOfWork;
        }

        public IEnumerable<CheckInOutStatistics> CheckInOut(DateTime from, DateTime to)
        {
            var result = new List<CheckInOutStatistics>();

            var residences = _unitOfWork.ResidenceRepository.GetAll();

            var groupedCheckIn = residences.GroupBy(s => s.CheckInDate);

            result.Add(new CheckInOutStatistics
            {
                Name = "Заселились",
                Series = Enumerable.Range(0, 1 + to.Subtract(from).Days)
                .Select(s => new CheckInOutDayStatistics
                {
                    Date = from.AddDays(s),
                    Value = groupedCheckIn.FirstOrDefault(global => global.Key == from.AddDays(s))?.Count() ?? 0
                })
            });

            var groupedCheckOut = residences
                .Where(s => s.CheckOutDate != null)
                .GroupBy(s => s.CheckOutDate);

            result.Add(new CheckInOutStatistics
            {
                Name = "Выселились",
                Series = Enumerable.Range(0, 1 + to.Subtract(from).Days)
                .Select(s => new CheckInOutDayStatistics
                {
                    Date = from.AddDays(s),
                    Value = groupedCheckOut.FirstOrDefault(global => global.Key == from.AddDays(s))?.Count() ?? 0
                })
            });

            return result;
        }

        public IEnumerable<NumberStatistics> Numbers()
        {
            var result = new List<NumberStatistics>();

            result.Add(new NumberStatistics
            {
                Name = "Клиентов",
                Value = _unitOfWork.ClientRepository.GetAll().Count()
            });

            result.Add(new NumberStatistics
            {
                Name = "Работников",
                Value = _unitOfWork.WorkerRepository.GetAll().Count()
            });

            result.Add(new NumberStatistics
            {
                Name = "Фактов проживания",
                Value = _unitOfWork.ResidenceRepository.GetAll().Count()
            });

            result.Add(new NumberStatistics
            {
                Name = "Номеров",
                Value = _unitOfWork.HotelRoomRepository.GetAll().Count()
            });

            result.Add(new NumberStatistics
            {
                Name = "Этажей",
                Value = _unitOfWork.HotelRepository.GetAll().FirstOrDefault()?.FloorCount ?? 0
            });

            result.Add(new NumberStatistics
            {
                Name = "Расписаний",
                Value = _unitOfWork.ScheduleRepository.GetAll().Count()
            });

            return result;
        }

        public IEnumerable<NumberStatistics> Occupancy()
        {
            var result = new List<NumberStatistics>();

            var occupancyCount = _unitOfWork.ResidenceRepository.GetAll(f => f.CheckOutDate == null).Count();
            result.Add(new NumberStatistics
            {
                Name = "Занятые",
                Value = occupancyCount
            });

            result.Add(new NumberStatistics
            {
                Name = "Свободные",
                Value = _unitOfWork.HotelRoomRepository.GetAll().Count() - occupancyCount
            });

            return result;
        }
    }
}
