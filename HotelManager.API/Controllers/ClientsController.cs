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
    public class ClientsController : ControllerBase
    {
        private readonly IClientsService _clientsService;
        private readonly IMapper _mapper;

        public ClientsController(IClientsService clientsService, IMapper mapper)
        {
            _clientsService = clientsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ClientViewModel> Get()
        {
            return _mapper.Map<IEnumerable<ClientDTO>, IEnumerable<ClientViewModel>>(_clientsService.GetAll()); ;
        }

        [HttpGet("{id}")]
        public ClientViewModel Get(int id)
        {
            return _mapper.Map<ClientDTO, ClientViewModel>(_clientsService.GetById(id)); ;
        }

        [HttpDelete("{id}")]
        public ClientViewModel Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPost]
        public IActionResult Add(ClientViewModel value)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, ClientViewModel value)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
