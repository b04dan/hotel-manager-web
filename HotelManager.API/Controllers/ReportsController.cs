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
    public class ReportsController : ControllerBase
    {
        [HttpGet("report1")]
        public IActionResult Report1()
        {
            throw new NotImplementedException("TODO");
        }

        [HttpGet("report2")]
        public IActionResult Report2()
        {
            throw new NotImplementedException("TODO");
        }

        [HttpGet("report3")]
        public IActionResult Report3()
        {
            throw new NotImplementedException("TODO");
        }
    }
}
