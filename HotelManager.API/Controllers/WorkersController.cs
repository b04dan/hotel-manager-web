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
    public class WorkersController : ControllerBase
    {
        private readonly IWorkersService _workersService;
        private readonly IMapper _mapper;

        public WorkersController(IWorkersService workersService, IMapper mapper)
        {
            _workersService = workersService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<WorkerViewModel> Get()
        {
            return _mapper.Map<IEnumerable<WorkerDTO>, IEnumerable<WorkerViewModel>>(_workersService.GetAll()); ;
        }

        [HttpGet("{id}")]
        public WorkerViewModel Get(int id)
        {
            return _mapper.Map<WorkerDTO, WorkerViewModel>(_workersService.GetById(id));
        }

        [HttpDelete("{id}")]
        public WorkerViewModel Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPost]
        public IActionResult Add(WorkerViewModel value)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, WorkerViewModel value)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
