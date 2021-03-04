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
    public class ResidencesController : ControllerBase
    {
        private readonly IResidencesService _residencesService;
        private readonly IMapper _mapper;

        public ResidencesController(IResidencesService residencesService, IMapper mapper)
        {
            _residencesService = residencesService;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<ResidenceViewModel> Get()
        {
            return _mapper.Map<IEnumerable<ResidenceDTO>, IEnumerable<ResidenceViewModel>>(_residencesService.GetAll()); ;
        }

        [HttpGet("{id}")]
        public ResidenceViewModel Get(int id)
        {
            return _mapper.Map<ResidenceDTO, ResidenceViewModel>(_residencesService.GetById(id)); ;
        }

        [HttpDelete("{id}")]
        public ResidenceViewModel Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPost]
        public IActionResult Add(ResidenceViewModel value)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, ResidenceViewModel value)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
