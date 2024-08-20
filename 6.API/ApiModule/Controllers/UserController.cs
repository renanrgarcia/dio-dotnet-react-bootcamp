using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiModule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetDateHourNow")]
        public IActionResult GetDateHour()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Hour = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }


        [HttpGet("GetHello/{name}")]
        public IActionResult GetHello(string name)
        {
            var message = $"Hello {name}, welcome!";
            return Ok(new { message });
        }
    }
}