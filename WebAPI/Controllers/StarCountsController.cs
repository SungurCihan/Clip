using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarCountsController : ControllerBase
    {
        IStarCountService _starCountService;

        public StarCountsController(IStarCountService starCountService)
        {
            _starCountService = starCountService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _starCountService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult AddAppointment(StarCount starCount)
        {
            var result = _starCountService.Add(starCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult UpdateAppointment(StarCount starCount)
        {
            var result = _starCountService.Update(starCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult DeleteAppointment(StarCount starCount)
        {
            var result = _starCountService.Delete(starCount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
