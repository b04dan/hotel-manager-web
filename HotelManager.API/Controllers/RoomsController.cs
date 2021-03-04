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
    public class RoomsController : ControllerBase
    {
        private readonly IHotelRoomsService _hotelRoomsService;
        private readonly IMapper _mapper;

        public RoomsController(IHotelRoomsService hotelRoomsService, IMapper mapper)
        {
            _hotelRoomsService = hotelRoomsService;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<HotelRoomViewModel> Get()
        {
            return _mapper.Map<IEnumerable<HotelRoomDTO>, IEnumerable<HotelRoomViewModel>>(_hotelRoomsService.GetAll()); ;
        }

        [HttpGet("{id}")]
        public HotelRoomViewModel Get(int id)
        {
            return _mapper.Map<HotelRoomDTO, HotelRoomViewModel>(_hotelRoomsService.GetById(id));
        }

        [HttpDelete("{id}")]
        public HotelRoomViewModel Delete(int id)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPost]
        public IActionResult Add(HotelRoomViewModel value)
        {
            throw new NotImplementedException("TODO");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, HotelRoomViewModel value)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
