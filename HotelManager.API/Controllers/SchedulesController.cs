using AutoMapper;
using HotelManager.API.ViewModels;
using HotelManager.BLL.DTO;
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
    public class SchedulesController : ControllerBase
    {
        private readonly ISchedulesService _schedulesService;
        private readonly IMapper _mapper;

        public SchedulesController(ISchedulesService schedulesService, IMapper mapper)
        {
            _schedulesService = schedulesService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ScheduleViewModel> Get()
        {
            return _mapper.Map<IEnumerable<WeeklyScheduleDTO>, IEnumerable<ScheduleViewModel>>(_schedulesService.GetAll());
        }

        [HttpGet("{id}")]
        public ScheduleViewModel Get(int id)
        {
            return _mapper.Map<WeeklyScheduleDTO, ScheduleViewModel>(_schedulesService.GetById(id));
        }

        [HttpDelete("{id}")]
        public ScheduleViewModel Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPost]
        public IActionResult Add(ScheduleViewModel value)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, ScheduleViewModel value)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
