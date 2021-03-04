using AutoMapper;
using HotelManager.API.ViewModels.Statistics;
using HotelManager.BLL.DTO.Statistics;
using HotelManager.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;
        private readonly IMapper _mapper;

        public StatisticsController(IStatisticsService statisticsService, IMapper mapper)
        {
            _statisticsService = statisticsService;
            _mapper = mapper;
        }

        [HttpGet("checkInOut/{days}")]
        public IEnumerable<CheckInOutStatisticsViewModel> CheckInOut(int days)
        {
            var today = DateTime.Today;
            var rangeStart = today.Subtract(TimeSpan.FromDays(days));

            return _mapper.Map<IEnumerable<CheckInOutStatistics>, 
                IEnumerable<CheckInOutStatisticsViewModel>>(
                _statisticsService.CheckInOut(rangeStart, today)
                );
        }

        [HttpGet("numbers")]
        public IEnumerable<NumberStatisticsViewModel> Numbers()
        {
            return _mapper.Map<IEnumerable<NumberStatistics>, 
                IEnumerable<NumberStatisticsViewModel>>(
                _statisticsService.Numbers()
                );
        }

        [HttpGet("occupancy")]
        public IEnumerable<NumberStatisticsViewModel> Occupancy()
        {
            return _mapper.Map<IEnumerable<NumberStatistics>,
                IEnumerable<NumberStatisticsViewModel>>(
                _statisticsService.Occupancy()
                );
        }

    }
}
